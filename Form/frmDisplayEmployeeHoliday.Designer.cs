namespace CarService
{
    partial class frmDisplayEmployeeHoliday
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
            this.grvEmployeeHoliday = new System.Windows.Forms.DataGridView();
            this.colEmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNickname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPositionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpHolidayDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grvEmpHolidayAllBranch = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvEmployeeHoliday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvEmpHolidayAllBranch)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grvEmployeeHoliday);
            this.panel2.Controls.Add(this.grvEmpHolidayAllBranch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(856, 571);
            this.panel2.TabIndex = 11;
            // 
            // grvEmployeeHoliday
            // 
            this.grvEmployeeHoliday.AllowUserToAddRows = false;
            this.grvEmployeeHoliday.AllowUserToDeleteRows = false;
            this.grvEmployeeHoliday.AllowUserToResizeRows = false;
            this.grvEmployeeHoliday.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grvEmployeeHoliday.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grvEmployeeHoliday.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvEmployeeHoliday.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grvEmployeeHoliday.ColumnHeadersHeight = 25;
            this.grvEmployeeHoliday.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEmpName,
            this.colSurname,
            this.colNickname,
            this.colPositionName,
            this.colEmpHolidayDetail});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(127)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvEmployeeHoliday.DefaultCellStyle = dataGridViewCellStyle2;
            this.grvEmployeeHoliday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvEmployeeHoliday.EnableHeadersVisualStyles = false;
            this.grvEmployeeHoliday.Location = new System.Drawing.Point(0, 0);
            this.grvEmployeeHoliday.Name = "grvEmployeeHoliday";
            this.grvEmployeeHoliday.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvEmployeeHoliday.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grvEmployeeHoliday.RowHeadersWidth = 70;
            this.grvEmployeeHoliday.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grvEmployeeHoliday.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvEmployeeHoliday.Size = new System.Drawing.Size(856, 571);
            this.grvEmployeeHoliday.TabIndex = 1;
            this.grvEmployeeHoliday.TabStop = false;
            // 
            // colEmpName
            // 
            this.colEmpName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEmpName.FillWeight = 80F;
            this.colEmpName.HeaderText = "ชื่อ";
            this.colEmpName.MinimumWidth = 70;
            this.colEmpName.Name = "colEmpName";
            this.colEmpName.ReadOnly = true;
            // 
            // colSurname
            // 
            this.colSurname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSurname.FillWeight = 90F;
            this.colSurname.HeaderText = "สกุล";
            this.colSurname.MinimumWidth = 80;
            this.colSurname.Name = "colSurname";
            this.colSurname.ReadOnly = true;
            // 
            // colNickname
            // 
            this.colNickname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colNickname.HeaderText = "ชื่อเล่น";
            this.colNickname.MinimumWidth = 70;
            this.colNickname.Name = "colNickname";
            this.colNickname.ReadOnly = true;
            this.colNickname.Width = 70;
            // 
            // colPositionName
            // 
            this.colPositionName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPositionName.FillWeight = 90F;
            this.colPositionName.HeaderText = "ตำแหน่ง";
            this.colPositionName.Name = "colPositionName";
            this.colPositionName.ReadOnly = true;
            // 
            // colEmpHolidayDetail
            // 
            this.colEmpHolidayDetail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEmpHolidayDetail.FillWeight = 170F;
            this.colEmpHolidayDetail.HeaderText = "หมายเหตุ";
            this.colEmpHolidayDetail.MinimumWidth = 60;
            this.colEmpHolidayDetail.Name = "colEmpHolidayDetail";
            this.colEmpHolidayDetail.ReadOnly = true;
            // 
            // grvEmpHolidayAllBranch
            // 
            this.grvEmpHolidayAllBranch.AllowUserToAddRows = false;
            this.grvEmpHolidayAllBranch.AllowUserToDeleteRows = false;
            this.grvEmpHolidayAllBranch.AllowUserToOrderColumns = true;
            this.grvEmpHolidayAllBranch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvEmpHolidayAllBranch.Location = new System.Drawing.Point(604, 154);
            this.grvEmpHolidayAllBranch.Name = "grvEmpHolidayAllBranch";
            this.grvEmpHolidayAllBranch.Size = new System.Drawing.Size(240, 150);
            this.grvEmpHolidayAllBranch.TabIndex = 12;
            this.grvEmpHolidayAllBranch.Visible = false;
            // 
            // frmDisplayEmployeeHoliday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 571);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDisplayEmployeeHoliday";
            this.Load += new System.EventHandler(this.frmDisplayEmployeeHoliday_Load);
            this.Shown += new System.EventHandler(this.frmDisplayEmployeeHoliday_Shown);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvEmployeeHoliday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvEmpHolidayAllBranch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView grvEmployeeHoliday;
        private System.Windows.Forms.DataGridView grvEmpHolidayAllBranch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNickname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPositionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpHolidayDetail;
    }
}