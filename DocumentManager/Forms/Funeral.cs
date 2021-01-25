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
using DocumentManager.Data;

namespace DocumentManager
{
    public partial class Funeral : FormBase
    {
        FuneralData funeralData;
        public Funeral()
        {
            InitializeComponent();
            Forms.FuneralForm = this;

            ComboBoxItemFiller(cmbFuneralDateMonth, DateTime.Now.Month, 12);
            ComboBoxItemFiller(cmbFuneralDateDay, 1, 31);
        }

        private void Funeral_Load(object sender, EventArgs e)
        {
            List<string> coffinTypes = readFile(Constants.pathCoffinTypes);
            List<string> urnTypes = readFile(Constants.pathUrnTypes);

            funeralData = Forms.funeralData;

            funeralData.DateYear = DateTime.Now.Year.ToString();

            cmbFuneralMethod.DataBindings.Add("Text", Forms.funeralData, nameof(FuneralData.Method));
            cmbFuneralType.DataBindings.Add("Text", Forms.funeralData, nameof(FuneralData.Type));
            tbFuneralDateYear.DataBindings.Add("Text", Forms.funeralData, nameof(FuneralData.DateYear));
            cmbFuneralDateMonth.DataBindings.Add("Text", Forms.funeralData, nameof(FuneralData.DateYear));
            cmbFuneralDateDay.DataBindings.Add("Text", Forms.funeralData, nameof(FuneralData.DateYear));
            cmbFuneralGraveOrCrypt.DataBindings.Add("Text", Forms.funeralData, nameof(FuneralData.GraveOrCrypt));
            cmbFuneralCatafalque.DataBindings.Add("Text", Forms.funeralData, nameof(FuneralData.Catafalque));
            cmbFuneralCoffinOrUrnType.DataBindings.Add("Text", Forms.funeralData, nameof(FuneralData.CoffinOrUrnType));
            cmbFuneralCryptOrCaissionType.DataBindings.Add("Text", Forms.funeralData, nameof(FuneralData.CryptOrCaissionType));
            cbFuneralUrnCloth.DataBindings.Add("Checked", Forms.funeralData, nameof(FuneralData.UrnCloth));
            tbFuneralGrave.DataBindings.Add("Text", Forms.funeralData, nameof(FuneralData.Grave));
            cmbFuneralGarveDigging.DataBindings.Add("Text", Forms.funeralData, nameof(FuneralData.GarveDigging));
            cmbFuneralGraveMarker.DataBindings.Add("Text", Forms.funeralData, nameof(FuneralData.GraveMarker));
            tbMusic.DataBindings.Add("Text", Forms.funeralData, nameof(FuneralData.Music));
            tbClientReach.DataBindings.Add("Text", Forms.funeralData, nameof(FuneralData.Reach));
            cbFuneralIsIDCardTaken.DataBindings.Add("Checked", Forms.funeralData, nameof(FuneralData.IsIDCardTaken));
            cbFuneralIsAddressCardTaken.DataBindings.Add("Checked", Forms.funeralData, nameof(FuneralData.IsAddressCardTaken));
            cbFuneralIsDeathCertificateTaken.DataBindings.Add("Checked", Forms.funeralData, nameof(FuneralData.IsDeathCertificateTaken));
            cbFuneralIsBirthCertificateTaken.DataBindings.Add("Checked", Forms.funeralData, nameof(FuneralData.IsBirthCertificateTaken));
            cbFuneralIsMarriageCertificateTaken.DataBindings.Add("Checked", Forms.funeralData, nameof(FuneralData.IsMarriageCertificateTaken));
            cbFuneralIsSpouseDeathCertificateTaken.DataBindings.Add("Checked", Forms.funeralData, nameof(FuneralData.IsSpouseDeathCertificateTaken));
            cbFuneralIsIDCardNeededByClient.DataBindings.Add("Checked", Forms.funeralData, nameof(FuneralData.IsIDCardNeededByClient));
        }

        private void Funeral_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClosingDialog(e);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Forms.ClientForm.Show();
            this.Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Forms.PrintForm.Show();
            this.Hide();
        }

        private void cmbFuneralMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbFuneralType.Items.Clear();
            cmbFuneralGraveOrCrypt.Items.Clear();
            tbFuneralGrave.Clear();
            cmbFuneralCatafalque.Items.Clear();
            tbMusic.Clear();
            cmbFuneralCoffinOrUrnType.Items.Clear();
            cbFuneralUrnCloth.Checked = false;
            cmbFuneralCryptOrCaissionType.Items.Clear();
            cmbFuneralGarveDigging.Items.Clear();
            cmbFuneralGraveMarker.Items.Clear();

            if (cmbFuneralMethod.SelectedIndex == 0)
            {
                cmbFuneralCoffinOrUrnType.Items.AddRange(readFile(Constants.pathUrnTypes).ToArray());
            }
            else
            {
                cmbFuneralType.Items.AddRange(Constants.funeralTypes.ToArray());
                cmbFuneralCatafalque.Items.AddRange(Constants.funeralCatafalques.ToArray());

                if (cmbFuneralMethod.SelectedIndex == 1)
                {
                    cmbFuneralCoffinOrUrnType.Items.AddRange(readFile(Constants.pathUrnTypes).ToArray());
                    cmbFuneralGraveOrCrypt.Items.AddRange(Constants.funeralGraveOrCrypt.ToArray());
                }
                else
                {
                    cmbFuneralCoffinOrUrnType.Items.AddRange(readFile(Constants.pathCoffinTypes).ToArray());
                    cmbFuneralGraveOrCrypt.Items.AddRange(Constants.funeralGraveOrCrypt.Take(3).ToArray());
                }
            }
        }

        private void cmbFuneralGraveOrCrypt_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbFuneralCryptOrCaissionType.Items.Clear();
            cmbFuneralGarveDigging.Items.Clear();
            cmbFuneralGraveMarker.Items.Clear();

            if (cmbFuneralMethod.SelectedIndex == 1)
            {
                if (cmbFuneralGraveOrCrypt.SelectedIndex == 0 || cmbFuneralGraveOrCrypt.SelectedIndex == 1)
                {
                    cmbFuneralCryptOrCaissionType.Items.AddRange(Constants.funeralCryptOrCassion.Skip(2).ToArray());
                    cmbFuneralGraveMarker.Items.AddRange(Constants.funeralGraveMarkers.ToArray());
                }
            }
            else if (cmbFuneralMethod.SelectedIndex == 2)
            {
                if (cmbFuneralGraveOrCrypt.SelectedIndex == 0 || cmbFuneralGraveOrCrypt.SelectedIndex == 1)
                {
                    cmbFuneralCryptOrCaissionType.Items.AddRange(Constants.funeralCryptOrCassion.Take(2).ToArray());
                    cmbFuneralGraveMarker.Items.AddRange(Constants.funeralGraveMarkers.ToArray());
                }
            }
        }

        private void cmbFuneralCryptOrCaissionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbFuneralGarveDigging.Items.Clear();
            cmbFuneralGraveMarker.Items.Clear();

            if (cmbFuneralMethod.SelectedIndex == 2 && cmbFuneralCryptOrCaissionType.SelectedIndex == 0)
            {
                cmbFuneralGarveDigging.Items.AddRange(Constants.funeralGraveDigging.Take(2).ToArray());
            }
            else if (cmbFuneralMethod.SelectedIndex == 2 && cmbFuneralCryptOrCaissionType.SelectedIndex == 1)
            {
                cmbFuneralGarveDigging.Items.AddRange(Constants.funeralGraveDigging.Skip(2).ToArray());
            }
        }
    }
}