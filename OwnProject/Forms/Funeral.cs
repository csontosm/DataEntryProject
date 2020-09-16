using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Words.NET;
using System.IO;

namespace OwnProject
{
    public partial class Funeral : FormBase
    {
        public Funeral()
        {
            InitializeComponent();
            Forms.FuneralForm = this;
        }

        private void KiegAdatok_FormClosing(object sender, FormClosingEventArgs e)
        {
            closingDialog(e);
        }

        private void btnBefejezesVisszaFomenu_Click(object sender, EventArgs e)
        {
            updateData();

            Forms.PrintForm.Show();
            this.Hide();
        }

        private void btnVisszaBejelento_Click(object sender, EventArgs e)
        {
            updateData();

            Forms.ClientForm.Show();
            this.Hide();
        }


        //UpdateData

        private void updateData()
        {
            var temetesData = Forms.funeralData;
            var bejelentoData = Forms.clientData;

            string sirko;
            if (cbSirkoKripta.SelectedIndex == 0) sirko = "van sirkő"; else if (cbSirkoKripta.SelectedIndex == 1) sirko = "kripta"; else sirko = "nincs sirkő";
            temetesData.TEMETES_MODJA = cbTemetesModja.Text + ", " + sirko;

            temetesData.TEMETES_TIPUSA = cbTemetesTipusa.Text;

            temetesData.TEMETES_IDOPONTJA = (tbT_I_E.Text + " " + cbT_I_H.Text + " " + cbT_I_N.Text + "  " + cbT_I_ORA.Text + ":" + cbT_I_PERC.Text);

            temetesData.RAVATALOZO = cbRavatalozo.Text;
            temetesData.URNATERITO = checkBoxUrnaterito.Checked;

            temetesData.TEMETES_SIRHELY = tbSirhelyKolombariumSzam.Text;

            temetesData.TEMETES_SIRASAS = cbSirasas.Text;
            temetesData.TEMETES_SIRJELZO = cbSirjelzo.Text;
            temetesData.TEMETES_ZENE = tbZene.Text;
            
            if (cbTemetesModja.SelectedIndex == 0)
            {
                temetesData.KOPORSO_URNA_TIPUS = cbUrnaTipus.Text;
                temetesData.VAKKRIPTA_KESZON_TIPUS = "";
            }
            else if (cbTemetesModja.SelectedIndex == 2)
            {
                temetesData.KOPORSO_URNA_TIPUS = cbUrnaTipus.Text;
                temetesData.VAKKRIPTA_KESZON_TIPUS = cbKeszon.Text;
            }
            else if (cbTemetesModja.SelectedIndex == 1)
            {
                temetesData.KOPORSO_URNA_TIPUS = cbKoporsoTipus.Text;
                temetesData.VAKKRIPTA_KESZON_TIPUS = cbVakkripta.Text;
            }
            else
            {
                temetesData.KOPORSO_URNA_TIPUS = "";
                temetesData.VAKKRIPTA_KESZON_TIPUS = "";
            }

            temetesData.A_E_SZ_I = checkBoxA_E_SZ_I.Checked;
            temetesData.A_E_L = checkBoxA_E_L.Checked;
            temetesData.A_E_H_B = checkBoxA_E_H_B.Checked;
            temetesData.A_E_SZ_A_K = checkBoxA_E_SZ_A_K.Checked;
            temetesData.A_H_A_K = checkBoxA_H_A_K.Checked;
            temetesData.A_H_H_A_K = checkBoxA_H_H_A_K.Checked;

            temetesData.A_E_SZ_V = checkBoxELHUNYT_SZEMELYI_VISSZAIGENYLES.Checked;

            bejelentoData.ClientReach = tbELERHETOSEG.Text;
        }

        private void cbTemetesModja_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSirkoKripta.Text = "";

            if(cbTemetesModja.SelectedIndex == 0)
            {
                cbSirkoKripta.Items.Clear();


                cbTemetesHelye.Enabled = false;

                tbT_I_E.Enabled = false;
                cbT_I_H.Enabled = false;
                cbT_I_N.Enabled = false;
                cbT_I_ORA.Enabled = false;
                cbT_I_PERC.Enabled = false;

                cbTemetesTipusa.Enabled = false;

                tbSirhelyKolombariumSzam.Enabled = false;

                cbRavatalozo.Enabled = false;

                tbZene.Enabled = false;

                cbSirkoKripta.Enabled = false;

                cbUrnaTipus.Enabled = true;
                cbUrnaTipus.Visible = true;
                cbKoporsoTipus.Enabled = false;
                cbKoporsoTipus.Visible = false;

                checkBoxUrnaterito.Enabled = true;


                cbTemetesHelye.Text = "";
                tbT_I_E.Text = "";
                cbT_I_H.Items.Clear();
                cbT_I_N.Items.Clear();
                cbT_I_ORA.Items.Clear();
                cbT_I_PERC.Items.Clear();
                cbTemetesTipusa.Text = "";
                cbSirkoKripta.Text = "";
                tbSirhelyKolombariumSzam.Text = "";
                cbRavatalozo.Text = "";
                tbZene.Text = "";
                cbKeszon.Text = "";
                cbVakkripta.Text = "";
                cbSirasas.Text = "";
                cbSirjelzo.Text = "";
            }
            else if(cbTemetesModja.SelectedIndex == 1)
            {
                labelSirkoKripta.Text = "Sirkő/Kripta";

                labelKoporsoUrnaTipus.Text = "Koporso tipus";


                tbT_I_E.Text = DateTime.Now.Year.ToString();
                cbFill(cbT_I_H, 1, 12);
                cbT_I_H.SelectedIndex = 0;
                cbFill(cbT_I_N, 1, 31);
                cbT_I_N.SelectedIndex = 0;
                cbFill(cbT_I_ORA, 9, 17);
                cbT_I_ORA.SelectedIndex = 0;
                cbT_I_PERC.Items.Add("00");
                cbT_I_PERC.Items.Add("30");
                cbT_I_PERC.SelectedIndex = 0;

                cbSirkoKripta.Items.Clear();
                cbSirkoKripta.Items.Add("Sirkő");
                cbSirkoKripta.Items.Add("Kripta");
                cbSirkoKripta.Items.Add("Nincs sirkő");


                cbTemetesHelye.Enabled = true;

                tbT_I_E.Enabled = true;
                cbT_I_H.Enabled = true;
                cbT_I_N.Enabled = true;
                cbT_I_ORA.Enabled = true;
                cbT_I_PERC.Enabled = true;

                cbTemetesTipusa.Enabled = true;

                tbSirhelyKolombariumSzam.Enabled = true;

                cbRavatalozo.Enabled = true;

                tbZene.Enabled = true;

                cbSirkoKripta.Enabled = true;

                cbUrnaTipus.Enabled = false;
                cbUrnaTipus.Visible = false;
                cbKoporsoTipus.Enabled = true;
                cbKoporsoTipus.Visible = true;

                checkBoxUrnaterito.Enabled = false;

                labelVakkriptaKeszon.Text = "Vakkripta";
            }
            else if (cbTemetesModja.SelectedIndex == 2)
            {
                labelSirkoKripta.Text = "Sirkő/Kripta/Kolomb.";

                labelKoporsoUrnaTipus.Text = "Urna tipus";


                tbT_I_E.Text = DateTime.Now.Year.ToString();
                cbFill(cbT_I_H, 1, 12);
                cbT_I_H.SelectedIndex = 0;
                cbFill(cbT_I_N, 1, 31);
                cbT_I_N.SelectedIndex = 0;
                cbFill(cbT_I_ORA, 9, 17);
                cbT_I_ORA.SelectedIndex = 0;
                cbT_I_PERC.Items.Add("00");
                cbT_I_PERC.Items.Add("30");
                cbT_I_PERC.SelectedIndex = 0;

                cbSirkoKripta.Items.Clear();
                cbSirkoKripta.Items.Add("Sirkő");
                cbSirkoKripta.Items.Add("Kripta");
                cbSirkoKripta.Items.Add("Kolombárium");
                cbSirkoKripta.Items.Add("Nincs sirkő");


                cbTemetesHelye.Enabled = true;

                tbT_I_E.Enabled = true;
                cbT_I_H.Enabled = true;
                cbT_I_N.Enabled = true;
                cbT_I_ORA.Enabled = true;
                cbT_I_PERC.Enabled = true;

                cbTemetesTipusa.Enabled = true;

                tbSirhelyKolombariumSzam.Enabled = true;

                cbRavatalozo.Enabled = true;

                tbZene.Enabled = true;

                cbSirkoKripta.Enabled = true;

                cbUrnaTipus.Enabled = true;
                cbUrnaTipus.Visible = true;
                cbKoporsoTipus.Enabled = false;
                cbKoporsoTipus.Visible = false;

                checkBoxUrnaterito.Enabled = true;

                labelVakkriptaKeszon.Text = "Keszon";
            }
        }

        private void cbSirkoKripta_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbRavatalozo.Items.Clear();
            cbRavatalozo.Items.Add("Máriabesnyő");
            cbRavatalozo.Items.Add("Pax");
            cbRavatalozo.Items.Add("Városi");
            cbRavatalozo.Items.Add("Sirnál");

            if (cbTemetesModja.SelectedIndex == 2)
            {
                cbSirasas.Enabled = false;

                if (cbSirkoKripta.SelectedIndex == 0)
                {
                    labelSirhelyKolombariumSzam.Text = "Sirhely szám";

                    cbVakkripta.Enabled = false;
                    cbVakkripta.Visible = false;
                    cbKeszon.Enabled = true;
                    cbKeszon.Visible = true;

                    cbSirjelzo.Enabled = false;
                }
                else if (cbSirkoKripta.SelectedIndex == 1)
                {
                    labelSirhelyKolombariumSzam.Text = "Sirhely szám";

                    cbVakkripta.Enabled = false;
                    cbVakkripta.Visible = true;
                    cbKeszon.Enabled = false;
                    cbKeszon.Visible = true;

                    cbSirjelzo.Enabled = false;
                }
                else if (cbSirkoKripta.SelectedIndex == 2)
                {
                    labelSirhelyKolombariumSzam.Text = "Kolombárium szám";

                    cbVakkripta.Enabled = false;
                    cbVakkripta.Visible = true;
                    cbKeszon.Enabled = false;
                    cbKeszon.Visible = true;

                    cbSirjelzo.Enabled = false;

                    cbRavatalozo.Items.Remove("Sirnál");
                    cbRavatalozo.Items.Add("Falnál");
                }
                else if (cbSirkoKripta.SelectedIndex == 3)
                {
                    labelSirhelyKolombariumSzam.Text = "Sirhely szám";

                    cbVakkripta.Enabled = false;
                    cbVakkripta.Visible = false;
                    cbKeszon.Enabled = true;
                    cbKeszon.Visible = true;

                    cbSirjelzo.Enabled = true;
                }
            }

            if (cbTemetesModja.SelectedIndex == 1)
            {
                labelSirhelyKolombariumSzam.Text = "Sirhely szám";

                if (cbSirkoKripta.SelectedIndex == 0)
                {
                    cbVakkripta.Enabled = true;
                    cbVakkripta.Visible = true;
                    cbKeszon.Enabled = false;
                    cbKeszon.Visible = false;

                    cbSirasas.Enabled = true;

                    cbSirjelzo.Enabled = true;
                }
                else if (cbSirkoKripta.SelectedIndex == 1)
                {
                    cbVakkripta.Enabled = false;
                    cbVakkripta.Visible = true;
                    cbKeszon.Enabled = false;
                    cbKeszon.Visible = true;

                    cbSirasas.Enabled = false;

                    cbSirjelzo.Enabled = false;
                }
                else if (cbSirkoKripta.SelectedIndex == 2)
                {
                    cbVakkripta.Enabled = true;
                    cbVakkripta.Visible = true;
                    cbKeszon.Enabled = false;
                    cbKeszon.Visible = false;

                    cbSirasas.Enabled = true;

                    cbSirjelzo.Enabled = true;
                }
            }
        }

        private void cbVakkripta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbVakkripta.SelectedIndex == 0)
            {
                cbSirasas.Items.Clear();
                cbSirasas.Items.Add("Sima");
                cbSirasas.Items.Add("Mélyitett");
            }
            else if (cbVakkripta.SelectedIndex == 1)
            {
                cbSirasas.Items.Clear();
                cbSirasas.Items.Add("Sima bővitett");
                cbSirasas.Items.Add("Mélyitett bővitett");
            }
        }
    }
}