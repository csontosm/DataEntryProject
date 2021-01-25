using DocumentManager.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentManager
{
    public static class Forms
    {
        public static Menu MenuForm = new Menu();
        public static Deceased DeceasedForm = new Deceased();
        public static Spouse SpouseForm = new Spouse();
        public static Client ClientForm = new Client();
        public static Funeral FuneralForm = new Funeral();
        public static Print PrintForm = new Print();
        public static Settings SettingsForm = new Settings();

        public static DeceasedData deceasedData = new DeceasedData();
        public static ClientData clientData = new ClientData();
        public static SpouseData spouseData = new SpouseData();
        public static FuneralData funeralData = new FuneralData();
        public static DataManager dataManager = new DataManager();

        public static bool isSpouseTheClient;
    }

}
