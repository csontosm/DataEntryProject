using DocumentManager.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Words.NET;

namespace DocumentManager
{
    public class DataManager
    {
        public DataManager()
        {
            deceased = Forms.deceasedData;
            spouse = Forms.spouseData;
            client = Forms.clientData;
            funeral = Forms.funeralData;
        }

        private DeceasedData deceased;
        private SpouseData spouse;
        private ClientData client;
        private FuneralData funeral;
        private List<TextReplacementRule> TextReplacementRules;

        private void initializeTextReplacementRules()
        {

            TextReplacementRules = new List<TextReplacementRule>()
            {
                //Deceased
                new TextReplacementRule("{DeceasedGenderMale}", ()=>"___", ()=>"", ()=>deceased.Gender == "Férfi"),
                new TextReplacementRule("{DeceasedGenderFemale}", ()=>"", ()=>"___", ()=>deceased.Gender == "Nő"),
                new TextReplacementRule("{DeceasedMaidenName}", ()=>"", ()=>deceased.BirthSurname + " " + deceased.BirthForename, ()=>deceased.Gender == "Férfi"),
                new TextReplacementRule("{DeceasedName}", ()=>deceased.BirthSurname + " " + deceased.BirthForename, ()=>deceased.MarriageName, ()=>deceased.MarriageName == ""), //!
                new TextReplacementRule("{DeceasedMarriageName}", ()=>deceased.MarriageName),
                new TextReplacementRule("{DeceasedBirthSurname}", ()=>deceased.BirthSurname),
                new TextReplacementRule("{DeceasedBirthForename}", ()=>deceased.BirthForename),
                new TextReplacementRule("{DeceasedBirthName}", ()=>deceased.BirthSurname + " " + deceased.BirthForename),
                new TextReplacementRule("{DeceasedAge}", () =>
                {
                    return HelperMethods.CalculateAge(
                            new DateTime(int.Parse(deceased.DateOfBirthYear), int.Parse(deceased.DateOfBirthMonth), int.Parse(deceased.DateOfBirthDay)),
                            new DateTime(int.Parse(deceased.DateOfDeathYear), int.Parse(deceased.DateOfDeathMonth), int.Parse(deceased.DateOfDeathDay)))
                        .ToString();
                }, ()=>"", ()=>deceased.DateOfBirthYear != null && deceased.DateOfBirthMonth != null && deceased.DateOfBirthDay != null && deceased.DateOfDeathYear != null && deceased.DateOfDeathMonth != null && deceased.DateOfDeathDay != null),
                new TextReplacementRule("{DeceasedDateOfBirthYear}", () => deceased.DateOfBirthYear),
                new TextReplacementRule("{DeceasedDateOfBirthMonth}", () => deceased.DateOfBirthMonth),
                new TextReplacementRule("{DeceasedDateOfBirthDay}", () => deceased.DateOfBirthDay),
                new TextReplacementRule("{DeceasedDateOfBirth}", () => deceased.DateOfBirthYear + "." + deceased.DateOfBirthMonth + "." + deceased.DateOfBirthDay),

                new TextReplacementRule("{DeceasedPlaceOfBirthCountry}", () => deceased.PlaceOfBirthCountry),
                new TextReplacementRule("{DeceasedPlaceOfBirthCity}", () => deceased.PlaceOfBirthCity),
                new TextReplacementRule("{DeceasedPlaceOfBrithDistrict}", () => deceased.PlaceOfBrithDistrict),
                new TextReplacementRule("{DeceasedPlaceOfBirth}", () => deceased.PlaceOfBirthCountry + " " + deceased.PlaceOfBirthCity + " " + deceased.PlaceOfBrithDistrict),

                new TextReplacementRule("{DeceasedDateOfDeathYear}", () => deceased.DateOfDeathYear),
                new TextReplacementRule("{DeceasedDateOfDeathMonth}", () => deceased.DateOfDeathMonth),
                new TextReplacementRule("{DeceasedDateOfDeathDay}", () => deceased.DateOfDeathDay),
                new TextReplacementRule("{DeceasedDateOfDeath}", () => deceased.DateOfDeathYear + "." + deceased.DateOfDeathMonth + "." + deceased.DateOfDeathDay),

                new TextReplacementRule("{DeceasedPlaceOfDeathCity}", () => deceased.PlaceOfDeathCity),
                new TextReplacementRule("{DeceasedPlaceOfDeathDistrict}", () => deceased.PlaceOfDeathDistrict),
                new TextReplacementRule("{DeceasedPlaceOfDeath}", () => deceased.PlaceOfDeathCity + " " + deceased.PlaceOfBrithDistrict),

                new TextReplacementRule("{DeceasedHomeCountry}", () => deceased.HomeCountry),
                new TextReplacementRule("{DeceasedHomeCity}", () => deceased.HomeCity),
                new TextReplacementRule("{DeceasedHomeAddress}", () => deceased.HomeAddress),
                new TextReplacementRule("{DeceasedHomeDistrict}", () => deceased.HomeDistrict),
                new TextReplacementRule("{DeceasedHome}", () => deceased.HomeCountry + " " + deceased.HomeCity + " " + deceased.HomeAddress + " " + deceased.HomeDistrict),

                new TextReplacementRule("{DeceasedResidenceCity}", () => deceased.ResidenceCity),
                new TextReplacementRule("{DeceasedResidenceDistrict}", () => deceased.ResidenceDistrict),

                new TextReplacementRule("{DeceasedNationality}", () => deceased.Nationality),
                new TextReplacementRule("{DeceasedPersonalIdentifierNumber}", () => deceased.PersonalIdentifierNumber),
                new TextReplacementRule("{DeceasedHomeCardNumber}", () => deceased.HomeCardNumber),
                new TextReplacementRule("{DeceasedIdentifierDocumentNumber}", () => deceased.IdentifierDocumentNumber),
                new TextReplacementRule("{DeceasedIdentifierDocumentExpireYear}", () => deceased.IdentifierDocumentExpireYear),
                new TextReplacementRule("{DeceasedIdentifierDocumentExpireMonth}", () => deceased.IdentifierDocumentExpireMonth),
                new TextReplacementRule("{DeceasedIdentifierDocumentExpireDay}", () => deceased.IdentifierDocumentExpireDay),

                new TextReplacementRule("{DeceasedFatherBirthSurname}", () => deceased.FatherBirthSurname),
                new TextReplacementRule("{DeceasedFatherBirthForename}", () => deceased.FatherBirthForename),
                new TextReplacementRule("{DeceasedFatherBirthName}", () => deceased.FatherBirthSurname + " " + deceased.FatherBirthForename),

                new TextReplacementRule("{DeceasedMotherBirthSurname}", () => deceased.MotherBirthSurname),
                new TextReplacementRule("{DeceasedMotherBirthForename}", () => deceased.MotherBirthForename),
                new TextReplacementRule("{DeceasedMotherBirthName}", () => deceased.MotherBirthSurname + " " + deceased.MotherBirthForename),

                new TextReplacementRule("{DeceasedProfession}", () => deceased.Profession),
                new TextReplacementRule("{DeceasedQualification}", () => deceased.Qualification),
                new TextReplacementRule("{KidsFromLastMarriageAll}", () => deceased.KidsFromLastMarriageAll),
                new TextReplacementRule("{KidsFromLastMarriageBornAlive}", () => deceased.KidsFromLastMarriageBornAlive),
                new TextReplacementRule("{KidsFromLastMarriageAlive}", () => deceased.KidsFromLastMarriageAlive),
                new TextReplacementRule("{KidsAlltogetherAll}", () => deceased.KidsAlltogetherAll),
                new TextReplacementRule("{KidsAlltogetherBornAlive}", () => deceased.KidsAlltogetherBornAlive),
                new TextReplacementRule("{KidsAlltogetherAlive}", () => deceased.KidsAlltogetherAlive),

                //Spouse
                new TextReplacementRule("{DateOfMarriageYear}", () => spouse.DateOfMarriageYear, () => "", () => deceased.IsMarried),
                new TextReplacementRule("{DateOfMarriageMonth}", () => spouse.DateOfMarriageMonth, () => "", () => deceased.IsMarried),
                new TextReplacementRule("{DateOfMarriageDay}", () => spouse.DateOfMarriageDay, () => "", () => deceased.IsMarried),

                new TextReplacementRule("{PlaceOfMarriageCountry}", () => spouse.PlaceOfMarriageCountry, () => "", () => deceased.IsMarried),
                new TextReplacementRule("{PlaceOfMarriageCity}", () => spouse.PlaceOfMarriageCity, () => "", () => deceased.IsMarried),
                new TextReplacementRule("{PlaceOfMarriageDistrict}", () => spouse.PlaceOfMarriageDistrict, () => "", () => deceased.IsMarried),

                new TextReplacementRule("{SpouseBirthSurname}", () => spouse.BirthSurname, () => "", () => deceased.IsMarried),
                new TextReplacementRule("{SpouseBirthForename}", () => spouse.BirthForename, () => "", () => deceased.IsMarried),
                new TextReplacementRule("{SpouseBirthName}", () => spouse.BirthSurname + " " + spouse.BirthForename, () => "", () => deceased.IsMarried),

                new TextReplacementRule("{SpouseMarriageName}", () => spouse.MarriageName, () => "", () => deceased.IsMarried),
                new TextReplacementRule("{SpouseMaidenName}", () => spouse.BirthSurname + " " + spouse.BirthForename, () => "", () => spouse.PersonalIdentifierNumber?.Substring(0, 1) == "2"), //!!!implement ()=>Forms.isMarried

                new TextReplacementRule("{SpouseDateOfBirthYear}", () => spouse.DateOfBirthYear, () => "", () => deceased.IsMarried),
                new TextReplacementRule("{SpouseDateOfBirthMonth}", () => spouse.DateOfBirthMonth, () => "", () => deceased.IsMarried),
                new TextReplacementRule("{SpouseDateOfBirthDay}", () => spouse.DateOfBirthDay, () => "", () => deceased.IsMarried),

                new TextReplacementRule("{SpousePlaceOfBirthCountry}", () => spouse.PlaceOfBirthCountry, () => "", () => deceased.IsMarried),

                new TextReplacementRule("{SpouseHomeCity}", () => spouse.HomeCity, () => "", () => deceased.IsMarried),
                new TextReplacementRule("{SpouseHomeDistrict}", () => spouse.HomeDistrict, () => "", () => deceased.IsMarried),
                new TextReplacementRule("{SpouseHomeAddress}", () => spouse.HomeAddress, () => "", () => deceased.IsMarried),

                new TextReplacementRule("{SpouseResidenceCity}", () => spouse.ResidenceCity, () => "", () => deceased.IsMarried),
                new TextReplacementRule("{SpouseResidenceDistrict}", () => spouse.ResidenceDistrict, () => "", () => deceased.IsMarried),

                new TextReplacementRule("{SpouseNationality}", () => spouse.Nationality, () => "", () => deceased.IsMarried),
                new TextReplacementRule("{SpousePersonalIdentifierNumber}", () => spouse.PersonalIdentifierNumber, () => "", () => deceased.IsMarried),

                //Client
                new TextReplacementRule("{ClientName}", () => client.Surname + " " + client.Forename),
                new TextReplacementRule("{ClientRelative}", () => client.Relative),
                new TextReplacementRule("{ClientIdentifierDocumentNumber}", () => client.IdentifierDocumentNumber),
                new TextReplacementRule("{ClientHomeCountry}", () => client.HomeCountry),
                new TextReplacementRule("{ClientHomePostcode}", () => client.HomePostcode),
                new TextReplacementRule("{ClientHomeCity}", () => client.HomeCity),
                new TextReplacementRule("{ClientHomeDistrict}", () => client.HomeDistrict),
                new TextReplacementRule("{ClientHomeAddress}", () => client.HomeAddress),
                new TextReplacementRule("{ClientReach}", () => funeral.Reach),

                new TextReplacementRule("{ClientHome}", () => client.HomePostcode + " " + client.HomeCity + " " + client.HomeDistrict + " " + client.HomeAddress),

                //Funeral
                new TextReplacementRule("{FuneralType}", () => funeral.Type),
                new TextReplacementRule("{FuneralMethod}", () => funeral.Method),
                new TextReplacementRule("{FuneralCatafalque}", () => funeral.Catafalque),
                new TextReplacementRule("{FuneralCoffinOrUrnType}", () => funeral.CoffinOrUrnType),
                new TextReplacementRule("{FuneralCryptOrCaissionType}", () => funeral.CryptOrCaissionType),
                new TextReplacementRule("{FuneralGrave}", () => funeral.Grave),
                new TextReplacementRule("{FuneralDate}", () => funeral.DateYear + "." + funeral.DateMonth + "." + funeral.DateDay),
                new TextReplacementRule("{FuneralMusic}", () => funeral.Music),
                new TextReplacementRule("{FuneralGarveDigging}", () => funeral.GarveDigging),
                new TextReplacementRule("{FuneralGraveMarker}", () => funeral.GraveMarker),
                new TextReplacementRule("{FuneralUrnCloth}", () => "X", () => "", () => funeral.UrnCloth),
                new TextReplacementRule("{FuneralisIDCardNeededByClient}", () => "X", () => "", () => funeral.IsIDCardNeededByClient),
                new TextReplacementRule("{FuneralIsIDCardTaken}", () => "X", () => "", () => funeral.IsIDCardTaken),
                new TextReplacementRule("{FuneralIsAddressCardTaken}", () => "X", () => "", () => funeral.IsAddressCardTaken),
                new TextReplacementRule("{FuneralIsDeathCertificateTaken}", () => "X", () => "", () => funeral.IsDeathCertificateTaken),
                new TextReplacementRule("{FuneralIsBirthCertificateTaken}", () => "X", () => "", () => funeral.IsBirthCertificateTaken),
                new TextReplacementRule("{FuneralIsMarriageCertificateTaken}", () => "X", () => "", () => funeral.IsMarriageCertificateTaken),
                new TextReplacementRule("{FuneralIsSpouseDeathCertificateTaken}", () => "X", () => "", () => funeral.IsSpouseDeathCertificateTaken),

                //---
                new TextReplacementRule("{DateOfIssue}", () => DateTime.Now.ToString("yyyy.MM.dd")),
                new TextReplacementRule("{DateOfIssueYear}", () => DateTime.Now.ToString("yyyy")),
                new TextReplacementRule("{DateOfIssueMonth}", () => DateTime.Now.ToString("MM")),
                new TextReplacementRule("{DateOfIssueDay}", () => DateTime.Now.ToString("dd")),

                new TextReplacementRule("{BlanketFoil}", () => "Sirkőre takarófólia!!!", () => "", () =>CheckFoil())
            };
        }

        public string[] getDocFiles(string templateDocPath)
        {
            string[] docTemplates = Directory.GetFiles(templateDocPath);
            return docTemplates;
        }

        public void createDictionary(string outputFilePath)
        {
            if (!Directory.Exists(outputFilePath))
            {
                Directory.CreateDirectory(outputFilePath);
            }
        }

        public void saveFile(string outputPath, DocX templateDoc)
        {
            if (!File.Exists(outputPath))
            {
                templateDoc.SaveAs(outputPath);
            }
        }

        public void replaceText(DocX templateDoc)
        {
            initializeTextReplacementRules();

            foreach (var rule in TextReplacementRules)
            {
                if (rule.ShouldReplace())
                {
                    templateDoc.ReplaceText(rule.TextToReplace, rule.TextToInsert() ?? string.Empty);
                }
            }
        }

        public bool CheckFoil()
        {
            if (funeral.Method == "Koporsós" && funeral.GraveOrCrypt == "Kripta")
            {
                return true;
            }
            else if (funeral.Method == "Úrnás")
            {
                if (funeral.GraveOrCrypt == "Kripta" || funeral.GraveOrCrypt == "Sirkő")
                {
                    return true;
                }
                else return false;
            }
            else return false;
        }
    }
}
