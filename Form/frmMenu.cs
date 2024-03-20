using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DatabaseClassLibrary;
using cllUtility;

namespace CarService
{
    public partial class frmMenu : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        string language = Program.Language;
        string defaultCompany = Program.DefaultCompanyID;
        string work_time_type = "";
        string DayStatus = string.Empty;
        string warn_msg1 = "", warn_msg2 = "";
        private Button currentButton;
        private Form activeForm = null;
        public string ComanyName;
        DateTime nowDateTime;
        //
        const int WS_MINIMIZEBOX = 0x20000;
        const int CS_DBLCLKS = 0x8;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= WS_MINIMIZEBOX;
                cp.ClassStyle |= CS_DBLCLKS;
                return cp;
            }
        }
        //
        public frmMenu()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            //btnCloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            //..
            //this.Text = Program.ProgramName;
            language = Program.Language;
            this.LBL_PROGRAM_NAME.Text = Program.ProgramName;
            this.lbUsername.Text = Program.LoginID;

            this.toolBarProgramID.Text = Program.ProgramID;
            this.toolBarCompany.Text = Program.CopyRight;
            this.toolBarRelVersion.Text = "REV.20220927";
            this.toolBarServerName.Text = Program.ServerName + " : " + Program.ServerPort;

        }

        private void SwitchLanguage()
        {
            //language = (language == "TH" ? )
           
            if (language != "TH")
            {
                Database.Connect();
                DataTable dtProgramName = Database.GetData("SELECT ProgramEnName FROM Programs WHERE ProgramID = '" + Program.ProgramID + "'", 5);
                this.LBL_PROGRAM_NAME.Text = dtProgramName.Rows[0]["ProgramEnName"].ToString();

                DataTable dtCompany = Database.GetData("SELECT CompanyEnFullName FROM Company WHERE CompanyID = '" + defaultCompany + "'", 5);
                this.LBL_COMPANY_FULL_NAME.Text = dtCompany.Rows[0]["CompanyEnFullName"].ToString();
                LBL_COMPANY_FULL_NAME.Visible = false;

                DataTable dtDayStatus = Database.GetData("SELECT ObjectDisplay FROM DisplayLanguage WHERE ProgramID = '" + Program.ProgramID + "' AND ObjectID = '" + "LBL_DAY_STATUS" + "'", 5);
                this.LBL_DAY_STATUS.Text = dtDayStatus.Rows[0]["ObjectDisplay"].ToString();
                warn_msg1 = "Please check now date";
                warn_msg2 = "Please set a work hour";


            }
            else
            {
                warn_msg1 = "กรุณากำหนดวันที่ปัจจุบันให้ถูกต้อง";
                warn_msg2 = "กรุณาระบุเวลาทำการของบริษัท";
            }

        }
        private void frmMenu_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            lblShortDate.Text = sharedFunction.SQLDateString(DateTime.Now);
            //lblNowTime.Text = DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00");
            lblNowTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private void frmMenu_Shown(object sender, EventArgs e)
        {
            timeEmpWork.Enabled = true;
            timeEmpWork.Start();
            //SwitchLanguage();
            GetCompanyTime();
            //cmbCompany.SelectedValue = defaultCompany;           
            //btnTimeStamp.PerformClick();
        }
        private void openChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }            
          
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();          
            //c.selectCompanyID = cmbCompany.SelectedValue.ToString();
            childForm.Show();
            //btnCloseChildForm.Visible = true;
        }

        private void closeChildForm()
        {
            if (activeForm != null)
            {
                //lblTitle.Text = "";
                activeForm.Close();
                //btnCloseChildForm.Visible = false;
                DisableButton();
            }
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    //Color color = Color.FromArgb(33, 127, 188);
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = SbuysColors.Sub_Main;
                    currentButton.ForeColor = SbuysColors.Text_Sub_Main;
                    currentButton.FlatAppearance.BorderColor = SbuysColors.Sub_Main;
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    //btnCloseChildForm.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelSideMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    //previousBtn.BackColor = Color.FromArgb(45, 45, 48);
                    previousBtn.BackColor = SbuysColors.Button;
                    previousBtn.ForeColor = SbuysColors.Text_Button;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            { this.WindowState = FormWindowState.Maximized; }
            else
            {
                this.WindowState = FormWindowState.Normal;
                CenterToScreen();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Program.prcs.Kill();
        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            closeChildForm();
            currentButton = null;
        }
        private void btnTimeStamp_Click(object sender, EventArgs e)
        {
            LBL_DAY_STATUS.Visible = false;
            openChildForm(new frmMain(), sender);
        }

        private void btnEmployeeNotWork_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDisplayEmpNotWork(), sender);
            CountEmpWork();
        }

        private void btnAdvNotWork_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDisplayAdvNotWork(), sender);
        }
        private void btnDisplayEmpHoliday_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDisplayEmployeeHoliday(), sender);
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            if(panelSideMenu.Width==220)
            {
                panelSideMenu.Width = 60;
            }

            else if (panelSideMenu.Width == 60)
            {
                panelSideMenu.Width = 220;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (panelSideMenu.Width < 220)
                panelSideMenu.Width += 5;
            else
            {
                timer2.Stop();
                timer2.Enabled = false;
            }
        }       
        private void GetCompanyTime()
        {
            LBL_COMPANY_FULL_NAME.Visible = false;
            try
            {
                Database.Connect();        

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = Database.vSqlConnection;
                SqlCmd.CommandType = CommandType.Text;
                SqlCmd.CommandText = "SELECT GETDATE()";
                nowDateTime = (DateTime)SqlCmd.ExecuteScalar();
                if (nowDateTime.Date != DateTime.Now.Date)
                {                    
                    MessageBox.Show(warn_msg1, "Validity Check", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Application.Exit();
                }
                btnTimeStamp.PerformClick();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Cannot get company work time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);             
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Database.Close();
            }
        }           

        private void timeEmpWork_Tick(object sender, EventArgs e)
        {
            lblShortDate.Text = Utility.SQLDateString(DateTime.Now);
            //lblNowTime.Text = DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00");
            lblNowTime.Text = DateTime.Now.ToString("HH:mm:ss");
            LBL_SHOW_NOW_TIME.Text = DateTime.Now.ToString("dddd, d MMMM yyyy HH:mm:ss");
            
            if (DayStatus == "work_day" && work_time_type == "Normal")
            {
                if (lblStartWorkTime.Text != "")
                {
                    if (lblAbsenceTime.Text != "-")
                    {
                        if (Convert.ToDateTime(lblNowTime.Text) > Convert.ToDateTime(lblStartWorkTime.Text) && Convert.ToDateTime(lblNowTime.Text) < Convert.ToDateTime(lblAbsenceTime.Text))
                        {
                            LBL_SHOW_NOW_TIME.ForeColor = Color.Red;
                        }
                    }
                    else
                    {
                        if (Convert.ToDateTime(lblNowTime.Text) > Convert.ToDateTime(lblStartWorkTime.Text) && Convert.ToDateTime(lblNowTime.Text) < Convert.ToDateTime(lblStartWorkNoon.Text))
                        {
                            LBL_SHOW_NOW_TIME.ForeColor = Color.Red;
                        }
                    }
                }
            }           
        }
      

        private void CountEmpWork()
        {
            Database.Connect();
            DataTable dtCountWork = Database.GetData("usp_EM100_10 '" + defaultCompany + "'", 5);
            string countWork = dtCountWork.Rows[0]["CountWork"].ToString();           
            string countAdvNotWork = dtCountWork.Rows[0]["CountAdvNotWork"].ToString();
            btnTimeStamp.Text = "    บันทึกเวลาทำงาน (" + countWork + ")";
            btnAdvNotWork.Text = "    ลาล่วงหน้า (" + countAdvNotWork + ")";
        }
       
        private void lbProgramName_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            { this.WindowState = FormWindowState.Maximized; }
            else
            {
                this.WindowState = FormWindowState.Normal;
                CenterToScreen();
            }
        }

        private void panelTitle_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            { this.WindowState = FormWindowState.Maximized; }
            else
            {
                this.WindowState = FormWindowState.Normal;
                CenterToScreen();
            }
        }

        public string LabelText
        {
            get
            {
                return this.LBL_COMPANY_FULL_NAME.Text;
            }
            set
            {
                this.LBL_COMPANY_FULL_NAME.Text = value;
            }
        }
    }
}
