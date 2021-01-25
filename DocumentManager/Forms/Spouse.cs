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
    public partial class Spouse : FormBase
    {
        SpouseData spouseData;
        public Spouse()
        {
            InitializeComponent();
            Forms.SpouseForm = this;

            ComboBoxItemFiller(cmbDateOfMarriageYear, 1900, DateTime.Now.Year);
            ComboBoxItemFiller(cmbDateOfMarriageMonth, 1, 12);
            ComboBoxItemFiller(cmbDateOfMarriageDay, 1, 31);

            ComboBoxItemFiller(cmbSpouseDateOfBirthYear, 1900, DateTime.Now.Year);
            ComboBoxItemFiller(cmbSpouseDateOfBirthMonth, 1, 12);
            ComboBoxItemFiller(cmbSpouseDateOfBirthDay, 1, 31);
        }

        private void Spouse_Load(object sender, EventArgs e)
        {
            spouseData = Forms.spouseData;

            cmbDateOfMarriageYear.DataBindings.Add("Text", Forms.spouseData, nameof(SpouseData.DateOfMarriageYear));
            cmbDateOfMarriageMonth.DataBindings.Add("Text", Forms.spouseData, nameof(SpouseData.DateOfMarriageMonth));
            cmbDateOfMarriageDay.DataBindings.Add("Text", Forms.spouseData, nameof(SpouseData.DateOfMarriageDay));
            tbPlaceOfMarriageCountry.DataBindings.Add("Text", Forms.spouseData, nameof(SpouseData.PlaceOfMarriageCountry));
            tbPlaceOfMarriageCity.DataBindings.Add("Text", Forms.spouseData, nameof(SpouseData.PlaceOfMarriageCity));
            tbPlaceOfMarriageDistrict.DataBindings.Add("Text", Forms.spouseData, nameof(SpouseData.PlaceOfMarriageDistrict));
            tbSpouseBirthSurname.DataBindings.Add("Text", Forms.spouseData, nameof(SpouseData.BirthSurname));
            tbSpouseBirthForename.DataBindings.Add("Text", Forms.spouseData, nameof(SpouseData.BirthForename));
            tbSpouseMarriageName.DataBindings.Add("Text", Forms.spouseData, nameof(SpouseData.MarriageName));
            cmbSpouseDateOfBirthYear.DataBindings.Add("Text", Forms.spouseData, nameof(SpouseData.DateOfBirthYear));
            cmbSpouseDateOfBirthMonth.DataBindings.Add("Text", Forms.spouseData, nameof(SpouseData.DateOfBirthMonth));
            cmbSpouseDateOfBirthDay.DataBindings.Add("Text", Forms.spouseData, nameof(SpouseData.DateOfBirthDay));
            tbSpousePlaceOfBirthCountry.DataBindings.Add("Text", Forms.spouseData, nameof(SpouseData.PlaceOfBirthCountry));
            tbSpousePersonalIdentifierNumber.DataBindings.Add("Text", Forms.spouseData, nameof(SpouseData.PersonalIdentifierNumber));
            tbSpouseHomeCity.DataBindings.Add("Text", Forms.spouseData, nameof(SpouseData.HomeCity));
            tbSpouseHomeAddress.DataBindings.Add("Text", Forms.spouseData, nameof(SpouseData.HomeAddress));
            tbSpouseHomeDistrict.DataBindings.Add("Text", Forms.spouseData, nameof(SpouseData.HomeDistrict));
            tbSpouseNationality.DataBindings.Add("Text", Forms.spouseData, nameof(SpouseData.Nationality));
            tbSpouseResidenceCity.DataBindings.Add("Text", Forms.spouseData, nameof(SpouseData.ResidenceCity));
            tbSpouseResidenceDistrict.DataBindings.Add("Text", Forms.spouseData, nameof(SpouseData.ResidenceDistrict));
            cbIsSpouseHomeEqualsResidence.DataBindings.Add("Checked", Forms.spouseData, nameof(SpouseData.IsSpouseHomeEqualsResidence));
        }

        private void Spouse_Activated(object sender, EventArgs e)
        {
            var elhunytData = Forms.deceasedData;
            if (elhunytData.Gender == "Férfi") tbSpousePersonalIdentifierNumberGender.Text = "2"; else if (elhunytData.Gender == "Nő") tbSpousePersonalIdentifierNumberGender.Text = "1"; else tbSpousePersonalIdentifierNumberGender.Text = "";
        }

        private void Spouse_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClosingDialog(e);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Forms.DeceasedForm.Show();
            this.Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Forms.ClientForm.Show();
            this.Hide();
        }

        private void tbPlaceOfMarriageCity_TextChanged(object sender, EventArgs e)
        {
            bool visible = tbPlaceOfMarriageCity.Text == "BUDAPEST" ? true : false;
            tbPlaceOfMarriageDistrict.Enabled = visible;
            lblPlaceOfMarriageDistrict.Enabled = visible;
        }

        private void tbSpouseHomeCity_TextChanged(object sender, EventArgs e)
        {
            bool visible = tbSpouseHomeCity.Text == "BUDAPEST" ? true : false;
            tbSpouseHomeDistrict.Enabled = visible;
            lblSpouseHomeDistrict.Enabled = visible;
        }

        private void tbSpouseResidenceCity_TextChanged(object sender, EventArgs e)
        {
            bool visible = tbSpouseResidenceCity.Text == "BUDAPEST" ? true : false;
            tbSpouseResidenceDistrict.Enabled = visible;
            lblSpouseResidenceDistrict.Enabled = visible;
        }

        private void cbIsSpouseHomeEqualsResidence_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIsSpouseHomeEqualsResidence.Checked)
            {
                tbSpouseResidenceCity.Enabled = false;
                tbSpouseResidenceDistrict.Enabled = false;
            }
            else
            {
                tbSpouseResidenceCity.Enabled = true;
                tbSpouseResidenceDistrict.Enabled = true;
            }
        }

        private void cmbSpouseDateOfBirthYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePersonalIdentifierNumber();
        }

        private void cmbSpouseDateOfBirthMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePersonalIdentifierNumber();
        }

        private void cmbSpouseDateOfBirthDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePersonalIdentifierNumber();
        }

        private void UpdatePersonalIdentifierNumber()
        {
            if (string.IsNullOrEmpty(cmbSpouseDateOfBirthYear.Text) || string.IsNullOrEmpty(cmbSpouseDateOfBirthMonth.Text) || string.IsNullOrEmpty(cmbSpouseDateOfBirthDay.Text)) return;
            tbSpousePersonalIdentifierNumberBirthDate.Text = (cmbSpouseDateOfBirthYear.Text.Substring(2) + cmbSpouseDateOfBirthMonth.Text + cmbSpouseDateOfBirthDay.Text);
        }
    }
}
