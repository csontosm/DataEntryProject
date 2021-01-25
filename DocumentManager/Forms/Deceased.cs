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
    public partial class Deceased : FormBase
    {
        DeceasedData deceasedData;
        public Deceased()
        {
            InitializeComponent();
            Forms.DeceasedForm = this;

            ComboBoxItemFiller(cmbDeceasedDateOfBirthYear, 1900, DateTime.Now.Year);
            ComboBoxItemFiller(cmbDeceasedDateOfBirthMonth, 1, 12);
            ComboBoxItemFiller(cmbDeceasedDateOfBirthDay, 1, 31);

            ComboBoxItemFiller(cmbDeceasedDateOfDeathMonth, 1, 12);
            ComboBoxItemFiller(cmbDeceasedDateOfDeathDay, 1, 31);

            ComboBoxItemFiller(cmbDeceasedIdentifierDocumentExpireYear, DateTime.Now.Year, 2099);
            cmbDeceasedIdentifierDocumentExpireYear.Items.Add("Hat.Nélk.");
            ComboBoxItemFiller(cmbDeceasedIdentifierDocumentExpireMonth, 1, 12);
            ComboBoxItemFiller(cmbDeceasedIdentifierDocumentExpireDay, 1, 31);
        }

        private void Deceased_Load(object sender, EventArgs e)
        {
            deceasedData = Forms.deceasedData;

            tbDeceasedDateOfDeathYear.DataBindings.Add("Text", Forms.deceasedData, nameof(DeceasedData.DateOfDeathYear));
            cmbDeceasedDateOfDeathMonth.DataBindings.Add("Text", Forms.deceasedData, nameof(DeceasedData.DateOfDeathMonth));
            cmbDeceasedDateOfDeathDay.DataBindings.Add("Text", Forms.deceasedData, nameof(DeceasedData.DateOfDeathDay));
            tbDeceasedPlaceOfDeathCity.DataBindings.Add("Text", Forms.deceasedData, nameof(DeceasedData.PlaceOfDeathCity));
            tbDeceasedBirthSurname.DataBindings.Add("Text", Forms.deceasedData, nameof(DeceasedData.BirthSurname));
            tbDeceasedBirthForename.DataBindings.Add("Text", Forms.deceasedData, nameof(DeceasedData.BirthForename));
            tbDeceasedMarriageName.DataBindings.Add("Text", Forms.deceasedData, nameof(DeceasedData.MarriageName));
            cmbDeceasedDateOfBirthYear.DataBindings.Add("Text", Forms.deceasedData, nameof(DeceasedData.DateOfBirthYear));
            cmbDeceasedDateOfBirthMonth.DataBindings.Add("Text", Forms.deceasedData, nameof(DeceasedData.DateOfBirthMonth));
            cmbDeceasedDateOfBirthDay.DataBindings.Add("Text", Forms.deceasedData, nameof(DeceasedData.DateOfBirthDay));
            tbDeceasedPlaceOfBirthCountry.DataBindings.Add("Text", Forms.deceasedData, nameof(DeceasedData.PlaceOfBirthCountry));
            tbDeceasedPlaceOfBirthCity.DataBindings.Add("Text", Forms.deceasedData, nameof(DeceasedData.PlaceOfBirthCity));
            tbDeceasedPersonalIdentifierNumber.DataBindings.Add("Text", Forms.deceasedData, nameof(DeceasedData.PersonalIdentifierNumber));
            tbDeceasedHomeCardNumber.DataBindings.Add("Text", Forms.deceasedData, nameof(DeceasedData.HomeCardNumber));
            tbDeceasedIdentifierDocumentNumber.DataBindings.Add("Text", Forms.deceasedData, nameof(DeceasedData.IdentifierDocumentNumber));
            cmbDeceasedIdentifierDocumentExpireYear.DataBindings.Add("Text", Forms.deceasedData, nameof(DeceasedData.IdentifierDocumentExpireYear));
            cmbDeceasedIdentifierDocumentExpireMonth.DataBindings.Add("Text", Forms.deceasedData, nameof(DeceasedData.IdentifierDocumentExpireMonth));
            cmbDeceasedIdentifierDocumentExpireDay.DataBindings.Add("Text", Forms.deceasedData, nameof(DeceasedData.IdentifierDocumentExpireDay));
            tbDeceasedNationality.DataBindings.Add("Text", Forms.deceasedData, nameof(DeceasedData.Nationality));
            tbDeceasedHomeCountry.DataBindings.Add("Text", Forms.deceasedData, nameof(DeceasedData.HomeCountry));
            tbDeceasedHomeCity.DataBindings.Add("Text", Forms.deceasedData, nameof(DeceasedData.HomeCity));
            tbDeceasedHomeAddress.DataBindings.Add("Text", Forms.deceasedData, nameof(DeceasedData.HomeAddress));
            tbDeceasedFatherBirthSurname.DataBindings.Add("Text", Forms.deceasedData, nameof(DeceasedData.FatherBirthSurname));
            tbDeceasedFatherBirthForename.DataBindings.Add("Text", Forms.deceasedData, nameof(DeceasedData.FatherBirthForename));
            tbDeceasedMotherBirthSurname.DataBindings.Add("Text", Forms.deceasedData, nameof(DeceasedData.MotherBirthSurname));
            tbDeceasedMotherBirthForename.DataBindings.Add("Text", Forms.deceasedData, nameof(DeceasedData.MotherBirthForename));
            tbKidsFromLastMarriageAll.DataBindings.Add("Text", Forms.deceasedData, nameof(DeceasedData.KidsFromLastMarriageAll));
            tbKidsFromLastMarriageBornAlive.DataBindings.Add("Text", Forms.deceasedData, nameof(DeceasedData.KidsFromLastMarriageBornAlive));
            tbKidsFromLastMarriageAlive.DataBindings.Add("Text", Forms.deceasedData, nameof(DeceasedData.KidsFromLastMarriageAlive));
            tbKidsAlltogetherAll.DataBindings.Add("Text", Forms.deceasedData, nameof(DeceasedData.KidsAlltogetherAll));
            tbKidsAlltogetherBornAlive.DataBindings.Add("Text", Forms.deceasedData, nameof(DeceasedData.KidsAlltogetherBornAlive));
            tbKidsAlltogetherAlive.DataBindings.Add("Text", Forms.deceasedData, nameof(DeceasedData.KidsAlltogetherAlive));
            tbDeceasedProfession.DataBindings.Add("Text", Forms.deceasedData, nameof(DeceasedData.Profession));
            cmbDeceasedGender.DataBindings.Add("Text", Forms.deceasedData, nameof(DeceasedData.Gender));
            tbDeceasedPlaceOfBrithDistrict.DataBindings.Add("Text", Forms.deceasedData, nameof(DeceasedData.PlaceOfBrithDistrict));
            tbDeceasedPlaceOfDeathDistrict.DataBindings.Add("Text", Forms.deceasedData, nameof(DeceasedData.PlaceOfDeathDistrict));
            tbDeceasedHomeDistrict.DataBindings.Add("Text", Forms.deceasedData, nameof(DeceasedData.HomeDistrict));
            tbDeceasedResidenceCity.DataBindings.Add("Text", Forms.deceasedData, nameof(DeceasedData.ResidenceCity));
            tbDeceasedResidenceDistrict.DataBindings.Add("Text", Forms.deceasedData, nameof(DeceasedData.ResidenceDistrict));
            tbDeceasedQualification.DataBindings.Add("Text", Forms.deceasedData, nameof(DeceasedData.Qualification));
            cbIsMarried.DataBindings.Add("Checked", Forms.deceasedData, nameof(DeceasedData.IsMarried));
            cbKidsFromOtherMarriage.DataBindings.Add("Checked", Forms.deceasedData, nameof(DeceasedData.HasKidsFromOtherMarriage));
            cbIsDeceasedHomeEqualsResidence.DataBindings.Add("Checked", Forms.deceasedData, nameof(DeceasedData.IsDeceasedHomeEqualsResidence));

            deceasedData.DateOfDeathYear = DateTime.Now.Year.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Forms.MenuForm.Show();
            this.Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (tbDeceasedBirthSurname.Text == "" || tbDeceasedBirthForename.Text == "")
            {
                MessageBox.Show("Nincs megadott név");
            }
            else
            {
                deceasedData.IsMarried = cbIsMarried.Checked;
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
            }
        }

        private void Deceased_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClosingDialog(e);
        }

        private void cbIsHomeEqualsResidence_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIsDeceasedHomeEqualsResidence.Checked)
            {
                tbDeceasedResidenceCity.Enabled = false;
                tbDeceasedResidenceDistrict.Enabled = false;
            }
            else
            {
                tbDeceasedResidenceCity.Enabled = true;
                tbDeceasedResidenceDistrict.Enabled = true;
            }
        }

        private void tbDeceasedPlaceOfBirthCity_TextChanged(object sender, EventArgs e)
        {
            bool visible = tbDeceasedPlaceOfBirthCity.Text == "BUDAPEST" ? true : false;
            tbDeceasedPlaceOfBrithDistrict.Enabled = visible;
            lblDeceasedPlaceOfBrithDistrict.Enabled = visible;
        }

        private void tbDeceasedPlaceOfDeathCity_TextChanged(object sender, EventArgs e)
        {
            bool visible = tbDeceasedPlaceOfDeathCity.Text == "BUDAPEST" ? true : false;
            tbDeceasedPlaceOfDeathDistrict.Enabled = visible;
            lblDeceasedPlaceOfDeathDistrict.Enabled = visible;
        }

        private void tbDeceasedHomeCity_TextChanged(object sender, EventArgs e)
        {
            bool visible = tbDeceasedHomeCity.Text == "BUDAPEST" ? true : false;
            tbDeceasedHomeDistrict.Enabled = visible;
            lblDeceasedHomeDistrict.Enabled = visible;
        }

        private void tbDeceasedResidenceCity_TextChanged(object sender, EventArgs e)
        {
            bool visible = tbDeceasedResidenceCity.Text == "BUDAPEST" ? true : false;
            tbDeceasedResidenceDistrict.Enabled = visible;
            lblDeceasedResidenceDistrict.Enabled = visible;
        }

        private void cmbDeceasedGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDeceasedGender.SelectedIndex == 0) tbDeceasedPersonalIdentifierNumberGender.Text = "2"; else tbDeceasedPersonalIdentifierNumberGender.Text = "1";
        }

        private void cmbDeceasedDateOfBirthYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePersonalIdentifierNumber();
        }

        private void cmbDeceasedDateOfBirthMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePersonalIdentifierNumber();
        }

        private void cmbDeceasedDateOfBirthDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePersonalIdentifierNumber();
        }

        private void UpdatePersonalIdentifierNumber()
        {
            if (string.IsNullOrEmpty(cmbDeceasedDateOfBirthYear.Text) || string.IsNullOrEmpty(cmbDeceasedDateOfBirthMonth.Text) || string.IsNullOrEmpty(cmbDeceasedDateOfBirthDay.Text)) return;
            tbDeceasedPersonalIdentifierNumberBirthDate.Text = (cmbDeceasedDateOfBirthYear.Text.Substring(2) + cmbDeceasedDateOfBirthMonth.Text + cmbDeceasedDateOfBirthDay.Text);
        }

        private void cbKidsFromOtherMarriage_CheckedChanged(object sender, EventArgs e)
        {
            lblKidsAlltogetherAll.Enabled = cbKidsFromOtherMarriage.Checked;
            lblKidsAlltogetherBornAlive.Enabled = cbKidsFromOtherMarriage.Checked;
            lblKidsAlltogetherAlive.Enabled = cbKidsFromOtherMarriage.Checked;
            lblKidsAlltogether.Enabled = cbKidsFromOtherMarriage.Checked;

            tbKidsAlltogetherAll.Enabled = cbKidsFromOtherMarriage.Checked;
            tbKidsAlltogetherBornAlive.Enabled = cbKidsFromOtherMarriage.Checked;
            tbKidsAlltogetherAlive.Enabled = cbKidsFromOtherMarriage.Checked;
        }
    }
}
