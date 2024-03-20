using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseClassLibrary;

namespace CarService
{
    public partial class frmEditLine : Form
    {
        public string empid;
        public string eid;
        public string newMessage;
        public string newDP;
        public string newPP1;
        public string newPP2;
        public string newPP3;
        public string newDate;

        string pathPicture = Program.pathPicture; //"http://161.82.175.125:83";
        string ftpServer = Program.FTPServer; // "ftp://161.82.175.125";
        string ftpUser = Program.FTPUser; // "pctpic";
        string ftpPass = Program.FTPPass; // "Pct211705";

        public frmEditLine()
        {
            InitializeComponent();
        }

        private void NMRWEIGHT_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            newMessage = TXTERRORDESC_NEW.Text;
            newDP = NMRVALUE_NEW.Text;
            newPP1 = txtImage01.Text;
            newPP2 = txtImage02.Text;
            newPP3 = txtImage03.Text;
            newDate = sharedFunction.SQLDateString(dtpDocDateFrom.Value.Date);

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public void editL(string newempid, string id, string message, string dp, string pp1, string pp2, string pp3,string opD,string opM,string ySelected, decimal dpmax)
        {
            empid = newempid;
            eid = id;
            TXTERRORDESC_NEW.Text = message;
            NMRVALUE_NEW.Text = dp;
            loadDate(opD,opM,ySelected);
            loadPicture();
            NMRVALUE_NEW.Maximum = dpmax;
        }

        private void btnAddPic1_Click(object sender, EventArgs e)
        {
            uploadFile("image01.png");
            try
            {
                string emp_id = empid;
                string rec_id = eid;
                rec_id = rec_id.Replace("+", "-PLUS");
                string directory = string.Format(@"{0}/SbuysPicture/WorkKPI_REC/{1}/{2}", ftpServer, emp_id, rec_id);

                if (CheckIfFileExists(directory + "/image01.png", ftpUser, ftpPass))
                {
                    RECImg1.Load(pathPicture + "/WorkKPI_REC/" + emp_id + "/" + rec_id + "/image01.png");
                    txtImage01.Text = emp_id + "/" + rec_id + "/image01.png";
                }
                else
                {
                    RECImg1.Load(pathPicture + "/WorkKPI_REC/" + emp_id + "/image01.png");
                    txtImage01.Text = emp_id + "/image01.png";
                }
                updatePicPath(txtImage01.Text, txtImage02.Text, txtImage03.Text);
                loadPicture();
            }
            catch { }
        }

        private void btnAddPic2_Click(object sender, EventArgs e)
        {
            uploadFile("image02.png");
            try
            {
                string emp_id = empid;
                string rec_id = eid;
                rec_id = rec_id.Replace("+", "-PLUS");
                string directory = string.Format(@"{0}/SbuysPicture/WorkKPI_REC/{1}/{2}", ftpServer, emp_id, rec_id);

                if (CheckIfFileExists(directory + "/image02.png", ftpUser, ftpPass))
                {
                    RECImg2.Load(pathPicture + "/WorkKPI_REC/" + emp_id + "/" + rec_id + "/image02.png");
                    txtImage02.Text = emp_id + "/" + rec_id + "/image02.png";
                }
                else
                {
                    RECImg2.Load(pathPicture + "/WorkKPI_REC/" + emp_id + "/image02.png");
                    txtImage02.Text = emp_id + "/image02.png";
                }
                updatePicPath(txtImage01.Text, txtImage02.Text, txtImage03.Text);
                loadPicture();
            }
            catch { }
        }

        private void btnAddPic3_Click(object sender, EventArgs e)
        {
            uploadFile("image03.png");
            try
            {
                string emp_id = empid;
                string rec_id = eid;
                rec_id = rec_id.Replace("+", "-PLUS");
                string directory = string.Format(@"{0}/SbuysPicture/WorkKPI_REC/{1}/{2}", ftpServer, emp_id, rec_id);

                if (CheckIfFileExists(directory + "/image03.png", ftpUser, ftpPass))
                {
                    RECImg3.Load(pathPicture + "/WorkKPI_REC/" + emp_id + "/" + rec_id + "/image03.png");
                    txtImage03.Text = emp_id + "/" + rec_id + "/image03.png";
                }
                else
                {
                    RECImg3.Load(pathPicture + "/WorkKPI_REC/" + emp_id + "/image03.png");
                    txtImage03.Text = emp_id + "/image03.png";
                }
                updatePicPath(txtImage01.Text, txtImage02.Text, txtImage03.Text);
                loadPicture();
            }
            catch { }
        }

        private void uploadFile(String imageName)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Image files (*.png)|*.png;";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog1.FileName;
                string empCode = empid;
                UploadFtpFile(selectedFileName, empCode, imageName);
                MessageBox.Show("อัพโหลดรูปภาพเรียบร้อยแล้ว", "อัพโหลดรูปภาพ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Cursor = Cursors.Default;
        }

        public void UploadFtpFile(string pathFile, string modelID, string imageName)
        {
            string rec_id = eid;//Change
            rec_id = rec_id.Replace("+", "-PLUS");

            FtpWebRequest request;

            string absoluteFileName = Path.GetFileName(pathFile);

            string directory = string.Format(@"{0}/SbuysPicture/WorkKPI_REC/{1}", ftpServer, modelID);
            
            FtpNewDirectory(directory, ftpUser, ftpPass);

            directory = string.Format(@"{0}/SbuysPicture/WorkKPI_REC/{1}/{2}", ftpServer, modelID, rec_id);

            FtpNewDirectory(directory, ftpUser, ftpPass);

            request = WebRequest.Create(new Uri(string.Format(@"{0}/SbuysPicture/WorkKPI_REC/{1}/{2}/{3}", ftpServer, modelID, rec_id, imageName))) as FtpWebRequest;
            request.Method = WebRequestMethods.Ftp.UploadFile;
            request.UseBinary = true;
            request.UsePassive = true;
            request.KeepAlive = true;
            request.Credentials = new NetworkCredential(ftpUser, ftpPass);
            //request.ConnectionGroupName = "group";

            using (FileStream fs = File.OpenRead(pathFile))
            {
                byte[] buffer = new byte[fs.Length];
                fs.Read(buffer, 0, buffer.Length);
                fs.Close();
                Stream requestStream = request.GetRequestStream();
                requestStream.Write(buffer, 0, buffer.Length);
                requestStream.Flush();
                requestStream.Close();
            }
        }

        private bool FtpNewDirectory(string directory, string username, string password)
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(directory);

                // Step 2 - Configure the connection request
                request.Credentials = new NetworkCredential(username, password);
                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = false;

                request.Method = WebRequestMethods.Ftp.MakeDirectory;

                // Step 3 - Call GetResponse() method to actually attempt to create the directory
                FtpWebResponse makeDirectoryResponse = (FtpWebResponse)request.GetResponse();
            }
            catch (WebException ex)
            {
                FtpWebResponse response = (FtpWebResponse)ex.Response;
                if (response.StatusCode == FtpStatusCode.ActionNotTakenFileUnavailable)
                    return false;
                else
                    return true;
            }
            return true;
        }

        private bool CheckIfFileExists(string fileName, string username, string password)
        {
            var request = (FtpWebRequest)WebRequest.Create(fileName);
            request.Credentials = new NetworkCredential(username, password);
            request.Method = WebRequestMethods.Ftp.GetFileSize;

            try
            {
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                return true;
            }
            catch (WebException ex)
            {
                FtpWebResponse response = (FtpWebResponse)ex.Response;
                if (response.StatusCode == FtpStatusCode.ActionNotTakenFileUnavailable)
                    return false;
            }
            return false;
        }

        private void loadPicture()
        {
            string emp_id = empid;
            string rec_id = eid;
            rec_id = rec_id.Replace("+", "-PLUS");

            string directory = string.Format(@"{0}/SbuysPicture/WorkKPI_REC/{1}/{2}", ftpServer, emp_id, rec_id);

            try
            {
                if (CheckIfFileExists(directory + "/image01.png", ftpUser, ftpPass))
                {
                    btnAddPic1.Text = "เปลี่ยนรูป";
                    btnDelPic1.Enabled = true;
                    RECImg1.Load(pathPicture + "/WorkKPI_REC/" + emp_id + "/" + rec_id + "/image01.png");
                    txtImage01.Text = emp_id + "/" + rec_id + "/image01.png";
                }

                else
                {
                    RECImg1.Load(pathPicture + "/WorkKPI_REC/" + emp_id + "/image01.png");
                    txtImage01.Text = emp_id + "/image01.png";
                }
            }
            catch { }

            try
            {
                if (CheckIfFileExists(directory + "/image02.png", ftpUser, ftpPass))
                {
                    btnAddPic2.Text = "เปลี่ยนรูป";
                    btnDelPic2.Enabled = true;
                    RECImg2.Load(pathPicture + "/WorkKPI_REC/" + emp_id + "/" + rec_id + "/image02.png");
                    txtImage02.Text = emp_id + "/" + rec_id + "/image02.png";
                }
                else
                {
                    RECImg2.Load(pathPicture + "/WorkKPI_REC/" + emp_id + "/image02.png");
                    txtImage02.Text = emp_id + "/image02.png";
                }
            }
            catch { }

            try
            {
                if (CheckIfFileExists(directory + "/image03.png", ftpUser, ftpPass))
                {
                    btnAddPic3.Text = "เปลี่ยนรูป";
                    btnDelPic3.Enabled = true;
                    RECImg3.Load(pathPicture + "/WorkKPI_REC/" + emp_id + "/" + rec_id + "/image03.png");
                    txtImage03.Text = emp_id + "/" + rec_id + "/image03.png";
                }
                else
                {
                    RECImg3.Load(pathPicture + "/WorkKPI_REC/" + emp_id + "/image03.png");
                    txtImage03.Text = emp_id + "/image03.png";
                }
            }
            catch { }
        }

        private void FTPDelete(PictureBox picbx, String imageName)
        {
            if (picbx.Image == null)
            {
                MessageBox.Show("ไม่มีรูปภาพให้ทำการลบ", "เกิดข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("คุณต้องการลบรูปภาพใช่หรือไม่", "ยืนยันการลบรูปภาพ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string emp_id = empid;
                    string rec_id = eid;
                    rec_id = rec_id.Replace("+", "-PLUS");
                    string filePath = string.Format(@"{0}/SbuysPicture/WorkKPI_REC/{1}/{2}/{3}", ftpServer, emp_id, rec_id, imageName);

                    if (CheckIfFileExists(filePath, ftpUser, ftpPass))
                    {
                        FtpWebRequest request = (FtpWebRequest)WebRequest.Create(filePath);
                        request.Method = WebRequestMethods.Ftp.DeleteFile;
                        request.Credentials = new NetworkCredential(ftpUser, ftpPass);

                        using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                        {
                            MessageBox.Show("ลบรูปภาพเรียบร้อยแล้ว", "ลบรูปภาพ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            picbx.Image = null;
                            if (imageName == "image01.png")
                            {
                                txtImage01.Text = "";
                                btnAddPic1.Text = "เพิ่มรูป";
                                btnDelPic1.Enabled = false;
                            }
                            else if (imageName == "image02.png")
                            {
                                txtImage02.Text = "";
                                btnAddPic2.Text = "เพิ่มรูป";
                                btnDelPic2.Enabled = false;
                            }
                            else if (imageName == "image03.png")
                            {
                                txtImage03.Text = "";
                                btnAddPic3.Text = "เพิ่มรูป";
                                btnDelPic3.Enabled = false;
                            }

                            picbx.Update();
                        }
                    }
                    else
                    {
                        MessageBox.Show("ไม่สามารถลบรูปภาพที่มาจากข้อมูลรุ่นสินค้าได้", "เกิดข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("ไม่สามารถลบรูปภาพ", "เกิดข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void updatePicPath(string pp1, string pp2, string pp3)
        {
            Database.Connect();
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = Database.vSqlConnection;
            SqlCmd.CommandType = CommandType.Text;

            string sqlL = "UPDATE WorkKPI_HE_REC ";
            sqlL += " SET PICTURE_PATH_1 ='" + pp1 + "'";
            sqlL += ", PICTURE_PATH_2 = '" + pp2 + "'";
            sqlL += ", PICTURE_PATH_3 = '" + pp3 + "'";
            sqlL += ", MOD_USERID = '" + null + "'";
            sqlL += ", MOD_DATETIME = GETDATE() ";
            sqlL += " WHERE REC_ID = '" + eid + "'";
            sqlL += " and  EmpID ='" + empid + "' ";

            SqlCmd.CommandText = sqlL;
            SqlCmd.ExecuteNonQuery();
            Database.Close();
        }

        private void btnDelPic1_Click(object sender, EventArgs e)
        {
            loadPicture();
            FTPDelete(RECImg1, "image01.png");   
            updatePicPath(txtImage01.Text, txtImage02.Text, txtImage03.Text); 
        }

        private void btnDelPic2_Click(object sender, EventArgs e)
        {
            loadPicture();
            FTPDelete(RECImg2, "image02.png");
            updatePicPath(txtImage01.Text, txtImage02.Text, txtImage03.Text);
        }

        private void btnDelPic3_Click(object sender, EventArgs e)
        {
            loadPicture();
            FTPDelete(RECImg3, "image03.png");
            updatePicPath(txtImage01.Text, txtImage02.Text, txtImage03.Text);
        }

        private void loadDate(string opD,string opM, string y)
        {
            dtpDocDateFrom.MinDate = new DateTime(int.Parse(y), 1, 1);
            dtpDocDateFrom.MaxDate = new DateTime(int.Parse(y), 12, 31);
            dtpDocDateFrom.Value = new DateTime(int.Parse(y), int.Parse(opM), int.Parse(opD));
        }

        private void btnZoomP1_Click(object sender, EventArgs e)
        {
            ZoomPic("image01.png");
        }

        private void btnZoomP2_Click(object sender, EventArgs e)
        {
            ZoomPic("image02.png");
        }

        private void btnZoomP3_Click(object sender, EventArgs e)
        {
            ZoomPic("image03.png");
        }

        private void ZoomPic(string fileName)
        {
            string emp_id = empid;
            string rec_id = eid;
            rec_id = rec_id.Replace("+", "-PLUS");
            string imgfile = fileName;

            string directory = string.Format(@"{0}/SbuysPicture/WorkKPI_REC/{1}/{2}", ftpServer, emp_id, rec_id);

            try
            {
                if (CheckIfFileExists(directory + "/" + imgfile, ftpUser, ftpPass))
                    Process.Start(pathPicture + "/WorkKPI_REC/" + emp_id + "/" + rec_id + "/" + imgfile);
                else
                    return;
                    //Process.Start(pathPicture + "/WorkKPI_REC/" + emp_id + "/" + imgfile);
            }
            catch { }
        }
    }
}
