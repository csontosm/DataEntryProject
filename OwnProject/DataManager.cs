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
                new TextReplacementRule("{ELHUNYT_NEVE}", deceived.BirthSurname + " "  + deceived.BirthForename, ()=>deceived.MarriageName == ""),
                new TextReplacementRule("{ELHUNYT_NEVE}", deceived.MarriageName, ()=>deceived.MarriageName != ""),
                new TextReplacementRule("{ELHUNYT_NEVE_AN}", deceived.Name + "  A.n.:" + deceived.MotherBirthSurname + " " + deceived.MotherBirthForename),
                new TextReplacementRule("{ELHUNYT_HALAL_IDOPONTJA}", deceived.TimeOfDeath),
                new TextReplacementRule("{E_H_E}", deceived.DateOfDeathYear),
                new TextReplacementRule("{E_H_H}", deceived.DateOfDeathMonth),
                new TextReplacementRule("{E_H_N}", deceived.DateOfDeathDay),
                new TextReplacementRule("{ELHUNYT_HALAL_HELYE_VAROS}", deceived.PlaceOfDeathCity),
                new TextReplacementRule("{ELHUNYT_HALAL_HELYE_KERULET}", deceived.PlaceOfDeathDistrict),
                new TextReplacementRule("{ELHUNYT_HALAL_HELYE}", deceived.PlaceOfDeath),
                new TextReplacementRule("{ELHUNYT_ELETKORA}", deceived.Age),
                new TextReplacementRule("{ELHUNYT_SZULETESI_NEVE}", deceived.BirthSurname + " " + deceived.BirthForename),
                new TextReplacementRule("{ELHUNYT_NEVE_SZULETESI_CSALADI_NEVE}", deceived.BirthSurname),
                new TextReplacementRule("{ELHUNYT_NEVE_SZULETESI_UTONEVE}", deceived.BirthForename),
                new TextReplacementRule("{ELHUNYT_NEVE_HAZASSAGI_NEVE}", deceived.MarriageName),

                new TextReplacementRule("{E_SZ_E}", deceived.DateOfBirthYear),
                new TextReplacementRule("{E_SZ_H}", deceived.DateOfBirthMonth),
                new TextReplacementRule("{E_SZ_N}", deceived.DateOfBirthDay),
                new TextReplacementRule("{ELHUNYT_SZULETESI_IDOPONTJA}", deceived.DateOfBirthYear + "/" + deceived.DateOfBirthMonth + "/" + deceived.DateOfBirthDay),


                new TextReplacementRule("{ELHUNYT_NEME_FERFI}", "___", ()=>deceived.Gender == "Férfi"),
                new TextReplacementRule("{ELHUNYT_NEME_NO}", "", ()=>deceived.Gender == "Férfi"),
                new TextReplacementRule("{ELHUNYT_LEANYKORI_NEVE}", "", ()=>deceived.Gender == "Férfi"),

                new TextReplacementRule("{ELHUNYT_NEME_FERFI}", "", ()=>deceived.Gender == "Nő"),
                new TextReplacementRule("{ELHUNYT_NEME_NO}", "___", ()=>deceived.Gender == "Nő"),
                new TextReplacementRule("{ELHUNYT_LEANYKORI_NEVE}", deceived.BirthSurname + deceived.BirthForename, ()=>deceived.Gender == "Nő"),


                new TextReplacementRule("{ELHUNYT_SZULETESI_HELYE}", deceived.PlaceOfBirthCountry + " " + deceived.PlaceOfBirthCity),

                new TextReplacementRule("{ELHUNYT_SZULETESI_I_H}", deceived.DateOfBirthYear + "/" + deceived.DateOfBirthMonth + "/" + deceived.DateOfBirthDay + " " + deceived.PlaceOfBirthCity + " " + deceived.PlaceOfBrithDistrict),
                new TextReplacementRule("{ELHUNYT_SZULETESI_HELYE_ORSZAG}", deceived.PlaceOfBirthCountry),
                new TextReplacementRule("{ELHUNYT_SZULETESI_HELYE_VAROS}", deceived.PlaceOfBirthCity),
                new TextReplacementRule("{ELHUNYT_SZULETESI_HELYE_KERULET}", deceived.PlaceOfBrithDistrict),

                new TextReplacementRule("{ELHUNYT_SZEMELYI_AZONOSITOJA}", deceived.PersonalIdentifierNumber),
                new TextReplacementRule("{ELHUNYT_LAKCIM_KARTYASZAM}", deceived.HomeCardNumber),

                new TextReplacementRule("{ELHUNYT_SZ_OKMANY_AZONOSITO}", deceived.IdentifierDocumentNumber),

                new TextReplacementRule("{ELHUNYT_ALLAMPOLGARSAG}", deceived.Nationality),

                new TextReplacementRule("{ELHUNYT_LAKOHELY_ORSZAG}", deceived.HomeCountry),
                new TextReplacementRule("{ELHUNYT_LAKOHELY_VAROS}", deceived.HomeCity),
                new TextReplacementRule("{ELHUNYT_LAKOHELY_KERULET}", deceived.HomeDistrict),
                new TextReplacementRule("{ELHUNYT_LAKOHELY_UTCA_HSZ}", deceived.HomeAddress),

                new TextReplacementRule("{ELHUNYT_TARTOZKODASI_VAROS}", deceived.ResidenceCity),
                new TextReplacementRule("{ELHUNYT_TARTOZKODASI_KERULET}", deceived.ResidenceDistrict),


                new TextReplacementRule("{ELHUNYT_APJA_SZULETESI_CSALADI_NEVE}", deceived.FatherBirthSurname),
                new TextReplacementRule("{ELHUNYT_APJA_SZULETESI_UTONEVE}", deceived.FatherBirthForename),

                new TextReplacementRule("{ELHUNYT_ANYJA_SZULETESI_CSALADI_NEVE}", deceived.MotherBirthSurname),
                new TextReplacementRule("{ELHUNYT_ANYJA_SZULETESI_UTONEVE}", deceived.MotherBirthForename),


                new TextReplacementRule("{ELHUNYT_FOGLALKOZAS}", deceived.Profession),
                new TextReplacementRule("{ELHUNYT_VEGZETTSEGE}", deceived.Qualification),

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

            //Hazastars/Elettars
            if (Forms.VOLTHAZASSAG)
            {
                templateDoc.ReplaceText("{ELHUNYT_KAPCSOLAT_ORSZAG}", spouse.PlaceOfMarriageCountry);
                templateDoc.ReplaceText("{ELHUNYT_KAPCSOLAT_VAROS}", spouse.PlaceOfMarriageCity);
                templateDoc.ReplaceText("{ELHUNYT_KAPCSOLAT_KERULET}", spouse.PlaceOfMarriageDistrict);
                templateDoc.ReplaceText("{ELHUNYT_KAPCSOLAT_HELYE}", spouse.ELHUNYT_KAPCSOLAT_HELYE);
                templateDoc.ReplaceText("{E_K_E}", spouse.DateOfMarriageYear);
                templateDoc.ReplaceText("{E_K_H}", spouse.DateOfMarriageMonth);
                templateDoc.ReplaceText("{E_K_N}", spouse.DateOfMarriageDay);

                templateDoc.ReplaceText("{ELHUNYT_KAPCSOLAT_SZULETESI_NEVE}", spouse.BirthName);
                templateDoc.ReplaceText("{ELHUNYT_KAPCSOLAT_SZULETESI_CSALADI_NEVE}", spouse.BirthSurname);
                templateDoc.ReplaceText("{ELHUNYT_KAPCSOLAT_SZULETESI_UTONEVE}", spouse.BirthForename);
                templateDoc.ReplaceText("{ELHUNYT_KAPCSOLAT_HAZASSAGI_NEVE}", spouse.MarriageName);
                templateDoc.ReplaceText("{E_K_SZ_E}", spouse.DateOfBirthYear);
                templateDoc.ReplaceText("{E_K_SZ_H}", spouse.DateOfBirthMonth);
                templateDoc.ReplaceText("{E_K_SZ_N}", spouse.DateOfBirthDay);

                templateDoc.ReplaceText("{ELHUNYT_KAPCSOLAT_SZULETESI_HELYE_ORSZAG}", spouse.PlaceOfBirthCountry);

                templateDoc.ReplaceText("{ELHUNYT_KAPCSOLAT_SZEMELYI_AZONOSITO}", spouse.PersonalIdentifierNumber);

                templateDoc.ReplaceText("{ELHUNYT_KAPCSOLAT_LAKOHELY_VAROS}", spouse.HomeCity);
                templateDoc.ReplaceText("{ELHUNYT_KAPCSOLAT_LAKOHELY_KERULET}", spouse.HomeDistrict);
                templateDoc.ReplaceText("{ELHUNYT_KAPCSOLAT_LAKOHELY_UTCA_HSZ}", spouse.HomeAddress);

                templateDoc.ReplaceText("{ELHUNYT_KAPCSOLAT_TARTOZKODASI_VAROS}", spouse.ResidenceCity);
                templateDoc.ReplaceText("{ELHUNYT_KAPCSOLAT_TARTOZKODASI_KERULET}", spouse.ResidenceDistrict);

                templateDoc.ReplaceText("{ELHUNYT_KAPCSOLAT_ALLAMPOLGARSAG}", spouse.Nationality);

                if (spouse.PersonalIdentifierNumber.Substring(0, 1) == "2")
                {
                    templateDoc.ReplaceText("{ELHUNYT_KAPCSOLAT_LEANYKORI_NEVE}", spouse.BirthName);
                }
                else
                {
                    templateDoc.ReplaceText("{ELHUNYT_KAPCSOLAT_LEANYKORI_NEVE}", "");
                }
            }
            else
            {
                templateDoc.ReplaceText("{ELHUNYT_KAPCSOLAT_ORSZAG}", "");
                templateDoc.ReplaceText("{ELHUNYT_KAPCSOLAT_VAROS}", "");
                templateDoc.ReplaceText("{ELHUNYT_KAPCSOLAT_KERULET}", "");
                templateDoc.ReplaceText("{ELHUNYT_KAPCSOLAT_HELYE}", "");
                templateDoc.ReplaceText("{E_K_E}", "");
                templateDoc.ReplaceText("{E_K_H}", "");
                templateDoc.ReplaceText("{E_K_N}", "");

                templateDoc.ReplaceText("{ELHUNYT_KAPCSOLAT_SZULETESI_CSALADI_NEVE}", "");
                templateDoc.ReplaceText("{ELHUNYT_KAPCSOLAT_SZULETESI_UTONEVE}", "");
                templateDoc.ReplaceText("{ELHUNYT_KAPCSOLAT_HAZASSAGI_NEVE}", "");
                templateDoc.ReplaceText("{E_K_SZ_E}", "");
                templateDoc.ReplaceText("{E_K_SZ_H}", "");
                templateDoc.ReplaceText("{E_K_SZ_N}", "");

                templateDoc.ReplaceText("{ELHUNYT_KAPCSOLAT_SZULETESI_HELYE_ORSZAG}", "");

                templateDoc.ReplaceText("{ELHUNYT_KAPCSOLAT_SZEMELYI_AZONOSITO}", "");

                templateDoc.ReplaceText("{ELHUNYT_KAPCSOLAT_LAKOHELY_VAROS}", "");
                templateDoc.ReplaceText("{ELHUNYT_KAPCSOLAT_LAKOHELY_KERULET}", "");
                templateDoc.ReplaceText("{ELHUNYT_KAPCSOLAT_LAKOHELY_UTCA_HSZ}", "");

                templateDoc.ReplaceText("{ELHUNYT_KAPCSOLAT_TARTOZKODASI_VAROS}", "");
                templateDoc.ReplaceText("{ELHUNYT_KAPCSOLAT_TARTOZKODASI_KERULET}", "");

                templateDoc.ReplaceText("{ELHUNYT_KAPCSOLAT_ALLAMPOLGARSAG}", "");

                templateDoc.ReplaceText("{ELHUNYT_KAPCSOLAT_LEANYKORI_NEVE}", "");
            }

            templateDoc.ReplaceText("{UH_O}", deceived.KidsFromLastMarriageAll);
            templateDoc.ReplaceText("{UH_ESZ}", deceived.KidsFromLastMarriageBornAlive);
            templateDoc.ReplaceText("{UH_EV}", deceived.KidsFromLastMarriageAlive);

            templateDoc.ReplaceText("{TH_O}", deceived.KidsAlltogetherAll);
            templateDoc.ReplaceText("{TH_ESZ}", deceived.KidsAlltogetherBornAlive);
            templateDoc.ReplaceText("{TH_EV}", deceived.KidsAlltogetherAlive);

            //Bejelentő

            templateDoc.ReplaceText("{BEJELENTO_NEVE}", client.ClientName);

            templateDoc.ReplaceText("{BEJELENTO_HOZZATARTOZOI_MINOSEGE}", client.ClientRelative);

            templateDoc.ReplaceText("{BEJELENTO_SZ_OKMANY_TIPUS}", client.ClientIdentifierDocumentType);
            templateDoc.ReplaceText("{BEJELENTO_SZ_OKMANY_KIALLITO}", client.ClientIdentifierDocumentIssuer);
            templateDoc.ReplaceText("{BEJELENTO_SZ_OKMANY_AZONOSITO}", client.ClientIdentifierDocumentNumber);
            templateDoc.ReplaceText("{B_O_E}", client.ClientIdentifierDocumentValidityYear);
            templateDoc.ReplaceText("{B_O_H}", client.ClientIdentifierDocumentValidityMonth);
            templateDoc.ReplaceText("{B_O_N}", client.ClientIdentifierDocumentValidityDay);

            templateDoc.ReplaceText("{BEJELENTO_LAKOHELY_ORSZAG}", client.ClientHomeCountry);
            templateDoc.ReplaceText("{BEJELENTO_LAKOHELY_VAROS}", client.ClientHomeCity);
            templateDoc.ReplaceText("{BEJELENTO_LAKOHELY_KERULET}", client.ClientHomeDistrict);
            templateDoc.ReplaceText("{BEJELENTO_LAKOHELY_UTCA_HSZ}", client.ClientHomeAddress);
            templateDoc.ReplaceText("{BEJELENTO_LAKOHELY_IRANYITOSZAM}", client.ClientHomePostcode);

            templateDoc.ReplaceText("{BEJELENTO_ELERHETOSEG}", client.ClientReach);

            if (Forms.HAZASTARS_E_BEJELENTO)
            {
                templateDoc.ReplaceText("{MEGRENDELO_NEVE}", spouse.MarriageName);
            }
            else
            {
                templateDoc.ReplaceText("{MEGRENDELO_NEVE}", client.ClientName);
            }


            //Temetés+KiegAdatok

            templateDoc.ReplaceText("{TEMETES_TIPUSA}", funeral.TEMETES_TIPUSA);
            templateDoc.ReplaceText("{TEMETES_MODJA}", funeral.TEMETES_MODJA);
            templateDoc.ReplaceText("{TEMETES_RAVATAL}", funeral.RAVATALOZO);
            templateDoc.ReplaceText("{KOPORSO_URNA_TIPUS}", funeral.KOPORSO_URNA_TIPUS);
            templateDoc.ReplaceText("{VAKKRIPTA_KESZON_TIPUS}", funeral.VAKKRIPTA_KESZON_TIPUS);
            templateDoc.ReplaceText("{TEMETES_SIRHELY}", funeral.TEMETES_SIRHELY);
            templateDoc.ReplaceText("{TEMETES_IDOPONTJA}", funeral.TEMETES_IDOPONTJA);
            templateDoc.ReplaceText("{TEMETES_ZENE}", funeral.TEMETES_ZENE);
            templateDoc.ReplaceText("{TEMETES_SIRASAS}", funeral.TEMETES_SIRASAS);
            templateDoc.ReplaceText("{TEMETES_SIRJELZO}", funeral.TEMETES_SIRJELZO);

            string x = "";
            if (funeral.A_E_SZ_I) x = "X"; else x = "";
            templateDoc.ReplaceText("{A_E_SZ_I}", x);

            if (funeral.A_E_L) x = "X"; else x = "";
            templateDoc.ReplaceText("{A_E_L}", x);

            if (funeral.A_E_H_B) x = "X"; else x = "";
            templateDoc.ReplaceText("{A_E_H_B}", x);

            if (funeral.A_E_SZ_A_K) x = "X"; else x = "";
            templateDoc.ReplaceText("{A_E_SZ_A_K}", x);

            if (funeral.A_H_A_K) x = "X"; else x = "";
            templateDoc.ReplaceText("{A_H_A_K}", x);

            if (funeral.A_H_H_A_K) x = "X"; else x = "";
            templateDoc.ReplaceText("{A_H_H_A_K}", x);


            if (funeral.A_E_SZ_V) x = "X"; else x = "";
            templateDoc.ReplaceText("{A_E_SZ_V}", x);


            if (funeral.URNATERITO) x = "X"; else x = "";
            templateDoc.ReplaceText("{T_U}", x);

            templateDoc.ReplaceText("{KIALLITAS_KELTE}", DateTime.Now.ToString("yyyy.MM.dd"));
            templateDoc.ReplaceText("{KIALLITAS_EV}", DateTime.Now.ToString("yyyy"));
            templateDoc.ReplaceText("{KIALLITAS_HO}", DateTime.Now.ToString("MM"));
            templateDoc.ReplaceText("{KIALLITAS_NAP}", DateTime.Now.ToString("dd"));

        }
    }
}
