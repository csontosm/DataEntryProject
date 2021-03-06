﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Words.NET;

namespace DocumentManager
{
    public class FormBase : Form
    {
        public void ClosingDialog(FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Biztos ki szeretnél lépni ?", "Bezárás", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        public void ComboBoxItemFiller(ComboBox cb, int x, int i)
        {
            int j = x;
            while (j - 1 < i)
            {
                if (j < 10)
                {
                    cb.Items.Add("0" + j);
                    j++;
                }
                else
                {
                    cb.Items.Add(j);
                    j++;
                }
            }
        }

        public void Save()
        {
            string[] docTemplateFilesArray = Forms.dataManager.getDocFiles(Settings.templateDocFolderPath);

            string name = Forms.deceasedData.BirthSurname + " " + Forms.deceasedData.BirthForename;

            for (int i = 0; i < docTemplateFilesArray.Count(); i++)
            {
                var templateFile = docTemplateFilesArray[i];
                var outputFileName = Path.GetFileName(docTemplateFilesArray[i]);
                var outputFolderPath = $@"{Settings.outputDocFolderPath}\{name}";
                var outputFilePath = Path.Combine(outputFolderPath, $"{name}_{outputFileName}");

                if (File.Exists(templateFile))
                {
                    var templateDoc = DocX.Load(docTemplateFilesArray[i]);
                    Forms.dataManager.replaceText(templateDoc);
                    Forms.dataManager.createDictionary(outputFolderPath);
                    Forms.dataManager.saveFile(outputFilePath, templateDoc);
                }
            }
        }

        public List<string> readFile(string filePath)
        {
            string line;
            List<string> items = new List<string>();

            StreamReader file = new StreamReader(filePath);
            while ((line = file.ReadLine()) != null)
            {
                items.Add(line);
            }
            file.Close();

            return items;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FormBase
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "FormBase";
            this.ResumeLayout(false);

        }
    }
}
