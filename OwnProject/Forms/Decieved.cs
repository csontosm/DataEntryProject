using OwnProject.Data;
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
        DecievedData decievedData;
        public Decieved()
        {
            InitializeComponent();
            // Forms.DeceivedForm = this;

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

        private void Decieved_Load(object sender, EventArgs e)
        {
            decievedData = Forms.decievedData;
            tbDeceivedBirthSurname.DataBindings.Add("Text", Forms.decievedData, nameof(DecievedData.BirthSurname));
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
                decievedData.IsMarried = cbIsMarried.Checked;
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

        private void tbDeceivedPlaceOfBirthCity_TextChanged(object sender, EventArgs e)
        {
            bool visible = tbDeceivedPlaceOfBirthCity.Text == "BUDAPEST" ? true : false;
            tbDeceivedPlaceOfBrithDistrict.Enabled = visible;
            lblDeceivedPlaceOfBrithDistrict.Enabled = visible;
        }

        private void tbDeceivedPlaceOfDeathCity_TextChanged(object sender, EventArgs e)
        {
            bool visible = tbDeceivedPlaceOfDeathCity.Text == "BUDAPEST" ? true : false;
            tbDeceivedPlaceOfDeathDistrict.Enabled = visible;
            lblDeceivedPlaceOfDeathDistrict.Enabled = visible;
        }

        private void tbDeceivedHomeCity_TextChanged(object sender, EventArgs e)
        {
            bool visible = tbDeceivedHomeCity.Text == "BUDAPEST" ? true : false;
            tbDeceivedHomeDistrict.Enabled = visible;
            lblDeceivedHomeDistrict.Enabled = visible;
        }

        private void tbDeceivedResidenceCity_TextChanged(object sender, EventArgs e)
        {
            bool visible = tbDeceivedResidenceCity.Text == "BUDAPEST" ? true : false;
            tbDeceivedResidenceDistrict.Enabled = visible;
            lblDeceivedResidenceDistrict.Enabled = visible;
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
            var decievedData = Forms.decievedData;

            decievedData.BirthSurname = tbDeceivedBirthSurname.Text;
            decievedData.BirthForename = tbDeceivedBirthForename.Text;
            decievedData.MarriageName = tbDeceivedMarriageName.Text;
            decievedData.Gender = cmbDeceivedGender.Text;
            decievedData.PlaceOfBirthCountry = tbDeceivedPlaceOfBirthCountry.Text;
            decievedData.PlaceOfBirthCity = tbDeceivedPlaceOfBirthCity.Text;
            decievedData.PlaceOfBrithDistrict = tbDeceivedPlaceOfBrithDistrict.Text;
            decievedData.DateOfBirthYear = cmbDeceivedDateOfBirthYear.Text;
            decievedData.DateOfBirthMonth = cmbDeceivedDateOfBirthMonth.Text;
            decievedData.DateOfBirthDay = cmbDeceivedDateOfBirthDay.Text;
            decievedData.DateOfDeathYear = tbDeceivedDateOfDeathYear.Text;
            decievedData.DateOfDeathMonth = cmbDeceivedDateOfDeathMonth.Text;
            decievedData.DateOfDeathDay = cmbDeceivedDateOfDeathDay.Text;
            decievedData.HomeCardNumber = tbDeceivedHomeCardNumber.Text;
            decievedData.IdentifierDocumentNumber = tbDeceivedIdentifierDocumentNumber.Text;
            decievedData.Nationality = tbDeceivedNationality.Text;
            decievedData.PlaceOfDeathCity = tbDeceivedPlaceOfDeathCity.Text;
            decievedData.PlaceOfDeathDistrict = tbDeceivedPlaceOfDeathDistrict.Text;
            decievedData.HomeCountry = tbDeceivedHomeCountry.Text;
            decievedData.HomeCity = tbDeceivedHomeCity.Text;
            decievedData.HomeDistrict = tbDeceivedHomeDistrict.Text;
            decievedData.HomeAddress = tbDeceivedHomeAddress.Text;
            decievedData.ResidenceCity = tbDeceivedResidenceCity.Text;
            decievedData.ResidenceDistrict = tbDeceivedResidenceDistrict.Text;
            decievedData.FatherBirthSurname = tbDeceivedFatherBirthSurname.Text;
            decievedData.FatherBirthForename = tbDeceivedFatherBirthForename.Text;
            decievedData.MotherBirthSurname = tbDeceivedMotherBirthSurname.Text;
            decievedData.MotherBirthForename = tbDeceivedMotherBirthForename.Text;

            decievedData.KidsFromLastMarriageAll = tbKidsFromLastMarriageAll.Text;
            decievedData.KidsFromLastMarriageBornAlive = tbKidsFromLastMarriageBornAlive.Text;
            decievedData.KidsFromLastMarriageAlive = tbKidsFromLastMarriageAlive.Text;
            decievedData.KidsAlltogetherAll = tbKidsAlltogetherAll.Text;
            decievedData.KidsAlltogetherBornAlive = tbKidsAlltogetherBornAlive.Text;
            decievedData.KidsAlltogetherAlive = tbKidsAlltogetherAlive.Text;

            decievedData.Qualification = tbDeceivedQualification.Text;
            decievedData.Profession = tbDeceivedProfession.Text;
            decievedData.PersonalIdentifierNumber = (tbDeceivedPersonalIdentifierNumberGender.Text + " " + tbDeceivedPersonalIdentifierNumberBirthDate.Text + " " + tbDeceivedPersonalIdentifierNumber.Text);

            string TimeOfBirth = cmbDeceivedDateOfBirthYear.Text + "/" + cmbDeceivedDateOfBirthMonth.Text + "/" + cmbDeceivedDateOfBirthDay.Text;
            string TimeOfDeath = tbDeceivedDateOfDeathYear.Text + "/" + cmbDeceivedDateOfDeathMonth.Text + "/" + cmbDeceivedDateOfDeathDay.Text;
            decievedData.Age = Convert.ToInt32(HelperMethods.CalculateAge(TimeOfBirth, TimeOfDeath)).ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            decievedData.IsMarried = checkBox1.Checked;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbDeceivedBirthSurname_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "string";
        }

        private void tbDeceivedBirthForename_TextChanged(object sender, EventArgs e)
        {
        }

        private void cbIsMarried_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = decievedData.IsMarried;
        }
    }
}
