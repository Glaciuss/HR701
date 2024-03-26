using DatabaseClassLibrary;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace CarService
{
    public partial class frmSetting : Form
    {
        string server = Database.vServer;
        string db = Database.vCatalog;
        string usr = Database.vUsername;
        string pass = Database.vPassword;
        string maxREC;
        string nowREC = "0";
        string Rec_ID_Recall;
        string currentYear = DateTime.Now.Year.ToString();

        public frmSetting()
        {
            InitializeComponent();
        }

        private void frmShowMessage_Load(object sender, EventArgs e)
        {
            SelectYear();
            this.Text = "Setting";
            panel_Line.Visible = false;
        }


        private void btnAddLine_Click(object sender, EventArgs e)
        {
            if (int.Parse(nowREC) >= int.Parse(maxREC))
            {
                MessageBox.Show("จำนวนครั้งเกินจำนวนสูงสุดที่กำหนด");
                return;
            }

            string MinMaxDP = txtNumREC.Text;
            string[] array = MinMaxDP.Split('/');
            decimal min = decimal.Parse(array[0]);
            decimal max = decimal.Parse(array[1]);
            decimal maxInputDP = max - min;//DP max Adjust

            frmAddLine f = new frmAddLine();
            f.Text = "เพิ่มหัวข้อปัญหา " + TXTHDR_DESC.Text;
            f.maxInputDP = maxInputDP;
            string empid = txtEmpID.Text;
            addLine(txtEmpID.Text, f.newMessage, f.newDP, f.newPP1, f.newPP2, f.newPP3);
            f.uponNew(Rec_ID_Recall, empid, cmb_Year.SelectedValue.ToString());

            if (f.ShowDialog() == DialogResult.OK)
            {
                editLine(txtEmpID.Text, f.eid, f.newMessage, f.newDP, f.newPP1, f.newPP2, f.newPP3,f.newDate);
            }
            else
            {
                delLineCall(empid, Rec_ID_Recall);
            }
        }

        private void btnEditLine_Click(object sender, EventArgs e)
        {
            string MinMaxDP = txtNumREC.Text;
            string[] array = MinMaxDP.Split('/');

            editREC(array[0], array[1]);
        }

        private void btnDelLine_Click(object sender, EventArgs e)
        {
            frmDelLine f = new frmDelLine();
            if (grdREC.CurrentRow == null)
            {
                return;
            }
            f.delH(grdREC.SelectedCells[4].Value.ToString(), grdREC.SelectedCells[1].Value.ToString());
            if (f.ShowDialog() == DialogResult.OK)
            {
                delLine(txtEmpID.Text, f.delid);
            }
        }


        private void loadLine(string h)
        {
            Cursor = Cursors.WaitCursor;
            DataGridView l = grdLine;
            grdLine.Columns["KPI_ID"].HeaderText = "ID";
            grdLine.Columns["KPI_DESC"].HeaderText = "Detail";
            grdLine.Columns["VALUE_TYPE"].HeaderText = "Type";
            grdLine.Columns["SETTING_VALUE"].HeaderText = "Value";
            grdLine.Columns["WEIGHT_RATE_LINE"].HeaderText = "Weight(%)";
            grdLine.Columns["MOD_USERID_LINE"].HeaderText = "ModUser";
            grdLine.Columns["MOD_DATETIME_LINE"].HeaderText = "ModDate";

            grdLine.Columns["VALUE_TYPE"].Visible = false;
            grdLine.Columns["SETTING_VALUE"].Visible = false;
            grdLine.Columns["WEIGHT_RATE_LINE"].Visible = false;
            grdLine.Columns["MOD_USERID_LINE"].Visible = false;
            grdLine.Columns["MOD_DATETIME_LINE"].Visible = false;

            grdLine.Columns["SETTING_VALUE"].DefaultCellStyle.Format = "N0";
            grdLine.Columns["SETTING_VALUE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdLine.Columns["WEIGHT_RATE_LINE"].DefaultCellStyle.Format = "N1";
            grdLine.Columns["WEIGHT_RATE_LINE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdLine.Columns["COUNT_DESC"].DefaultCellStyle.Format = "N0";
            l.DataSource = null;
            Database.Connect();

            string sqlL = "select l.HDR_ID,l.KPI_ID,l.KPI_DESC,l.VALUE_TYPE,l.SETTING_VALUE, ";
            sqlL += " l.WEIGHT_RATE,l.MOD_USERID,l.MOD_DATETIME ";
            sqlL += " , (select ISNULL(sum(w.DEDUCT_POINT),0) from WorkKPI_HE_REC w inner join WorkKPI_Line isrec on ";
            sqlL += " w.KPI_ID = isrec.KPI_ID ";
            sqlL += " where w.KPI_ID = l.KPI_ID ";
            sqlL += " and w.EmpID = '" + txtEmpID.Text + "' ";
            sqlL += " and  Year(FAULT_DATETIME) ='" + currentYear + "' ";
            sqlL += " and  DELETE_REC ='" + "0" + "' ";
            sqlL += " ) as SumRecPoint  ";
            sqlL += " from WorkKPI_Line l ";
            sqlL += " left join  WorkKPI_HE_REC rec on rec.KPI_ID = l.KPI_ID ";
            sqlL += " where  l.HDR_ID ='" + h + "' ";
            sqlL += " group by l.HDR_ID,l.KPI_ID,l.KPI_DESC,l.VALUE_TYPE,l.SETTING_VALUE,";
            sqlL += " l.WEIGHT_RATE,l.MOD_USERID,l.MOD_DATETIME ";
            sqlL += " order by KPI_ID";

            DataTable dtL = Database.GetData(sqlL);

            if (dtL.Rows.Count > 0)
            {
                l.AutoGenerateColumns = false;
                l.DataSource = dtL;
                l.Columns["HDR_ID_LINE"].DataPropertyName = "HDR_ID";
                l.Columns["KPI_ID"].DataPropertyName = "KPI_ID";
                l.Columns["KPI_DESC"].DataPropertyName = "KPI_DESC";
                l.Columns["VALUE_TYPE"].DataPropertyName = "VALUE_TYPE";
                l.Columns["SETTING_VALUE"].DataPropertyName = "SETTING_VALUE";
                l.Columns["WEIGHT_RATE_LINE"].DataPropertyName = "WEIGHT_RATE";
                l.Columns["MOD_USERID_LINE"].DataPropertyName = "MOD_USERID";
                l.Columns["MOD_DATETIME_LINE"].DataPropertyName = "MOD_DATETIME";
                l.Columns["COUNT_DESC"].DataPropertyName = "SumRecPoint";
            }
            Database.Close();

            decimal sum = 0;
            for (int i = 0; i < dtL.Rows.Count; i++)
            {
                sum += (decimal.Parse(dtL.Rows[i]["WEIGHT_RATE"].ToString())) * 100;
                decimal mul = (decimal.Parse(dtL.Rows[i]["WEIGHT_RATE"].ToString())) * 100;
                dtL.Rows[i]["WEIGHT_RATE"] = mul.ToString();
                decimal sumRounded = Decimal.Round(sum, 1);
                TXTW_L.Text = sumRounded.ToString() + "%";
            }
            Cursor = Cursors.Default;
        }

        private void addLine(string empid, string message, string dp, string pp1, string pp2, string pp3)
        {
            Database.Connect();
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = Database.vSqlConnection;
            SqlCmd.CommandType = CommandType.Text;

            string newREC_ID = TXTHDR_ID.Text + "000";

            string sqlNextID = "select MAX(REC_ID)+1 from WorkKPI_HE_REC ";
            sqlNextID += "Where KPI_ID = '" + TXTHDR_ID.Text + "'";
            sqlNextID += " and  EmpID ='" + txtEmpID.Text + "' ";
            DataTable dtNextID = Database.GetData(sqlNextID);
            string NextID = dtNextID.Rows[0][0].ToString();

            if (NextID == "")
            {
                int newREC = int.Parse(newREC_ID) + 1;
                NextID = newREC.ToString();
            }

            Rec_ID_Recall = NextID;

            string sqlH = "INSERT INTO WorkKPI_HE_REC(EmpID,REC_ID,HDR_ID,KPI_ID,";
            sqlH += "ERROR_DESC,DEDUCT_POINT,PICTURE_PATH_1,PICTURE_PATH_2,PICTURE_PATH_3,MOD_USERID,MOD_DATETIME) ";
            sqlH += " VALUES('" + empid + "'";
            sqlH += ",'" + NextID + "'";
            sqlH += ",'" + "200" + "'";
            sqlH += ",'" + TXTHDR_ID.Text + "'";
            sqlH += ",'" + message + "'";
            sqlH += ",'" + dp + "'";
            sqlH += ",'" + pp1 + "'";
            sqlH += ",'" + pp2 + "'";
            sqlH += ",'" + pp3 + "'";
            sqlH += ",'" + Program.LoginID + "'";
            sqlH += ", GETDATE()" + ")";

            SqlCmd.CommandText = sqlH;
            SqlCmd.ExecuteNonQuery();
            Database.Close();
            loadREC(TXTHDR_ID.Text);
            calWork("");
            RowSelectMark();
        }

        private void delLine(string empid, string id)
        {
            Database.Connect();
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = Database.vSqlConnection;
            SqlCmd.CommandType = CommandType.Text;

            string sqlL = "UPDATE WorkKPI_HE_REC ";
            sqlL += " SET DELETE_REC = '1'";
            sqlL += ", MOD_USERID = '" + Program.LoginID + "'";
            sqlL += ", MOD_DATETIME = GETDATE() ";
            sqlL += " WHERE REC_ID = '" + id + "'";
            sqlL += " and  EmpID ='" + empid + "' ";

            SqlCmd.CommandText = sqlL;
            SqlCmd.ExecuteNonQuery();
            
            loadREC(TXTHDR_ID.Text);
            calWork("");
            loadLine("200");
            RowSelectMark();
            Database.Close();
        }

        private void delLineCall(string empid, string id)
        {
            Database.Connect();
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = Database.vSqlConnection;
            SqlCmd.CommandType = CommandType.Text;

            string sqlL = "DELETE FROM WorkKPI_HE_REC ";
            sqlL += " WHERE REC_ID = '" + id + "' ";
            sqlL += " and  EmpID ='" + empid + "' ";

            SqlCmd.CommandText = sqlL;
            SqlCmd.ExecuteNonQuery();
            
            loadREC(TXTHDR_ID.Text);
            calWork("");
            loadLine("200");
            RowSelectMark();
            Database.Close();
        }

        private void editLine(string empid, string id, string message, string dp, string pp1, string pp2, string pp3,string eventDate)
        {
            if (message.Contains("'"))
            {
                message = message.Replace("'"," ");
            }

            Database.Connect();
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = Database.vSqlConnection;
            SqlCmd.CommandType = CommandType.Text;

            string sqlL = "UPDATE WorkKPI_HE_REC ";
            sqlL += " SET ERROR_DESC ='" + message + "'";
            sqlL += ", DEDUCT_POINT = '" + dp + "'";
            sqlL += ", PICTURE_PATH_1 = '" + pp1 + "'";
            sqlL += ", PICTURE_PATH_2 = '" + pp2 + "'";
            sqlL += ", PICTURE_PATH_3 = '" + pp3 + "'";
            sqlL += ", FAULT_DATETIME = '" + eventDate + "'";
            sqlL += ", DELETE_REC = '0'";
            sqlL += ", MOD_USERID = '" + Program.LoginID + "'";
            sqlL += ", MOD_DATETIME = GETDATE() ";
            sqlL += " WHERE REC_ID = '" + id + "'";
            sqlL += " and  EmpID ='" + empid + "' ";

            SqlCmd.CommandText = sqlL;
            SqlCmd.ExecuteNonQuery();
            
            loadREC(TXTHDR_ID.Text);
            calWork("");
            loadLine("200");
            RowSelectMark();
            Database.Close();
        }

        public void loadSet(string empid, string title)
        {
            LBL_TITLE.Text = title;
            txtEmpID.Text = empid;
        }

        private void grdLine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            panel_Line.Visible = true;

            TXTHDR_ID.Text = grdLine.SelectedCells[1].Value.ToString();
            TXTHDR_DESC.Text = grdLine.SelectedCells[2].Value.ToString();

            loadREC(TXTHDR_ID.Text);
        }

        private void loadREC(string rec)
        {
            if (grdLine.SelectedRows.Count <= 0) return;

            if (TXTHDR_ID.Text == "201")
            {
                panel_Line.Enabled = false;
                btnAddLine.Visible = false;
                btnEditLine.Visible = false;
                btnDelLine.Visible = false;
                lblDC.Visible = true;
            }
            else if (TXTHDR_ID.Text == "HDR_ID")
            {
                return;
            }
            else
            {
                panel_Line.Enabled = true;
                btnAddLine.Visible = true;
                btnEditLine.Visible = true;
                btnDelLine.Visible = true;
                lblDC.Visible = false;
            }

            Cursor = Cursors.WaitCursor;
            DataGridView l = grdREC;
            grdREC.Columns["REC_ID"].HeaderText = "ID";
            grdREC.Columns["ERROR_DESC"].HeaderText = "Detail";
            grdREC.Columns["DEDUCT_POINT"].HeaderText = "DP";
            grdREC.Columns["PICTURE_PATH_1"].HeaderText = "Pic1";
            grdREC.Columns["PICTURE_PATH_2"].HeaderText = "Pic2";
            grdREC.Columns["PICTURE_PATH_3"].HeaderText = "Pic3";
            grdREC.Columns["MOD_USERID_REC"].HeaderText = "Editor";
            grdREC.Columns["MOD_DATETIME_REC"].HeaderText = "Date";
            grdREC.Columns["FAULT_DATETIME"].HeaderText = "Incident";

            grdREC.Columns["DEDUCT_POINT"].DefaultCellStyle.Format = "N0";
            grdREC.Columns["REC_ID"].Visible = false;

            l.DataSource = null;
            Database.Connect();

            string sqlL = "select *  from WorkKPI_HE_REC ";
            sqlL += " where  KPI_ID ='" + rec + "' ";
            sqlL += " and  EmpID ='" + txtEmpID.Text + "' ";
            sqlL += " and  Year(FAULT_DATETIME) ='" + cmb_Year.SelectedValue.ToString() + "' ";
            if (cbShowDelRow.Checked == false)
            {
                sqlL += " and  DELETE_REC ='" + "0" + "' ";
            }
            sqlL += " order by REC_ID";
            DataTable dtL = Database.GetData(sqlL);

            nowREC = "0";

            if (dtL.Rows.Count > 0)
            {
                l.AutoGenerateColumns = false;
                l.DataSource = dtL;

                l.Columns["DEL_REC"].Visible = false;

                l.Columns["REC_ID"].DataPropertyName = "REC_ID";
                l.Columns["HDR_ID_REC"].DataPropertyName = "HDR_ID";
                l.Columns["KPI_ID_REC"].DataPropertyName = "KPI_ID";
                l.Columns["ERROR_DESC"].DataPropertyName = "ERROR_DESC";
                l.Columns["DEDUCT_POINT"].DataPropertyName = "DEDUCT_POINT";
                l.Columns["PICTURE_PATH_1"].DataPropertyName = "PICTURE_PATH_1";
                l.Columns["PICTURE_PATH_2"].DataPropertyName = "PICTURE_PATH_2";
                l.Columns["PICTURE_PATH_3"].DataPropertyName = "PICTURE_PATH_3";
                l.Columns["DEL_REC"].DataPropertyName = "DELETE_REC";
                l.Columns["MOD_USERID_REC"].DataPropertyName = "MOD_USERID";
                l.Columns["MOD_DATETIME_REC"].DataPropertyName = "MOD_DATETIME";
                l.Columns["FAULT_DATETIME"].DataPropertyName = "FAULT_DATETIME";

                decimal sum = 0;
                for (int i = 0; i < dtL.Rows.Count; i++)
                {
                    
                    if (dtL.Rows[i]["DELETE_REC"].ToString() == "False")
                    {
                        sum += decimal.Parse(dtL.Rows[i]["DEDUCT_POINT"].ToString());
                        decimal sumRounded = Decimal.Round(sum, 0);
                        nowREC = sumRounded.ToString();
                    }
                }
            }
            else nowREC = "0";

            maxREC = (decimal.Parse(grdLine.SelectedCells[4].Value.ToString())).ToString("N0");
            txtNumREC.Text = nowREC + "/" + maxREC;

            grdREC.CurrentCell = null;
            this.grdREC.Sort(this.grdREC.Columns["DEL_REC"], ListSortDirection.Ascending);
            disablegrdREC();
            Database.Close();
            Cursor = Cursors.Default;

            changeTextColor();
        }

        private void SelectYear()
        {
            Database.Connect();
            string sqlYear = "select Year(MOD_DATETIME)as YearSelected from WorkKPI_HE_REC ";
            sqlYear += "group by Year(MOD_DATETIME) order by YearSelected desc";
            DataTable dtEd = Database.GetData(sqlYear);

            string sqlYearMin = "select min(Year(MOD_DATETIME)) - 1 as YearSelected from WorkKPI_HE_REC ";
            DataTable dtYMin = Database.GetData(sqlYearMin);
            string YearMin = dtYMin.Rows[0]["YearSelected"].ToString();

            if (YearMin == "")
            {
                currentYear = DateTime.Now.Year.ToString();
                YearMin = currentYear;
            }

            DataRow toInsert = dtEd.NewRow();
            toInsert[0] = YearMin;
            dtEd.Rows.InsertAt(toInsert, 0);
            cmb_Year.DisplayMember = "YearSelected";
            cmb_Year.ValueMember = "YearSelected";
            cmb_Year.DataSource = dtEd;
            Database.Close();

            cmb_Year.SelectedValue = DateTime.Now.Year.ToString();
        }

        public void calWork(string empID)
        {
            frmMain f = new frmMain();
            Database.Connect();

            string sqlL = "select *  from WorkKPI_Line ";
            sqlL += " where  HDR_ID ='" + "200" + "' ";
            sqlL += " order by KPI_ID";
            DataTable dtL = Database.GetData(sqlL);

            decimal sumV = 0;
            decimal sumScore = 0;

            if (dtL.Rows.Count > 0)
            {
                for (int i = 0; i < dtL.Rows.Count; i++)
                {
                    string kpi_id = dtL.Rows[i]["KPI_ID"].ToString();

                    string sqlRec = "select *  from WorkKPI_HE_REC ";
                    if (empID != "")
                    {
                        sqlRec += " where  EmpID ='" + empID + "' ";
                    }
                    else if (empID == "")
                    {
                        sqlRec += " where  EmpID ='" + txtEmpID.Text + "' ";
                    }
                    sqlRec += " and  KPI_ID ='" + kpi_id + "' ";
                    sqlRec += " and  Year(FAULT_DATETIME) ='" + cmb_Year.Text + "' ";
                    DataTable dtRec = Database.GetData(sqlRec);
                    if (dtRec.Rows.Count > 0)
                    {
                        for (int value_kpi = 0; value_kpi < dtRec.Rows.Count; value_kpi++)
                        {
                            if (dtRec.Rows[value_kpi]["DELETE_REC"].ToString() == "False")
                            {
                                sumV += decimal.Parse(dtRec.Rows[value_kpi]["DEDUCT_POINT"].ToString());
                            }
                        }
                    }

                    decimal v = decimal.Parse(dtL.Rows[i]["SETTING_VALUE"].ToString());
                    
                    decimal Ical;
                    if (v == 0) Ical = 0;
                    else Ical = ((v - sumV) / v) * 100;
                    sumV = 0;//Reset Score
                    decimal w = decimal.Parse(dtL.Rows[i]["WEIGHT_RATE"].ToString());
                    decimal IIcal = Ical * w;
                    sumScore += IIcal;
                }
                txtScore.Text = sumScore.ToString("N2");
            }
            else
            {
                txtScore.Text = "100";
            }
            Database.Close();
        }

        private void cmb_Year_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_Year.SelectedValue != null)
            {
                currentYear = cmb_Year.SelectedValue.ToString();
            }

            loadREC(TXTHDR_ID.Text);
            calWork("");
            loadLine("200");
        }

        private void disablegrdREC()
        {
            if (grdREC.Rows.Count > 0 && grdREC.SelectedRows.Count > 0)
            {
                btnEditLine.Enabled = true;
                btnDelLine.Enabled = true;
            }
            else
            {
                btnEditLine.Enabled = false;
                btnDelLine.Enabled = false;
            } 
        }

        private void grdREC_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (grdREC.Rows.Count > 0 && grdREC.SelectedRows.Count > 0)
            {
                if (grdREC.SelectedCells[9].Value.ToString() == "True")
                {
                    grdREC.DefaultCellStyle.SelectionBackColor = Color.Silver;  
                    btnEditLine.Enabled = false;
                    btnDelLine.Enabled = false;
                }
                else
                {
                    btnEditLine.Enabled = true;
                    btnDelLine.Enabled = true;
                    grdREC.DefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
                }
            }   
        }

        private void RowSelectMark()
        {
            int countR = 0;
            foreach (DataGridViewRow gRow in grdLine.Rows)
            {
                if (gRow.Cells["KPI_ID"].Value.ToString() == TXTHDR_ID.Text)
                {
                    grdLine.CurrentCell = grdLine.Rows[countR].Cells[1];
                }
                countR += 1;
            }
            grdREC.CurrentCell = null;
        }

        private void cbShowDelRow_CheckedChanged(object sender, EventArgs e)
        {
            loadREC(TXTHDR_ID.Text);
        }

        private void changeTextColor()
        {
            if(grdREC.Rows.Count > 0)
            {
                int rowCount = 0;

                foreach (DataGridViewRow row in grdREC.Rows)
                {
                    if (row.Cells["DEL_REC"].Value.ToString() == "True")
                    {
                        int cellCount = 0;
                        foreach (DataGridViewColumn cell in grdREC.Columns)
                        {
                            grdREC.Rows[rowCount].Cells[cellCount].Style.ForeColor = Color.Red;
                            cellCount += 1;
                        }
                    }
                    rowCount += 1;
                }
            }
        }

        private void editREC(string min, string max)
        {
            if (grdREC.Rows.Count <= 0) return;
            if (grdREC.SelectedRows.Count <= 0) return;

            frmEditLine f = new frmEditLine();
            string empid = txtEmpID.Text;
            string id = grdREC.SelectedCells[1].Value.ToString();
            string message = grdREC.SelectedCells[4].Value.ToString();
            string dp = grdREC.SelectedCells[5].Value.ToString();
            string pp1 = grdREC.SelectedCells[6].Value.ToString();
            string pp2 = grdREC.SelectedCells[7].Value.ToString();
            string pp3 = grdREC.SelectedCells[8].Value.ToString();
            string fault_date = grdREC.SelectedCells[0].Value.ToString();

            var date = DateTime.Parse(fault_date);
            var outputD = date.ToString("dd");
            var outputM = date.ToString("MM");

            decimal maxInputDP = decimal.Parse(max) - (decimal.Parse(min) - decimal.Parse(dp));//DP max Adjust
            f.editL(empid, id, message, dp, pp1, pp2, pp3, outputD, outputM, cmb_Year.SelectedValue.ToString(),maxInputDP);
            if (f.ShowDialog() == DialogResult.OK)
            {
                editLine(txtEmpID.Text, f.eid, f.newMessage, f.newDP, f.newPP1, f.newPP2, f.newPP3, f.newDate);
            }
        }

        private void grdREC_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdREC.SelectedCells[9].Value.ToString() == "True") MessageBox.Show("ไม่สามารถแก้ไขได้", "แก้ไข", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                string MinMaxDP = txtNumREC.Text;
                string[] array = MinMaxDP.Split('/');
                editREC(array[0], array[1]);
            } 
        }
    }
}
