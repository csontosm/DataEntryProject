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

            cbFill(cbE_K_E, 1900, DateTime.Now.Year);
            cbE_K_E.SelectedIndex = 0;
            cbFill(cbE_K_H, 1, 12);
            cbE_K_H.SelectedIndex = 0;
            cbFill(cbE_K_N, 1, 31);
            cbE_K_N.SelectedIndex = 0;

            cbFill(cbE_K_SZ_E, 1900, DateTime.Now.Year);
            cbE_K_SZ_E.SelectedIndex = 0;
            cbFill(cbE_K_SZ_H, 1, 12);
            cbE_K_SZ_H.SelectedIndex = 0;
            cbFill(cbE_K_SZ_N, 1, 31);
            cbE_K_SZ_N.SelectedIndex = 0;
        }

        private void FormHazastars_Activated(object sender, EventArgs e)
        {
            var elhunytData = Forms.deceivedData;
            if (elhunytData.Gender == "Férfi") tbH_SZA_N.Text = "2"; else if (elhunytData.Gender == "Nő") tbH_SZA_N.Text = "1"; else tbH_SZA_N.Text = "";
        }

        private void btnVisszaElhunyt_Click(object sender, EventArgs e)
        {
            updateData();

            Forms.DeceivedForm.Show();
            this.Hide();
        }

        private void btnTovabbBejelento_Click(object sender, EventArgs e)
        {
            updateData();

            Forms.ClientForm.Show();
            this.Hide();
        }

        private void FormHazastars_FormClosing(object sender, FormClosingEventArgs e)
        {
            closingDialog(e);
        }

        //TextBox.TextChanged methods

        private void tbELHUNYT_KAPCSOLAT_VAROS_TextChanged(object sender, EventArgs e)
        {
            bool visible;
            if (tbELHUNYT_KAPCSOLAT_VAROS.Text == "BUDAPEST")
            {
                visible = true;
            }
            else
            {
                visible = false;
                tbELHUNYT_KAPCSOLAT_KERULET.Text = "";
            }

            tbELHUNYT_KAPCSOLAT_KERULET.Enabled = visible;
        }

        private void tbELHUNYT_KAPCSOLAT_LAKOHELY_VAROS_TextChanged(object sender, EventArgs e)
        {
            bool visible;
            if (tbELHUNYT_KAPCSOLAT_LAKOHELY_VAROS.Text == "BUDAPEST")
            {
                visible = true;
            }
            else
            {
                visible = false;
                tbELHUNYT_KAPCSOLAT_LAKOHELY_KERULET.Text = "";
            }

            tbELHUNYT_KAPCSOLAT_LAKOHELY_KERULET.Enabled = visible;
        }

        private void tbELHUNYT_KAPCSOLAT_TARTOZKODASI_VAROS_TextChanged(object sender, EventArgs e)
        {
            bool visible;
            if (tbELHUNYT_KAPCSOLAT_TARTOZKODASI_VAROS.Text == "BUDAPEST")
            {
                visible = true;
            }
            else
            {
                visible = false;
                tbELHUNYT_KAPCSOLAT_TARTOZKODASI_KERULET.Text = "";
            }

            tbELHUNYT_KAPCSOLAT_TARTOZKODASI_KERULET.Enabled = visible;
        }

        private void checkBoxLAKOHELYTARTOZKODASI_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLAKOHELYTARTOZKODASI.Checked)
            {
                tbELHUNYT_KAPCSOLAT_TARTOZKODASI_VAROS.Enabled = false;
                tbELHUNYT_KAPCSOLAT_TARTOZKODASI_KERULET.Enabled = false;

                tbELHUNYT_KAPCSOLAT_TARTOZKODASI_VAROS.Text = tbELHUNYT_KAPCSOLAT_LAKOHELY_VAROS.Text;

                if (tbELHUNYT_KAPCSOLAT_LAKOHELY_VAROS.Text == "BUDAPEST")
                {
                    tbELHUNYT_KAPCSOLAT_TARTOZKODASI_KERULET.Text = tbELHUNYT_KAPCSOLAT_LAKOHELY_KERULET.Text;
                }
                else
                {
                    tbELHUNYT_KAPCSOLAT_TARTOZKODASI_KERULET.Text = "";
                }
            }
            else
            {
                tbELHUNYT_KAPCSOLAT_TARTOZKODASI_VAROS.Enabled = true;
                tbELHUNYT_KAPCSOLAT_TARTOZKODASI_KERULET.Enabled = true;
            }
        }

        private void cbE_K_SZ_E_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbH_SZA_SZ.Text = (cbE_K_SZ_E.Text.Substring(2, cbE_K_SZ_E.Text.Length - 2) + cbE_K_SZ_H.Text + cbE_K_SZ_N.Text);
        }

        private void cbE_K_SZ_H_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbH_SZA_SZ.Text = (cbE_K_SZ_E.Text.Substring(2, cbE_K_SZ_E.Text.Length - 2) + cbE_K_SZ_H.Text + cbE_K_SZ_N.Text);
        }

        private void cbE_K_SZ_N_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbH_SZA_SZ.Text = (cbE_K_SZ_E.Text.Substring(2, cbE_K_SZ_E.Text.Length - 2) + cbE_K_SZ_H.Text + cbE_K_SZ_N.Text);
        }

        //Update data

        private void updateData()
        {
            var spouseData = Forms.spouseData;

            spouseData.PlaceOfMarriageCountry = tbELHUNYT_KAPCSOLAT_ORSZAG.Text;
            spouseData.PlaceOfMarriageCity = tbELHUNYT_KAPCSOLAT_VAROS.Text;
            spouseData.PlaceOfMarriageDistrict = tbELHUNYT_KAPCSOLAT_KERULET.Text;
            spouseData.BirthSurname = tbELHUNYT_KAPCSOLAT_SZULETESI_CSALADI_NEVE.Text;
            spouseData.BirthForename = tbELHUNYT_KAPCSOLAT_SZULETESI_UTONEVE.Text;
            spouseData.MarriageName = tbELHUNYT_KAPCSOLAT_HAZASSAGI_NEVE.Text;
            spouseData.Nationality = tbELHUNYT_KAPCSOLAT_ALLAMPOLGARSAG.Text;
            spouseData.PlaceOfBirthCountry = tbELHUNYT_KAPCSOLAT_SZULETESI_HELYE_ORSZAG.Text;

            spouseData.HomeCity = tbELHUNYT_KAPCSOLAT_LAKOHELY_VAROS.Text;
            spouseData.HomeDistrict = tbELHUNYT_KAPCSOLAT_LAKOHELY_KERULET.Text;
            spouseData.HomeAddress = tbELHUNYT_KAPCSOLAT_LAKOHELY_UTCA_HSZ.Text;

            spouseData.ResidenceCity = tbELHUNYT_KAPCSOLAT_TARTOZKODASI_VAROS.Text;
            spouseData.ResidenceDistrict = tbELHUNYT_KAPCSOLAT_TARTOZKODASI_KERULET.Text;

            spouseData.DateOfMarriageYear = cbE_K_E.Text;
            spouseData.DateOfMarriageMonth = cbE_K_H.Text;
            spouseData.DateOfMarriageDay = cbE_K_N.Text;

            spouseData.DateOfBirthYear = cbE_K_SZ_E.Text;
            spouseData.DateOfBirthMonth = cbE_K_SZ_H.Text;
            spouseData.DateOfBirthDay = cbE_K_SZ_N.Text;


            //Összevont adatok

            spouseData.ELHUNYT_KAPCSOLAT_HELYE = (tbELHUNYT_KAPCSOLAT_ORSZAG.Text + " " + tbELHUNYT_KAPCSOLAT_VAROS.Text);

            spouseData.PersonalIdentifierNumber = (tbH_SZA_N.Text + " " + tbH_SZA_SZ.Text + " " + tbH_SZA.Text);

            spouseData.BirthName = (tbELHUNYT_KAPCSOLAT_SZULETESI_CSALADI_NEVE.Text + " " + tbELHUNYT_KAPCSOLAT_SZULETESI_UTONEVE.Text);
        }
    }
}
