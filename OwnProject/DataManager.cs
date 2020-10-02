using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Words.NET;

namespace OwnProject
{
    public class DataManager
    {
        public DataManager()
        {
            deceived = Forms.deceivedData;
            spouse = Forms.spouseData;
            client = Forms.clientData;
            funeral = Forms.funeralData;

            initializeTextReplacementRules();
        }

        private DecievedData deceived;
        private SpouseData spouse;
        private ClientData client;
        private FuneralData funeral;
        private List<TextReplacementRule> TextReplacementRules;

        private void initializeTextReplacementRules()
        {
            TextReplacementRules = new List<TextReplacementRule>()
            {
                //Decieved
                new TextReplacementRule("{DeceivedGenderMale}", "___", "", ()=>deceived.Gender == "Férfi"),
                new TextReplacementRule("{DeceivedGenderFemale}", "", "___", ()=>deceived.Gender == "Férfi"),
                new TextReplacementRule("{DecievedMaidenName}", "", deceived.BirthSurname + deceived.BirthForename, ()=>deceived.Gender == "Férfi"),

                new TextReplacementRule("{DecievedName}", deceived.BirthSurname + " " + deceived.BirthForename, deceived.MarriageName, ()=>deceived.MarriageName == ""),

                new TextReplacementRule("{DeceivedMarriageName}", deceived.MarriageName),
                new TextReplacementRule("{DeceivedBirthSurname}", deceived.BirthSurname),
                new TextReplacementRule("{DeceivedBirthForename}", deceived.BirthForename),

                new TextReplacementRule("{DeceivedAge}", deceived.Age),

                new TextReplacementRule("{DeceivedDateOfBirthYear}", deceived.DateOfBirthYear),
                new TextReplacementRule("{DeceivedDateOfBirthMonth}", deceived.DateOfBirthMonth),
                new TextReplacementRule("{DeceivedDateOfBirthDay}", deceived.DateOfBirthDay),
                new TextReplacementRule("{DeceivedPlaceOfBirthCountry}", deceived.PlaceOfBirthCountry),
                new TextReplacementRule("{DeceivedPlaceOfBirthCity}", deceived.PlaceOfBirthCity),
                new TextReplacementRule("{DeceivedPlaceOfBrithDistrict}", deceived.PlaceOfBrithDistrict),

                new TextReplacementRule("{DeceivedDateOfDeathYear}", deceived.DateOfDeathYear),
                new TextReplacementRule("{DeceivedDateOfDeathMonth}", deceived.DateOfDeathMonth),
                new TextReplacementRule("{DeceivedDateOfDeathDay}", deceived.DateOfDeathDay),
                new TextReplacementRule("{DeceivedPlaceOfDeathCity}", deceived.PlaceOfDeathCity),
                new TextReplacementRule("{DeceivedPlaceOfDeathDistrict}", deceived.PlaceOfDeathDistrict),

                new TextReplacementRule("{DeceivedHomeCountry}", deceived.HomeCountry),
                new TextReplacementRule("{DeceivedHomeCity}", deceived.HomeCity),
                new TextReplacementRule("{DeceivedHomeAddress}", deceived.HomeAddress),
                new TextReplacementRule("{DeceivedHomeDistrict}", deceived.HomeDistrict),
                new TextReplacementRule("{DeceivedResidenceCity}", deceived.ResidenceCity),
                new TextReplacementRule("{DeceivedResidenceDistrict}", deceived.ResidenceDistrict),

                new TextReplacementRule("{DeceivedNationality}", deceived.Nationality),
                new TextReplacementRule("{DeceivedPersonalIdentifierNumber}", deceived.PersonalIdentifierNumber),
                new TextReplacementRule("{DeceivedIdentifierDocumentNumber}", deceived.IdentifierDocumentNumber),
                new TextReplacementRule("{DeceivedHomeCardNumber}", deceived.HomeCardNumber),

                new TextReplacementRule("{DeceivedFatherBirthSurname}", deceived.FatherBirthSurname),
                new TextReplacementRule("{DeceivedFatherBirthForename}", deceived.FatherBirthForename),
                new TextReplacementRule("{DeceivedMotherBirthSurname}", deceived.MotherBirthSurname),
                new TextReplacementRule("{DeceivedMotherBirthForename}", deceived.MotherBirthForename),

                new TextReplacementRule("{DeceivedProfession}", deceived.Profession),
                new TextReplacementRule("{DeceivedQualification}", deceived.Qualification),

                new TextReplacementRule("{KidsFromLastMarriageAll}", deceived.KidsFromLastMarriageAll),
                new TextReplacementRule("{KidsFromLastMarriageBornAlive}", deceived.KidsFromLastMarriageBornAlive),
                new TextReplacementRule("{KidsFromLastMarriageAlive}", deceived.KidsFromLastMarriageAlive),
                new TextReplacementRule("{KidsAlltogetherAll}", deceived.KidsAlltogetherAll),
                new TextReplacementRule("{KidsAlltogetherBornAlive}", deceived.KidsAlltogetherBornAlive),
                new TextReplacementRule("{KidsAlltogetherAlive}", deceived.KidsAlltogetherAlive),
                //Spouse
                new TextReplacementRule("{DateOfMarriageYear}", spouse.DateOfMarriageYear, "", ()=>Forms.isMarried),
                new TextReplacementRule("{DateOfMarriageMonth}", spouse.DateOfMarriageMonth, "", ()=>Forms.isMarried),
                new TextReplacementRule("{DateOfMarriageDay}", spouse.DateOfMarriageDay, "", ()=>Forms.isMarried),
                new TextReplacementRule("{PlaceOfMarriageCountry}", spouse.PlaceOfMarriageCountry, "", ()=>Forms.isMarried),
                new TextReplacementRule("{PlaceOfMarriageCity}", spouse.PlaceOfMarriageCity, "", ()=>Forms.isMarried),
                new TextReplacementRule("{PlaceOfMarriageDistrict}", spouse.PlaceOfMarriageDistrict, "", ()=>Forms.isMarried),

                new TextReplacementRule("{SpouseBirthSurname}", spouse.BirthSurname, "", ()=>Forms.isMarried),
                new TextReplacementRule("{SpouseBirthForename}", spouse.BirthForename, "", ()=>Forms.isMarried),
                new TextReplacementRule("{SpouseMarriageName}", spouse.MarriageName, "", ()=>Forms.isMarried),
                new TextReplacementRule("{SpouseMaidenName}", spouse.BirthSurname + " " + spouse.BirthForename, "", ()=>spouse.PersonalIdentifierNumber?.Substring(0, 1) == "2"), //!!!implement ()=>Forms.isMarried

                new TextReplacementRule("{SpouseDateOfBirthYear}", spouse.DateOfBirthYear, "", ()=>Forms.isMarried),
                new TextReplacementRule("{SpouseDateOfBirthMonth}", spouse.DateOfBirthMonth, "", ()=>Forms.isMarried),
                new TextReplacementRule("{SpouseDateOfBirthDay}", spouse.DateOfBirthDay, "", ()=>Forms.isMarried),
                new TextReplacementRule("{SpousePlaceOfBirthCountry}", spouse.PlaceOfBirthCountry, "", ()=>Forms.isMarried),

                new TextReplacementRule("{SpouseHomeCity}", spouse.HomeCity, "", ()=>Forms.isMarried),
                new TextReplacementRule("{SpouseHomeDistrict}", spouse.HomeDistrict, "", ()=>Forms.isMarried),
                new TextReplacementRule("{SpouseHomeAddress}", spouse.HomeAddress, "", ()=>Forms.isMarried),
                new TextReplacementRule("{SpouseResidenceCity}", spouse.ResidenceCity, "", ()=>Forms.isMarried),
                new TextReplacementRule("{SpouseResidenceDistrict}", spouse.ResidenceDistrict, "", ()=>Forms.isMarried),

                new TextReplacementRule("{SpouseNationality}", spouse.Nationality, "", ()=>Forms.isMarried),
                new TextReplacementRule("{SpousePersonalIdentifierNumber}", spouse.PersonalIdentifierNumber, "", ()=>Forms.isMarried),

                //Client
                new TextReplacementRule("{ClientName}", client.Surname + " " + client.Forename),

                new TextReplacementRule("{ClientRelative}", client.Relative),

                new TextReplacementRule("{ClientIdentifierDocumentNumber}", client.IdentifierDocumentNumber),

                new TextReplacementRule("{ClientHomeCountry}", client.HomeCountry),
                new TextReplacementRule("{ClientHomePostcode}", client.HomePostcode),
                new TextReplacementRule("{ClientHomeCity}", client.HomeCity),
                new TextReplacementRule("{ClientHomeDistrict}", client.HomeDistrict),
                new TextReplacementRule("{ClientHomeAddress}", client.HomeAddress),

                new TextReplacementRule("{ClientReach}", client.Reach),

                //Funeral
                new TextReplacementRule("{FuneralType}", funeral.Type),
                new TextReplacementRule("{FuneralMethod}", funeral.Method),
                new TextReplacementRule("{FuneralCatafalque}", funeral.Catafalque),
                new TextReplacementRule("{FuneralCoffinOrUrnType}", funeral.CoffinOrUrnType),
                new TextReplacementRule("{FuneralCryptOrCaissionType}", funeral.CryptOrCaissionType),
                new TextReplacementRule("{FuneralGrave}", funeral.Grave),
                new TextReplacementRule("{FuneralDate}", funeral.Date),
                new TextReplacementRule("{FuneralMusic}", funeral.Music),
                new TextReplacementRule("{FuneralGarveDigging}", funeral.GarveDigging),
                new TextReplacementRule("{FuneralGraveMarker}", funeral.GraveMarker),
                new TextReplacementRule("{FuneralUrnCloth}", "X", "", ()=>funeral.UrnCloth),

                new TextReplacementRule("{FuneralisIDCardNeededByClient}", "X", "", ()=>funeral.isIDCardNeededByClient),

                new TextReplacementRule("{FuneralIsIDCardTaken}", "X", "", ()=>funeral.isIDCardTaken),
                new TextReplacementRule("{FuneralIsAddressCardTaken}", "X", "", ()=>funeral.isAddressCardTaken),
                new TextReplacementRule("{FuneralIsDeathCertificateTaken}", "X", "", ()=>funeral.isDeathCertificateTaken),
                new TextReplacementRule("{FuneralIsBirthCertificateTaken}", "X", "", ()=>funeral.isBirthCertificateTaken),
                new TextReplacementRule("{FuneralIsMarriageCertificateTaken}", "X", "", ()=>funeral.isMarriageCertificateTaken),
                new TextReplacementRule("{FuneralIsSpouseDeathCertificateTaken}", "X", "", ()=>funeral.isSpouseDeathCertificateTaken),

                //---
                new TextReplacementRule("{DateOfIssue}", DateTime.Now.ToString("yyyy.MM.dd"))
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
            foreach (var rule in TextReplacementRules)
            {
                if (rule.ShouldReplace())
                {
                    templateDoc.ReplaceText(rule.TextToReplace, rule.TextToInsert);
                }
            }
        }
    }
}
