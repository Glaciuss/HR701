using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DatabaseClassLibrary;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace CarService
{
    public partial class frmShowMessage : Form
    {
        int _msgCount = 0;
        string _empID = "";
        string server = Database.vServer;
        string db = Database.vCatalog;
        string usr = Database.vUsername;
        string pass = Database.vPassword;
        string connectionString;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // width of ellipse
           int nHeightEllipse // height of ellipse
       );
        public frmShowMessage()
        {
            InitializeComponent();
        }
        private void frmShowMessage_Load(object sender, EventArgs e)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width + 1, Height + 1, 20, 20));
            this.Text = "Message";
            ShowSetting();
            connectionString = @"Data Source=" + server + ";Initial Catalog=" + db + ";User ID=" + usr + ";Password=" + pass + ";MultipleActiveResultSets=true";
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            LBL_9.Text = TXTADD_9.Text;

            int countempty = 0;
            int countnotempty = 0;
            SqlConnection cnn;
            cnn = new SqlConnection(connectionString);
            cnn.Open();

            string sqlMsg = "INSERT INTO WorkKPI_Line(HDR_ID,KPI_ID,KPI_DESC,VALUE_TYPE,SETTING_VALUE,WEIGHT_RATE,MOD_USERID,MOD_DATETIME) ";
            sqlMsg += " VALUES (@HDR_ID,@KPI_ID,@KPI_DESC,@VALUE_TYPE,@SETTING_VALUE,@WEIGHT_RATE,@MOD_USERID,@MOD_DATETIME)";

            string sqlLabel = "INSERT INTO WorkKPI_Line(HDR_ID,KPI_ID,KPI_DESC) ";
            sqlLabel += "VALUES (@HDR_ID,@KPI_ID,@KPI_DESC)";

            string sqlLabelUp = "UPDATE WorkKPI_Line ";
            sqlLabelUp += "SET KPI_DESC = @KPI_DESC ";
            sqlLabelUp += "WHERE KPI_ID = @KPI_ID ";

            string sqlTextBox = "UPDATE WorkKPI_Line ";
            sqlTextBox += "SET SETTING_VALUE = @SETTING_VALUE, ";
            sqlTextBox += "MOD_DATETIME = GETDATE() ";
            sqlTextBox += "WHERE KPI_ID = @KPI_ID";

            string sqlTextBoxUp = "UPDATE WorkKPI_Line ";
            sqlTextBoxUp += "SET WEIGHT_RATE = @WEIGHT_RATE ";
            sqlTextBoxUp += "WHERE KPI_ID = @KPI_ID";

            Database.Connect();
            string sqlHeader = "SELECT * from WorkKPI_Header";
            string sqlLine = "SELECT * from WorkKPI_Line order by KPI_ID";
            DataTable dtMsg_H = Database.GetData(sqlHeader);
            DataTable dtMsg_L = Database.GetData(sqlLine);

            if (dtMsg_H.Rows.Count > 0)
            {
                string HDR_ID = dtMsg_H.Rows[0]["HDR_ID"].ToString(); //Header_ID Group1
                int KPI_ID = 100;
                //Insert KPI_DESC in to dbo.WorkKPI_line (empty)
                if (dtMsg_L.Rows.Count == 0)
                {
                    foreach (Label l in GROUP1.Controls.OfType<Label>().OrderBy(l => l.Name))
                    {
                        if (l == LBLWEIGHT1 || l == LBLVALUE1 || l == LBLRatio1)
                        {

                        }
                        else
                        {
                            SqlCommand cmdL = new SqlCommand(sqlLabel, cnn);
                            countempty++;
                            cmdL.Parameters.AddWithValue("@HDR_ID", HDR_ID);
                            cmdL.Parameters.AddWithValue("@KPI_ID", (KPI_ID + countempty).ToString());
                            cmdL.Parameters.AddWithValue("@KPI_DESC", l.Text);
                            //MessageBox.Show("Add to dbo.WorkKPI_Line = " + l.Text  + (KPI_ID+countempty).ToString() + " row");
                            cmdL.ExecuteNonQuery();
                        }
                    }
                }
                //update KPI_DESC in to dbo.WorkKPI_line (not empty)
                else
                {
                    foreach (Label l in GROUP1.Controls.OfType<Label>().OrderBy(l => l.Name))
                    {
                        if (l == LBLWEIGHT1 || l == LBLVALUE1 || l == LBLRatio1)
                        {

                        }
                        else
                        {
                            SqlCommand cmdUL = new SqlCommand(sqlLabelUp, cnn);
                            countnotempty++;
                            cmdUL.Parameters.AddWithValue("@KPI_ID", (KPI_ID + countnotempty).ToString());
                            cmdUL.Parameters.AddWithValue("@KPI_DESC", l.Text);
                            cmdUL.ExecuteNonQuery();
                        }
                    }
                }

                int countV = 0;
                int countW = 0;

                foreach (TextBox l in GROUP1.Controls.OfType<TextBox>().OrderBy(l => l.Name))
                {
                    if (l == txtRatio_1 || l == TXTADD_9)
                    {

                    }
                    else if (l.Name.Contains("TXTV"))
                    {
                        countV++;
                        SqlCommand cmdT = new SqlCommand(sqlTextBox, cnn);
                        cmdT.Parameters.AddWithValue("@SETTING_VALUE", l.Text);
                        cmdT.Parameters.AddWithValue("@KPI_ID", (KPI_ID + countV).ToString());
                        cmdT.ExecuteNonQuery();
                    }

                    else if (l.Name.Contains("TXTW"))
                    {
                        countW++;
                        SqlCommand cmdT = new SqlCommand(sqlTextBoxUp, cnn);
                        cmdT.Parameters.AddWithValue("@WEIGHT_RATE", l.Text);
                        cmdT.Parameters.AddWithValue("@KPI_ID", (KPI_ID + countW).ToString());
                        cmdT.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Updated Successful");
            }
            Database.Close();

            string ud_H100 = "UPDATE WorkKPI_Header ";
            ud_H100 += "SET WEIGHT_RATE = '" + TXTSCORE1.Text + "'";
            ud_H100 += " ,MOD_DATETIME = GETDATE()";
            ud_H100 += "WHERE HDR_DESC = '" + GROUP1.Text + "'";

            string ud_H200 = "UPDATE WorkKPI_Header ";
            ud_H200 += "SET WEIGHT_RATE = '" + TXTSCORE2.Text + "'";
            ud_H200 += " ,MOD_DATETIME = GETDATE()";
            ud_H200 += "WHERE HDR_DESC = '" + GROUP2.Text + "'";

            string ud_H300 = "UPDATE WorkKPI_Header ";
            ud_H300 += "SET WEIGHT_RATE = '" + TXTSCORE3.Text + "'";
            ud_H300 += " ,MOD_DATETIME = GETDATE()";
            ud_H300 += "WHERE HDR_DESC = '" + GROUP3.Text + "'";

            string ud_H400 = "UPDATE WorkKPI_Header ";
            ud_H400 += "SET WEIGHT_RATE = '" + TXTSCORE4.Text + "'";
            ud_H400 += " ,MOD_DATETIME = GETDATE()";
            ud_H400 += "WHERE HDR_DESC = '" + GROUP4.Text + "'";

            

            foreach (Label l in GROUP1.Controls.OfType<Label>())
            {
                if (l.Text != string.Empty)
                {
                    
                }
            }

            if (GROUP1.Text != string.Empty)
            {
                SqlCommand ud_sqlH = new SqlCommand(ud_H100, cnn);
                ud_sqlH.ExecuteNonQuery();
            }
            if (GROUP2.Text != string.Empty)
            {
                SqlCommand ud_sqlH = new SqlCommand(ud_H200, cnn);
                ud_sqlH.ExecuteNonQuery();
            }
            if (GROUP3.Text != string.Empty)
            {
                SqlCommand ud_sqlH = new SqlCommand(ud_H300, cnn);
                ud_sqlH.ExecuteNonQuery();
            }
            if (GROUP4.Text != string.Empty)
            {
                SqlCommand ud_sqlH = new SqlCommand(ud_H400, cnn);
                ud_sqlH.ExecuteNonQuery();
            }

            cnn.Close();
            //this.Close();
        }

        private void ShowSetting()
        {
            btnAddHeader.Location = new Point(950,172);
            try
            {
                string sqlLine = "SELECT * from WorkKPI_Line order by KPI_ID";
                string sqlHeader = "SELECT * from WorkKPI_Header";
                Database.Connect();
                DataTable dtMsg_L = Database.GetData(sqlLine);
                DataTable dtMsg_H = Database.GetData(sqlHeader);

                if (dtMsg_H.Rows.Count > 0)
                {
                    GROUP1.Text = dtMsg_H.Rows[0]["HDR_DESC"].ToString(); //Header Group1
                    GROUP2.Text = dtMsg_H.Rows[1]["HDR_DESC"].ToString(); //Header Group2
                    GROUP3.Text = dtMsg_H.Rows[2]["HDR_DESC"].ToString(); //Header Group3

                    decimal d0 = decimal.Parse(dtMsg_H.Rows[0]["WEIGHT_RATE"].ToString());
                    decimal d1 = decimal.Parse(dtMsg_H.Rows[1]["WEIGHT_RATE"].ToString());
                    decimal d2 = decimal.Parse(dtMsg_H.Rows[2]["WEIGHT_RATE"].ToString());

                    TXTSCORE1.Text = d0.ToString("0.0");
                    TXTSCORE2.Text = d1.ToString("0.0");
                    TXTSCORE3.Text = d2.ToString("0.0");

                    if (dtMsg_H.Rows.Count > 3)
                    {
                        GROUP4.Text = dtMsg_H.Rows[3]["HDR_DESC"].ToString(); //Header Group4
                        decimal d3 = decimal.Parse(dtMsg_H.Rows[3]["WEIGHT_RATE"].ToString());
                        TXTSCORE4.Text = d3.ToString("0.0");
                    }

                    if (dtMsg_L.Rows.Count > 0)
                    {
                        int countV = 0;
                        int countW = 0;

                        //Show Group 1 (value & weight)
                        foreach (TextBox l in GROUP1.Controls.OfType<TextBox>().OrderBy(l => l.Name))
                        {
                            if (l == txtRatio_1 || l == TXTADD_9)
                            {

                            }
                            else if (l.Name.Contains("TXTV"))
                            {
                                countV++;
                                decimal v = decimal.Parse(dtMsg_L.Rows[countV - 1]["SETTING_VALUE"].ToString());
                                l.Text = v.ToString("0");
                            }

                            else if (l.Name.Contains("TXTW"))
                            {
                                countW++;
                                decimal w = decimal.Parse(dtMsg_L.Rows[countW - 1]["WEIGHT_RATE"].ToString());
                                l.Text = w.ToString("0.0");
                            }
                        }

                        List<bool> CanDelG1 = new List<bool>();
                        int countnotempty = 0;
                        //Show Group 1 (label)
                        foreach (Label l in GROUP1.Controls.OfType<Label>().OrderBy(l => l.Name))
                        {
                            if (l == LBLWEIGHT1 || l == LBLVALUE1 || l == LBLRatio1)
                            {

                            }
                            else
                            {
                                countnotempty++;
                                l.Text = dtMsg_L.Rows[countnotempty - 1]["KPI_DESC"].ToString();

                                //Can add?
                                if (l.Text == "")
                                {
                                    btnAddWork1_1.Enabled = true;
                                    CanDelG1.Add(false);
                                }
                                else
                                {
                                    btnAddWork1_1.Enabled = false;
                                    CanDelG1.Add(true);
                                }

                                //Can del?
                                if (CanDelG1.Contains(true))
                                {
                                    btnDelWork1_1.Enabled = true;
                                }
                                else 
                                {
                                    btnDelWork1_1.Enabled = false;
                                }
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                this.Close();
            }
            finally
            {
                Database.Close();
            }
        }

        private void BTN_CANCEL_Click(object sender, EventArgs e)
        {
            if (_empID != "")
            {
            }
            else
            {
                this.Close();
            }
        }

        private void Refresh_w1(object sender, EventArgs e)
        {
            decimal WorkDay = 0;
            decimal Leave = 0;
            decimal notice = 0;
            decimal Absent = 0;
            decimal Late = 0;
            decimal Suspended = 0;
            decimal Medical = 0;
            decimal Warning = 0;
            decimal Holiday = 0;
            decimal add1 = 0;
            decimal.TryParse(TXTW0.Text, out WorkDay);
            decimal.TryParse(TXTW1.Text, out Leave);
            decimal.TryParse(TXTW2.Text, out notice);
            decimal.TryParse(TXTW3.Text, out Absent);
            decimal.TryParse(TXTW4.Text, out Late);
            decimal.TryParse(TXTW5.Text, out Suspended);
            decimal.TryParse(TXTW6.Text, out Medical);
            decimal.TryParse(TXTW7.Text, out Warning);
            decimal.TryParse(TXTW8.Text, out Holiday);
            decimal.TryParse(TXTW9.Text, out add1);
            txtRatio_1.Text = (WorkDay + Leave + notice + Absent + Late + Suspended + Medical + Warning + Holiday + add1).ToString();
        }
        private void Refresh_w2(object sender, EventArgs e)
        {
            decimal Mistake = 0;
            decimal Delinquent = 0;
            decimal Area = 0;
            decimal Tool = 0;
            decimal Equipment = 0;
            decimal Uniform = 0;
            decimal Hairstyle = 0;
            decimal Other = 0;
            decimal.TryParse(txtMistake_W.Text, out Mistake);
            decimal.TryParse(txtDelinquent_W.Text, out Delinquent);
            decimal.TryParse(txtArea_W.Text, out Area);
            decimal.TryParse(txtTool_W.Text, out Tool);
            decimal.TryParse(txtEquipment_W.Text, out Equipment);
            decimal.TryParse(txtUniform_W.Text, out Uniform);
            decimal.TryParse(txtHairstyle_W.Text, out Hairstyle);
            decimal.TryParse(txtOther_W.Text, out Other);
            txtRatio_2.Text = (Mistake + Delinquent + Area + Tool + Equipment + Uniform + Hairstyle + Other).ToString();
        }
        private void Refresh_w3(object sender, EventArgs e)
        {
            decimal Learn = 0;
            decimal Train = 0;
            decimal.TryParse(txtLearn_W.Text, out Learn);
            decimal.TryParse(txtTrain_W.Text, out Train);
            txtRatio_3.Text = (Learn + Train).ToString();
        }

        private void btnAddHeader_Click(object sender, EventArgs e)
        {
            GROUP4.Visible = true;
            btnAddHeader.Visible = false;
            LBLSCORE4.Visible = true;
            TXTSCORE4.Visible = true;
        }

        private void btnDelWork4_Click(object sender, EventArgs e)
        {
            GROUP4.Visible = false;
            btnAddHeader.Visible = true;
            LBLSCORE4.Visible = false;
            TXTSCORE4.Visible = false;
        }

        private void btnAddWork1_1_Click(object sender, EventArgs e)
        {
            TXTADD_9.Visible = true;
            TXTV9.Visible = true;
            TXTW9.Visible = true;
            btnAddWork1_1.Enabled = false;
            btnDelWork1_1.Enabled = true;
            TXTADD_9.Focus();

        }

        private void btnDelWork1_1_Click(object sender, EventArgs e)
        {
            TXTADD_9.Visible = false;
            TXTV9.Visible = false;
            TXTW9.Visible = false;
            btnAddWork1_1.Enabled = true;
            btnDelWork1_1.Enabled = false;
            TXTW9.Text = "";
            TXTV9.Text = "";
            TXTADD_9.Text = "";

            int countV = 0;
            int countW = 0;
            int countTXT = 0;
            foreach (TextBox l in GROUP1.Controls.OfType<TextBox>().OrderBy(l => l.Name))
            {
                if (l == txtRatio_1)
                {

                }
                else if (l.Name.Contains("TXTADD"))
                {
                    
                    if (l.Visible == false)
                    {
                        countTXT++;
                    }
                }
                else if (l.Name.Contains("TXTV"))
                {
                    countV++;
                }

                else if (l.Name.Contains("TXTW"))
                {
                    countW++;
                }
            }

            MessageBox.Show("Box text show = " + countTXT.ToString());

        }

        
    }
}
