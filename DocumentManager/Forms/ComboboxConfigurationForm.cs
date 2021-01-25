using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentManager
{
    public partial class ComboboxConfigurationForm : Form
    {
        public ListBox lbName;
        public ComboboxConfigurationForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Forms.SettingsForm.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbItemToAdd.Text != "")
            {
                lbName.Items.Add(tbItemToAdd.Text);

                this.Close();
                Forms.SettingsForm.Show();
            }
            else
            {
                MessageBox.Show("Hiányzó adat.");
            }
        }
    }
}
