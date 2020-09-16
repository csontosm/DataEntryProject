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

            cbB_O_E.Items.Add("Hat. Nélk.");
            CbFill(cbB_O_E, DateTime.Now.Year, DateTime.Now.Year + 30);
            cbB_O_E.SelectedIndex = 0;

            cbB_O_H.Items.Add("");
            CbFill(cbB_O_H, 1, 12);
            cbB_O_H.SelectedIndex = 0;

            cbB_O_N.Items.Add("");
            CbFill(cbB_O_N, 1, 31);
            cbB_O_N.SelectedIndex = 0;
        }

        private void FormBejelento_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClosingDialog(e);
        }

        private void btnVisszaHazastars_Click(object sender, EventArgs e)
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

        private void btnTovabbKiegAdatok_Click(object sender, EventArgs e)
        {
            updateData();

            Forms.FuneralForm.Show();
            this.Hide();
        }

        private void cbB_O_E_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool visible;

            if (cbB_O_E.SelectedIndex == 0) visible = false; else visible = true;

            cbB_O_H.Enabled = visible;
            cbB_O_N.Enabled = visible;
        }

        private void label1_VisibleChanged(object sender, EventArgs e)
        {
            checkBox_Hazastars_A_Bejelento.Enabled = Forms.isMarried;
        }

        private void checkBox_Hazastars_A_Bejelento_CheckedChanged(object sender, EventArgs e)
        {
            var spouseData = Forms.spouseData;
            bool hazastars = checkBox_Hazastars_A_Bejelento.Checked;

            cbBEJELENTO_HOZZATARTOZOI_MINOSEGE.Visible = hazastars;
            tbBEJELENTO_HOZZATARTOZOI_MINOSEGE.Visible = !hazastars;

            tbBEJELENTO_CSALADI_NEVE.Enabled = !hazastars;
            tbBEJELENTO_UTONEVE.Enabled = !hazastars;
            tbBEJELENTO_LAKOHELY_VAROS.Enabled = !hazastars;
            tbBEJELENTO_LAKOHELY_UTCA_HSZ.Enabled = !hazastars;

            if (hazastars)
            {
                tbBEJELENTO_CSALADI_NEVE.Text = spouseData.BirthSurname;
                tbBEJELENTO_UTONEVE.Text = spouseData.BirthForename;
                tbBEJELENTO_LAKOHELY_VAROS.Text = spouseData.HomeCity;
                tbBEJELENTO_LAKOHELY_UTCA_HSZ.Text = spouseData.HomeAddress;
            }
            else
            {
                tbBEJELENTO_CSALADI_NEVE.Text = "";
                tbBEJELENTO_UTONEVE.Text = "";
                tbBEJELENTO_LAKOHELY_VAROS.Text = "";
                tbBEJELENTO_LAKOHELY_UTCA_HSZ.Text = "";
                cbBEJELENTO_HOZZATARTOZOI_MINOSEGE.SelectedIndex = -1;
            }
        }

        //TextBox.TextChanged methods

        private void tbBEJELENTO_LAKOHELY_VAROS_TextChanged(object sender, EventArgs e)
        {
            bool visible;
            if (tbBEJELENTO_LAKOHELY_VAROS.Text == "BUDAPEST")
            {
                visible = true;
            }
            else
            {
                visible = false;
                tbBEJELENTO_LAKOHELY_KERULET.Text = "";
            }

            tbBEJELENTO_LAKOHELY_KERULET.Enabled = visible;
        }

        //UpdateData

        private void updateData()
        {
            var bejelentoData = Forms.clientData;
            bool hazastars = checkBox_Hazastars_A_Bejelento.Checked;
            Forms.isSpouseTheClient = hazastars;

            if (hazastars)
            {
                bejelentoData.ClientRelative = cbBEJELENTO_HOZZATARTOZOI_MINOSEGE.Text;
            }
            else
            {
                bejelentoData.ClientRelative = tbBEJELENTO_HOZZATARTOZOI_MINOSEGE.Text;
            }

            bejelentoData.ClientSurname = tbBEJELENTO_CSALADI_NEVE.Text;
            bejelentoData.ClientForename = tbBEJELENTO_UTONEVE.Text;
            bejelentoData.ClientIdentifierDocumentNumber = tbBEJELENTO_SZ_OKMANY_AZONOSITO.Text;
            bejelentoData.ClientIdentifierDocumentIssuer = tbBEJELENTO_SZ_OKMANY_KIALLITO.Text;
            bejelentoData.ClientHomeCountry = tbBEJELENTO_LAKOHELY_ORSZAG.Text;
            bejelentoData.ClientHomeCity = tbBEJELENTO_LAKOHELY_VAROS.Text;
            bejelentoData.ClientHomeDistrict = tbBEJELENTO_LAKOHELY_KERULET.Text;
            bejelentoData.ClientHomeAddress = tbBEJELENTO_LAKOHELY_UTCA_HSZ.Text;
            bejelentoData.ClientHomePostcode = tbBEJELENTO_LAKOHELY_IRANYITOSZAM.Text;

            bejelentoData.ClientIdentifierDocumentType = cbSzemelyazonositoTipusBejelento.Text;

            bejelentoData.ClientIdentifierDocumentValidityYear = cbB_O_E.Text;
            bejelentoData.ClientIdentifierDocumentValidityMonth = cbB_O_H.Text;
            bejelentoData.ClientIdentifierDocumentValidityDay = cbB_O_N.Text;


            //Összevont adatok

            bejelentoData.ClientName = (tbBEJELENTO_CSALADI_NEVE.Text + " " + tbBEJELENTO_UTONEVE.Text);
        }
    }
}
