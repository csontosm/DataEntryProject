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
    public partial class Decieved : FormBase
    {
        public Decieved()
        {
            InitializeComponent();
            Forms.DeceivedForm = this;

            ComboBoxItemFiller(cmbDeceivedDateOfBirthYear, 1900, DateTime.Now.Year);
            cmbDeceivedDateOfBirthYear.SelectedIndex = 0;
            ComboBoxItemFiller(cmbDeceivedDateOfBirthMonth, 1, 12);
            cmbDeceivedDateOfBirthMonth.SelectedIndex = 0;
            ComboBoxItemFiller(cmbDeceivedDateOfBirthDay, 1, 31);
            cmbDeceivedDateOfBirthDay.SelectedIndex = 0;


            tbDeceivedDateOfDeathYear.Text = DateTime.Now.Year.ToString();
            ComboBoxItemFiller(cmbDeceivedDateOfDeathMonth, 1, 12);
            cmbDeceivedDateOfDeathMonth.SelectedIndex = 0;
            ComboBoxItemFiller(cmbDeceivedDateOfDeathDay, 1, 31);
            cmbDeceivedDateOfDeathDay.SelectedIndex = 0;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            updateData();

            Forms.MenuForm.Show();
            this.Hide();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(tbDeceivedBirthSurname.Text == "" || tbDeceivedBirthForename.Text == "")
            {
                MessageBox.Show("Nincs megadott név");
            }
            else
            {
                Forms.isMarried = cbIsMarried.Checked;
                if (cbIsMarried.Checked == true)
                {
                    Forms.SpouseForm.Show();
                    this.Hide();
                }
                else
                {
                    Forms.ClientForm.Show();
                    this.Hide();
                }

                updateData();
            }
        }

        private void Decieved_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClosingDialog(e);
        }

        private void cbKidsFromOtherMarriage_CheckedChanged(object sender, EventArgs e)
        {
            bool visible;

            if (cbKidsFromOtherMarriage.Checked)
            {
                visible = true;

                tbKidsAlltogetherAll.Text = "";
                tbKidsAlltogetherBornAlive.Text = "";
                tbKidsAlltogetherAlive.Text = "";
            }
            else
            {
                visible = false;

                tbKidsAlltogetherAll.Text = tbKidsFromLastMarriageAll.Text;
                tbKidsAlltogetherBornAlive.Text = tbKidsFromLastMarriageBornAlive.Text;
                tbKidsAlltogetherAlive.Text = tbKidsFromLastMarriageAlive.Text;
            }

            lblKidsAlltogetherAll.Enabled = visible;
            lblKidsAlltogetherBornAlive.Enabled = visible;
            lblKidsAlltogetherAlive.Enabled = visible;
            lblKidsAlltogether.Enabled = visible;

            tbKidsAlltogetherAll.Enabled = visible;
            tbKidsAlltogetherBornAlive.Enabled = visible;
            tbKidsAlltogetherAlive.Enabled = visible;
        }

        private void cbIsMarried_CheckedChanged(object sender, EventArgs e)
        {
            btnNext.Text = cbIsMarried.Checked ? "Tovább: Bejelentő" : "Tovább: Házastárs / Élettárs";
        }

        private void cbIsHomeEqualsResidence_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIsHomeEqualsResidence.Checked)
            {
                tbDeceivedResidenceCity.Enabled = false;
                tbDeceivedResidenceDistrict.Enabled = false;

                tbDeceivedResidenceCity.Text = tbDeceivedHomeCity.Text;

                if (tbDeceivedHomeCity.Text == "BUDAPEST")
                {
                    tbDeceivedResidenceDistrict.Text = tbDeceivedHomeDistrict.Text;
                }
                else
                {
                    tbDeceivedResidenceDistrict.Text = "";
                }
            }
            else
            {
                tbDeceivedResidenceCity.Enabled = true;
                tbDeceivedResidenceDistrict.Enabled = true;
            }
        }

        private void tbDeceivedHomeCity_TextChanged(object sender, EventArgs e)
        {
            bool visible = tbDeceivedHomeCity.Text == "BUDAPEST" ? true : false;
            tbDeceivedHomeDistrict.Enabled = visible;
        }

        private void tbDeceivedPlaceOfBirthCity_TextChanged(object sender, EventArgs e)
        {
            bool visible = tbDeceivedPlaceOfBirthCity.Text == "BUDAPEST" ? true : false;
            tbDeceivedPlaceOfBirthCity.Enabled = visible;
        }

        private void tbDeceivedPlaceOfDeathCity_TextChanged(object sender, EventArgs e)
        {
            bool visible;
            if (tbDeceivedPlaceOfDeathCity.Text == "BUDAPEST")
            {
                visible = true;
            }
            else
            {
                visible = false;
                tbDeceivedPlaceOfDeathDistrict.Text = "";
            }

            tbDeceivedPlaceOfDeathDistrict.Enabled = visible;
        }

        private void tbDeceivedResidenceCity_TextChanged(object sender, EventArgs e)
        {
            bool visible;
            if (tbDeceivedResidenceCity.Text == "BUDAPEST")
            {
                visible = true;
            }
            else
            {
                visible = false;
                tbDeceivedResidenceDistrict.Text = "";
            }

            tbDeceivedResidenceDistrict.Enabled = visible;
        }
        private void tbKidsFromLastMarriageAll_TextChanged(object sender, EventArgs e)
        {
            if (!cbKidsFromOtherMarriage.Checked) tbKidsAlltogetherAll.Text = tbKidsFromLastMarriageAll.Text;
        }

        private void tbKidsFromLastMarriageBornAlive_TextChanged(object sender, EventArgs e)
        {
            if (!cbKidsFromOtherMarriage.Checked) tbKidsAlltogetherBornAlive.Text = tbKidsFromLastMarriageBornAlive.Text;
        }

        private void tbKidsFromLastMarriageAlive_TextChanged(object sender, EventArgs e)
        {
            if (!cbKidsFromOtherMarriage.Checked) tbKidsAlltogetherAlive.Text = tbKidsFromLastMarriageAlive.Text;
        }

        private void cmbDeceivedGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDeceivedGender.SelectedIndex == 0) tbDeceivedPersonalIdentifierNumberGender.Text = "2"; else tbDeceivedPersonalIdentifierNumberGender.Text = "1";
        }

        private void cmbDeceivedDateOfBirthYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbDeceivedPersonalIdentifierNumberBirthDate.Text = (cmbDeceivedDateOfBirthYear.Text.Substring(2, cmbDeceivedDateOfBirthYear.Text.Length - 2) + cmbDeceivedDateOfBirthMonth.Text + cmbDeceivedDateOfBirthDay.Text);
        }

        private void cmbDeceivedDateOfBirthMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbDeceivedPersonalIdentifierNumberBirthDate.Text = (cmbDeceivedDateOfBirthYear.Text.Substring(2, cmbDeceivedDateOfBirthYear.Text.Length - 2) + cmbDeceivedDateOfBirthMonth.Text + cmbDeceivedDateOfBirthDay.Text);
        }

        private void cmbDeceivedDateOfBirthDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbDeceivedPersonalIdentifierNumberBirthDate.Text = (cmbDeceivedDateOfBirthYear.Text.Substring(2, cmbDeceivedDateOfBirthYear.Text.Length - 2) + cmbDeceivedDateOfBirthMonth.Text + cmbDeceivedDateOfBirthDay.Text);
        }

        private void updateData()
        {
            var elhunytData = Forms.deceivedData;

            elhunytData.BirthSurname = tbDeceivedBirthSurname.Text;
            elhunytData.BirthForename = tbDeceivedBirthForename.Text;
            elhunytData.MarriageName = tbDeceivedMarriageName.Text;
            elhunytData.Gender = cmbDeceivedGender.Text;
            elhunytData.PlaceOfBirthCountry = tbDeceivedPlaceOfBirthCountry.Text;
            elhunytData.PlaceOfBirthCity = tbDeceivedPlaceOfBirthCity.Text;
            elhunytData.PlaceOfBrithDistrict = tbDeceivedPlaceOfBrithDistrict.Text;
            elhunytData.DateOfBirthYear = cmbDeceivedDateOfBirthYear.Text;
            elhunytData.DateOfBirthMonth = cmbDeceivedDateOfBirthMonth.Text;
            elhunytData.DateOfBirthDay = cmbDeceivedDateOfBirthDay.Text;
            elhunytData.DateOfDeathYear = tbDeceivedDateOfDeathYear.Text;
            elhunytData.DateOfDeathMonth = cmbDeceivedDateOfDeathMonth.Text;
            elhunytData.DateOfDeathDay = cmbDeceivedDateOfDeathDay.Text;
            elhunytData.HomeCardNumber = tbDeceivedHomeCardNumber.Text;
            elhunytData.IdentifierDocumentNumber = tbDeceivedIdentifierDocumentNumber.Text;
            elhunytData.Nationality = tbDeceivedNationality.Text;
            elhunytData.PlaceOfDeathCity = tbDeceivedPlaceOfDeathCity.Text;
            elhunytData.PlaceOfDeathDistrict = tbDeceivedPlaceOfDeathDistrict.Text;
            elhunytData.HomeCountry = tbDeceivedHomeCountry.Text;
            elhunytData.HomeCity = tbDeceivedHomeCity.Text;
            elhunytData.HomeDistrict = tbDeceivedHomeDistrict.Text;
            elhunytData.HomeAddress = tbDeceivedHomeAddress.Text;
            elhunytData.ResidenceCity = tbDeceivedResidenceCity.Text;
            elhunytData.ResidenceDistrict = tbDeceivedResidenceDistrict.Text;
            elhunytData.FatherBirthSurname = tbDeceivedFatherBirthSurname.Text;
            elhunytData.FatherBirthForename = tbDeceivedFatherBirthForename.Text;
            elhunytData.MotherBirthSurname = tbDeceivedMotherBirthSurname.Text;
            elhunytData.MotherBirthForename = tbDeceivedMotherBirthForename.Text;

            elhunytData.KidsFromLastMarriageAll = tbKidsFromLastMarriageAll.Text;
            elhunytData.KidsFromLastMarriageBornAlive = tbKidsFromLastMarriageBornAlive.Text;
            elhunytData.KidsFromLastMarriageAlive = tbKidsFromLastMarriageAlive.Text;
            elhunytData.KidsAlltogetherAll = tbKidsAlltogetherAll.Text;
            elhunytData.KidsAlltogetherBornAlive = tbKidsAlltogetherBornAlive.Text;
            elhunytData.KidsAlltogetherAlive = tbKidsAlltogetherAlive.Text;

            elhunytData.Qualification = tbDeceivedQualification.Text;
            elhunytData.Profession = tbDeceivedProfession.Text;
            elhunytData.PersonalIdentifierNumber = (tbDeceivedPersonalIdentifierNumberGender.Text + " " + tbDeceivedPersonalIdentifierNumberBirthDate.Text + " " + tbDeceivedPersonalIdentifierNumber.Text);

            string TimeOfBirth = cmbDeceivedDateOfBirthYear.Text + "/" + cmbDeceivedDateOfBirthMonth.Text + "/" + cmbDeceivedDateOfBirthDay.Text;
            string TimeOfDeath = tbDeceivedDateOfDeathYear.Text + "/" + cmbDeceivedDateOfDeathMonth.Text + "/" + cmbDeceivedDateOfDeathDay.Text;
            elhunytData.Age = Convert.ToInt32(HelperMethods.CalculateAge(TimeOfBirth, TimeOfDeath)).ToString();
        }
    }
}
