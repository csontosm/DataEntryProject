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

            cbFill(cbE_SZ_E, 1900, DateTime.Now.Year);
            cbE_SZ_E.SelectedIndex = 0;
            cbFill(cbE_SZ_H, 1, 12);
            cbE_SZ_H.SelectedIndex = 0;
            cbFill(cbE_SZ_N, 1, 31);
            cbE_SZ_N.SelectedIndex = 0;


            tbE_H_E.Text = DateTime.Now.Year.ToString();
            cbFill(cbE_H_H, 1, 12);
            cbE_H_H.SelectedIndex = 0;
            cbFill(cbE_H_N, 1, 31);
            cbE_H_N.SelectedIndex = 0;


            cbE_O_E.Items.Add("Hat. Nélk.");
            cbFill(cbE_O_E, DateTime.Now.Year, DateTime.Now.Year + 30);
            cbE_O_E.SelectedIndex = 0;

            cbFill(cbE_O_H, 1, 12);
            cbE_O_H.SelectedIndex = 0;

            cbFill(cbE_O_N, 1, 31);
            cbE_O_N.SelectedIndex = 0;
        }


        //----------

        private void btnVisszaMain_Click(object sender, EventArgs e)
        {
            updateData();

            Forms.MenuForm.Show();
            this.Hide();

        }

        private void buttonTovabbHazastars_Click(object sender, EventArgs e)
        {
            if(tbELHUNYT_NEVE_SZULETESI_CSALADI_NEVE.Text == "" || tbELHUNYT_NEVE_SZULETESI_UTONEVE.Text == "")
            {
                MessageBox.Show("Nincs megadott név");
            }
            else
            {
                Forms.VOLTHAZASSAG = checkBox_VoltHazastarsa.Checked;
                if (checkBox_VoltHazastarsa.Checked == true)
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

        private void FormElhunyt_FormClosing(object sender, FormClosingEventArgs e)
        {
            closingDialog(e);
        }


        //---------

        private void cbSzemelyazonositoTipus_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool visible;

            if (cbELHUNYT_SZ_OKMANY_TIPUS.SelectedIndex == 1)
            {
                visible = false;
                tbELHUNYT_ALLAMPOLGARSAG.Text = "Magyar";
            } else
            {
                visible = true;
                tbELHUNYT_ALLAMPOLGARSAG.Text = "";
            }

            tbELHUNYT_ALLAMPOLGARSAG.Enabled = visible;
            labelAllampolgarsagElhunyt.Enabled = visible;
        }

        private void checkBox_GyermekMasHazassabol_CheckedChanged(object sender, EventArgs e)
        {
            bool visible;

            if (checkBox_GyermekMasHazassabol.Checked)
            {
                visible = true;

                tbOSSZ_O.Text = "";
                tbOSSZ_ESZ.Text = "";
                tbOSSZ_EV.Text = "";
            }
            else
            {
                visible = false;

                tbOSSZ_O.Text = tbUH_O.Text;
                tbOSSZ_ESZ.Text = tbUH_ESZ.Text;
                tbOSSZ_EV.Text = tbUH_EV.Text;
            }

            labelTH_O.Enabled = visible;
            labelTH_ESZ.Enabled = visible;
            labelTH_EV.Enabled = visible;
            labelOsszesen_Szuletett_Gyermekek.Enabled = visible;

            tbOSSZ_O.Enabled = visible;
            tbOSSZ_ESZ.Enabled = visible;
            tbOSSZ_EV.Enabled = visible;
        }

        private void checkBox_VoltHazastarsa_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_VoltHazastarsa.Checked == false)
            {
                buttonTovabbHazastars.Text = "Tovább: Bejelentő";
            }
            else
            {
                buttonTovabbHazastars.Text = "Tovább: Házastárs / Élettárs";
            }
        }

        private void checkBoxLAKOHELYTARTOZKODASI_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLAKOHELYTARTOZKODASI.Checked)
            {
                tbELHUNYT_TARTOZKODASI_VAROS.Enabled = false;
                tbELHUNYT_TARTOZKODASI_KERULET.Enabled = false;

                tbELHUNYT_TARTOZKODASI_VAROS.Text = tbELHUNYT_LAKOHELY_VAROS.Text;

                if (tbELHUNYT_LAKOHELY_VAROS.Text == "BUDAPEST")
                {
                    tbELHUNYT_TARTOZKODASI_KERULET.Text = tbELHUNYT_LAKOHELY_KERULET.Text;
                }
                else
                {
                    tbELHUNYT_TARTOZKODASI_KERULET.Text = "";
                }
            }
            else
            {
                tbELHUNYT_TARTOZKODASI_VAROS.Enabled = true;
                tbELHUNYT_TARTOZKODASI_KERULET.Enabled = true;
            }
        }

        private void tbELHUNYT_LAKOHELY_VAROS_TextChanged(object sender, EventArgs e)
        {
            bool visible = tbELHUNYT_LAKOHELY_VAROS.Text == "BUDAPEST" ? true : false;
            tbELHUNYT_LAKOHELY_KERULET.Enabled = visible;
        }

        private void tbELHUNYT_SZULETESI_HELYE_VAROS_TextChanged(object sender, EventArgs e)
        {
            bool visible;
            if (tbELHUNYT_SZULETESI_HELYE_VAROS.Text == "BUDAPEST")
            {
                visible = true;
            }
            else
            {
                visible = false;
                tbELHUNYT_SZULETESI_HELYE_KERULET.Text = "";
            }

            tbELHUNYT_SZULETESI_HELYE_KERULET.Enabled = visible;
        }

        private void tbELHUNYT_HALALESET_VAROS_TextChanged(object sender, EventArgs e)
        {
            bool visible;
            if (tbELHUNYT_HALALESET_VAROS.Text == "BUDAPEST")
            {
                visible = true;
            }
            else
            {
                visible = false;
                tbELHUNYT_HALALESET_KERULET.Text = "";
            }

            tbELHUNYT_HALALESET_KERULET.Enabled = visible;
        }

        private void tbELHUNYT_TARTOZKODASI_VAROS_TextChanged(object sender, EventArgs e)
        {
            bool visible;
            if (tbELHUNYT_TARTOZKODASI_VAROS.Text == "BUDAPEST")
            {
                visible = true;
            }
            else
            {
                visible = false;
                tbELHUNYT_TARTOZKODASI_KERULET.Text = "";
            }

            tbELHUNYT_TARTOZKODASI_KERULET.Enabled = visible;
        }
        private void tbUH_O_TextChanged(object sender, EventArgs e)
        {
            if (!checkBox_GyermekMasHazassabol.Checked)
            {
                tbOSSZ_O.Text = tbUH_O.Text;
            }
        }

        private void tbUH_ESZ_TextChanged(object sender, EventArgs e)
        {
            if (!checkBox_GyermekMasHazassabol.Checked)
            {
                tbOSSZ_ESZ.Text = tbUH_ESZ.Text;
            }
        }

        private void tbUH_EV_TextChanged(object sender, EventArgs e)
        {
            if (!checkBox_GyermekMasHazassabol.Checked)
            {
                tbOSSZ_EV.Text = tbUH_EV.Text;
            }
        }

        private void cbElhunytNeme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbElhunytNeme.SelectedIndex == 0) tbE_SZA_N.Text = "2"; else tbE_SZA_N.Text = "1";
        }

        private void cbE_SZ_E_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbE_SZA_SZ.Text = (cbE_SZ_E.Text.Substring(2, cbE_SZ_E.Text.Length - 2) + cbE_SZ_H.Text + cbE_SZ_N.Text);
        }

        private void cbE_SZ_H_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbE_SZA_SZ.Text = (cbE_SZ_E.Text.Substring(2, cbE_SZ_E.Text.Length - 2) + cbE_SZ_H.Text + cbE_SZ_N.Text);
        }

        private void cbE_SZ_N_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbE_SZA_SZ.Text = (cbE_SZ_E.Text.Substring(2, cbE_SZ_E.Text.Length - 2) + cbE_SZ_H.Text + cbE_SZ_N.Text);
        }


        private void cbE_O_E_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool visible;

            if (cbE_O_E.SelectedIndex == 0)
            {
                visible = false;
                cbE_O_H.SelectedIndex = 0;
                cbE_O_N.SelectedIndex = 0;
            }
            else visible = true;

            cbE_O_H.Enabled = visible;
            cbE_O_N.Enabled = visible;
        }

        //UpdateData

        private void updateData()
        {
            var elhunytData = Forms.deceivedData;

            elhunytData.BirthSurname = tbELHUNYT_NEVE_SZULETESI_CSALADI_NEVE.Text;
            elhunytData.BirthForename = tbELHUNYT_NEVE_SZULETESI_UTONEVE.Text;
            elhunytData.MarriageName = tbELHUNYT_NEVE_HAZASSAGI_NEVE.Text;

            elhunytData.Gender = cbElhunytNeme.Text;

            elhunytData.PlaceOfBirthCountry = tbELHUNYT_SZULETESI_HELYE_ORSZAG.Text;
            elhunytData.PlaceOfBirthCity = tbELHUNYT_SZULETESI_HELYE_VAROS.Text;
            elhunytData.PlaceOfBrithDistrict = tbELHUNYT_SZULETESI_HELYE_KERULET.Text;

            elhunytData.DateOfBirthYear = cbE_SZ_E.Text;
            elhunytData.DateOfBirthMonth = cbE_SZ_H.Text;
            elhunytData.DateOfBirthDay = cbE_SZ_N.Text;

            elhunytData.DateOfDeathYear = tbE_H_E.Text;
            elhunytData.DateOfDeathMonth = cbE_H_H.Text;
            elhunytData.DateOfDeathDay = cbE_H_N.Text;

            elhunytData.HomeCardNumber = tbELHUNYT_LAKCIM_KARTYASZAM.Text;

            elhunytData.IdentifierDocumentNumber = tbELHUNYT_SZ_OKMANY_AZONOSITO.Text;

            elhunytData.Nationality = tbELHUNYT_ALLAMPOLGARSAG.Text;

            elhunytData.PlaceOfDeathCity = tbELHUNYT_HALALESET_VAROS.Text;
            elhunytData.PlaceOfDeathDistrict = tbELHUNYT_HALALESET_KERULET.Text;

            elhunytData.HomeCountry = tbELHUNYT_LAKOHELY_ORSZAG.Text;
            elhunytData.HomeCity = tbELHUNYT_LAKOHELY_VAROS.Text;
            elhunytData.HomeDistrict = tbELHUNYT_LAKOHELY_KERULET.Text;
            elhunytData.HomeAddress = tbELHUNYT_LAKOHELY_UTCA_HSZ.Text;

            elhunytData.ResidenceCity = tbELHUNYT_TARTOZKODASI_VAROS.Text;
            elhunytData.ResidenceDistrict = tbELHUNYT_TARTOZKODASI_KERULET.Text;

            elhunytData.FatherBirthSurname = tbELHUNYT_APJA_SZULETESI_CSALADI_NEVE.Text;
            elhunytData.FatherBirthForename = tbELHUNYT_APJA_SZULETESI_UTONEVE.Text;
            elhunytData.MotherBirthSurname = tbELHUNYT_ANYJA_SZULETESI_CSALADI_NEVE.Text;
            elhunytData.MotherBirthForename = tbELHUNYT_ANYJA_SZULETESI_UTONEVE.Text;

            elhunytData.KidsFromLastMarriageAll = tbUH_O.Text;
            elhunytData.KidsFromLastMarriageBornAlive = tbUH_ESZ.Text;
            elhunytData.KidsFromLastMarriageAlive = tbUH_EV.Text;

            elhunytData.KidsAlltogetherAll = tbOSSZ_O.Text;
            elhunytData.KidsAlltogetherBornAlive = tbOSSZ_ESZ.Text;
            elhunytData.KidsAlltogetherAlive = tbOSSZ_EV.Text;

            elhunytData.Qualification = tbELHUNYT_VEGZETTSEG.Text;
            elhunytData.Profession = tbELHUNYT_FOGLALKOZAS.Text;



            elhunytData.TimeOfDeath = (tbE_H_E.Text + "/" + cbE_H_H.Text + "/" + cbE_H_N.Text);
            elhunytData.PlaceOfDeath = (tbELHUNYT_HALALESET_VAROS.Text + " " + tbELHUNYT_HALALESET_KERULET.Text);

            elhunytData.PersonalIdentifierNumber = (tbE_SZA_N.Text + " " + tbE_SZA_SZ.Text + " " + tbE_SZA.Text);

            elhunytData.Age = Convert.ToInt32(HelperMethods.CalculateAge(elhunytData.TimeOfBirth, elhunytData.TimeOfDeath)).ToString();
        }
    }
}
