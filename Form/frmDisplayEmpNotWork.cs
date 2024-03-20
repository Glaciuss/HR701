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
    public partial class frmDisplayEmpNotWork : Form
    {
        public string selectCompanyID { get; set; }
        string currentCompanyID = "";
        public frmDisplayEmpNotWork()
        {
            InitializeComponent();
        }

        private void frmDisplayEmpNotWork_Load(object sender, EventArgs e)
        {
            //this.Text = "ไม่มาทำงาน";
            Database.Connect();
            //DataTable dtCompany = Database.GetData("SELECT CompanyID,CompanyName FROM Company WHERE CompanyStatus=1", 10);
            //if (dtCompany.Rows.Count > 0)
            //{
            //    cmbCompany.DisplayMember = "CompanyName";
            //    cmbCompany.ValueMember = "CompanyID";
            //    cmbCompany.DataSource = dtCompany;
            //}
            //else
            //{
            //    cmbCompany.DataSource = null;
            //}
            //cmbCompany.SelectedValue = Program.DefaultCompanyID;

            //Utility.displayRowNo(grvEmpNotComeToday);
            //grvEmpNotComeToday.ClearSelection();
            if (selectCompanyID == null)
            {
                currentCompanyID = Program.DefaultCompanyID;
            }
            else { currentCompanyID = selectCompanyID; }

            DataGridView g = grvEmpNotComeToday;
            g.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14.25F, GraphicsUnit.Pixel);
            foreach (DataGridViewColumn c in g.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Segoe UI", 14.25F, GraphicsUnit.Pixel);
            }
            g.RowHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14.25F, GraphicsUnit.Pixel);

            g.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            g.RowHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14.25F, GraphicsUnit.Pixel);
            g.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14.25F, GraphicsUnit.Pixel);
            g.ClearSelection();
        }
        private void frmDisplayEmpNotWork_Shown(object sender, EventArgs e)
        {
            DisplayEmpNotWork(currentCompanyID);           
            Utility.displayRowNo(grvEmpNotComeToday);
        }
        private void DisplayEmpNotWork(string companyID)
        {
            try
            {
                Database.Connect();                

                string sqlNotWork = "usp_EM100_15 '" + companyID + "' ,'" + Utility.SQLDateString(DateTime.Now) + "'";
                DataGridView g = grvEmpNotComeToday;
               
                //if (g.Rows.Count > 0) { g.Rows.Clear(); g.ClearSelection(); }
                
                DataTable dtNotWork = Database.GetData(sqlNotWork, 10);
                if (dtNotWork.Rows.Count == 0) { g.DataSource = null; return; }
                g.AutoGenerateColumns = false;
                g.DataSource = dtNotWork;
                g.Columns["colEmpName"].DataPropertyName = "EmployeeName";
                g.Columns["colSurname"].DataPropertyName = "EmployeeSurname";
                g.Columns["colNickname"].DataPropertyName = "NickName";
                g.Columns["colPositionName"].DataPropertyName = "PositionName";
                g.Columns["colWorkPeriodName"].DataPropertyName = "WorkTimePeriodName";
                g.Columns["colLeaveTypeName"].DataPropertyName = "LeaveTypeName";
                g.Columns["colWorkDetail"].DataPropertyName = "WorkDetail";
                g.Columns["colEmpApprove"].DataPropertyName = "EmpCheckName";
                g.Columns["colTransactionDate"].DataPropertyName = "TransactionDate";
                                
                //g.Sort(g.Columns["colLeaveTypeIDNotCome"], ListSortDirection.Ascending);
                //g.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14.25F, GraphicsUnit.Pixel);
                //foreach (DataGridViewColumn c in g.Columns)
                //{
                //    c.DefaultCellStyle.Font = new Font("Segoe UI", 14.25F, GraphicsUnit.Pixel);
                //}
                //g.RowHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14.25F, GraphicsUnit.Pixel);

                //g.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                //g.RowHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14.25F, GraphicsUnit.Pixel);
                //g.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14.25F, GraphicsUnit.Pixel);
                g.ClearSelection();
                Utility.displayRowNo(grvEmpNotComeToday);
            }
            catch
            {
                grvEmpNotComeToday.DataSource = null;
            }
            finally
            {
                Database.Close();
            }
        }

       

        //private void cmbCompany_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cmbCompany.SelectedValue == null) { return; }
        //    DisplayEmpNotWork(cmbCompany.SelectedValue.ToString());
        //}

        private void grvEmpNotComeToday_Sorted(object sender, EventArgs e)
        {
            Utility.displayRowNo(grvEmpNotComeToday);
        }
        //private void ShowEmpNotWorkToday(string strCompanyID)  /*Show employee not come today*/
        //{
        //    DataGridView gAll = grvEmpWorkTimeAllBranch;
        //    DataGridView gNotWork = grvEmpNotComeToday;
        //    if (gNotWork.Rows.Count > 0) gNotWork.Rows.Clear();

        //    if (lblWorkTimeType.Text == "Normal")
        //    {
        //        gNotWork.Columns["colPeriodNameNotCome"].Visible = false;
        //    }
        //    else if (lblWorkTimeType.Text == "Shift")
        //    {
        //        gNotWork.Columns["colPeriodNameNotCome"].Visible = true;
        //    }
        //    if (gAll.Rows.Count > 0)
        //    {
        //        foreach (DataGridViewRow gAllRow in gAll.Rows)
        //        {
        //            if (gAllRow.Cells["EmpCompanyID"].Value.ToString() == strCompanyID && gAllRow.Cells["EmpIsComeID"].Value.ToString() == "1")
        //            {
        //                int i = gNotWork.Rows.Add();
        //                DataGridViewRow gNotRow = gNotWork.Rows[i];
        //                gNotRow.Cells["colEmpIDNotCome"].Value = gAllRow.Cells["EmployeeID"].Value.ToString();
        //                gNotRow.Cells["colEmpNameNotCome"].Value = gAllRow.Cells["EmployeeName"].Value.ToString();
        //                gNotRow.Cells["colEmpSurnameNotCome"].Value = gAllRow.Cells["EmployeeSurname"].Value.ToString();
        //                gNotRow.Cells["colNicknameNotCome"].Value = gAllRow.Cells["Nickname"].Value.ToString();
        //                gNotRow.Cells["colPositionNameNotCome"].Value = gAllRow.Cells["PositionName"].Value.ToString();
        //                gNotRow.Cells["colPeriodNameNotCome"].Value = gAllRow.Cells["WorkTimePeriodName"].Value.ToString();
        //                gNotRow.Cells["colEmpIsComeIDNotCome"].Value = gAllRow.Cells["EmpIsComeID"].Value.ToString();
        //                gNotRow.Cells["colLeaveTypeIDNotCome"].Value = gAllRow.Cells["LeaveTypeID"].Value.ToString();
        //                gNotRow.Cells["colLeaveTypeName"].Value = gAllRow.Cells["LeaveTypeName"].Value.ToString();
        //                gNotRow.Cells["colNotComeDetail"].Value = gAllRow.Cells["WorkDetail"].Value.ToString();

        //                if (gAllRow.Cells["EmpCheckName"].Value.ToString() == string.Empty)
        //                {
        //                    gNotRow.Cells["colNotComeEmpApprove"].Value = "-";
        //                }
        //                else
        //                {
        //                    gNotRow.Cells["colNotComeEmpApprove"].Value = gAllRow.Cells["EmpCheckName"].Value.ToString();
        //                }

        //                if (gAllRow.Cells["TransactionDate"].Value == null || gAllRow.Cells["TransactionDate"].Value == DBNull.Value)
        //                {
        //                    gNotRow.Cells["colNotComeTransactionDate"].Value = "-";
        //                }
        //                else
        //                {
        //                    gNotRow.Cells["colNotComeTransactionDate"].Value = Convert.ToDateTime(gAllRow.Cells["TransactionDate"].Value).ToString("dd/MM/yyyy HH:mm:ss");
        //                }

        //                //gNotWork.Rows[i].Cells["colNotComeShowTransactionDate"].Value = gAllRow.Cells["showTransacTionDate"].Value.ToString(); 
        //                gNotRow.HeaderCell.Value = string.Format("{0}", gNotRow.Index + 1);
        //            }
        //        }
        //        gNotWork.Sort(gNotWork.Columns["colLeaveTypeIDNotCome"], ListSortDirection.Ascending);

        //        //Utility.displayRowNo(gNotWork);
        //        gNotWork.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14.25F, GraphicsUnit.Pixel);
        //        foreach (DataGridViewColumn c in gNotWork.Columns)
        //        {
        //            c.DefaultCellStyle.Font = new Font("Segoe UI", 14.25F, GraphicsUnit.Pixel);
        //        }
        //        gNotWork.RowHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14.25F, GraphicsUnit.Pixel);

        //        gNotWork.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        //        gNotWork.ClearSelection();
        //        //if (gNotWork.RowCount > 0)
        //        //{
        //        //    lblTotalNotComeToday.Text = "ไม่มาทำงาน (" + gNotWork.RowCount.ToString() + ")";
        //        //}
        //        //else
        //        //{
        //        //    lblTotalNotComeToday.Text = "ไม่มาทำงาน";
        //        //}
        //    }
        //    else
        //    {
        //        gNotWork.Rows.Clear();
        //       // lblTotalNotComeToday.Text = "ไม่มาทำงาน";
        //    }
        //}
    }
}
