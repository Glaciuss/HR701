namespace CarService
{
    partial class frmSelectWorkShift
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectWorkShift));
            this.grvWorkTimePeriod = new System.Windows.Forms.DataGridView();
            this.colSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colWorkTimePeriodID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWorkTimePeriodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grvWorkTimePeriod)).BeginInit();
            this.SuspendLayout();
            // 
            // grvWorkTimePeriod
            // 
            this.grvWorkTimePeriod.AllowUserToAddRows = false;
            this.grvWorkTimePeriod.AllowUserToDeleteRows = false;
            this.grvWorkTimePeriod.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvWorkTimePeriod.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grvWorkTimePeriod.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvWorkTimePeriod.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grvWorkTimePeriod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvWorkTimePeriod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSelect,
            this.colWorkTimePeriodID,
            this.colWorkTimePeriodName,
            this.colStartTime,
            this.colEndTime});
            this.grvWorkTimePeriod.EnableHeadersVisualStyles = false;
            this.grvWorkTimePeriod.Location = new System.Drawing.Point(29, 79);
            this.grvWorkTimePeriod.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grvWorkTimePeriod.Name = "grvWorkTimePeriod";
            this.grvWorkTimePeriod.RowHeadersWidth = 50;
            this.grvWorkTimePeriod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvWorkTimePeriod.Size = new System.Drawing.Size(1203, 367);
            this.grvWorkTimePeriod.TabIndex = 0;
            this.grvWorkTimePeriod.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvWorkTimePeriod_CellClick);
            // 
            // colSelect
            // 
            this.colSelect.FillWeight = 80F;
            this.colSelect.HeaderText = "";
            this.colSelect.Name = "colSelect";
            // 
            // colWorkTimePeriodID
            // 
            this.colWorkTimePeriodID.HeaderText = "WorkTimePeriodID";
            this.colWorkTimePeriodID.Name = "colWorkTimePeriodID";
            this.colWorkTimePeriodID.Visible = false;
            // 
            // colWorkTimePeriodName
            // 
            this.colWorkTimePeriodName.FillWeight = 178.4065F;
            this.colWorkTimePeriodName.HeaderText = "ชื่อเวลาทำงาน";
            this.colWorkTimePeriodName.Name = "colWorkTimePeriodName";
            this.colWorkTimePeriodName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colWorkTimePeriodName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colStartTime
            // 
            this.colStartTime.FillWeight = 89.20326F;
            this.colStartTime.HeaderText = "เวลาเริ่มงาน";
            this.colStartTime.Name = "colStartTime";
            this.colStartTime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colStartTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colEndTime
            // 
            this.colEndTime.FillWeight = 89.20326F;
            this.colEndTime.HeaderText = "เวลาเลิกงาน";
            this.colEndTime.Name = "colEndTime";
            this.colEndTime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEndTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Image = global::CarService.Properties.Resources.submit21;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(537, 458);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(188, 57);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "ตกลง";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.label1.Location = new System.Drawing.Point(375, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(513, 68);
            this.label1.TabIndex = 2;
            this.label1.Text = "กรุณาระบุเวลาทำงาน";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmSelectWorkShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1263, 530);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grvWorkTimePeriod);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmSelectWorkShift";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmSelectWorkShift_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvWorkTimePeriod)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grvWorkTimePeriod;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWorkTimePeriodID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWorkTimePeriodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEndTime;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
    }
}