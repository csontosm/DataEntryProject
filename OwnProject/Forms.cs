using OwnProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OwnProject
{
    public static class Forms
    {
        public static Form MenuForm = new Menu();
        public static Form DecievedForm = new Decieved();
        public static Form SpouseForm = new Spouse();
        public static Form ClientForm = new Client();
        public static Form FuneralForm = new Funeral();
        public static Form PrintForm = new Print();
        public static Form SettingsForm = new Settings();

        public static DecievedData decievedData = new DecievedData();
        public static ClientData clientData = new ClientData();
        public static SpouseData spouseData = new SpouseData();
        public static FuneralData funeralData = new FuneralData();
        public static DataManager dataManager = new DataManager();

        public static bool isSpouseTheClient;
    }

}
