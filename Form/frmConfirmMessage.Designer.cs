namespace CarService
{
    partial class frmConfirmMessage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnCancel = new CarService.Class.RJButton();
            this.btnOK = new CarService.Class.RJButton();
            this.pnlDisplayMsg = new System.Windows.Forms.Panel();
            this.LBL_CONFIRM_MESSAGE = new System.Windows.Forms.Label();
            this.pnlOK = new System.Windows.Forms.Panel();
            this.BTN_DONE = new CarService.Class.RJButton();
            this.pnlBottom.SuspendLayout();
            this.pnlDisplayMsg.SuspendLayout();
            this.pnlOK.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(2, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(559, 5);
            this.pnlTop.TabIndex = 113;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(2, 243);
            this.pnlLeft.TabIndex = 114;
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(561, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(2, 243);
            this.pnlRight.TabIndex = 115;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.pnlBottom.Controls.Add(this.btnCancel);
            this.pnlBottom.Controls.Add(this.btnOK);
            this.pnlBottom.Location = new System.Drawing.Point(2, 198);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(559, 45);
            this.pnlBottom.TabIndex = 116;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.BorderRadius = 20;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.btnCancel.Location = new System.Drawing.Point(279, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 36);
            this.btnCancel.TabIndex = 114;
            this.btnCancel.Text = "ยกเลิก";
            this.btnCancel.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.pnlCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnOK.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.btnOK.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnOK.BorderRadius = 20;
            this.btnOK.BorderSize = 0;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.btnOK.Location = new System.Drawing.Point(154, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(119, 36);
            this.btnOK.TabIndex = 113;
            this.btnOK.Text = "ตกลง";
            this.btnOK.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // pnlDisplayMsg
            // 
            this.pnlDisplayMsg.Controls.Add(this.LBL_CONFIRM_MESSAGE);
            this.pnlDisplayMsg.Controls.Add(this.pnlOK);
            this.pnlDisplayMsg.Controls.Add(this.pnlBottom);
            this.pnlDisplayMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDisplayMsg.Location = new System.Drawing.Point(0, 0);
            this.pnlDisplayMsg.Name = "pnlDisplayMsg";
            this.pnlDisplayMsg.Size = new System.Drawing.Size(563, 243);
            this.pnlDisplayMsg.TabIndex = 117;
            // 
            // LBL_CONFIRM_MESSAGE
            // 
            this.LBL_CONFIRM_MESSAGE.BackColor = System.Drawing.Color.White;
            this.LBL_CONFIRM_MESSAGE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LBL_CONFIRM_MESSAGE.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_CONFIRM_MESSAGE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.LBL_CONFIRM_MESSAGE.Location = new System.Drawing.Point(2, 5);
            this.LBL_CONFIRM_MESSAGE.Name = "LBL_CONFIRM_MESSAGE";
            this.LBL_CONFIRM_MESSAGE.Size = new System.Drawing.Size(559, 192);
            this.LBL_CONFIRM_MESSAGE.TabIndex = 0;
            this.LBL_CONFIRM_MESSAGE.Text = "Confirm Message";
            this.LBL_CONFIRM_MESSAGE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlOK
            // 
            this.pnlOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.pnlOK.Controls.Add(this.BTN_DONE);
            this.pnlOK.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlOK.Location = new System.Drawing.Point(0, 198);
            this.pnlOK.Name = "pnlOK";
            this.pnlOK.Size = new System.Drawing.Size(563, 45);
            this.pnlOK.TabIndex = 117;
            // 
            // BTN_DONE
            // 
            this.BTN_DONE.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BTN_DONE.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.BTN_DONE.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.BTN_DONE.BorderRadius = 20;
            this.BTN_DONE.BorderSize = 0;
            this.BTN_DONE.FlatAppearance.BorderSize = 0;
            this.BTN_DONE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_DONE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DONE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.BTN_DONE.Location = new System.Drawing.Point(222, 4);
            this.BTN_DONE.Name = "BTN_DONE";
            this.BTN_DONE.Size = new System.Drawing.Size(119, 36);
            this.BTN_DONE.TabIndex = 113;
            this.BTN_DONE.Text = "ตกลง";
            this.BTN_DONE.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.BTN_DONE.UseVisualStyleBackColor = false;
            this.BTN_DONE.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // frmConfirmMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(563, 243);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlDisplayMsg);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmConfirmMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmConfirmMessage_Load);
            this.pnlBottom.ResumeLayout(false);
            this.pnlDisplayMsg.ResumeLayout(false);
            this.pnlOK.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlDisplayMsg;
        private System.Windows.Forms.Label LBL_CONFIRM_MESSAGE;
        private System.Windows.Forms.Panel pnlOK;
        private Class.RJButton BTN_DONE;
        private Class.RJButton btnCancel;
        private Class.RJButton btnOK;
    }
}