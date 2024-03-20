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
    public partial class frmSelectWorkShift : Form
    {
        public string PeriodID
        {
            get { return this.selectPeriodID; }
        }

        string selectPeriodID = "";
        public frmSelectWorkShift()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            bool isSelect = false;

            DataGridView g = grvWorkTimePeriod;

            foreach (DataGridViewRow gRow in g.Rows)
            {
                DataGridViewCheckBoxCell gChk = (DataGridViewCheckBoxCell)gRow.Cells["colSelect"];
                if (gChk.Value != null)
                {
                    if ((bool)gChk.Value == true)
                    {
                        isSelect = true;
                        break;
                    }
                }
            }
            if (isSelect == false)
            {
                MessageBox.Show("กรุณาเลือกเวลาทำงาน", "Validity Check", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            foreach (DataGridViewRow gRow in g.Rows)
            {
                DataGridViewCheckBoxCell gChk = (DataGridViewCheckBoxCell)gRow.Cells["colSelect"];
                //gChk.Value = false;
                if (gChk.Value != null)
                {
                    if ((bool)gChk.Value == true)
                    {
                        selectPeriodID = gRow.Cells["colWorkTimePeriodID"].Value.ToString();
                    }
                }
            }
            this.DialogResult = DialogResult.OK;
        }

        private void DisplayWorkTimePeriod()
        {
            try
            {
                DataGridView g = grvWorkTimePeriod;
                if (g.Rows.Count > 0) g.Rows.Clear();
                string sql = "SELECT p.WorkTimePeriodID,p.WorkTimePeriodName,p.StartTime,p.EndTime";
                sql += " FROM WorkTimePeriod p INNER JOIN CompanyWorkTimePeriod cp ON";
                sql += " p.WorkTimePeriodID=cp.WorkTimePeriodID";
                sql += " WHERE cp.CompanyID='" + Program.DefaultCompanyID + "'";
                sql += " AND cp.Status='" + "Y" + "'";
                Database.Connect();
                DataTable dt = Database.GetData(sql, 10);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        int row = g.Rows.Add();
                        g.Rows[row].Cells["colWorkTimePeriodID"].Value = dr["WorkTimePeriodID"].ToString();
                        g.Rows[row].Cells["colWorkTimePeriodName"].Value = dr["WorkTimePeriodName"].ToString();
                        g.Rows[row].Cells["colStartTime"].Value = dr["StartTime"].ToString();
                        g.Rows[row].Cells["colEndTime"].Value = dr["EndTime"].ToString();
                    }
                    g.ClearSelection();
                    Utility.displayRowNo(g);
                }
                else
                {
                    g.Rows.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }

        private void frmSelectWorkShift_Load(object sender, EventArgs e)
        {
            DisplayWorkTimePeriod();
        }

        private void grvWorkTimePeriod_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowSelect = e.RowIndex;
            if (rowSelect < 0) { return; }
            DataGridViewRow gRow = grvWorkTimePeriod.Rows[rowSelect];
            DataGridViewCheckBoxCell gChk = (DataGridViewCheckBoxCell)gRow.Cells["colSelect"];
            gChk.Value = !(gChk.Value == null ? false : (bool)gChk.Value);
        }
    }
}

