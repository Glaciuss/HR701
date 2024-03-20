
namespace CarService
{
    partial class frmDelHeader
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
            this.label2 = new System.Windows.Forms.Label();
            this.TXTHDR_DESC_DEL = new System.Windows.Forms.Label();
            this.TXTHDR_ID_DEL = new System.Windows.Forms.Label();
            this.btnConfirm = new CarService.Class.RJButton();
            this.btnCancel = new CarService.Class.RJButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "ลบหัวข้อ :";
            // 
            // TXTHDR_DESC_DEL
            // 
            this.TXTHDR_DESC_DEL.AutoSize = true;
            this.TXTHDR_DESC_DEL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTHDR_DESC_DEL.Location = new System.Drawing.Point(174, 43);
            this.TXTHDR_DESC_DEL.Name = "TXTHDR_DESC_DEL";
            this.TXTHDR_DESC_DEL.Size = new System.Drawing.Size(44, 21);
            this.TXTHDR_DESC_DEL.TabIndex = 117;
            this.TXTHDR_DESC_DEL.Text = "หัวข้อ";
            // 
            // TXTHDR_ID_DEL
            // 
            this.TXTHDR_ID_DEL.AutoSize = true;
            this.TXTHDR_ID_DEL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTHDR_ID_DEL.Location = new System.Drawing.Point(123, 43);
            this.TXTHDR_ID_DEL.Name = "TXTHDR_ID_DEL";
            this.TXTHDR_ID_DEL.Size = new System.Drawing.Size(44, 21);
            this.TXTHDR_ID_DEL.TabIndex = 118;
            this.TXTHDR_ID_DEL.Text = "หัวข้อ";
            this.TXTHDR_ID_DEL.Visible = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirm.BackColor = System.Drawing.Color.DarkGray;
            this.btnConfirm.BackgroundColor = System.Drawing.Color.DarkGray;
            this.btnConfirm.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnConfirm.BorderRadius = 20;
            this.btnConfirm.BorderSize = 0;
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.Black;
            this.btnConfirm.Location = new System.Drawing.Point(102, 97);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(84, 40);
            this.btnConfirm.TabIndex = 115;
            this.btnConfirm.Text = "ยืนยัน";
            this.btnConfirm.TextColor = System.Drawing.Color.Black;
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancel.BackgroundColor = System.Drawing.Color.DarkGray;
            this.btnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancel.BorderRadius = 20;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(192, 97);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 40);
            this.btnCancel.TabIndex = 116;
            this.btnCancel.Text = "ยกเลิก";
            this.btnCancel.TextColor = System.Drawing.Color.Black;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmDelHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.TXTHDR_ID_DEL);
            this.Controls.Add(this.TXTHDR_DESC_DEL);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDelHeader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ลบกลุ่มหัวข้อการวัดผล";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Class.RJButton btnCancel;
        private Class.RJButton btnConfirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TXTHDR_DESC_DEL;
        private System.Windows.Forms.Label TXTHDR_ID_DEL;
    }
}