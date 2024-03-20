using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DatabaseClassLibrary;
using cllUtility;

namespace CarService
{
    public partial class frmDisplayAdvNotWork : Form
    {
        //public string selectCompanyID { get; set; }
        //string currentCompanyID = "";
        public frmDisplayAdvNotWork()
        {
            InitializeComponent();
            CustomizeTheme();
        }
        private void CustomizeTheme()
        {
            this.pnlCompany.BackColor = SbuysColors.BG_Minor;
           
            grvEmpEarlyLeave.ColumnHeadersDefaultCellStyle.BackColor = SbuysColors.Main;
            grvEmpEarlyLeave.ColumnHeadersDefaultCellStyle.ForeColor = SbuysColors.Text_Main;
        }

        private void frmDisplayAdvNotWork_Load(object sender, EventArgs e)
        {
            this.Text = "ลาล่วงหน้า";
            Database.Connect();
            DataTable dtCompany = Database.GetData("SELECT CompanyID,CompanyName FROM Company WHERE CompanyStatus=1", 10);
            if (dtCompany.Rows.Count > 0)
            {
                cmbCompany.DisplayMember = "CompanyName";
                cmbCompany.ValueMember = "CompanyID";
                cmbCompany.DataSource = dtCompany;
            }
            else
            {
                cmbCompany.DataSource = null;
            }
            cmbCompany.SelectedValue = Program.DefaultCompanyID;
            //if (selectCompanyID == null)
            //{
            //    currentCompanyID = Program.DefaultCompanyID;
            //}
            //else { currentCompanyID = selectCompanyID; }
            DataGridView g = grvEmpEarlyLeave;
            g.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14.25F, GraphicsUnit.Pixel);           
            g.RowHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14.25F, GraphicsUnit.Pixel);
            g.DefaultCellStyle.Font = new Font("Segoe UI", 14.25F, GraphicsUnit.Pixel);       
            g.ClearSelection();
        }

        private void frmDisplayAdvNotWork_Shown(object sender, EventArgs e)
        {
            DisplayEmpEarlyLeave(Program.DefaultCompanyID);           
            Utility.displayRowNo(grvEmpEarlyLeave);
        }

        private void DisplayEmpEarlyLeave(string companyID)
        {
            DataGridView g = grvEmpEarlyLeave;
            if (g.Rows.Count > 0) g.Rows.Clear();
            try
            {
                Database.Connect();

                DataTable dt = Database.GetData("usp_EM100_03 '" + companyID + "'");

                if (dt.Rows.Count == 0) { return; }

                foreach (DataRow dr in dt.Rows)
                {
                    int i = g.Rows.Add();
                    DataGridViewRow gRow = g.Rows[i];
                    gRow.Cells["colEarlyEmpID"].Value = dr["EmployeeID"].ToString();
                    gRow.Cells["colEarlyWorkDate"].Value = dr["WorkDate"].ToString();
                    gRow.Cells["colEarlyDate"].Value = dr["ShowWorkDate"].ToString();
                    gRow.Cells["colEarlyDay"].Value = dr["showDayName"].ToString();
                    gRow.Cells["colEarlyEmpName"].Value = dr["EmployeeName"].ToString();
                    gRow.Cells["colEarlyEmpSurname"].Value = dr["EmployeeSurname"].ToString();
                    gRow.Cells["colEarlyNickname"].Value = dr["Nickname"].ToString();
                    gRow.Cells["colEarlyPositionName"].Value = dr["PositionName"].ToString();
                    gRow.Cells["colEarlyLeaveTypeName"].Value = dr["LeaveTypeName"].ToString();
                    gRow.Cells["colEarlyEmpIsComeName"].Value = dr["ShowEmpIsComeName"].ToString();
                    gRow.Cells["colEarlyDetail"].Value = dr["WorkDetail"].ToString();
                    gRow.Cells["colEarlyEmpCheck"].Value = dr["EmpCheckName"].ToString();
                    if (!dr.IsNull("TransactionDate"))
                    {
                        gRow.Cells["colEarlyTransactionDate"].Value = Convert.ToDateTime(dr["TransactionDate"]).ToString("dd/MM/yyyy HH:mm:ss");
                    }
                    else { gRow.Cells["colEarlyTransactionDate"].Value = "-"; }
                    gRow.HeaderCell.Value = string.Format("{0}", i + 1);
                }               
                //g.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14.25F, GraphicsUnit.Pixel);
                ////foreach (DataGridViewColumn c in g.Columns)
                ////{
                ////    c.DefaultCellStyle.Font = new Font("Segoe UI", 14.25F, GraphicsUnit.Pixel);

                ////    if (c.Name == "colEarlyDay")
                ////    {
                ////        c.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                ////    }
                ////}
                //g.RowHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14.25F, GraphicsUnit.Pixel);
                //g.ClearSelection();
             
                //Utility.displayRowNo(grvEmpEarlyLeave);
            
            }
            catch (Exception ex)
            {
                g.Rows.Clear();
                //lblTotalEarlyLeave.Text = "0";
                string msg = "แสดงรายชื่อพนักงานที่ลาล่วงหน้า ";
                MessageBox.Show(msg + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Database.Close();
            }
        }
        //private void cmbCompany_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cmbCompany.SelectedValue == null) { return; }
        //    DisplayEmpEarlyLeave(cmbCompany.SelectedValue.ToString());
        //}

        private void grvEmpEarlyLeave_Sorted(object sender, EventArgs e)
        {
            Utility.displayRowNo(grvEmpEarlyLeave);
        }

        private void cmbCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCompany.SelectedValue == null) { return; }
            DisplayEmpEarlyLeave(cmbCompany.SelectedValue.ToString());
        }
    }
}
