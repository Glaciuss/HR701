namespace CarService
{
    partial class frmSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetting));
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.LBL_TITLE = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel_Line = new System.Windows.Forms.Panel();
            this.grdREC = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbShowDelRow = new System.Windows.Forms.CheckBox();
            this.txtNumREC = new System.Windows.Forms.TextBox();
            this.TXTHDR_DESC = new System.Windows.Forms.TextBox();
            this.TXTHDR_ID = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblDC = new System.Windows.Forms.Label();
            this.btnEditLine = new CarService.Class.RJButton();
            this.btnCancel = new CarService.Class.RJButton();
            this.btnDelLine = new CarService.Class.RJButton();
            this.btnAddLine = new CarService.Class.RJButton();
            this.panel_Header = new System.Windows.Forms.Panel();
            this.grdLine = new System.Windows.Forms.DataGridView();
            this.HDR_ID_LINE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KPI_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KPI_DESC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALUE_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SETTING_VALUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WEIGHT_RATE_LINE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOD_USERID_LINE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOD_DATETIME_LINE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COUNT_DESC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSelectY = new System.Windows.Forms.Label();
            this.cmb_Year = new System.Windows.Forms.ComboBox();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.TXTW_L = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.txtEmpID_A = new System.Windows.Forms.TabControl();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.toolBarProgramID = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolBarCompany = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolBarServerName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolBarRelVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.FAULT_DATETIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REC_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HDR_ID_REC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KPI_ID_REC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ERROR_DESC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEDUCT_POINT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PICTURE_PATH_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PICTURE_PATH_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PICTURE_PATH_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEL_REC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOD_USERID_REC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOD_DATETIME_REC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTitleBar.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel_Line.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdREC)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLine)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.txtEmpID_A.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.pnlLeft.Location = new System.Drawing.Point(-8, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(10, 550);
            this.pnlLeft.TabIndex = 109;
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(1182, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(2, 661);
            this.pnlRight.TabIndex = 110;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.panelTitleBar.Controls.Add(this.LBL_TITLE);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1182, 39);
            this.panelTitleBar.TabIndex = 107;
            // 
            // LBL_TITLE
            // 
            this.LBL_TITLE.BackColor = System.Drawing.Color.Transparent;
            this.LBL_TITLE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_TITLE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_TITLE.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_TITLE.ForeColor = System.Drawing.SystemColors.Control;
            this.LBL_TITLE.Location = new System.Drawing.Point(0, 0);
            this.LBL_TITLE.Name = "LBL_TITLE";
            this.LBL_TITLE.Size = new System.Drawing.Size(1182, 39);
            this.LBL_TITLE.TabIndex = 27;
            this.LBL_TITLE.Text = "EmpName";
            this.LBL_TITLE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel_Line);
            this.tabPage1.Controls.Add(this.panel_Header);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1174, 555);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "การปฏิบัติงาน";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel_Line
            // 
            this.panel_Line.Controls.Add(this.grdREC);
            this.panel_Line.Controls.Add(this.panel1);
            this.panel_Line.Controls.Add(this.panel4);
            this.panel_Line.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Line.Location = new System.Drawing.Point(531, 3);
            this.panel_Line.Name = "panel_Line";
            this.panel_Line.Padding = new System.Windows.Forms.Padding(5);
            this.panel_Line.Size = new System.Drawing.Size(640, 549);
            this.panel_Line.TabIndex = 1;
            this.panel_Line.Visible = false;
            // 
            // grdREC
            // 
            this.grdREC.AllowUserToAddRows = false;
            this.grdREC.AllowUserToDeleteRows = false;
            this.grdREC.AllowUserToResizeRows = false;
            this.grdREC.BackgroundColor = System.Drawing.Color.White;
            this.grdREC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdREC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdREC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FAULT_DATETIME,
            this.REC_ID,
            this.HDR_ID_REC,
            this.KPI_ID_REC,
            this.ERROR_DESC,
            this.DEDUCT_POINT,
            this.PICTURE_PATH_1,
            this.PICTURE_PATH_2,
            this.PICTURE_PATH_3,
            this.DEL_REC,
            this.MOD_USERID_REC,
            this.MOD_DATETIME_REC});
            this.grdREC.Location = new System.Drawing.Point(8, 55);
            this.grdREC.Name = "grdREC";
            this.grdREC.ReadOnly = true;
            this.grdREC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdREC.Size = new System.Drawing.Size(615, 368);
            this.grdREC.TabIndex = 3;
            this.grdREC.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdREC_CellDoubleClick);
            this.grdREC.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdREC_RowEnter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbShowDelRow);
            this.panel1.Controls.Add(this.txtNumREC);
            this.panel1.Controls.Add(this.TXTHDR_DESC);
            this.panel1.Controls.Add(this.TXTHDR_ID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 48);
            this.panel1.TabIndex = 3;
            // 
            // cbShowDelRow
            // 
            this.cbShowDelRow.AutoSize = true;
            this.cbShowDelRow.Location = new System.Drawing.Point(473, 11);
            this.cbShowDelRow.Name = "cbShowDelRow";
            this.cbShowDelRow.Size = new System.Drawing.Size(86, 24);
            this.cbShowDelRow.TabIndex = 136;
            this.cbShowDelRow.Text = "Show All";
            this.cbShowDelRow.UseVisualStyleBackColor = true;
            this.cbShowDelRow.CheckedChanged += new System.EventHandler(this.cbShowDelRow_CheckedChanged);
            // 
            // txtNumREC
            // 
            this.txtNumREC.Location = new System.Drawing.Point(396, 9);
            this.txtNumREC.Name = "txtNumREC";
            this.txtNumREC.ReadOnly = true;
            this.txtNumREC.Size = new System.Drawing.Size(71, 27);
            this.txtNumREC.TabIndex = 2;
            this.txtNumREC.Text = "now/max";
            // 
            // TXTHDR_DESC
            // 
            this.TXTHDR_DESC.Location = new System.Drawing.Point(120, 9);
            this.TXTHDR_DESC.Name = "TXTHDR_DESC";
            this.TXTHDR_DESC.ReadOnly = true;
            this.TXTHDR_DESC.Size = new System.Drawing.Size(270, 27);
            this.TXTHDR_DESC.TabIndex = 1;
            this.TXTHDR_DESC.Text = "HDR_DESC  ";
            // 
            // TXTHDR_ID
            // 
            this.TXTHDR_ID.Location = new System.Drawing.Point(43, 9);
            this.TXTHDR_ID.Name = "TXTHDR_ID";
            this.TXTHDR_ID.ReadOnly = true;
            this.TXTHDR_ID.Size = new System.Drawing.Size(71, 27);
            this.TXTHDR_ID.TabIndex = 0;
            this.TXTHDR_ID.Text = "HDR_ID";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.lblDC);
            this.panel4.Controls.Add(this.btnEditLine);
            this.panel4.Controls.Add(this.btnCancel);
            this.panel4.Controls.Add(this.btnDelLine);
            this.panel4.Controls.Add(this.btnAddLine);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(5, 429);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(630, 115);
            this.panel4.TabIndex = 1;
            // 
            // lblDC
            // 
            this.lblDC.AutoSize = true;
            this.lblDC.Location = new System.Drawing.Point(173, 49);
            this.lblDC.Name = "lblDC";
            this.lblDC.Size = new System.Drawing.Size(294, 20);
            this.lblDC.TabIndex = 137;
            this.lblDC.Text = "หัวข้อในความผิดพลาดนี้ถูกนับข้อมูลในระบบ Sbuy";
            // 
            // btnEditLine
            // 
            this.btnEditLine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditLine.BackColor = System.Drawing.Color.DarkGray;
            this.btnEditLine.BackgroundColor = System.Drawing.Color.DarkGray;
            this.btnEditLine.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEditLine.BorderRadius = 20;
            this.btnEditLine.BorderSize = 0;
            this.btnEditLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditLine.FlatAppearance.BorderSize = 0;
            this.btnEditLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditLine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditLine.ForeColor = System.Drawing.Color.Black;
            this.btnEditLine.Location = new System.Drawing.Point(284, 38);
            this.btnEditLine.Name = "btnEditLine";
            this.btnEditLine.Size = new System.Drawing.Size(84, 40);
            this.btnEditLine.TabIndex = 118;
            this.btnEditLine.Text = "แก้ไข";
            this.btnEditLine.TextColor = System.Drawing.Color.Black;
            this.btnEditLine.UseVisualStyleBackColor = false;
            this.btnEditLine.Click += new System.EventHandler(this.btnEditLine_Click);
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
            this.btnCancel.Location = new System.Drawing.Point(478, 38);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 40);
            this.btnCancel.TabIndex = 117;
            this.btnCancel.Text = "ยกเลิก";
            this.btnCancel.TextColor = System.Drawing.Color.Black;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            // 
            // btnDelLine
            // 
            this.btnDelLine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelLine.BackColor = System.Drawing.Color.DarkGray;
            this.btnDelLine.BackgroundColor = System.Drawing.Color.DarkGray;
            this.btnDelLine.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDelLine.BorderRadius = 20;
            this.btnDelLine.BorderSize = 0;
            this.btnDelLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelLine.FlatAppearance.BorderSize = 0;
            this.btnDelLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelLine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelLine.ForeColor = System.Drawing.Color.Black;
            this.btnDelLine.Location = new System.Drawing.Point(374, 38);
            this.btnDelLine.Name = "btnDelLine";
            this.btnDelLine.Size = new System.Drawing.Size(84, 40);
            this.btnDelLine.TabIndex = 116;
            this.btnDelLine.Text = "ลบ";
            this.btnDelLine.TextColor = System.Drawing.Color.Black;
            this.btnDelLine.UseVisualStyleBackColor = false;
            this.btnDelLine.Click += new System.EventHandler(this.btnDelLine_Click);
            // 
            // btnAddLine
            // 
            this.btnAddLine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddLine.BackColor = System.Drawing.Color.DarkGray;
            this.btnAddLine.BackgroundColor = System.Drawing.Color.DarkGray;
            this.btnAddLine.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddLine.BorderRadius = 20;
            this.btnAddLine.BorderSize = 0;
            this.btnAddLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddLine.FlatAppearance.BorderSize = 0;
            this.btnAddLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLine.ForeColor = System.Drawing.Color.Black;
            this.btnAddLine.Location = new System.Drawing.Point(194, 38);
            this.btnAddLine.Name = "btnAddLine";
            this.btnAddLine.Size = new System.Drawing.Size(84, 40);
            this.btnAddLine.TabIndex = 115;
            this.btnAddLine.Text = "เพิ่ม";
            this.btnAddLine.TextColor = System.Drawing.Color.Black;
            this.btnAddLine.UseVisualStyleBackColor = false;
            this.btnAddLine.Click += new System.EventHandler(this.btnAddLine_Click);
            // 
            // panel_Header
            // 
            this.panel_Header.Controls.Add(this.grdLine);
            this.panel_Header.Controls.Add(this.panel2);
            this.panel_Header.Controls.Add(this.panel3);
            this.panel_Header.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Header.Location = new System.Drawing.Point(3, 3);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Padding = new System.Windows.Forms.Padding(5);
            this.panel_Header.Size = new System.Drawing.Size(528, 549);
            this.panel_Header.TabIndex = 0;
            // 
            // grdLine
            // 
            this.grdLine.AllowUserToAddRows = false;
            this.grdLine.AllowUserToDeleteRows = false;
            this.grdLine.AllowUserToResizeRows = false;
            this.grdLine.BackgroundColor = System.Drawing.Color.White;
            this.grdLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HDR_ID_LINE,
            this.KPI_ID,
            this.KPI_DESC,
            this.VALUE_TYPE,
            this.SETTING_VALUE,
            this.WEIGHT_RATE_LINE,
            this.MOD_USERID_LINE,
            this.MOD_DATETIME_LINE,
            this.COUNT_DESC});
            this.grdLine.Location = new System.Drawing.Point(5, 55);
            this.grdLine.Name = "grdLine";
            this.grdLine.ReadOnly = true;
            this.grdLine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdLine.Size = new System.Drawing.Size(515, 368);
            this.grdLine.TabIndex = 2;
            this.grdLine.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdLine_CellClick);
            // 
            // HDR_ID_LINE
            // 
            this.HDR_ID_LINE.HeaderText = "HDR_ID";
            this.HDR_ID_LINE.Name = "HDR_ID_LINE";
            this.HDR_ID_LINE.ReadOnly = true;
            this.HDR_ID_LINE.Visible = false;
            this.HDR_ID_LINE.Width = 80;
            // 
            // KPI_ID
            // 
            this.KPI_ID.HeaderText = "KPI_ID";
            this.KPI_ID.Name = "KPI_ID";
            this.KPI_ID.ReadOnly = true;
            this.KPI_ID.Width = 40;
            // 
            // KPI_DESC
            // 
            this.KPI_DESC.HeaderText = "KPI_DESC";
            this.KPI_DESC.MinimumWidth = 200;
            this.KPI_DESC.Name = "KPI_DESC";
            this.KPI_DESC.ReadOnly = true;
            this.KPI_DESC.Width = 250;
            // 
            // VALUE_TYPE
            // 
            this.VALUE_TYPE.HeaderText = "VALUE_TYPE";
            this.VALUE_TYPE.Name = "VALUE_TYPE";
            this.VALUE_TYPE.ReadOnly = true;
            this.VALUE_TYPE.Width = 50;
            // 
            // SETTING_VALUE
            // 
            this.SETTING_VALUE.HeaderText = "SETTING_VALUE";
            this.SETTING_VALUE.Name = "SETTING_VALUE";
            this.SETTING_VALUE.ReadOnly = true;
            this.SETTING_VALUE.Width = 50;
            // 
            // WEIGHT_RATE_LINE
            // 
            this.WEIGHT_RATE_LINE.HeaderText = "WEIGHT_RATE";
            this.WEIGHT_RATE_LINE.Name = "WEIGHT_RATE_LINE";
            this.WEIGHT_RATE_LINE.ReadOnly = true;
            this.WEIGHT_RATE_LINE.Width = 80;
            // 
            // MOD_USERID_LINE
            // 
            this.MOD_USERID_LINE.HeaderText = "MOD_USERID";
            this.MOD_USERID_LINE.Name = "MOD_USERID_LINE";
            this.MOD_USERID_LINE.ReadOnly = true;
            // 
            // MOD_DATETIME_LINE
            // 
            this.MOD_DATETIME_LINE.HeaderText = "MOD_DATETIME";
            this.MOD_DATETIME_LINE.Name = "MOD_DATETIME_LINE";
            this.MOD_DATETIME_LINE.ReadOnly = true;
            this.MOD_DATETIME_LINE.Width = 120;
            // 
            // COUNT_DESC
            // 
            this.COUNT_DESC.HeaderText = "CountDP";
            this.COUNT_DESC.Name = "COUNT_DESC";
            this.COUNT_DESC.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblSelectY);
            this.panel2.Controls.Add(this.cmb_Year);
            this.panel2.Controls.Add(this.txtEmpID);
            this.panel2.Controls.Add(this.TXTW_L);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(518, 48);
            this.panel2.TabIndex = 2;
            // 
            // lblSelectY
            // 
            this.lblSelectY.AutoSize = true;
            this.lblSelectY.Location = new System.Drawing.Point(3, 12);
            this.lblSelectY.Name = "lblSelectY";
            this.lblSelectY.Size = new System.Drawing.Size(47, 20);
            this.lblSelectY.TabIndex = 135;
            this.lblSelectY.Text = "เลือกปี";
            // 
            // cmb_Year
            // 
            this.cmb_Year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Year.FormattingEnabled = true;
            this.cmb_Year.Items.AddRange(new object[] {
            "2021",
            "2022",
            "2023"});
            this.cmb_Year.Location = new System.Drawing.Point(56, 9);
            this.cmb_Year.Name = "cmb_Year";
            this.cmb_Year.Size = new System.Drawing.Size(74, 28);
            this.cmb_Year.TabIndex = 134;
            this.cmb_Year.SelectedValueChanged += new System.EventHandler(this.cmb_Year_SelectedValueChanged);
            // 
            // txtEmpID
            // 
            this.txtEmpID.Enabled = false;
            this.txtEmpID.Location = new System.Drawing.Point(289, 9);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.ReadOnly = true;
            this.txtEmpID.Size = new System.Drawing.Size(53, 27);
            this.txtEmpID.TabIndex = 3;
            this.txtEmpID.Text = "EmpID";
            this.txtEmpID.Visible = false;
            // 
            // TXTW_L
            // 
            this.TXTW_L.Enabled = false;
            this.TXTW_L.Location = new System.Drawing.Point(348, 9);
            this.TXTW_L.Name = "TXTW_L";
            this.TXTW_L.ReadOnly = true;
            this.TXTW_L.Size = new System.Drawing.Size(63, 27);
            this.TXTW_L.TabIndex = 2;
            this.TXTW_L.Text = "W ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtScore);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(5, 429);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(518, 115);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 136;
            this.label1.Text = "คะแนนปฏิบัติงาน";
            // 
            // txtScore
            // 
            this.txtScore.Enabled = false;
            this.txtScore.Location = new System.Drawing.Point(115, 27);
            this.txtScore.Name = "txtScore";
            this.txtScore.ReadOnly = true;
            this.txtScore.Size = new System.Drawing.Size(105, 27);
            this.txtScore.TabIndex = 136;
            this.txtScore.Text = "Score";
            // 
            // txtEmpID_A
            // 
            this.txtEmpID_A.Controls.Add(this.tabPage1);
            this.txtEmpID_A.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEmpID_A.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpID_A.Location = new System.Drawing.Point(0, 39);
            this.txtEmpID_A.Name = "txtEmpID_A";
            this.txtEmpID_A.SelectedIndex = 0;
            this.txtEmpID_A.Size = new System.Drawing.Size(1182, 588);
            this.txtEmpID_A.TabIndex = 163;
            // 
            // statusBar
            // 
            this.statusBar.AutoSize = false;
            this.statusBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.statusBar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBarProgramID,
            this.toolBarCompany,
            this.toolBarServerName,
            this.toolBarRelVersion});
            this.statusBar.Location = new System.Drawing.Point(0, 627);
            this.statusBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.statusBar.Name = "statusBar";
            this.statusBar.Padding = new System.Windows.Forms.Padding(1, 0, 17, 0);
            this.statusBar.Size = new System.Drawing.Size(1182, 34);
            this.statusBar.SizingGrip = false;
            this.statusBar.TabIndex = 164;
            this.statusBar.Text = "statusStrip1";
            // 
            // toolBarProgramID
            // 
            this.toolBarProgramID.AutoSize = false;
            this.toolBarProgramID.BackColor = System.Drawing.Color.Transparent;
            this.toolBarProgramID.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner;
            this.toolBarProgramID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolBarProgramID.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolBarProgramID.Name = "toolBarProgramID";
            this.toolBarProgramID.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolBarProgramID.Size = new System.Drawing.Size(150, 29);
            this.toolBarProgramID.Text = "ProgramID";
            this.toolBarProgramID.ToolTipText = "รหัสโปรแกรม";
            // 
            // toolBarCompany
            // 
            this.toolBarCompany.AutoSize = false;
            this.toolBarCompany.BackColor = System.Drawing.Color.Transparent;
            this.toolBarCompany.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolBarCompany.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner;
            this.toolBarCompany.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolBarCompany.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolBarCompany.Name = "toolBarCompany";
            this.toolBarCompany.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolBarCompany.Size = new System.Drawing.Size(799, 29);
            this.toolBarCompany.Spring = true;
            this.toolBarCompany.Text = "Company Co., Ltd.";
            // 
            // toolBarServerName
            // 
            this.toolBarServerName.BackColor = System.Drawing.Color.Transparent;
            this.toolBarServerName.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner;
            this.toolBarServerName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolBarServerName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolBarServerName.Name = "toolBarServerName";
            this.toolBarServerName.Size = new System.Drawing.Size(105, 29);
            this.toolBarServerName.Text = "Server Name : Port";
            this.toolBarServerName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolBarRelVersion
            // 
            this.toolBarRelVersion.AutoSize = false;
            this.toolBarRelVersion.BackColor = System.Drawing.Color.Transparent;
            this.toolBarRelVersion.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.toolBarRelVersion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolBarRelVersion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolBarRelVersion.Name = "toolBarRelVersion";
            this.toolBarRelVersion.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolBarRelVersion.Size = new System.Drawing.Size(110, 29);
            this.toolBarRelVersion.Text = "REV.20210702";
            this.toolBarRelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FAULT_DATETIME
            // 
            this.FAULT_DATETIME.HeaderText = "INCIDENT";
            this.FAULT_DATETIME.Name = "FAULT_DATETIME";
            this.FAULT_DATETIME.ReadOnly = true;
            // 
            // REC_ID
            // 
            this.REC_ID.HeaderText = "REC_ID";
            this.REC_ID.Name = "REC_ID";
            this.REC_ID.ReadOnly = true;
            this.REC_ID.Width = 60;
            // 
            // HDR_ID_REC
            // 
            this.HDR_ID_REC.HeaderText = "HDR_ID";
            this.HDR_ID_REC.Name = "HDR_ID_REC";
            this.HDR_ID_REC.ReadOnly = true;
            this.HDR_ID_REC.Visible = false;
            this.HDR_ID_REC.Width = 80;
            // 
            // KPI_ID_REC
            // 
            this.KPI_ID_REC.HeaderText = "KPI_ID";
            this.KPI_ID_REC.Name = "KPI_ID_REC";
            this.KPI_ID_REC.ReadOnly = true;
            this.KPI_ID_REC.Visible = false;
            this.KPI_ID_REC.Width = 40;
            // 
            // ERROR_DESC
            // 
            this.ERROR_DESC.HeaderText = "ERROR_DESC";
            this.ERROR_DESC.Name = "ERROR_DESC";
            this.ERROR_DESC.ReadOnly = true;
            this.ERROR_DESC.Width = 160;
            // 
            // DEDUCT_POINT
            // 
            this.DEDUCT_POINT.HeaderText = "DEDUCT_POINT";
            this.DEDUCT_POINT.Name = "DEDUCT_POINT";
            this.DEDUCT_POINT.ReadOnly = true;
            this.DEDUCT_POINT.Width = 50;
            // 
            // PICTURE_PATH_1
            // 
            this.PICTURE_PATH_1.HeaderText = "PICTURE_PATH_1";
            this.PICTURE_PATH_1.Name = "PICTURE_PATH_1";
            this.PICTURE_PATH_1.ReadOnly = true;
            this.PICTURE_PATH_1.Width = 50;
            // 
            // PICTURE_PATH_2
            // 
            this.PICTURE_PATH_2.HeaderText = "PICTURE_PATH_2";
            this.PICTURE_PATH_2.Name = "PICTURE_PATH_2";
            this.PICTURE_PATH_2.ReadOnly = true;
            this.PICTURE_PATH_2.Width = 50;
            // 
            // PICTURE_PATH_3
            // 
            this.PICTURE_PATH_3.HeaderText = "PICTURE_PATH_3";
            this.PICTURE_PATH_3.Name = "PICTURE_PATH_3";
            this.PICTURE_PATH_3.ReadOnly = true;
            this.PICTURE_PATH_3.Width = 50;
            // 
            // DEL_REC
            // 
            this.DEL_REC.HeaderText = "DEL";
            this.DEL_REC.Name = "DEL_REC";
            this.DEL_REC.ReadOnly = true;
            // 
            // MOD_USERID_REC
            // 
            this.MOD_USERID_REC.HeaderText = "MOD_USERID";
            this.MOD_USERID_REC.Name = "MOD_USERID_REC";
            this.MOD_USERID_REC.ReadOnly = true;
            this.MOD_USERID_REC.Width = 60;
            // 
            // MOD_DATETIME_REC
            // 
            this.MOD_DATETIME_REC.HeaderText = "MOD_DATETIME";
            this.MOD_DATETIME_REC.Name = "MOD_DATETIME_REC";
            this.MOD_DATETIME_REC.ReadOnly = true;
            // 
            // frmSetting
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.txtEmpID_A);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "frmSetting";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmShowMessage_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel_Line.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdREC)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel_Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdLine)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.txtEmpID_A.ResumeLayout(false);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label LBL_TITLE;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl txtEmpID_A;
        private System.Windows.Forms.Panel panel_Line;
        private System.Windows.Forms.Panel panel_Header;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView grdLine;
        private System.Windows.Forms.Panel panel4;
        private Class.RJButton btnDelLine;
        private Class.RJButton btnAddLine;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel toolBarProgramID;
        private System.Windows.Forms.ToolStripStatusLabel toolBarCompany;
        private System.Windows.Forms.ToolStripStatusLabel toolBarServerName;
        private System.Windows.Forms.ToolStripStatusLabel toolBarRelVersion;
        private Class.RJButton btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TXTHDR_DESC;
        private System.Windows.Forms.TextBox TXTHDR_ID;
        private Class.RJButton btnEditLine;
        private System.Windows.Forms.TextBox TXTW_L;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView grdREC;
        private System.Windows.Forms.TextBox txtNumREC;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Label lblSelectY;
        private System.Windows.Forms.ComboBox cmb_Year;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label lblDC;
        private System.Windows.Forms.DataGridViewTextBoxColumn HDR_ID_LINE;
        private System.Windows.Forms.DataGridViewTextBoxColumn KPI_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn KPI_DESC;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALUE_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SETTING_VALUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn WEIGHT_RATE_LINE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOD_USERID_LINE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOD_DATETIME_LINE;
        private System.Windows.Forms.DataGridViewTextBoxColumn COUNT_DESC;
        private System.Windows.Forms.CheckBox cbShowDelRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn FAULT_DATETIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn REC_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HDR_ID_REC;
        private System.Windows.Forms.DataGridViewTextBoxColumn KPI_ID_REC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ERROR_DESC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEDUCT_POINT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PICTURE_PATH_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PICTURE_PATH_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PICTURE_PATH_3;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEL_REC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOD_USERID_REC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOD_DATETIME_REC;
    }
}