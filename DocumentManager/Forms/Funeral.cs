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
        }

        private void Funeral_Load(object sender, EventArgs e)
        {
            funeralData = Forms.funeralData;

            cmbFuneralMethod.DataBindings.Add("Text", Forms.funeralData, nameof(FuneralData.Method));
            cmbFuneralType.DataBindings.Add("Text", Forms.funeralData, nameof(FuneralData.Type));
            //tbDate.DataBindings.Add("Text", Forms.funeralData, nameof(FuneralData.Date));
            cmbFuneralCatafalque.DataBindings.Add("Text", Forms.funeralData, nameof(FuneralData.Catafalque));
            cmbFuneralCoffinOrUrnType.DataBindings.Add("Text", Forms.funeralData, nameof(FuneralData.CoffinOrUrnType));
            cmbFuneralCryptOrCaissionType.DataBindings.Add("Text", Forms.funeralData, nameof(FuneralData.CryptOrCaissionType));
            cbFuneralUrnCloth.DataBindings.Add("Checked", Forms.funeralData, nameof(FuneralData.UrnCloth));
            tbFuneralGrave.DataBindings.Add("Text", Forms.funeralData, nameof(FuneralData.Grave));
            cmbFuneralGarveDigging.DataBindings.Add("Text", Forms.funeralData, nameof(FuneralData.GarveDigging));
            cmbFuneralGraveMarker.DataBindings.Add("Text", Forms.funeralData, nameof(FuneralData.GraveMarker));
            tbMusic.DataBindings.Add("Text", Forms.funeralData, nameof(FuneralData.Music));
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

        private void btnNext_Click(object sender, EventArgs e)
        {

            Forms.PrintForm.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            Forms.ClientForm.Show();
            this.Hide();
        }
    }
}