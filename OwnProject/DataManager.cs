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
                new TextReplacementRule("{ELHUNYT_NEME_FERFI}", "___", "", ()=>deceived.Gender == "Férfi"),
                new TextReplacementRule("{ELHUNYT_NEME_NO}", "", "___", ()=>deceived.Gender == "Férfi"),
                new TextReplacementRule("{ELHUNYT_LEANYKORI_NEVE}", "", deceived.BirthSurname + deceived.BirthForename, ()=>deceived.Gender == "Férfi"),

                new TextReplacementRule("{ELHUNYT_NEVE}", deceived.BirthSurname + " " + deceived.BirthForename, deceived.MarriageName, ()=>deceived.MarriageName == ""),

                new TextReplacementRule("{ELHUNYT_NEVE_HAZASSAGI_NEVE}", deceived.MarriageName),
                new TextReplacementRule("{ELHUNYT_SZULETESI_NEVE}", deceived.BirthSurname + " " + deceived.BirthForename),
                new TextReplacementRule("{ELHUNYT_NEVE_SZULETESI_CSALADI_NEVE}", deceived.BirthSurname),
                new TextReplacementRule("{ELHUNYT_NEVE_SZULETESI_UTONEVE}", deceived.BirthForename),

                new TextReplacementRule("{ELHUNYT_ELETKORA}", deceived.Age),

                new TextReplacementRule("{E_SZ_E}", deceived.DateOfBirthYear),
                new TextReplacementRule("{E_SZ_H}", deceived.DateOfBirthMonth),
                new TextReplacementRule("{E_SZ_N}", deceived.DateOfBirthDay),
                new TextReplacementRule("{ELHUNYT_SZULETESI_HELYE_ORSZAG}", deceived.PlaceOfBirthCountry),
                new TextReplacementRule("{ELHUNYT_SZULETESI_HELYE_VAROS}", deceived.PlaceOfBirthCity),
                new TextReplacementRule("{ELHUNYT_SZULETESI_HELYE_KERULET}", deceived.PlaceOfBrithDistrict),

                new TextReplacementRule("{E_H_E}", deceived.DateOfDeathYear),
                new TextReplacementRule("{E_H_H}", deceived.DateOfDeathMonth),
                new TextReplacementRule("{E_H_N}", deceived.DateOfDeathDay),
                new TextReplacementRule("{ELHUNYT_HALAL_HELYE_VAROS}", deceived.PlaceOfDeathCity),
                new TextReplacementRule("{ELHUNYT_HALAL_HELYE_KERULET}", deceived.PlaceOfDeathDistrict),

                new TextReplacementRule("{ELHUNYT_LAKOHELY_ORSZAG}", deceived.HomeCountry),
                new TextReplacementRule("{ELHUNYT_LAKOHELY_VAROS}", deceived.HomeCity),
                new TextReplacementRule("{ELHUNYT_LAKOHELY_UTCA_HSZ}", deceived.HomeAddress),
                new TextReplacementRule("{ELHUNYT_LAKOHELY_KERULET}", deceived.HomeDistrict),
                new TextReplacementRule("{ELHUNYT_TARTOZKODASI_VAROS}", deceived.ResidenceCity),
                new TextReplacementRule("{ELHUNYT_TARTOZKODASI_KERULET}", deceived.ResidenceDistrict),

                new TextReplacementRule("{ELHUNYT_ALLAMPOLGARSAG}", deceived.Nationality),
                new TextReplacementRule("{ELHUNYT_SZEMELYI_AZONOSITOJA}", deceived.PersonalIdentifierNumber),
                new TextReplacementRule("{ELHUNYT_SZ_OKMANY_AZONOSITO}", deceived.IdentifierDocumentNumber),
                new TextReplacementRule("{ELHUNYT_LAKCIM_KARTYASZAM}", deceived.HomeCardNumber),

                new TextReplacementRule("{ELHUNYT_APJA_SZULETESI_CSALADI_NEVE}", deceived.FatherBirthSurname),
                new TextReplacementRule("{ELHUNYT_APJA_SZULETESI_UTONEVE}", deceived.FatherBirthForename),
                new TextReplacementRule("{ELHUNYT_ANYJA_SZULETESI_CSALADI_NEVE}", deceived.MotherBirthSurname),
                new TextReplacementRule("{ELHUNYT_ANYJA_SZULETESI_UTONEVE}", deceived.MotherBirthForename),

                new TextReplacementRule("{ELHUNYT_FOGLALKOZAS}", deceived.Profession),
                new TextReplacementRule("{ELHUNYT_VEGZETTSEGE}", deceived.Qualification),

                new TextReplacementRule("{UH_O}", deceived.KidsFromLastMarriageAll),
                new TextReplacementRule("{UH_ESZ}", deceived.KidsFromLastMarriageBornAlive),
                new TextReplacementRule("{UH_EV}", deceived.KidsFromLastMarriageAlive),
                new TextReplacementRule("{TH_O}", deceived.KidsAlltogetherAll),
                new TextReplacementRule("{TH_ESZ}", deceived.KidsAlltogetherBornAlive),
                new TextReplacementRule ("{TH_EV}", deceived.KidsAlltogetherAlive),

                //Spouse
                new TextReplacementRule("{E_K_E}", spouse.DateOfMarriageYear, "", ()=>Forms.isMarried),
                new TextReplacementRule("{E_K_H}", spouse.DateOfMarriageMonth, "", ()=>Forms.isMarried),
                new TextReplacementRule("{E_K_N}", spouse.DateOfMarriageDay, "", ()=>Forms.isMarried),
                new TextReplacementRule("{ELHUNYT_KAPCSOLAT_ORSZAG}", spouse.PlaceOfMarriageCountry, "", ()=>Forms.isMarried),
                new TextReplacementRule("{ELHUNYT_KAPCSOLAT_VAROS}", spouse.PlaceOfMarriageCity, "", ()=>Forms.isMarried),
                new TextReplacementRule("{ELHUNYT_KAPCSOLAT_KERULET}", spouse.PlaceOfMarriageDistrict, "", ()=>Forms.isMarried),

                new TextReplacementRule("{ELHUNYT_KAPCSOLAT_SZULETESI_CSALADI_NEVE}", spouse.BirthSurname, "", ()=>Forms.isMarried),
                new TextReplacementRule("{ELHUNYT_KAPCSOLAT_SZULETESI_UTONEVE}", spouse.BirthForename, "", ()=>Forms.isMarried),
                new TextReplacementRule("{ELHUNYT_KAPCSOLAT_HAZASSAGI_NEVE}", spouse.MarriageName, "", ()=>Forms.isMarried),
                new TextReplacementRule("{ELHUNYT_KAPCSOLAT_LEANYKORI_NEVE}", spouse.BirthSurname + " " + spouse.BirthForename, "", ()=>spouse.PersonalIdentifierNumber.Substring(0, 1) == "2"), //!!!implement ()=>Forms.isMarried

                new TextReplacementRule("{E_K_SZ_E}", spouse.DateOfBirthYear, "", ()=>Forms.isMarried),
                new TextReplacementRule("{E_K_SZ_H}", spouse.DateOfBirthMonth, "", ()=>Forms.isMarried),
                new TextReplacementRule("{E_K_SZ_N}", spouse.DateOfBirthDay, "", ()=>Forms.isMarried),
                new TextReplacementRule("{ELHUNYT_KAPCSOLAT_SZULETESI_HELYE_ORSZAG}", spouse.PlaceOfBirthCountry, "", ()=>Forms.isMarried),

                new TextReplacementRule("{ELHUNYT_KAPCSOLAT_LAKOHELY_VAROS}", spouse.HomeCity, "", ()=>Forms.isMarried),
                new TextReplacementRule("{ELHUNYT_KAPCSOLAT_LAKOHELY_KERULET}", spouse.HomeDistrict, "", ()=>Forms.isMarried),
                new TextReplacementRule ("{ELHUNYT_KAPCSOLAT_LAKOHELY_UTCA_HSZ}", spouse.HomeAddress, "", ()=>Forms.isMarried),
                new TextReplacementRule("{ELHUNYT_KAPCSOLAT_TARTOZKODASI_VAROS}", spouse.ResidenceCity, "", ()=>Forms.isMarried),
                new TextReplacementRule("{ELHUNYT_KAPCSOLAT_TARTOZKODASI_KERULET}", spouse.ResidenceDistrict, "", ()=>Forms.isMarried),

                new TextReplacementRule("{ELHUNYT_KAPCSOLAT_ALLAMPOLGARSAG}", spouse.Nationality, "", ()=>Forms.isMarried),
                new TextReplacementRule("{ELHUNYT_KAPCSOLAT_SZEMELYI_AZONOSITO}", spouse.PersonalIdentifierNumber, "", ()=>Forms.isMarried),

                //Client
                new TextReplacementRule("{BEJELENTO_NEVE}", client.ClientSurname + " " + client.ClientForename),

                new TextReplacementRule("{BEJELENTO_HOZZATARTOZOI_MINOSEGE}", client.ClientRelative),

                new TextReplacementRule("{BEJELENTO_SZ_OKMANY_AZONOSITO}", client.ClientIdentifierDocumentNumber),

                new TextReplacementRule("{BEJELENTO_LAKOHELY_ORSZAG}", client.ClientHomeCountry),
                new TextReplacementRule("{BEJELENTO_LAKOHELY_IRANYITOSZAM}", client.ClientHomePostcode),
                new TextReplacementRule("{BEJELENTO_LAKOHELY_VAROS}", client.ClientHomeCity),
                new TextReplacementRule("{BEJELENTO_LAKOHELY_KERULET}", client.ClientHomeDistrict),
                new TextReplacementRule("{BEJELENTO_LAKOHELY_UTCA_HSZ}", client.ClientHomeAddress),

                new TextReplacementRule("{BEJELENTO_ELERHETOSEG}", client.ClientReach),

                //Funeral
                new TextReplacementRule("{TEMETES_TIPUSA}", funeral.Type),
                new TextReplacementRule("{TEMETES_MODJA}", funeral.Method),
                new TextReplacementRule("{TEMETES_RAVATAL}", funeral.Catafalque),
                new TextReplacementRule("{KOPORSO_URNA_TIPUS}", funeral.CoffinOrUrnType),
                new TextReplacementRule("{VAKKRIPTA_KESZON_TIPUS}", funeral.CryptOrCaissionType),
                new TextReplacementRule("{TEMETES_SIRHELY}", funeral.Grave),
                new TextReplacementRule("{TEMETES_IDOPONTJA}", funeral.Date),
                new TextReplacementRule("{TEMETES_ZENE}", funeral.Music),
                new TextReplacementRule("{TEMETES_SIRASAS}", funeral.GarveDigging),
                new TextReplacementRule("{TEMETES_SIRJELZO}", funeral.GraveMarker),
                new TextReplacementRule("{T_U}", "X", "", ()=>funeral.UrnCloth),

                new TextReplacementRule("{A_E_SZ_V}", "X", "", ()=>funeral.isIDCardNeededByClient),

                new TextReplacementRule("{A_E_SZ_I}", "X", "", ()=>funeral.isIDCardTaken),
                new TextReplacementRule("{A_E_L}", "X", "", ()=>funeral.isAddressCardTaken),
                new TextReplacementRule("{A_E_H_B}", "X", "", ()=>funeral.isDeathCertificateTaken),
                new TextReplacementRule("{A_E_SZ_A_K}", "X", "", ()=>funeral.isBirthCertificateTaken),
                new TextReplacementRule("{A_H_A_K}", "X", "", ()=>funeral.isMarriageCertificateTaken),
                new TextReplacementRule("{A_H_H_A_K}", "X", "", ()=>funeral.isSpouseDeathCertificateTaken),

                //---
                new TextReplacementRule("{KIALLITAS_KELTE}", DateTime.Now.ToString("yyyy.MM.dd"))
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
