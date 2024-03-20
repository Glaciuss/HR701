using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarService
{
    public partial class frmEditHeader : Form
    {
        public string newHeader;
        public string newWeight;
        public string newID;

        private string oldW;
        private string oldSumW;

        public frmEditHeader()
        {
            InitializeComponent();
            NMRWEIGHT.TextChanged += new EventHandler(NMRWEIGHT_TextChanged);
        }

        private void NMRWEIGHT_TextChanged(object sender, EventArgs e)
        {
            NMRWEIGHT.Select(1, 0);
            WChange();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string w = TXT_SumWLine.Text;
            Match match = Regex.Match(w, @"\d+.\d+");
            decimal sumW = decimal.Parse(match.Value);
            if (sumW <= 100)
            {
                newHeader = TXTHDR_DESC_NEW.Text;
                newWeight = (decimal.Parse(NMRWEIGHT.Text) / 100).ToString();
                newID = TXTHDR_ID_NEW.Text;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(sumW + "% > 100%", "error");
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public void editH(string dh, string dw, string id, string sWL)
        {
            TXTHDR_DESC_NEW.Text = dh;
            NMRWEIGHT.Text = dw;
            TXTHDR_ID_NEW.Text = id;
            TXT_SumWLine.Text = sWL;

            oldW = dw;
            oldSumW = sWL;
        }

        private void WChange()
        {
            if (oldW != null && oldSumW != null)
            {
                decimal diffW = decimal.Parse(NMRWEIGHT.Value.ToString()) - decimal.Parse(oldW);
                Match match = Regex.Match(oldSumW, @"\d+.\d+");
                decimal sumW = decimal.Parse(match.Value) + diffW;
                TXT_SumWLine.Text = sumW.ToString("N1") + "%";
            }
        }

        private void btnWChange_Click(object sender, EventArgs e)
        {
            WChange();
        }
    }
}
