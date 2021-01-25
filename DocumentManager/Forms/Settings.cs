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

namespace DocumentManager
{
    public partial class Settings : FormBase
    {
        public Settings()
        {
            InitializeComponent();

            Forms.SettingsForm = this;

            lbCoffinTypes.Items.AddRange(readFile(Constants.pathCoffinTypes).ToArray());
            lbUrnTypes.Items.AddRange(readFile(Constants.pathUrnTypes).ToArray());
        }

        private void editFile(string filePath, List<string> itemsList)
        {
            List<string> itemsFile = readFile(filePath);

            if (itemsFile != itemsList)
            {
                TextWriter tw = new StreamWriter(filePath);

                foreach (String s in itemsList)
                    tw.WriteLine(s);

                tw.Close();
            }
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

        private void loadPaths()
        {
            string line;
            string path = Constants.pathSettings;
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
            string path = Constants.pathSettings;
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            List<string> coffinTypes = lbCoffinTypes.Items.Cast<String>().ToList();
            List<string> urnTypes = lbUrnTypes.Items.Cast<String>().ToList();

            editFile(Constants.pathCoffinTypes, coffinTypes);
            editFile(Constants.pathUrnTypes, urnTypes);

            savePaths();
            Forms.MenuForm.Show();
            this.Hide();
        }

        private void btnCoffinAdd_Click(object sender, EventArgs e)
        {
            ComboboxConfigurationForm addForm = new ComboboxConfigurationForm();
            addForm.lbName = lbCoffinTypes;
            addForm.Show();
            this.Hide();
        }

        private void btnCoffinDelete_Click(object sender, EventArgs e)
        {
            if (lbCoffinTypes.SelectedItem != null)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Biztosan törölni szeretnéd ?", "Törlés", buttons);
                if (result == DialogResult.Yes)
                {
                    lbCoffinTypes.Items.Remove(lbCoffinTypes.SelectedItem);
                }
            }
            else
            {
                MessageBox.Show("Nincs semmi kiválasztva.", "Hiba");
            }
        }

        private void btnUrnAdd_Click(object sender, EventArgs e)
        {
            ComboboxConfigurationForm addForm = new ComboboxConfigurationForm();
            addForm.lbName = lbUrnTypes;
            addForm.Show();
            this.Hide();
        }

        private void btnUrnDelete_Click(object sender, EventArgs e)
        {
            if (lbUrnTypes.SelectedItem != null)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Biztosan törölni szeretnéd ?", "Törlés", buttons);
                if (result == DialogResult.Yes)
                {
                    lbUrnTypes.Items.Remove(lbUrnTypes.SelectedItem);
                }
            }
            else
            {
                MessageBox.Show("Nincs semmi kiválasztva.", "Hiba");
            }
        }
    }
}
