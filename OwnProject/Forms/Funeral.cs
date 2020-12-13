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

        private void updateData()
        {
        }
    }
}