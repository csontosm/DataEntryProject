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
    public partial class Spouse : FormBase
    {
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

        private void Spouse_Activated(object sender, EventArgs e)
        {
            var elhunytData = Forms.deceivedData;
            if (elhunytData.Gender == "Férfi") tbSpousePersonalIdentifierNumberGender.Text = "2"; else if (elhunytData.Gender == "Nő") tbSpousePersonalIdentifierNumberGender.Text = "1"; else tbSpousePersonalIdentifierNumberGender.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            updateData();

            Forms.DeceivedForm.Show();
            this.Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            updateData();

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

        private void updateData()
        {
            var spouseData = Forms.spouseData;

            spouseData.PlaceOfMarriageCountry = tbPlaceOfMarriageCountry.Text;
            spouseData.PlaceOfMarriageCity = tbPlaceOfMarriageCity.Text;
            spouseData.PlaceOfMarriageDistrict = tbPlaceOfMarriageDistrict.Text;
            spouseData.BirthSurname = tbSpouseBirthSurname.Text;
            spouseData.BirthForename = tbSpouseBirthForename.Text;
            spouseData.MarriageName = tbSpouseMarriageName.Text;
            spouseData.Nationality = tbSpouseNationality.Text;
            spouseData.PlaceOfBirthCountry = tbSpousePlaceOfBirthCountry.Text;
            spouseData.HomeCity = tbSpouseHomeCity.Text;
            spouseData.HomeDistrict = tbSpouseHomeDistrict.Text;
            spouseData.HomeAddress = tbSpouseHomeAddress.Text;
            spouseData.ResidenceCity = tbSpouseResidenceCity.Text;
            spouseData.ResidenceDistrict = tbSpouseResidenceDistrict.Text;
            spouseData.DateOfMarriageYear = cmbDateOfMarriageYear.Text;
            spouseData.DateOfMarriageMonth = cmbDateOfMarriageMonth.Text;
            spouseData.DateOfMarriageDay = cmbDateOfMarriageDay.Text;
            spouseData.DateOfBirthYear = cmbSpouseDateOfBirthYear.Text;
            spouseData.DateOfBirthMonth = cmbSpouseDateOfBirthMonth.Text;
            spouseData.DateOfBirthDay = cmbSpouseDateOfBirthDay.Text;
            spouseData.PersonalIdentifierNumber = (tbSpousePersonalIdentifierNumberGender.Text + " " + tbSpousePersonalIdentifierNumberBirthDate.Text + " " + tbSpousePersonalIdentifierNumber.Text);
        }
    }
}
