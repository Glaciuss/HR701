using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarService
{
    public partial class frmDelHeader : Form
    {
        public string delh;
        public string delid;

        public frmDelHeader()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            delh = TXTHDR_DESC_DEL.Text;
            delid = TXTHDR_ID_DEL.Text;
            this.DialogResult = DialogResult.OK;
        }

        public void delH(string dh, string id)
        {
            TXTHDR_DESC_DEL.Text = dh;
            TXTHDR_ID_DEL.Text = id;
        }
    }
}
