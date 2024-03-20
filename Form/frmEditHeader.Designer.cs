
namespace CarService
{
    partial class frmEditHeader
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTHDR_DESC_NEW = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NMRWEIGHT = new System.Windows.Forms.NumericUpDown();
            this.TXTHDR_ID_NEW = new System.Windows.Forms.Label();
            this.TXT_SumWLine = new System.Windows.Forms.TextBox();
            this.btnCancel = new CarService.Class.RJButton();
            this.btnSave = new CarService.Class.RJButton();
            this.btnWChange = new CarService.Class.RJButton();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NMRWEIGHT)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.panel3.Controls.Add(this.btnWChange);
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 157);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(384, 54);
            this.panel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "แก้ไขหัวข้อ";
            // 
            // TXTHDR_DESC_NEW
            // 
            this.TXTHDR_DESC_NEW.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTHDR_DESC_NEW.Location = new System.Drawing.Point(138, 40);
            this.TXTHDR_DESC_NEW.Name = "TXTHDR_DESC_NEW";
            this.TXTHDR_DESC_NEW.Size = new System.Drawing.Size(172, 29);
            this.TXTHDR_DESC_NEW.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "น้ำหนัก";
            // 
            // NMRWEIGHT
            // 
            this.NMRWEIGHT.DecimalPlaces = 1;
            this.NMRWEIGHT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NMRWEIGHT.Location = new System.Drawing.Point(138, 103);
            this.NMRWEIGHT.Name = "NMRWEIGHT";
            this.NMRWEIGHT.Size = new System.Drawing.Size(76, 29);
            this.NMRWEIGHT.TabIndex = 9;
            // 
            // TXTHDR_ID_NEW
            // 
            this.TXTHDR_ID_NEW.AutoSize = true;
            this.TXTHDR_ID_NEW.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTHDR_ID_NEW.Location = new System.Drawing.Point(316, 43);
            this.TXTHDR_ID_NEW.Name = "TXTHDR_ID_NEW";
            this.TXTHDR_ID_NEW.Size = new System.Drawing.Size(25, 21);
            this.TXTHDR_ID_NEW.TabIndex = 119;
            this.TXTHDR_ID_NEW.Text = "ID";
            this.TXTHDR_ID_NEW.Visible = false;
            // 
            // TXT_SumWLine
            // 
            this.TXT_SumWLine.Enabled = false;
            this.TXT_SumWLine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_SumWLine.Location = new System.Drawing.Point(220, 103);
            this.TXT_SumWLine.Name = "TXT_SumWLine";
            this.TXT_SumWLine.Size = new System.Drawing.Size(64, 29);
            this.TXT_SumWLine.TabIndex = 120;
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
            this.btnCancel.Location = new System.Drawing.Point(192, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 40);
            this.btnCancel.TabIndex = 116;
            this.btnCancel.Text = "ยกเลิก";
            this.btnCancel.TextColor = System.Drawing.Color.Black;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.DarkGray;
            this.btnSave.BackgroundColor = System.Drawing.Color.DarkGray;
            this.btnSave.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSave.BorderRadius = 20;
            this.btnSave.BorderSize = 0;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(102, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 40);
            this.btnSave.TabIndex = 115;
            this.btnSave.Text = "บันทึก";
            this.btnSave.TextColor = System.Drawing.Color.Black;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnWChange
            // 
            this.btnWChange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnWChange.BackColor = System.Drawing.Color.DarkGray;
            this.btnWChange.BackgroundColor = System.Drawing.Color.DarkGray;
            this.btnWChange.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnWChange.BorderRadius = 20;
            this.btnWChange.BorderSize = 0;
            this.btnWChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWChange.FlatAppearance.BorderSize = 0;
            this.btnWChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWChange.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWChange.ForeColor = System.Drawing.Color.Black;
            this.btnWChange.Location = new System.Drawing.Point(288, 6);
            this.btnWChange.Name = "btnWChange";
            this.btnWChange.Size = new System.Drawing.Size(84, 40);
            this.btnWChange.TabIndex = 121;
            this.btnWChange.Text = "WC";
            this.btnWChange.TextColor = System.Drawing.Color.Black;
            this.btnWChange.UseVisualStyleBackColor = false;
            this.btnWChange.Visible = false;
            this.btnWChange.Click += new System.EventHandler(this.btnWChange_Click);
            // 
            // frmEditHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.TXT_SumWLine);
            this.Controls.Add(this.TXTHDR_ID_NEW);
            this.Controls.Add(this.NMRWEIGHT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTHDR_DESC_NEW);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditHeader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "แก้ไขกลุ่มหัวข้อการวัดผล";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NMRWEIGHT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private Class.RJButton btnCancel;
        private Class.RJButton btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTHDR_DESC_NEW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NMRWEIGHT;
        private System.Windows.Forms.Label TXTHDR_ID_NEW;
        private System.Windows.Forms.TextBox TXT_SumWLine;
        private Class.RJButton btnWChange;
    }
}