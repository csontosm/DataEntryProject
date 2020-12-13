using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Words.NET;

namespace OwnProject
{
    public partial class Menu : FormBase
    {
        public Menu()
        {
            InitializeComponent();

            Settings.templateDocFolderPath = paths()[0];
            Settings.outputDocFolderPath = paths()[1];

            //var elhunytData = Forms.deceivedData;
        }

        public string[] paths()
        {
            List<string> list = new List<string>();
            string path = @"D:\Settings.txt";

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path)) { }
            }

            using (StreamReader sr = File.OpenText(path))
            {
                if (File.ReadLines(path).Count() == 2)
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        list.Add(s);
                    }
                }
                else
                {
                    list.Add("");
                    list.Add("");
                }
            }
            String[] str = list.ToArray();
            return str;
        }

        public bool checkPaths()
        {
            string path = @"D:\Settings.txt";
            if (File.Exists(path))
            {
                if (Settings.templateDocFolderPath == "" || Settings.outputDocFolderPath == "") return false; else return true;
            }
            else
            {
                return false;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClosingDialog(e);
        }

        private void btnSettings_Click_1(object sender, EventArgs e)
        {
            try
            {
                Forms.SettingsForm.Show();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            this.Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (checkPaths())
            {
                Forms.DecievedForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nincsenek kiválasztott mappák");
            }
        }
    }
}
