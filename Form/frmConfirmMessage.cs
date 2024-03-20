using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CarService
{
    public partial class frmConfirmMessage : Form
    {
        
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
      (
          int nLeftRect,     // x-coordinate of upper-left corner
          int nTopRect,      // y-coordinate of upper-left corner
          int nRightRect,    // x-coordinate of lower-right corner
          int nBottomRect,   // y-coordinate of lower-right corner
          int nWidthEllipse, // width of ellipse
          int nHeightEllipse // height of ellipse
      );

        public string _txt_type = "";
        public string _confirm_msg = "";
        public frmConfirmMessage()
        {
            InitializeComponent();
            CustomizeTheme();
        }

        void CustomizeTheme()
        {
            this.pnlTop.BackColor = SbuysColors.Main;
            this.pnlLeft.BackColor = SbuysColors.Main;
            this.pnlRight.BackColor = SbuysColors.Main;
            this.pnlBottom.BackColor = SbuysColors.Main;
            this.LBL_CONFIRM_MESSAGE.BackColor = Color.White;
            this.LBL_CONFIRM_MESSAGE.ForeColor = SbuysColors.Main;
          
            BTN_DONE.BackColor = SbuysColors.BG_Main;
            BTN_DONE.ForeColor = SbuysColors.Text_BG_Main;
            BTN_DONE.FlatAppearance.BorderColor = SbuysColors.BG_Main;

            btnCancel.BackColor = SbuysColors.BG_Main;
            btnCancel.ForeColor = SbuysColors.Text_BG_Main;
            btnCancel.FlatAppearance.BorderColor = SbuysColors.BG_Main;

            btnOK.BackColor = SbuysColors.BG_Main;
            btnOK.ForeColor = SbuysColors.Text_BG_Main;
            btnOK.FlatAppearance.BorderColor = SbuysColors.BG_Main;
        }

        void confirm_theme()
        {
            this.LBL_CONFIRM_MESSAGE.ForeColor = SbuysColors.Main;
            this.LBL_CONFIRM_MESSAGE.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           
            this.pnlTop.BackColor = Color.FromArgb(43, 61, 81);
            this.pnlLeft.BackColor = Color.FromArgb(43, 61, 81);
            this.pnlRight.BackColor = Color.FromArgb(43, 61, 81);
            this.pnlBottom.BackColor = Color.FromArgb(43, 61, 81);

            this.pnlBottom.Visible = true;
            this.pnlOK.Visible = false;
        }
        void warn_theme()
        {
            this.LBL_CONFIRM_MESSAGE.ForeColor = SbuysColors.Main;
            this.LBL_CONFIRM_MESSAGE.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTop.BackColor = Color.FromArgb(195, 56, 37);
            this.pnlLeft.BackColor = Color.FromArgb(195, 56, 37);
            this.pnlRight.BackColor = Color.FromArgb(195, 56, 37);
            //this.pnlBottom.BackColor = Color.FromArgb(195, 56, 37);
            this.pnlOK.BackColor = Color.FromArgb(195, 56, 37);
        }
        void detail_theme()
        {
            this.LBL_CONFIRM_MESSAGE.ForeColor = SbuysColors.Main;
            this.LBL_CONFIRM_MESSAGE.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
        private void frmConfirmMessage_Load(object sender, EventArgs e)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width + 1, Height + 1, 20, 20));
            if (_txt_type == "confirm")
            {
                confirm_theme();
            }
            else 
            {
                if (_txt_type == "warn")
                {
                    warn_theme();
                }
                else if (_txt_type == "detail")
                {
                    detail_theme();
                }               
                pnlBottom.Visible = false;
                pnlOK.Visible = true;
            }
            if (_confirm_msg != "")
            {
                LBL_CONFIRM_MESSAGE.Text = _confirm_msg;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void pnlCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
