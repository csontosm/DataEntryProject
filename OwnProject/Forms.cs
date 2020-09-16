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
        public static Form MenuForm;
        public static Form DeceivedForm;
        public static Form SpouseForm;
        public static Form ClientForm;
        public static Form FuneralForm;
        public static Form PrintForm;
        public static Form SettingsForm;

        public static DecievedData deceivedData = new DecievedData();
        public static ClientData clientData = new ClientData();
        public static SpouseData spouseData = new SpouseData();
        public static FuneralData funeralData = new FuneralData();
        public static DataManager dataManager = new DataManager();

        public static void loadAllForms()
        {
            Decieved frmDeceived = new Decieved();
            Spouse frmSpouse = new Spouse();
            Client frmClient = new Client();
            Funeral frmFuneral = new Funeral();
            Print frmPrint = new Print();
            Settings frmSettings = new Settings();
        }

        public static bool isMarried;
        public static bool isSpouseTheClient;
    }

}
