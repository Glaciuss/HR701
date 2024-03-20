using System;
using System.Windows.Forms;
using System.Globalization;
using System.Diagnostics;
using System.Data;
using DatabaseClassLibrary;

namespace CarService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public const string ProgramID = "HR701";  // input 0 with out check authen...
        public const string ProgramName = "บันทึกความผิดพลาดในการทำงานของพนักงาน";
        public const string Description = "Time attendance";
        public const string Module = "HR";
        //public const string CustomizedBy = "Passakorn";
        public static DateTime DateCreated = DateTime.ParseExact("05/05/2016", "dd/MM/yyyy", CultureInfo.InvariantCulture);
        public static DateTime DateModified = DateTime.ParseExact("06/05/2016", "dd/MM/yyyy", CultureInfo.InvariantCulture);
        public const string Version = "2.0";
        public const string Release = "1.0";

        //public static string CopyRight = "Copyright © " + DateTime.Now.Year.ToString() + " PCT SOFTWARE CO.,LTD.";
        public static string CopyRight = "Copyright ©" + " PCT SOFTWARE CO.,LTD.";
        public static string AppPath = string.Empty;
        public static string ExePath = string.Empty;
        public static string ReportPath = string.Empty;
        public static string ServerName = string.Empty;
        public static string ServerPort = string.Empty;
        public static string LoginID = string.Empty;
        public static string LoginName = string.Empty;
        public static string EmployeeID = string.Empty;
        public static string DefaultCompanyID = string.Empty;
        public static string DefaultCompanyName = string.Empty;
        public static string CompanyID = string.Empty;
        public static string CompanyName = string.Empty;
        public static string UserGroup = string.Empty;
        public static string SoundPath = string.Empty;
        public static string Language = string.Empty;
        public static string HR_SelectCompany = string.Empty;

        //public static bool AllowEdit;
        //public static bool AllowDelete;       

        //public static string Set1 = string.Empty;

        public static string FTPServer = string.Empty;
        public static string FTPUser = string.Empty;
        public static string FTPPass = string.Empty;
        public static string pathPicture = "";

        public static Process prcs;

        [STAThread]
        static void Main()
        {
            prcs = Process.GetCurrentProcess();

            AppPath = Application.StartupPath;
            int s = AppPath.IndexOf("\\bin");

            if (s != -1)
            {
                AppPath = AppPath.Substring(0, s);
            }

            if (checkProcessRunning(ProgramID) == false)
            {
                return;
            }

            if (checkFormatDate() == false)
            {
                return;
            }

            if (checkUserLogin() == false)
            {
                return;
            }

            getSetting();
            getColors();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMenu());
         
        }
        static bool checkUserLogin()
        {
            IniFile ini = new IniFile();
            string filePath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + "\\CarServiceLogin.ini";
            try
            {
                LoginID = ini.Read(filePath, "main", "Username");
                CompanyID = ini.Read(filePath, "main", "CompanyID");

                Database.Connect();

                string strSQL;
                strSQL = " SELECT Employee.EmployeeID,Employee.EmployeeName,Employee.EmployeeSurname,[User].UserName,[User].CompanyID,[User].UserGroupID,AllowInsert,AllowEdit,AllowDelete ";
                strSQL += "   FROM Employee ";
                strSQL += " INNER JOIN [User] ON Employee.EmployeeID = [User].EmployeeID ";
                strSQL += " INNER JOIN UserAuthen ON [User].UserGroupID = UserAuthen.UserGroupID ";
                strSQL += "  WHERE [User].UserName = '" + LoginID + "' ";

                if (ProgramID != "0")
                {
                    strSQL += "  AND UserAuthen.ProgramID = '" + ProgramID + "' ";
                }

                DataTable dt = Database.GetData(strSQL);

                if (dt.Rows.Count > 0)
                {
                    Program.LoginName = dt.Rows[0]["EmployeeName"].ToString() + " " + dt.Rows[0]["EmployeeSurname"].ToString();
                    Program.CompanyID = dt.Rows[0]["CompanyID"].ToString();
                    Program.UserGroup = dt.Rows[0]["UserGroupID"].ToString();
                    Program.EmployeeID = dt.Rows[0]["EmployeeID"].ToString();
                    //Program.AllowInsert = (bool)dt.Rows[0]["AllowInsert"];
                    //Program.AllowEdit = (bool)dt.Rows[0]["AllowEdit"];
                    //Program.AllowDelete = (bool)dt.Rows[0]["AllowDelete"];

                    strSQL = " SELECT * FROM Company ";
                    strSQL += " WHERE CompanyID = '" + CompanyID + "' ";
                    dt = Database.GetData(strSQL);
                    if (dt.Rows.Count > 0)
                    {
                        Program.CompanyName = dt.Rows[0]["CompanyFullName"].ToString();
                    }

                    dt = null;
                    Database.Close();
                    return true;
                }
                else
                {
                    string StringMsg = "คุณไม่มีสิทธิ์ในการใช้งานโปรแกรมนี้";
                    MessageBox.Show(StringMsg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //dt = null;
                    Database.Close();
                    return false;
                }

            }
            catch (Exception ex)
            {
                string StringMsg = "เกิดข้อผิดพลาดในการเชื่อมต่อกับระบบ";
                StringMsg = StringMsg + (char)13 + (char)13;
                StringMsg = StringMsg + "System Msg: " + ex.Message;
                MessageBox.Show(StringMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        static void getSetting()
        {
            IniFile ini = new IniFile();
            string filePath = Program.AppPath + "\\config\\CarServiceConfig.ini";
            try
            {
                //ExePath = ini.Read(filePath, "setting", "ExePath");
                //ReportPath = ini.Read(filePath, "setting", "ReportPath");
                //SoundPath = ini.Read(filePath,"setting", "SoundPath");
                //DefaultCompanyID = ini.Read(filePath, "setting", "CompanyID");
                //Language = ini.Read(filePath, "setting", "Language");

                FTPServer = ini.Read(filePath, "setting", "FTPServer");
                FTPUser = ini.Read(filePath, "setting", "FTPUser");
                FTPPass = ini.Read(filePath, "setting", "FTPPass");
                pathPicture = ini.Read(filePath, "setting", "PicturePath"); //PicturePath

                ServerName = ini.Read(filePath, "main", "Server");
                ServerPort = ini.Read(filePath, "main", "ServerPort");
                DefaultCompanyID = ini.Read(filePath, "setting", "CompanyID");
                Database.Connect();
                string sqlSetting = "SELECT ConfigName,Value FROM SystemConfig WHERE ConfigGroupID='setting' and CompanyID='" + Program.CompanyID + "'";
                DataTable dtSetting = Database.GetData(sqlSetting, 5);
                foreach (DataRow drSetting in dtSetting.Rows)
                {
                    switch (drSetting["ConfigName"].ToString())
                    {
                        case "ExePath":
                            ExePath = drSetting["Value"].ToString();
                            break;
                        case "HR_SelectCompany":
                            HR_SelectCompany = drSetting["Value"].ToString();
                            break;
                        case "SoundPath":
                            SoundPath = drSetting["Value"].ToString();
                            break;
                        case "Language":
                            Language = drSetting["Value"].ToString();
                            break;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }          
        }
        static Boolean checkProcessRunning(string Process_Name)
        {
            Process[] processes;
            string StringMsg;
            int count = 0;
            StringMsg = "โปรแกรมนี้ถูกเปิดไว้แล้ว";

            processes = Process.GetProcesses();
            foreach (Process instance in processes)
            {
                if (instance.ProcessName == Process_Name)
                {
                    count = count + 1;
                    if (count > 1)
                    {
                        MessageBox.Show(StringMsg, "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }
            return true;
        }

        static Boolean checkFormatDate()
        {
            string stringCulture;
            string StringDate;
            string StringMsg;

            stringCulture = System.Threading.Thread.CurrentThread.CurrentCulture.Name;
            StringDate = System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern.ToString();
            

            if (stringCulture != "th-TH")
            {
                StringMsg = "กรุณาเปลี่ยนรูปแบบของวันที่ในเครื่องคอมพิวเตอร์ของท่านเป็นภาษาไทย";
                StringMsg = StringMsg + (char)13;
                StringMsg = StringMsg + "รูปแบบ วัน/เดือน/ปี (dd/MM/yyyy) ";

                MessageBox.Show(StringMsg, "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {                
                return true;
            }

            //if (StringDate != "dd/MM/yyyy")
            //{
            //    //StringMsg = "Short date pattern is not correct.";
            //    //StringMsg = StringMsg + (char)13 + (char)13;
            //    //StringMsg = StringMsg + "Please change date's format pattern to 'dd/MM/yyyy'.";
            //    //StringMsg = StringMsg + (char)13;
            //    StringMsg = "กรุณาเปลี่ยนรูปแบบของวันที่ในเครื่องคอมพิวเตอร์ของท่าน";
            //    StringMsg = StringMsg + (char)13;
            //    StringMsg = StringMsg + "เป็น วัน/เดือน/ปี (dd/MM/yyyy) ";

            //    MessageBox.Show(StringMsg, "Warning",
            //            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return false;
            //}
            //else
            //{
            //    return true;
            //}
        }
        static void getColors()
        {
            IniFile ini = new IniFile();
            string filePath = Program.AppPath + "\\config\\CarServiceConfig.ini";
            try
            {
                //[Colors]
                //Main = 2D2D30
                //Text_Main = DCDCDC
                //Sub_Main = 2B3D51
                //Text_Sub_Main = DCDCDC
                //Button = 2D2D30
                //Text_Button = DCDCDC
                //BG_Main = F5F5F5
                //Text_BG_Main = 000000
                //BG_Minor = DCDCDC
                //Text_BG_Minor = 000000
                string _main = ini.Read(filePath, "Colors", "Main");
                string _text_main = ini.Read(filePath, "Colors", "Text_Main");
                string _sub_main = ini.Read(filePath, "Colors", "Sub_Main");
                string _text_sub_main = ini.Read(filePath, "Colors", "Text_Sub_Main");
                string _button = ini.Read(filePath, "Colors", "Button");
                string _text_button = ini.Read(filePath, "Colors", "Text_Button");
                string _bg_main = ini.Read(filePath, "Colors", "BG_Main");
                string _text_bg_main = ini.Read(filePath, "Colors", "Text_BG_Main");
                string _bg_minor = ini.Read(filePath, "Colors", "BG_Minor");
                string _text_bg_minor = ini.Read(filePath, "Colors", "Text_BG_Minor");
                string config_name = string.Empty;
                string value = string.Empty;
                Database.Connect();
                string sqlSetting = "SELECT ConfigName,Value FROM SystemConfig WHERE ConfigGroupID='COLORS' and CompanyID='" + Program.CompanyID + "'";
                DataTable dtSetting = Database.GetData(sqlSetting, 5);
                foreach (DataRow drSetting in dtSetting.Rows)
                {
                    config_name = drSetting["ConfigName"].ToString();
                    value = drSetting["Value"].ToString();
                    switch (config_name)
                    {
                        case "Main":
                            _main = value;
                            break;
                        case "Text_Main":
                            _text_main = value;
                            break;
                        case "Sub_Main":
                            _sub_main = value;
                            break;
                        case "Text_Sub_Main":
                            _text_sub_main = value;
                            break;
                        case "Button":
                            _button = value;
                            break;
                        case "Text_Button":
                            _text_button = value;
                            break;
                        case "BG_Main":
                            _bg_main = value;
                            break;
                        case "Text_BG_Main":
                            _text_bg_main = value;
                            break;
                        case "BG_Minor":
                            _bg_minor = value;
                            break;
                        case "Text_BG_Minor":
                            _text_bg_minor = value;
                            break;
                    }
                }

                try
                {
                    SbuysColors.Main = System.Drawing.ColorTranslator.FromHtml(_main);
                }
                catch { }

                try
                {
                    SbuysColors.Text_Main = System.Drawing.ColorTranslator.FromHtml(_text_main);
                }
                catch { }
                try
                {
                    SbuysColors.Sub_Main = System.Drawing.ColorTranslator.FromHtml(_sub_main);
                }
                catch { }

                try
                {
                    SbuysColors.Text_Sub_Main = System.Drawing.ColorTranslator.FromHtml(_text_sub_main);
                }
                catch { }

                try
                {
                    SbuysColors.Button = System.Drawing.ColorTranslator.FromHtml(_button);
                }
                catch { }

                try
                {
                    SbuysColors.Text_Button = System.Drawing.ColorTranslator.FromHtml(_text_button);
                }
                catch { }

                try
                {
                    SbuysColors.BG_Main = System.Drawing.ColorTranslator.FromHtml(_bg_main);
                }
                catch { }

                try
                {
                    SbuysColors.Text_BG_Main = System.Drawing.ColorTranslator.FromHtml(_text_bg_main);
                }
                catch { }

                try
                {
                    SbuysColors.BG_Minor = System.Drawing.ColorTranslator.FromHtml(_bg_minor);
                }
                catch { }

                try
                {
                    SbuysColors.Text_BG_Minor = System.Drawing.ColorTranslator.FromHtml(_text_bg_minor);
                }
                catch { }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

    }
}
