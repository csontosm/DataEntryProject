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
            cmbDateOfMarriageYear.SelectedIndex = 0;
            ComboBoxItemFiller(cmbDateOfMarriageMonth, 1, 12);
            cmbDateOfMarriageMonth.SelectedIndex = 0;
            ComboBoxItemFiller(cmbDateOfMarriageDay, 1, 31);
            cmbDateOfMarriageDay.SelectedIndex = 0;

            ComboBoxItemFiller(cmbSpouseDateOfBirthYear, 1900, DateTime.Now.Year);
            cmbSpouseDateOfBirthYear.SelectedIndex = 0;
            ComboBoxItemFiller(cmbSpouseDateOfBirthMonth, 1, 12);
            cmbSpouseDateOfBirthMonth.SelectedIndex = 0;
            ComboBoxItemFiller(cmbSpouseDateOfBirthDay, 1, 31);
            cmbSpouseDateOfBirthDay.SelectedIndex = 0;
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
        }

        private void Spouse_Activated(object sender, EventArgs e)
        {
            var elhunytData = Forms.deceasedData;
            if (elhunytData.Gender == "Férfi") tbSpousePersonalIdentifierNumberGender.Text = "2"; else if (elhunytData.Gender == "Nő") tbSpousePersonalIdentifierNumberGender.Text = "1"; else tbSpousePersonalIdentifierNumberGender.Text = "";
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

        private void Spouse_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClosingDialog(e);
        }

        private void tbPlaceOfMarriageCity_TextChanged(object sender, EventArgs e)
        {
            bool visible;
            if (tbPlaceOfMarriageCity.Text == "BUDAPEST")
            {
                visible = true;
            }
            else
            {
                visible = false;
                tbPlaceOfMarriageDistrict.Text = "";
            }

            tbPlaceOfMarriageDistrict.Enabled = visible;
        }

        private void tbSpouseHomeCity_TextChanged(object sender, EventArgs e)
        {
            bool visible;
            if (tbSpouseHomeCity.Text == "BUDAPEST")
            {
                visible = true;
            }
            else
            {
                visible = false;
                tbSpouseHomeDistrict.Text = "";
            }

            tbSpouseHomeDistrict.Enabled = visible;
        }

        private void tbSpouseResidenceCity_TextChanged(object sender, EventArgs e)
        {
            bool visible;
            if (tbSpouseResidenceCity.Text == "BUDAPEST")
            {
                visible = true;
            }
            else
            {
                visible = false;
                tbSpouseResidenceDistrict.Text = "";
            }

            tbSpouseResidenceDistrict.Enabled = visible;
        }

        private void cbHomeEqualsResidence_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHomeEqualsResidence.Checked)
            {
                tbSpouseResidenceCity.Enabled = false;
                tbSpouseResidenceDistrict.Enabled = false;

                tbSpouseResidenceCity.Text = tbSpouseHomeCity.Text;

                if (tbSpouseHomeCity.Text == "BUDAPEST")
                {
                    tbSpouseResidenceDistrict.Text = tbSpouseHomeDistrict.Text;
                }
                else
                {
                    tbSpouseResidenceDistrict.Text = "";
                }
            }
            else
            {
                tbSpouseResidenceCity.Enabled = true;
                tbSpouseResidenceDistrict.Enabled = true;
            }
        }

        private void cmbSpouseDateOfBirthYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSpousePersonalIdentifierNumberBirthDate.Text = (cmbSpouseDateOfBirthYear.Text.Substring(2, cmbSpouseDateOfBirthYear.Text.Length - 2) + cmbSpouseDateOfBirthMonth.Text + cmbSpouseDateOfBirthDay.Text);
        }

        private void cmbSpouseDateOfBirthMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSpousePersonalIdentifierNumberBirthDate.Text = (cmbSpouseDateOfBirthYear.Text.Substring(2, cmbSpouseDateOfBirthYear.Text.Length - 2) + cmbSpouseDateOfBirthMonth.Text + cmbSpouseDateOfBirthDay.Text);
        }

        private void cmbSpouseDateOfBirthDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSpousePersonalIdentifierNumberBirthDate.Text = (cmbSpouseDateOfBirthYear.Text.Substring(2, cmbSpouseDateOfBirthYear.Text.Length - 2) + cmbSpouseDateOfBirthMonth.Text + cmbSpouseDateOfBirthDay.Text);
        }
    }
}
