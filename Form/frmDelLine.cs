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
    public partial class frmDelLine : Form
    {
        public string delh;
        public string delid;

        public frmDelLine()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            delh = TXTKPI_DESC_DEL.Text;
            delid = TXTKPI_ID_DEL.Text;
            this.DialogResult = DialogResult.OK;
        }

        public void delH(string dh, string id)
        {
            TXTKPI_DESC_DEL.Text = dh;
            TXTKPI_ID_DEL.Text = id;
        }
    }
}
