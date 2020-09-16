using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OwnProject
{
    public partial class Settings : FormBase
    {
        public Settings()
        {
            InitializeComponent();

            Forms.SettingsForm = this;
        }

        public static string templateDocFolderPath;
        public static string outputDocFolderPath;

        private void FormSettings_Activated(object sender, EventArgs e)
        {
            loadPaths();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    tbInput.Text = fbd.SelectedPath;
                    savePaths();
                }
            }
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    tbOutput.Text = fbd.SelectedPath;
                    savePaths();
                }
            }
        }

        private void btnVisszaFormMain_Click(object sender, EventArgs e)
        {
            savePaths();

            Forms.MenuForm.Show();
            this.Hide();
        }

        private void loadPaths()
        {
            string line;
            string path = @"D:\Settings.txt";
            List<string> paths = new List<string>();

            StreamReader file = new StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                paths.Add(line);
            }
            file.Close();
            
            if (paths.Count == 0)
            {
                tbInput.Text = "";
                tbOutput.Text = "";
            }
            else
            {
                tbInput.Text = paths[0];
                tbOutput.Text = paths[1];
            }
        }

        private void savePaths()
        {
            string path = @"D:\Settings.txt";
            File.WriteAllText(path, String.Empty);
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(tbInput.Text);
                    sw.WriteLine(tbOutput.Text);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(tbInput.Text);
                    sw.WriteLine(tbOutput.Text);
                }
            }
            Settings.templateDocFolderPath = tbInput.Text;
            Settings.outputDocFolderPath = tbOutput.Text;
        }

        private void FormSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClosingDialog(e);
        }
    }
}
