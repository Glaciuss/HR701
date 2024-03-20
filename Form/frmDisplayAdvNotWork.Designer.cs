namespace CarService
{
    partial class frmDisplayAdvNotWork
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grvEmpEarlyLeave = new System.Windows.Forms.DataGridView();
            this.pnlCompany = new System.Windows.Forms.Panel();
            this.lblShowOpenOrClose = new System.Windows.Forms.Label();
            this.cmbCompany = new System.Windows.Forms.ComboBox();
            this.colEarlyEmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEarlyWorkDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEarlyDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEarlyDayID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEarlyDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEarlyEmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEarlyEmpSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEarlyNickname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEarlyPositionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEarlyEmpIsComeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEarlyLeaveTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEarlyEmpIsComeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEarlyDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEarlyEmpCheck = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEarlyTransactionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvEmpEarlyLeave)).BeginInit();
            this.pnlCompany.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.grvEmpEarlyLeave);
            this.panel2.Controls.Add(this.pnlCompany);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(603, 226);
            this.panel2.TabIndex = 10;
            // 
            // grvEmpEarlyLeave
            // 
            this.grvEmpEarlyLeave.AllowUserToAddRows = false;
            this.grvEmpEarlyLeave.AllowUserToDeleteRows = false;
            this.grvEmpEarlyLeave.AllowUserToResizeRows = false;
            this.grvEmpEarlyLeave.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grvEmpEarlyLeave.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grvEmpEarlyLeave.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grvEmpEarlyLeave.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvEmpEarlyLeave.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grvEmpEarlyLeave.ColumnHeadersHeight = 25;
            this.grvEmpEarlyLeave.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEarlyEmpID,
            this.colEarlyWorkDate,
            this.colEarlyDate,
            this.colEarlyDayID,
            this.colEarlyDay,
            this.colEarlyEmpName,
            this.colEarlyEmpSurname,
            this.colEarlyNickname,
            this.colEarlyPositionName,
            this.colEarlyEmpIsComeID,
            this.colEarlyLeaveTypeName,
            this.colEarlyEmpIsComeName,
            this.colEarlyDetail,
            this.colEarlyEmpCheck,
            this.colEarlyTransactionDate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(127)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvEmpEarlyLeave.DefaultCellStyle = dataGridViewCellStyle2;
            this.grvEmpEarlyLeave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvEmpEarlyLeave.EnableHeadersVisualStyles = false;
            this.grvEmpEarlyLeave.Location = new System.Drawing.Point(0, 0);
            this.grvEmpEarlyLeave.Name = "grvEmpEarlyLeave";
            this.grvEmpEarlyLeave.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvEmpEarlyLeave.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grvEmpEarlyLeave.RowHeadersWidth = 70;
            this.grvEmpEarlyLeave.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grvEmpEarlyLeave.Size = new System.Drawing.Size(599, 222);
            this.grvEmpEarlyLeave.TabIndex = 34;
            this.grvEmpEarlyLeave.TabStop = false;
            this.grvEmpEarlyLeave.Sorted += new System.EventHandler(this.grvEmpEarlyLeave_Sorted);
            // 
            // pnlCompany
            // 
            this.pnlCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.pnlCompany.Controls.Add(this.lblShowOpenOrClose);
            this.pnlCompany.Controls.Add(this.cmbCompany);
            this.pnlCompany.Location = new System.Drawing.Point(0, 0);
            this.pnlCompany.Name = "pnlCompany";
            this.pnlCompany.Size = new System.Drawing.Size(905, 31);
            this.pnlCompany.TabIndex = 141;
            // 
            // lblShowOpenOrClose
            // 
            this.lblShowOpenOrClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblShowOpenOrClose.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowOpenOrClose.ForeColor = System.Drawing.Color.Red;
            this.lblShowOpenOrClose.Location = new System.Drawing.Point(331, 1);
            this.lblShowOpenOrClose.Name = "lblShowOpenOrClose";
            this.lblShowOpenOrClose.Size = new System.Drawing.Size(223, 29);
            this.lblShowOpenOrClose.TabIndex = 25;
            this.lblShowOpenOrClose.Text = "Open or Close";
            this.lblShowOpenOrClose.Visible = false;
            // 
            // cmbCompany
            // 
            this.cmbCompany.BackColor = System.Drawing.Color.White;
            this.cmbCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCompany.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCompany.FormattingEnabled = true;
            this.cmbCompany.Location = new System.Drawing.Point(1, 1);
            this.cmbCompany.Name = "cmbCompany";
            this.cmbCompany.Size = new System.Drawing.Size(324, 29);
            this.cmbCompany.TabIndex = 6;
            this.cmbCompany.SelectedIndexChanged += new System.EventHandler(this.cmbCompany_SelectedIndexChanged);
            // 
            // colEarlyEmpID
            // 
            this.colEarlyEmpID.HeaderText = "EmployeeID";
            this.colEarlyEmpID.Name = "colEarlyEmpID";
            this.colEarlyEmpID.ReadOnly = true;
            this.colEarlyEmpID.Visible = false;
            this.colEarlyEmpID.Width = 101;
            // 
            // colEarlyWorkDate
            // 
            this.colEarlyWorkDate.HeaderText = "WorkDate";
            this.colEarlyWorkDate.Name = "colEarlyWorkDate";
            this.colEarlyWorkDate.ReadOnly = true;
            this.colEarlyWorkDate.Visible = false;
            this.colEarlyWorkDate.Width = 89;
            // 
            // colEarlyDate
            // 
            this.colEarlyDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colEarlyDate.FillWeight = 70F;
            this.colEarlyDate.HeaderText = "วันที่";
            this.colEarlyDate.MinimumWidth = 70;
            this.colEarlyDate.Name = "colEarlyDate";
            this.colEarlyDate.ReadOnly = true;
            this.colEarlyDate.Width = 70;
            // 
            // colEarlyDayID
            // 
            this.colEarlyDayID.HeaderText = "DayID";
            this.colEarlyDayID.Name = "colEarlyDayID";
            this.colEarlyDayID.ReadOnly = true;
            this.colEarlyDayID.Visible = false;
            this.colEarlyDayID.Width = 66;
            // 
            // colEarlyDay
            // 
            this.colEarlyDay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colEarlyDay.HeaderText = "วัน";
            this.colEarlyDay.MinimumWidth = 70;
            this.colEarlyDay.Name = "colEarlyDay";
            this.colEarlyDay.ReadOnly = true;
            this.colEarlyDay.Width = 70;
            // 
            // colEarlyEmpName
            // 
            this.colEarlyEmpName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEarlyEmpName.FillWeight = 80F;
            this.colEarlyEmpName.HeaderText = "ชื่อ";
            this.colEarlyEmpName.MinimumWidth = 70;
            this.colEarlyEmpName.Name = "colEarlyEmpName";
            this.colEarlyEmpName.ReadOnly = true;
            // 
            // colEarlyEmpSurname
            // 
            this.colEarlyEmpSurname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEarlyEmpSurname.FillWeight = 90F;
            this.colEarlyEmpSurname.HeaderText = "สกุล";
            this.colEarlyEmpSurname.MinimumWidth = 80;
            this.colEarlyEmpSurname.Name = "colEarlyEmpSurname";
            this.colEarlyEmpSurname.ReadOnly = true;
            // 
            // colEarlyNickname
            // 
            this.colEarlyNickname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colEarlyNickname.HeaderText = "ชื่อเล่น";
            this.colEarlyNickname.MinimumWidth = 60;
            this.colEarlyNickname.Name = "colEarlyNickname";
            this.colEarlyNickname.ReadOnly = true;
            this.colEarlyNickname.Width = 65;
            // 
            // colEarlyPositionName
            // 
            this.colEarlyPositionName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colEarlyPositionName.FillWeight = 90F;
            this.colEarlyPositionName.HeaderText = "ตำแหน่ง";
            this.colEarlyPositionName.Name = "colEarlyPositionName";
            this.colEarlyPositionName.ReadOnly = true;
            this.colEarlyPositionName.Width = 72;
            // 
            // colEarlyEmpIsComeID
            // 
            this.colEarlyEmpIsComeID.HeaderText = "EmpIsComeID";
            this.colEarlyEmpIsComeID.Name = "colEarlyEmpIsComeID";
            this.colEarlyEmpIsComeID.ReadOnly = true;
            this.colEarlyEmpIsComeID.Visible = false;
            this.colEarlyEmpIsComeID.Width = 113;
            // 
            // colEarlyLeaveTypeName
            // 
            this.colEarlyLeaveTypeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colEarlyLeaveTypeName.FillWeight = 80F;
            this.colEarlyLeaveTypeName.HeaderText = "สถานะ";
            this.colEarlyLeaveTypeName.MinimumWidth = 60;
            this.colEarlyLeaveTypeName.Name = "colEarlyLeaveTypeName";
            this.colEarlyLeaveTypeName.ReadOnly = true;
            this.colEarlyLeaveTypeName.Width = 64;
            // 
            // colEarlyEmpIsComeName
            // 
            this.colEarlyEmpIsComeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colEarlyEmpIsComeName.HeaderText = "ประเภท";
            this.colEarlyEmpIsComeName.Name = "colEarlyEmpIsComeName";
            this.colEarlyEmpIsComeName.ReadOnly = true;
            this.colEarlyEmpIsComeName.Width = 68;
            // 
            // colEarlyDetail
            // 
            this.colEarlyDetail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colEarlyDetail.FillWeight = 170F;
            this.colEarlyDetail.HeaderText = "หมายเหตุ";
            this.colEarlyDetail.MinimumWidth = 100;
            this.colEarlyDetail.Name = "colEarlyDetail";
            this.colEarlyDetail.ReadOnly = true;
            // 
            // colEarlyEmpCheck
            // 
            this.colEarlyEmpCheck.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colEarlyEmpCheck.HeaderText = "ผู้บันทึกข้อมูล";
            this.colEarlyEmpCheck.MinimumWidth = 80;
            this.colEarlyEmpCheck.Name = "colEarlyEmpCheck";
            this.colEarlyEmpCheck.ReadOnly = true;
            this.colEarlyEmpCheck.Width = 99;
            // 
            // colEarlyTransactionDate
            // 
            this.colEarlyTransactionDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colEarlyTransactionDate.FillWeight = 90F;
            this.colEarlyTransactionDate.HeaderText = "วันที่บันทึก";
            this.colEarlyTransactionDate.MinimumWidth = 60;
            this.colEarlyTransactionDate.Name = "colEarlyTransactionDate";
            this.colEarlyTransactionDate.ReadOnly = true;
            this.colEarlyTransactionDate.Width = 84;
            // 
            // frmDisplayAdvNotWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(603, 226);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDisplayAdvNotWork";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.frmDisplayAdvNotWork_Load);
            this.Shown += new System.EventHandler(this.frmDisplayAdvNotWork_Shown);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvEmpEarlyLeave)).EndInit();
            this.pnlCompany.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView grvEmpEarlyLeave;
        private System.Windows.Forms.Panel pnlCompany;
        private System.Windows.Forms.Label lblShowOpenOrClose;
        public System.Windows.Forms.ComboBox cmbCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEarlyEmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEarlyWorkDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEarlyDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEarlyDayID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEarlyDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEarlyEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEarlyEmpSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEarlyNickname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEarlyPositionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEarlyEmpIsComeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEarlyLeaveTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEarlyEmpIsComeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEarlyDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEarlyEmpCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEarlyTransactionDate;
    }
}