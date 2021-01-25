using DocumentManager.Data;
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
    public partial class Client : FormBase
    {

        ClientData clientData;

        public Client()
        {
            InitializeComponent();
            Forms.ClientForm = this;
        }

        private void Client_Load(object sender, EventArgs e)
        {
            clientData = Forms.clientData;

            tbClientSurname.DataBindings.Add("Text", Forms.clientData, nameof(ClientData.Surname));
            tbClientForename.DataBindings.Add("Text", Forms.clientData, nameof(ClientData.Forename));
            tbClientRelative.DataBindings.Add("Text", Forms.clientData, nameof(ClientData.Relative));
            tbClientIdentifierDocumentNumber.DataBindings.Add("Text", Forms.clientData, nameof(ClientData.IdentifierDocumentNumber));
            tbClientHomeCountry.DataBindings.Add("Text", Forms.clientData, nameof(ClientData.HomeCountry));
            tbClientHomePostcode.DataBindings.Add("Text", Forms.clientData, nameof(ClientData.HomePostcode));
            tbClientHomeCity.DataBindings.Add("Text", Forms.clientData, nameof(ClientData.HomeCity));
            tbClientHomeAddress.DataBindings.Add("Text", Forms.clientData, nameof(ClientData.HomeAddress));
            tbClientHomeDistrict.DataBindings.Add("Text", Forms.clientData, nameof(ClientData.HomeDistrict));
        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClosingDialog(e);
        }

        private void cbIsClientEqualsSpouse_CheckedChanged(object sender, EventArgs e)
        {
            var spouseData = Forms.spouseData;
            bool hazastars = cbIsClientEqualsSpouse.Checked;

            tbClientSurname.Enabled = !hazastars;
            tbClientForename.Enabled = !hazastars;
            tbClientHomeCity.Enabled = !hazastars;
            tbClientHomeAddress.Enabled = !hazastars;

            if (hazastars)
            {
                clientData.Surname = spouseData.BirthSurname;
                clientData.Forename = spouseData.BirthForename;
                clientData.HomeCity = spouseData.HomeCity;
                clientData.HomeAddress = spouseData.HomeAddress;
            }
            else
            {
                clientData.Surname = "";
                clientData.Forename = "";
                clientData.HomeCity = "";
                clientData.HomeAddress = "";
            }
        }

        private void updateData()
        {
            var client = Forms.clientData;
            bool hazastars = cbIsClientEqualsSpouse.Checked;

            Forms.isSpouseTheClient = hazastars;
            client.Relative = tbClientRelative.Text;
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            updateData();
            var deceased = Forms.deceasedData;

            if (deceased.IsMarried == true)
            {
                Forms.SpouseForm.Show();
                this.Hide();
            }
            else if (deceased.IsMarried == false)
            {
                Forms.DeceasedForm.Show();
                this.Hide();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            updateData();

            Forms.FuneralForm.Show();
            this.Hide();
        }

        private void tbClientHomeCity_TextChanged(object sender, EventArgs e)
        {
            bool visible = tbClientHomeCity.Text == "BUDAPEST" ? true : false;
            tbClientHomeDistrict.Enabled = visible;
            lblClientHomeDistrict.Enabled = visible;
        }
    }
}
