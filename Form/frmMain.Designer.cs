namespace CarService
{
    partial class frmMain
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
            //if(disposing)
            //{
            //    if (_mp3Player != null) _mp3Player.Dispose();                
            //}
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.timeEmpWork = new System.Windows.Forms.Timer(this.components);
            this.lblDisplayText = new System.Windows.Forms.Label();
            this.grvEmpWork = new System.Windows.Forms.DataGridView();
            this.GRV_COL_EMPLOYEE_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRV_COL_EMPLOYEE_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRV_COL_EMPLOYEE_SURNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRV_COL_NICKNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRV_COL_POSITION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkKPIScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSummary = new System.Windows.Forms.Panel();
            this.grvWorkTimePeriod = new System.Windows.Forms.DataGridView();
            this.grvEmployeeWorkTimePeriod = new System.Windows.Forms.DataGridView();
            this.grvCompanyTimeCondition = new System.Windows.Forms.DataGridView();
            this.grvCountEmployee = new System.Windows.Forms.DataGridView();
            this.colCompanyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlDisplayEmpWork_BG = new System.Windows.Forms.Panel();
            this.pnlDisplayEmpWork = new System.Windows.Forms.Panel();
            this.pnlFinger = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblAllPosition = new System.Windows.Forms.Label();
            this.cbAllPosition = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAllCompany = new System.Windows.Forms.Label();
            this.cbAllCompany = new System.Windows.Forms.CheckBox();
            this.cmb_Company = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.pnlCompany = new System.Windows.Forms.Panel();
            this.lblShowOpenOrClose = new System.Windows.Forms.Label();
            this.cmbCompany = new System.Windows.Forms.ComboBox();
            this.timeDisplay = new System.Windows.Forms.Timer(this.components);
            this.btnSearch = new CarService.Class.RJButton();
            this.btnSetting = new CarService.Class.RJButton();
            this.btnLanguage = new CarService.Class.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.grvEmpWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvWorkTimePeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvEmployeeWorkTimePeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCompanyTimeCondition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCountEmployee)).BeginInit();
            this.pnlDisplayEmpWork_BG.SuspendLayout();
            this.pnlDisplayEmpWork.SuspendLayout();
            this.pnlFinger.SuspendLayout();
            this.pnlCompany.SuspendLayout();
            this.SuspendLayout();
            // 
            // timeEmpWork
            // 
            this.timeEmpWork.Interval = 1000;
            // 
            // lblDisplayText
            // 
            this.lblDisplayText.BackColor = System.Drawing.Color.Transparent;
            this.lblDisplayText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisplayText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDisplayText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDisplayText.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayText.Location = new System.Drawing.Point(0, 0);
            this.lblDisplayText.Name = "lblDisplayText";
            this.lblDisplayText.Size = new System.Drawing.Size(424, 420);
            this.lblDisplayText.TabIndex = 18;
            this.lblDisplayText.Text = "Fingerprint status";
            this.lblDisplayText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grvEmpWork
            // 
            this.grvEmpWork.AllowUserToAddRows = false;
            this.grvEmpWork.AllowUserToDeleteRows = false;
            this.grvEmpWork.AllowUserToResizeRows = false;
            this.grvEmpWork.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grvEmpWork.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grvEmpWork.BackgroundColor = System.Drawing.Color.White;
            this.grvEmpWork.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvEmpWork.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grvEmpWork.ColumnHeadersHeight = 25;
            this.grvEmpWork.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GRV_COL_EMPLOYEE_ID,
            this.GRV_COL_EMPLOYEE_NAME,
            this.GRV_COL_EMPLOYEE_SURNAME,
            this.GRV_COL_NICKNAME,
            this.GRV_COL_POSITION,
            this.WorkKPIScore});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(127)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvEmpWork.DefaultCellStyle = dataGridViewCellStyle6;
            this.grvEmpWork.Dock = System.Windows.Forms.DockStyle.Left;
            this.grvEmpWork.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grvEmpWork.Location = new System.Drawing.Point(0, 0);
            this.grvEmpWork.Name = "grvEmpWork";
            this.grvEmpWork.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(127)))), ((int)(((byte)(188)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvEmpWork.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grvEmpWork.RowHeadersWidth = 70;
            this.grvEmpWork.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grvEmpWork.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvEmpWork.Size = new System.Drawing.Size(510, 420);
            this.grvEmpWork.TabIndex = 1;
            this.grvEmpWork.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvEmpWork_CellDoubleClick);
            this.grvEmpWork.Sorted += new System.EventHandler(this.grvEmpWork_Sorted);
            this.grvEmpWork.Leave += new System.EventHandler(this.grvEmpWork_Leave);
            // 
            // GRV_COL_EMPLOYEE_ID
            // 
            this.GRV_COL_EMPLOYEE_ID.HeaderText = "EmployeeID";
            this.GRV_COL_EMPLOYEE_ID.Name = "GRV_COL_EMPLOYEE_ID";
            this.GRV_COL_EMPLOYEE_ID.ReadOnly = true;
            this.GRV_COL_EMPLOYEE_ID.Visible = false;
            this.GRV_COL_EMPLOYEE_ID.Width = 102;
            // 
            // GRV_COL_EMPLOYEE_NAME
            // 
            this.GRV_COL_EMPLOYEE_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRV_COL_EMPLOYEE_NAME.DefaultCellStyle = dataGridViewCellStyle2;
            this.GRV_COL_EMPLOYEE_NAME.FillWeight = 60F;
            this.GRV_COL_EMPLOYEE_NAME.HeaderText = "ชื่อ";
            this.GRV_COL_EMPLOYEE_NAME.MinimumWidth = 80;
            this.GRV_COL_EMPLOYEE_NAME.Name = "GRV_COL_EMPLOYEE_NAME";
            this.GRV_COL_EMPLOYEE_NAME.ReadOnly = true;
            this.GRV_COL_EMPLOYEE_NAME.Width = 80;
            // 
            // GRV_COL_EMPLOYEE_SURNAME
            // 
            this.GRV_COL_EMPLOYEE_SURNAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRV_COL_EMPLOYEE_SURNAME.DefaultCellStyle = dataGridViewCellStyle3;
            this.GRV_COL_EMPLOYEE_SURNAME.FillWeight = 60F;
            this.GRV_COL_EMPLOYEE_SURNAME.HeaderText = "สกุล";
            this.GRV_COL_EMPLOYEE_SURNAME.MinimumWidth = 80;
            this.GRV_COL_EMPLOYEE_SURNAME.Name = "GRV_COL_EMPLOYEE_SURNAME";
            this.GRV_COL_EMPLOYEE_SURNAME.ReadOnly = true;
            this.GRV_COL_EMPLOYEE_SURNAME.Width = 80;
            // 
            // GRV_COL_NICKNAME
            // 
            this.GRV_COL_NICKNAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRV_COL_NICKNAME.DefaultCellStyle = dataGridViewCellStyle4;
            this.GRV_COL_NICKNAME.FillWeight = 20F;
            this.GRV_COL_NICKNAME.HeaderText = "ชื่อเล่น";
            this.GRV_COL_NICKNAME.MinimumWidth = 80;
            this.GRV_COL_NICKNAME.Name = "GRV_COL_NICKNAME";
            this.GRV_COL_NICKNAME.ReadOnly = true;
            this.GRV_COL_NICKNAME.Width = 80;
            // 
            // GRV_COL_POSITION
            // 
            this.GRV_COL_POSITION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRV_COL_POSITION.DefaultCellStyle = dataGridViewCellStyle5;
            this.GRV_COL_POSITION.FillWeight = 60F;
            this.GRV_COL_POSITION.HeaderText = "ตำแหน่ง";
            this.GRV_COL_POSITION.MinimumWidth = 80;
            this.GRV_COL_POSITION.Name = "GRV_COL_POSITION";
            this.GRV_COL_POSITION.ReadOnly = true;
            this.GRV_COL_POSITION.Width = 80;
            // 
            // WorkKPIScore
            // 
            this.WorkKPIScore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.WorkKPIScore.DataPropertyName = "WorkKPIScore";
            this.WorkKPIScore.FillWeight = 20F;
            this.WorkKPIScore.HeaderText = "คะแนนการปฏิบัติงาน (%)";
            this.WorkKPIScore.Name = "WorkKPIScore";
            this.WorkKPIScore.ReadOnly = true;
            this.WorkKPIScore.Visible = false;
            this.WorkKPIScore.Width = 156;
            // 
            // pnlSummary
            // 
            this.pnlSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.pnlSummary.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSummary.Location = new System.Drawing.Point(0, 430);
            this.pnlSummary.Name = "pnlSummary";
            this.pnlSummary.Size = new System.Drawing.Size(429, 58);
            this.pnlSummary.TabIndex = 33;
            // 
            // grvWorkTimePeriod
            // 
            this.grvWorkTimePeriod.AllowUserToAddRows = false;
            this.grvWorkTimePeriod.AllowUserToDeleteRows = false;
            this.grvWorkTimePeriod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvWorkTimePeriod.Location = new System.Drawing.Point(192, 213);
            this.grvWorkTimePeriod.Name = "grvWorkTimePeriod";
            this.grvWorkTimePeriod.Size = new System.Drawing.Size(197, 118);
            this.grvWorkTimePeriod.TabIndex = 35;
            // 
            // grvEmployeeWorkTimePeriod
            // 
            this.grvEmployeeWorkTimePeriod.AllowUserToAddRows = false;
            this.grvEmployeeWorkTimePeriod.AllowUserToDeleteRows = false;
            this.grvEmployeeWorkTimePeriod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvEmployeeWorkTimePeriod.Location = new System.Drawing.Point(395, 213);
            this.grvEmployeeWorkTimePeriod.Name = "grvEmployeeWorkTimePeriod";
            this.grvEmployeeWorkTimePeriod.Size = new System.Drawing.Size(111, 120);
            this.grvEmployeeWorkTimePeriod.TabIndex = 40;
            this.grvEmployeeWorkTimePeriod.Visible = false;
            // 
            // grvCompanyTimeCondition
            // 
            this.grvCompanyTimeCondition.AllowUserToAddRows = false;
            this.grvCompanyTimeCondition.AllowUserToDeleteRows = false;
            this.grvCompanyTimeCondition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvCompanyTimeCondition.Location = new System.Drawing.Point(512, 213);
            this.grvCompanyTimeCondition.Name = "grvCompanyTimeCondition";
            this.grvCompanyTimeCondition.Size = new System.Drawing.Size(111, 120);
            this.grvCompanyTimeCondition.TabIndex = 42;
            this.grvCompanyTimeCondition.Visible = false;
            // 
            // grvCountEmployee
            // 
            this.grvCountEmployee.AllowUserToAddRows = false;
            this.grvCountEmployee.AllowUserToDeleteRows = false;
            this.grvCountEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvCountEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCompanyID,
            this.colTotalEmp});
            this.grvCountEmployee.Location = new System.Drawing.Point(521, 393);
            this.grvCountEmployee.Name = "grvCountEmployee";
            this.grvCountEmployee.Size = new System.Drawing.Size(111, 115);
            this.grvCountEmployee.TabIndex = 43;
            this.grvCountEmployee.Visible = false;
            // 
            // colCompanyID
            // 
            this.colCompanyID.HeaderText = "CompanyID";
            this.colCompanyID.Name = "colCompanyID";
            // 
            // colTotalEmp
            // 
            this.colTotalEmp.HeaderText = "TotalEmployee";
            this.colTotalEmp.Name = "colTotalEmp";
            // 
            // pnlDisplayEmpWork_BG
            // 
            this.pnlDisplayEmpWork_BG.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlDisplayEmpWork_BG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDisplayEmpWork_BG.Controls.Add(this.pnlDisplayEmpWork);
            this.pnlDisplayEmpWork_BG.Controls.Add(this.pnlSummary);
            this.pnlDisplayEmpWork_BG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDisplayEmpWork_BG.Location = new System.Drawing.Point(361, 0);
            this.pnlDisplayEmpWork_BG.Name = "pnlDisplayEmpWork_BG";
            this.pnlDisplayEmpWork_BG.Size = new System.Drawing.Size(433, 492);
            this.pnlDisplayEmpWork_BG.TabIndex = 46;
            // 
            // pnlDisplayEmpWork
            // 
            this.pnlDisplayEmpWork.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDisplayEmpWork.Controls.Add(this.grvEmpWork);
            this.pnlDisplayEmpWork.Controls.Add(this.lblDisplayText);
            this.pnlDisplayEmpWork.Location = new System.Drawing.Point(3, 4);
            this.pnlDisplayEmpWork.Name = "pnlDisplayEmpWork";
            this.pnlDisplayEmpWork.Size = new System.Drawing.Size(424, 420);
            this.pnlDisplayEmpWork.TabIndex = 34;
            // 
            // pnlFinger
            // 
            this.pnlFinger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.pnlFinger.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFinger.Controls.Add(this.btnClear);
            this.pnlFinger.Controls.Add(this.lblAllPosition);
            this.pnlFinger.Controls.Add(this.cbAllPosition);
            this.pnlFinger.Controls.Add(this.label2);
            this.pnlFinger.Controls.Add(this.cmbPosition);
            this.pnlFinger.Controls.Add(this.txtEmpName);
            this.pnlFinger.Controls.Add(this.label3);
            this.pnlFinger.Controls.Add(this.lblAllCompany);
            this.pnlFinger.Controls.Add(this.cbAllCompany);
            this.pnlFinger.Controls.Add(this.btnSearch);
            this.pnlFinger.Controls.Add(this.cmb_Company);
            this.pnlFinger.Controls.Add(this.label1);
            this.pnlFinger.Controls.Add(this.btnSetting);
            this.pnlFinger.Controls.Add(this.btnLanguage);
            this.pnlFinger.Controls.Add(this.lblEmployeeID);
            this.pnlFinger.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlFinger.Location = new System.Drawing.Point(0, 0);
            this.pnlFinger.Name = "pnlFinger";
            this.pnlFinger.Size = new System.Drawing.Size(361, 492);
            this.pnlFinger.TabIndex = 34;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(253, 38);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(53, 30);
            this.btnClear.TabIndex = 199;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblAllPosition
            // 
            this.lblAllPosition.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblAllPosition.Location = new System.Drawing.Point(74, 73);
            this.lblAllPosition.Name = "lblAllPosition";
            this.lblAllPosition.Size = new System.Drawing.Size(214, 25);
            this.lblAllPosition.TabIndex = 143;
            this.lblAllPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAllPosition.Visible = false;
            // 
            // cbAllPosition
            // 
            this.cbAllPosition.AutoSize = true;
            this.cbAllPosition.Checked = true;
            this.cbAllPosition.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAllPosition.Location = new System.Drawing.Point(312, 77);
            this.cbAllPosition.Name = "cbAllPosition";
            this.cbAllPosition.Size = new System.Drawing.Size(41, 21);
            this.cbAllPosition.TabIndex = 142;
            this.cbAllPosition.Text = "All";
            this.cbAllPosition.UseVisualStyleBackColor = true;
            this.cbAllPosition.CheckedChanged += new System.EventHandler(this.cbAllPosition_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 141;
            this.label2.Text = "ตำแหน่ง";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbPosition
            // 
            this.cmbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Items.AddRange(new object[] {
            "2021",
            "2022",
            "2023"});
            this.cmbPosition.Location = new System.Drawing.Point(77, 73);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(229, 25);
            this.cmbPosition.TabIndex = 140;
            this.cmbPosition.SelectedIndexChanged += new System.EventHandler(this.cmbPosition_SelectedIndexChanged);
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(77, 42);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(170, 25);
            this.txtEmpName.TabIndex = 138;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 137;
            this.label3.Text = "ชื่อ/ชื่อเล่น";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAllCompany
            // 
            this.lblAllCompany.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblAllCompany.Location = new System.Drawing.Point(74, 11);
            this.lblAllCompany.Name = "lblAllCompany";
            this.lblAllCompany.Size = new System.Drawing.Size(214, 25);
            this.lblAllCompany.TabIndex = 136;
            this.lblAllCompany.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAllCompany.Visible = false;
            // 
            // cbAllCompany
            // 
            this.cbAllCompany.AutoSize = true;
            this.cbAllCompany.Location = new System.Drawing.Point(312, 13);
            this.cbAllCompany.Name = "cbAllCompany";
            this.cbAllCompany.Size = new System.Drawing.Size(41, 21);
            this.cbAllCompany.TabIndex = 135;
            this.cbAllCompany.Text = "All";
            this.cbAllCompany.UseVisualStyleBackColor = true;
            this.cbAllCompany.Visible = false;
            this.cbAllCompany.CheckedChanged += new System.EventHandler(this.cbAllCompany_CheckedChanged);
            // 
            // cmb_Company
            // 
            this.cmb_Company.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Company.Enabled = false;
            this.cmb_Company.FormattingEnabled = true;
            this.cmb_Company.Items.AddRange(new object[] {
            "2021",
            "2022",
            "2023"});
            this.cmb_Company.Location = new System.Drawing.Point(77, 11);
            this.cmb_Company.Name = "cmb_Company";
            this.cmb_Company.Size = new System.Drawing.Size(229, 25);
            this.cmb_Company.TabIndex = 133;
            this.cmb_Company.SelectedIndexChanged += new System.EventHandler(this.cmb_Company_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 30;
            this.label1.Text = "บริษัท";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmployeeID.Location = new System.Drawing.Point(83, 460);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(46, 22);
            this.lblEmployeeID.TabIndex = 9;
            this.lblEmployeeID.Visible = false;
            // 
            // pnlCompany
            // 
            this.pnlCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.pnlCompany.Controls.Add(this.lblShowOpenOrClose);
            this.pnlCompany.Controls.Add(this.cmbCompany);
            this.pnlCompany.Location = new System.Drawing.Point(0, 0);
            this.pnlCompany.Name = "pnlCompany";
            this.pnlCompany.Size = new System.Drawing.Size(993, 31);
            this.pnlCompany.TabIndex = 140;
            // 
            // lblShowOpenOrClose
            // 
            this.lblShowOpenOrClose.BackColor = System.Drawing.Color.Transparent;
            this.lblShowOpenOrClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblShowOpenOrClose.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowOpenOrClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(56)))), ((int)(((byte)(37)))));
            this.lblShowOpenOrClose.Location = new System.Drawing.Point(331, 1);
            this.lblShowOpenOrClose.Name = "lblShowOpenOrClose";
            this.lblShowOpenOrClose.Size = new System.Drawing.Size(276, 29);
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
            // timeDisplay
            // 
            this.timeDisplay.Interval = 1000;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSearch.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSearch.BorderRadius = 15;
            this.btnSearch.BorderSize = 0;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(95, 104);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 31);
            this.btnSearch.TabIndex = 134;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextColor = System.Drawing.Color.White;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSetting.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSetting.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSetting.BorderRadius = 15;
            this.btnSetting.BorderSize = 0;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.Location = new System.Drawing.Point(3, 417);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(74, 31);
            this.btnSetting.TabIndex = 39;
            this.btnSetting.Text = "Setting";
            this.btnSetting.TextColor = System.Drawing.Color.White;
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Visible = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnLanguage
            // 
            this.btnLanguage.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLanguage.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLanguage.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLanguage.BorderRadius = 15;
            this.btnLanguage.BorderSize = 0;
            this.btnLanguage.FlatAppearance.BorderSize = 0;
            this.btnLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLanguage.ForeColor = System.Drawing.Color.White;
            this.btnLanguage.Location = new System.Drawing.Point(3, 454);
            this.btnLanguage.Name = "btnLanguage";
            this.btnLanguage.Size = new System.Drawing.Size(74, 31);
            this.btnLanguage.TabIndex = 38;
            this.btnLanguage.Text = "TH/EN";
            this.btnLanguage.TextColor = System.Drawing.Color.White;
            this.btnLanguage.UseVisualStyleBackColor = false;
            this.btnLanguage.Visible = false;
            this.btnLanguage.Click += new System.EventHandler(this.btnLanguage_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(794, 492);
            this.Controls.Add(this.pnlDisplayEmpWork_BG);
            this.Controls.Add(this.pnlFinger);
            this.Controls.Add(this.grvCompanyTimeCondition);
            this.Controls.Add(this.grvEmployeeWorkTimePeriod);
            this.Controls.Add(this.grvWorkTimePeriod);
            this.Controls.Add(this.grvCountEmployee);
            this.Controls.Add(this.pnlCompany);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.grvEmpWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvWorkTimePeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvEmployeeWorkTimePeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCompanyTimeCondition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCountEmployee)).EndInit();
            this.pnlDisplayEmpWork_BG.ResumeLayout(false);
            this.pnlDisplayEmpWork.ResumeLayout(false);
            this.pnlFinger.ResumeLayout(false);
            this.pnlFinger.PerformLayout();
            this.pnlCompany.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timeEmpWork;
        private System.Windows.Forms.DataGridView grvEmpWork;
        private System.Windows.Forms.Label lblDisplayText;
        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.DataGridView grvWorkTimePeriod;
        private System.Windows.Forms.DataGridView grvEmployeeWorkTimePeriod;
        private System.Windows.Forms.DataGridView grvCompanyTimeCondition;
        private System.Windows.Forms.DataGridView grvCountEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompanyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalEmp;
        private System.Windows.Forms.Panel pnlDisplayEmpWork_BG;
        private System.Windows.Forms.Panel pnlFinger;
        private System.Windows.Forms.Panel pnlCompany;
        private System.Windows.Forms.Label lblShowOpenOrClose;
        public System.Windows.Forms.ComboBox cmbCompany;
        private System.Windows.Forms.Panel pnlDisplayEmpWork;
        private System.Windows.Forms.Timer timeDisplay;
        private Class.RJButton btnLanguage;
        private System.Windows.Forms.Label lblEmployeeID;
        private Class.RJButton btnSetting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Company;
        private Class.RJButton btnSearch;
        private System.Windows.Forms.CheckBox cbAllCompany;
        private System.Windows.Forms.Label lblAllCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRV_COL_EMPLOYEE_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRV_COL_EMPLOYEE_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRV_COL_EMPLOYEE_SURNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRV_COL_NICKNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRV_COL_POSITION;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkKPIScore;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.CheckBox cbAllPosition;
        private System.Windows.Forms.Label lblAllPosition;
        private System.Windows.Forms.Button btnClear;
    }
}

