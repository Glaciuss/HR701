using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;
using DatabaseClassLibrary;
using cllUtility;
using System.Runtime.InteropServices;
using System.Media;

//using System.Threading.Tasks;
using System.Collections;

namespace CarService
{
    public partial class frmMain : Form
    {

        string company_work_time_type = ""; //Normal,Shift

        string language = Program.Language;
        private string defaultCompanyID = Program.DefaultCompanyID;
        Cursor cdefault = Cursors.Default;
        Cursor cwait = Cursors.WaitCursor;
        DateTime localDate = DateTime.Now;
        //DateTime nowDateTime;
        String[] cultureNames = { "th-TH" };
        int cnt_company = 0;
        string semi = "'";
        string server = Database.vServer;
        string db = Database.vCatalog;
        string usr = Database.vUsername;
        string pass = Database.vPassword;

        string CompanyID = Program.CompanyID;

        string connetionString;
        string anyDeptID = "any(select DeptID from Employee)";
        string anyCompany = "any(select BranchID from Employee)";
        string anyEmp = "any(select EmployeeName from Employee)";


        #region Warning_Sound

        private void clearEmpData()
        {
            lblEmployeeID.Text = "";
        }
        #endregion
        #region Display Language
        #endregion

        public frmMain()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            this.BringToFront();
            this.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomizeTheme();
        }
        private void CustomizeTheme()
        {
            language = Program.Language;
            DataGridView g = grvEmpWork;
            g.Dock = DockStyle.Fill;
            g.RowHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14.25F, GraphicsUnit.Pixel);
            g.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14.25F, GraphicsUnit.Pixel);
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Text = Program.ProgramName;
            lblDisplayText.Visible = false;
            connetionString = @"Data Source=" + server + ";Initial Catalog=" + db + ";User ID=" + usr + ";Password=" + pass + ";MultipleActiveResultSets=true";
        }
        private void frmMain_Shown(object sender, EventArgs e)
        {
            SelectCompany();
            CheckPosition();
            cmb_Company.SelectedValue = Program.CompanyID;

            cmb_Company.Enabled = false;

            //check enable select company
            if (Program.UserGroup.Equals("SYS-ADMIN") || Program.UserGroup.Equals("DIRECTOR"))
            {
                if (Program.HR_SelectCompany.Equals("True"))
                {
                    cmb_Company.Enabled = true;
                }
            }

            SelectPosition();
            DisplayEmp(anyEmp,cmb_Company.SelectedValue.ToString(), anyDeptID, true);
            format_empwork();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Database.Close();
        }

        private void grvEmpWork_Leave(object sender, EventArgs e)
        {
            grvEmpWork.ClearSelection();
        }

        private void cmbCompany_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grvEmpWork_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowSelect = e.RowIndex;
            if (rowSelect < 0) { return; }
            DataGridViewRow gRow = grvEmpWork.Rows[rowSelect];
            if (gRow.Cells["GRV_COL_EMPLOYEE_ID"].Value.ToString() != "0")
            {
                frmSetting f = new frmSetting();
                string empid = gRow.Cells["GRV_COL_EMPLOYEE_ID"].Value.ToString();
                string empname = gRow.Cells["GRV_COL_EMPLOYEE_NAME"].Value.ToString() + " ";
                empname += gRow.Cells["GRV_COL_EMPLOYEE_SURNAME"].Value.ToString() + " (";
                empname += gRow.Cells["GRV_COL_NICKNAME"].Value.ToString() + ")";
                f.loadSet(empid,empname);
                if (f.ShowDialog(this) == DialogResult.OK)
                {

                }
                else
                {
                }
            }
        }

        private void btnLanguage_Click(object sender, EventArgs e)
        {
            language = (language == "TH" ? "EN" : "TH");
        }

        private void grvEmpWork_Sorted(object sender, EventArgs e)
        {
            format_empwork();
            Utility.displayRowNo(grvEmpWork);
        }

        private void format_empwork()
        {
            DataGridView g = grvEmpWork;
            int i = 0;
            int totalEmpWork = 0, totalNotWork = 0;

            foreach (DataGridViewRow gRow in g.Rows)
            {
                gRow.HeaderCell.Value = string.Format("{0}", i + 1);
                i += 1;
            }
            g.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            if (cnt_company > 1)
            {
                g.Columns["GRV_COL_EMPLOYEE_NAME"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                g.Columns["GRV_COL_EMPLOYEE_SURNAME"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                g.Columns["GRV_COL_NICKNAME"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                g.Columns["GRV_COL_POSITION"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            else
            {
                g.Columns["GRV_COL_EMPLOYEE_NAME"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                g.Columns["GRV_COL_EMPLOYEE_SURNAME"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                g.Columns["GRV_COL_NICKNAME"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                g.Columns["GRV_COL_POSITION"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            g.ClearSelection();
        }

        private void DisplayEmp(string EmpName,string CompanyID,string PositionID, bool score)
        {
            Cursor = Cursors.WaitCursor;
            DataGridView g = grvEmpWork; 
            g.DataSource = null;
            Database.Connect();

            string sqlCount = "select e.EmployeeID,";
            sqlCount += " e.EmployeeName,";
            sqlCount += " e.EmployeeSurname,";
            sqlCount += " e.NickName,";
            sqlCount += " e.EmpStatusID,";
            sqlCount += " ps.PositionName ";
            sqlCount += " from Employee e ";
            sqlCount += " INNER JOIN Position ps ON e.DeptID=ps.DeptID AND e.PositionID=ps.PositionID ";
            sqlCount += " where e.EmpStatusID = '0'";
            sqlCount += " and (e.EmployeeName = " + EmpName + " or e.NickName = " + EmpName + ")";
            sqlCount += " and e.BranchID = " + CompanyID;
            sqlCount += " and e.DeptID = " + PositionID;
            sqlCount += " order by EmployeeID";

            DataTable dtWork = Database.GetData(sqlCount, 15);

            //Fixed Column
            if (dtWork.Rows.Count > 0 && score == true)
            {
                g.AutoGenerateColumns = false;
                g.DataSource = dtWork;

                g.Columns["GRV_COL_EMPLOYEE_ID"].DataPropertyName = "EmployeeID";
                g.Columns["GRV_COL_EMPLOYEE_NAME"].DataPropertyName = "EmployeeName";
                g.Columns["GRV_COL_EMPLOYEE_SURNAME"].DataPropertyName = "EmployeeSurname";
                g.Columns["GRV_COL_NICKNAME"].DataPropertyName = "NickName";
                g.Columns["GRV_COL_POSITION"].DataPropertyName = "PositionName";
                g.Columns["WorkKPIScore"].DataPropertyName = "EmpStatusID";
            }
            Database.Close();

            //for (int i = 0; i < dtWork.Rows.Count; i++)
            //{
            //    frmSetting f = new frmSetting();
            //    f.calWork(dtWork.Rows[i]["EmployeeID"].ToString());
            //}

            //else if (dtWork.Rows.Count > 0 && score == false)
            //{
            //    g.AutoGenerateColumns = false;
            //    g.DataSource = dtWork;

            //    g.Columns["GRV_COL_EMPLOYEE_ID"].DataPropertyName = "EmployeeID";
            //    g.Columns["GRV_COL_EMPLOYEE_NAME"].DataPropertyName = "EmployeeName";
            //    g.Columns["GRV_COL_EMPLOYEE_SURNAME"].DataPropertyName = "EmployeeSurname";
            //    g.Columns["GRV_COL_NICKNAME"].DataPropertyName = "NickName";
            //    g.Columns["GRV_COL_POSITION"].DataPropertyName = "PositionName";
            //}

            //Database.Close();
            Cursor = Cursors.Default;
        }
        
        private void btnSetting_Click(object sender, EventArgs e)
        {
            bool confirm_result = false;
            frmShowMessage f = new frmShowMessage();
            if (f.ShowDialog(this) == DialogResult.OK)
            {
                confirm_result = true;
            }
            else 
            { 
                confirm_result = false; 
                clearEmpData(); 
            }
        }

        public void btnSearch_Click(object sender, EventArgs e)
        {
            string EmpName;
            if (txtEmpName.Text == "")
            {
                EmpName = anyEmp;
            }
            else
            {
                EmpName = "'" + txtEmpName.Text + "'";
            }

            string DeptID;

            if (cmbPosition.SelectedIndex == -1)
            {
                DeptID = anyDeptID;
            }
            else
            {
                DeptID = cmbPosition.SelectedValue.ToString();
            }

            if (cbAllCompany.Checked == true && cbAllPosition.Checked == true)
            {
                DisplayEmp(EmpName,anyCompany, anyDeptID, true);
            }
            else if (cbAllCompany.Checked == true && cbAllPosition.Checked == false)
            {
                DisplayEmp(EmpName,anyCompany, DeptID, true);
            }
            else if (cbAllCompany.Checked == false && cbAllPosition.Checked == true)
            {
                DisplayEmp(EmpName,cmb_Company.SelectedValue.ToString(), anyDeptID, true);
            }
            else if(cbAllCompany.Checked == false && cbAllPosition.Checked == false)
            {
                DisplayEmp(EmpName,cmb_Company.SelectedValue.ToString(), DeptID, true);
            }

            format_empwork();
        }

        private void SelectCompany()
        {
            Database.Connect();
            DataTable dtEd = Database.GetData("SELECT * FROM Company", 10);
            cmb_Company.DisplayMember = "CompanyFullName";
            cmb_Company.ValueMember = "CompanyID";
            cmb_Company.DataSource = dtEd;
            Database.Close();
        }
        private void SelectPosition()
        {
            Database.Connect();
            DataTable dtEd = Database.GetData("SELECT * FROM Position", 10);
            cmbPosition.DisplayMember = "PositionName";
            cmbPosition.ValueMember = "DeptID";
            cmbPosition.DataSource = dtEd;
            Database.Close();

            cmbPosition.SelectedIndex = -1;
        }

        private void cbAllCompany_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAllCompany.Checked == true)
            {
                lblAllCompany.Visible = true;
                lblAllCompany.Text = "ทุกสาขา";
                cmb_Company.Enabled = false;
            }
            else
            {
                lblAllCompany.Visible = false;
                cmb_Company.Enabled = true;
            }
        }

        private void cbAllPosition_CheckedChanged(object sender, EventArgs e)
        {
            CheckPosition();
            btnSearch_Click(null, new EventArgs());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmpName.Text = "";
        }

        private void cmb_Company_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSearch_Click(null, new EventArgs());
        }

        private void CheckPosition()
        {
            if (cbAllPosition.Checked == true)
            {
                lblAllPosition.Visible = true;
                lblAllPosition.Text = "ทุกตำแหน่ง";
                cmbPosition.Enabled = false;
            }
            else
            {
                lblAllPosition.Visible = false;
                cmbPosition.Enabled = true;
            }
        }

        private void cmbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSearch_Click(null, new EventArgs());
        }
    }    
}



