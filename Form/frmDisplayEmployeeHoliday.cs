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
    public partial class frmDisplayEmployeeHoliday : Form
    {
        public string selectCompanyID { get; set; }
        public frmDisplayEmployeeHoliday()
        {
            InitializeComponent();
        }

        private void frmDisplayEmployeeHoliday_Load(object sender, EventArgs e)
        {
            Database.Connect();
            DataTable dtHoliday = Database.GetData("usp_EM100_04", 10);
            if (dtHoliday.Rows.Count > 0)
            {
                grvEmpHolidayAllBranch.DataSource = dtHoliday;
            }
            else
            {
                grvEmpHolidayAllBranch.DataSource = null;
            }

            DisplayEmployeeHoliday(Program.DefaultCompanyID);
        }
        private void frmDisplayEmployeeHoliday_Shown(object sender, EventArgs e)
        {

        }
        private void DisplayEmployeeHoliday(string companyID)
        {
            try
            {

                DataGridView gAll = grvEmpHolidayAllBranch;
                DataGridView gEmpHoliday = grvEmployeeHoliday;
                if (gEmpHoliday.Rows.Count > 0) gEmpHoliday.Rows.Clear();
                //Utility.ClearTextBoxInGroupBox(grvEmployeeHoliday);

                foreach (DataGridViewRow gAllRow in gAll.Rows)
                {

                    if (gAllRow.Cells["BranchID"].Value.ToString() == companyID)
                    {
                        int i = gEmpHoliday.Rows.Add();
                        DataGridViewRow gRow = gEmpHoliday.Rows[i];
                        //gEmpHoliday.Rows[i].Cells["colEmployeeID"].Value = gAllRow.Cells["EmployeeID"].Value.ToString();
                        gRow.Cells["colEmpName"].Value = gAllRow.Cells["EmployeeName"].Value.ToString();
                        gRow.Cells["colSurname"].Value = gAllRow.Cells["EmployeeSurname"].Value.ToString();
                        gRow.Cells["colNickname"].Value = gAllRow.Cells["NickName"].Value.ToString();
                        gRow.Cells["colPositionName"].Value = gAllRow.Cells["PositionName"].Value.ToString();
                        gRow.Cells["colEmpHolidayDetail"].Value = gAllRow.Cells["showEmpHolidayDetail"].Value.ToString();
                    }
                }

                gEmpHoliday.ClearSelection();
                Utility.displayRowNo(gEmpHoliday);
                gEmpHoliday.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14.25F, GraphicsUnit.Pixel);
                gEmpHoliday.RowHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14.25F, GraphicsUnit.Pixel);

                foreach (DataGridViewColumn c in gEmpHoliday.Columns)
                {
                    c.DefaultCellStyle.Font = new Font("Segoe UI", 14.25F, GraphicsUnit.Pixel);
                }
                gEmpHoliday.ClearSelection();
                gEmpHoliday.CurrentCell = null;
            }
            catch (Exception ex)
            {
                grvEmployeeHoliday.Rows.Clear();
                MessageBox.Show("แสดงรายชื่อพนักงานที่มีวันหยุดวันนี้ " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Database.Close();
            }

        }

      
    }
}
