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

        private void Funeral_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClosingDialog(e);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            updateData();

            Forms.PrintForm.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            updateData();

            Forms.ClientForm.Show();
            this.Hide();
        }

        private void cmbFuneralMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbGraveOrCrypt.Text = "";

            if(cmbFuneralMethod.SelectedIndex == 0)
            {
                cmbGraveOrCrypt.Items.Clear();


                cbTemetesHelye.Enabled = false;

                tbFuneralDateYear.Enabled = false;
                cmbFuneralDateMonth.Enabled = false;
                cmbFuneralDateDay.Enabled = false;
                cmbFuneralDateHour.Enabled = false;
                cmbFuneralDateMinute.Enabled = false;

                cmbFuneralType.Enabled = false;

                tbFuneralGrave.Enabled = false;

                cmbFuneralCatafalque.Enabled = false;

                tbMusic.Enabled = false;

                cmbGraveOrCrypt.Enabled = false;

                cmbFuneralCoffinOrUrnType.Enabled = true;
                cmbFuneralCoffinOrUrnType.Visible = true;
                cbKoporsoTipus.Enabled = false;
                cbKoporsoTipus.Visible = false;

                cbFuneralUrnCloth.Enabled = true;


                cbTemetesHelye.Text = "";
                tbFuneralDateYear.Text = "";
                cmbFuneralDateMonth.Items.Clear();
                cmbFuneralDateDay.Items.Clear();
                cmbFuneralDateHour.Items.Clear();
                cmbFuneralDateMinute.Items.Clear();
                cmbFuneralType.Text = "";
                cmbGraveOrCrypt.Text = "";
                tbFuneralGrave.Text = "";
                cmbFuneralCatafalque.Text = "";
                tbMusic.Text = "";
                cmbFuneralCaissionType.Text = "";
                cmbFuneralCrypt.Text = "";
                cmbFuneralGarveDigging.Text = "";
                cmbFuneralGraveMarker.Text = "";
            }
            else if(cmbFuneralMethod.SelectedIndex == 1)
            {
                lblGraveOrCrypt.Text = "Sirkő/Kripta";

                lblFuneralCoffinOrUrnType.Text = "Koporso tipus";


                tbFuneralDateYear.Text = DateTime.Now.Year.ToString();
                ComboBoxItemFiller(cmbFuneralDateMonth, 1, 12);
                cmbFuneralDateMonth.SelectedIndex = 0;
                ComboBoxItemFiller(cmbFuneralDateDay, 1, 31);
                cmbFuneralDateDay.SelectedIndex = 0;
                ComboBoxItemFiller(cmbFuneralDateHour, 9, 17);
                cmbFuneralDateHour.SelectedIndex = 0;
                cmbFuneralDateMinute.Items.Add("00");
                cmbFuneralDateMinute.Items.Add("30");
                cmbFuneralDateMinute.SelectedIndex = 0;

                cmbGraveOrCrypt.Items.Clear();
                cmbGraveOrCrypt.Items.Add("Sirkő");
                cmbGraveOrCrypt.Items.Add("Kripta");
                cmbGraveOrCrypt.Items.Add("Nincs sirkő");


                cbTemetesHelye.Enabled = true;

                tbFuneralDateYear.Enabled = true;
                cmbFuneralDateMonth.Enabled = true;
                cmbFuneralDateDay.Enabled = true;
                cmbFuneralDateHour.Enabled = true;
                cmbFuneralDateMinute.Enabled = true;

                cmbFuneralType.Enabled = true;

                tbFuneralGrave.Enabled = true;

                cmbFuneralCatafalque.Enabled = true;

                tbMusic.Enabled = true;

                cmbGraveOrCrypt.Enabled = true;

                cmbFuneralCoffinOrUrnType.Enabled = false;
                cmbFuneralCoffinOrUrnType.Visible = false;
                cbKoporsoTipus.Enabled = true;
                cbKoporsoTipus.Visible = true;

                cbFuneralUrnCloth.Enabled = false;

                lblFuneralCaissionType.Text = "Vakkripta";
            }
            else if (cmbFuneralMethod.SelectedIndex == 2)
            {
                lblGraveOrCrypt.Text = "Sirkő/Kripta/Kolomb.";

                lblFuneralCoffinOrUrnType.Text = "Urna tipus";


                tbFuneralDateYear.Text = DateTime.Now.Year.ToString();
                ComboBoxItemFiller(cmbFuneralDateMonth, 1, 12);
                cmbFuneralDateMonth.SelectedIndex = 0;
                ComboBoxItemFiller(cmbFuneralDateDay, 1, 31);
                cmbFuneralDateDay.SelectedIndex = 0;
                ComboBoxItemFiller(cmbFuneralDateHour, 9, 17);
                cmbFuneralDateHour.SelectedIndex = 0;
                cmbFuneralDateMinute.Items.Add("00");
                cmbFuneralDateMinute.Items.Add("30");
                cmbFuneralDateMinute.SelectedIndex = 0;

                cmbGraveOrCrypt.Items.Clear();
                cmbGraveOrCrypt.Items.Add("Sirkő");
                cmbGraveOrCrypt.Items.Add("Kripta");
                cmbGraveOrCrypt.Items.Add("Kolombárium");
                cmbGraveOrCrypt.Items.Add("Nincs sirkő");


                cbTemetesHelye.Enabled = true;

                tbFuneralDateYear.Enabled = true;
                cmbFuneralDateMonth.Enabled = true;
                cmbFuneralDateDay.Enabled = true;
                cmbFuneralDateHour.Enabled = true;
                cmbFuneralDateMinute.Enabled = true;

                cmbFuneralType.Enabled = true;

                tbFuneralGrave.Enabled = true;

                cmbFuneralCatafalque.Enabled = true;

                tbMusic.Enabled = true;

                cmbGraveOrCrypt.Enabled = true;

                cmbFuneralCoffinOrUrnType.Enabled = true;
                cmbFuneralCoffinOrUrnType.Visible = true;
                cbKoporsoTipus.Enabled = false;
                cbKoporsoTipus.Visible = false;

                cbFuneralUrnCloth.Enabled = true;

                lblFuneralCaissionType.Text = "Keszon";
            }
        }

        private void cmbGraveOrCrypt_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbFuneralCatafalque.Items.Clear();
            cmbFuneralCatafalque.Items.Add("Máriabesnyő");
            cmbFuneralCatafalque.Items.Add("Pax");
            cmbFuneralCatafalque.Items.Add("Városi");
            cmbFuneralCatafalque.Items.Add("Sirnál");

            if (cmbFuneralMethod.SelectedIndex == 2)
            {
                cmbFuneralGarveDigging.Enabled = false;

                if (cmbGraveOrCrypt.SelectedIndex == 0)
                {
                    lblFuneralGrave.Text = "Sirhely szám";

                    cmbFuneralCrypt.Enabled = false;
                    cmbFuneralCrypt.Visible = false;
                    cmbFuneralCaissionType.Enabled = true;
                    cmbFuneralCaissionType.Visible = true;

                    cmbFuneralGraveMarker.Enabled = false;
                }
                else if (cmbGraveOrCrypt.SelectedIndex == 1)
                {
                    lblFuneralGrave.Text = "Sirhely szám";

                    cmbFuneralCrypt.Enabled = false;
                    cmbFuneralCrypt.Visible = true;
                    cmbFuneralCaissionType.Enabled = false;
                    cmbFuneralCaissionType.Visible = true;

                    cmbFuneralGraveMarker.Enabled = false;
                }
                else if (cmbGraveOrCrypt.SelectedIndex == 2)
                {
                    lblFuneralGrave.Text = "Kolombárium szám";

                    cmbFuneralCrypt.Enabled = false;
                    cmbFuneralCrypt.Visible = true;
                    cmbFuneralCaissionType.Enabled = false;
                    cmbFuneralCaissionType.Visible = true;

                    cmbFuneralGraveMarker.Enabled = false;

                    cmbFuneralCatafalque.Items.Remove("Sirnál");
                    cmbFuneralCatafalque.Items.Add("Falnál");
                }
                else if (cmbGraveOrCrypt.SelectedIndex == 3)
                {
                    lblFuneralGrave.Text = "Sirhely szám";

                    cmbFuneralCrypt.Enabled = false;
                    cmbFuneralCrypt.Visible = false;
                    cmbFuneralCaissionType.Enabled = true;
                    cmbFuneralCaissionType.Visible = true;

                    cmbFuneralGraveMarker.Enabled = true;
                }
            }

            if (cmbFuneralMethod.SelectedIndex == 1)
            {
                lblFuneralGrave.Text = "Sirhely szám";

                if (cmbGraveOrCrypt.SelectedIndex == 0)
                {
                    cmbFuneralCrypt.Enabled = true;
                    cmbFuneralCrypt.Visible = true;
                    cmbFuneralCaissionType.Enabled = false;
                    cmbFuneralCaissionType.Visible = false;

                    cmbFuneralGarveDigging.Enabled = true;

                    cmbFuneralGraveMarker.Enabled = true;
                }
                else if (cmbGraveOrCrypt.SelectedIndex == 1)
                {
                    cmbFuneralCrypt.Enabled = false;
                    cmbFuneralCrypt.Visible = true;
                    cmbFuneralCaissionType.Enabled = false;
                    cmbFuneralCaissionType.Visible = true;

                    cmbFuneralGarveDigging.Enabled = false;

                    cmbFuneralGraveMarker.Enabled = false;
                }
                else if (cmbGraveOrCrypt.SelectedIndex == 2)
                {
                    cmbFuneralCrypt.Enabled = true;
                    cmbFuneralCrypt.Visible = true;
                    cmbFuneralCaissionType.Enabled = false;
                    cmbFuneralCaissionType.Visible = false;

                    cmbFuneralGarveDigging.Enabled = true;

                    cmbFuneralGraveMarker.Enabled = true;
                }
            }
        }

        private void cmbFuneralCrypt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbFuneralCrypt.SelectedIndex == 0)
            {
                cmbFuneralGarveDigging.Items.Clear();
                cmbFuneralGarveDigging.Items.Add("Sima");
                cmbFuneralGarveDigging.Items.Add("Mélyitett");
            }
            else if (cmbFuneralCrypt.SelectedIndex == 1)
            {
                cmbFuneralGarveDigging.Items.Clear();
                cmbFuneralGarveDigging.Items.Add("Sima bővitett");
                cmbFuneralGarveDigging.Items.Add("Mélyitett bővitett");
            }
        }

        private void updateData()
        {
            var funeral = Forms.funeralData;
            var client = Forms.clientData;

            string sirko;
            if (cmbGraveOrCrypt.SelectedIndex == 0) sirko = "van sirkő"; else if (cmbGraveOrCrypt.SelectedIndex == 1) sirko = "kripta"; else sirko = "nincs sirkő";
            funeral.Method = cmbFuneralMethod.Text + ", " + sirko;

            funeral.Type = cmbFuneralType.Text;

            funeral.Date = (tbFuneralDateYear.Text + " " + cmbFuneralDateMonth.Text + " " + cmbFuneralDateDay.Text + "  " + cmbFuneralDateHour.Text + ":" + cmbFuneralDateMinute.Text);

            funeral.Catafalque = cmbFuneralCatafalque.Text;
            funeral.UrnCloth = cbFuneralUrnCloth.Checked;

            funeral.Grave = tbFuneralGrave.Text;

            funeral.GarveDigging = cmbFuneralGarveDigging.Text;
            funeral.GraveMarker = cmbFuneralGraveMarker.Text;
            funeral.Music = tbMusic.Text;

            if (cmbFuneralMethod.SelectedIndex == 0)
            {
                funeral.CoffinOrUrnType = cmbFuneralCoffinOrUrnType.Text;
                funeral.CryptOrCaissionType = "";
            }
            else if (cmbFuneralMethod.SelectedIndex == 2)
            {
                funeral.CoffinOrUrnType = cmbFuneralCoffinOrUrnType.Text;
                funeral.CryptOrCaissionType = cmbFuneralCaissionType.Text;
            }
            else if (cmbFuneralMethod.SelectedIndex == 1)
            {
                funeral.CoffinOrUrnType = cbKoporsoTipus.Text;
                funeral.CryptOrCaissionType = cmbFuneralCrypt.Text;
            }
            else
            {
                funeral.CoffinOrUrnType = "";
                funeral.CryptOrCaissionType = "";
            }

            funeral.isIDCardTaken = cbFuneralIsIDCardTaken.Checked;
            funeral.isAddressCardTaken = cbFuneralIsAddressCardTaken.Checked;
            funeral.isDeathCertificateTaken = cbFuneralIsDeathCertificateTaken.Checked;
            funeral.isBirthCertificateTaken = cbFuneralIsBirthCertificateTaken.Checked;
            funeral.isMarriageCertificateTaken = cbFuneralIsMarriageCertificateTaken.Checked;
            funeral.isSpouseDeathCertificateTaken = cbFuneralIsSpouseDeathCertificateTaken.Checked;

            funeral.isIDCardNeededByClient = cbFuneralIsIDCardNeededByClient.Checked;

            client.Reach = cmbClientReach.Text;
        }
    }
}