using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OwnProject
{
    public partial class Client : FormBase
    {
        public Client()
        {
            InitializeComponent();
            Forms.ClientForm = this;
        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClosingDialog(e);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            updateData();

            if (Forms.isMarried == true)
            {
                Forms.SpouseForm.Show();
                this.Hide();
            }
            else if (Forms.isMarried == false)
            {
                Forms.DeceivedForm.Show();
                this.Hide();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            updateData();

            Forms.FuneralForm.Show();
            this.Hide();
        }

        private void cbIsClientEqualsSpouse_CheckedChanged(object sender, EventArgs e)
        {
            var spouseData = Forms.spouseData;
            bool hazastars = cbIsClientEqualsSpouse.Checked;

            cmbClientRelative.Visible = hazastars;
            tbClientRelative.Visible = !hazastars;

            tbClientSurname.Enabled = !hazastars;
            tbClientForename.Enabled = !hazastars;
            tbClientHomeCity.Enabled = !hazastars;
            tbClientHomeAddress.Enabled = !hazastars;

            if (hazastars)
            {
                tbClientSurname.Text = spouseData.BirthSurname;
                tbClientForename.Text = spouseData.BirthForename;
                tbClientHomeCity.Text = spouseData.HomeCity;
                tbClientHomeAddress.Text = spouseData.HomeAddress;
            }
            else
            {
                tbClientSurname.Text = "";
                tbClientForename.Text = "";
                tbClientHomeCity.Text = "";
                tbClientHomeAddress.Text = "";
                cmbClientRelative.SelectedIndex = -1;
            }
        }

        private void tbClientHomeCity_TextChanged(object sender, EventArgs e)
        {
            bool visible;
            if (tbClientHomeCity.Text == "BUDAPEST")
            {
                visible = true;
            }
            else
            {
                visible = false;
                tbClientHomeDistrict.Text = "";
            }

            tbClientHomeDistrict.Enabled = visible;
        }

        private void updateData()
        {
            var client = Forms.clientData;
            bool hazastars = cbIsClientEqualsSpouse.Checked;

            Forms.isSpouseTheClient = hazastars;
            client.Relative = hazastars ? cmbClientRelative.Text : tbClientRelative.Text;
            client.Surname = tbClientSurname.Text;
            client.Forename = tbClientForename.Text;
            client.IdentifierDocumentNumber = tbClientIdentifierDocumentNumber.Text;
            client.HomeCountry = tbClientHomeCountry.Text;
            client.HomeCity = tbClientHomeCity.Text;
            client.HomeDistrict = tbClientHomeDistrict.Text;
            client.HomeAddress = tbClientHomeAddress.Text;
            client.HomePostcode = tbClientHomePostcode.Text;
            client.ClientName = (tbClientSurname.Text + " " + tbClientForename.Text);
        }
    }
}
