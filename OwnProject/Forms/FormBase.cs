using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Words.NET;

namespace OwnProject
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
        public void CbFill(ComboBox cb, int x, int i)
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

            string name = Forms.deceivedData.Name;

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
    }
}
