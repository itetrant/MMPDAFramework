using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OpenNETCF.Net.Ftp;
using System.IO;

namespace MMPDA
{
    public partial class fDownload : Form
    {
        delegate void StringDelegate(string value);
        private FTP get_ftp;
        private bool _connected;
        public fDownload()
        {
            InitializeComponent();
        }
        #region Form Events
        private void fDownload_Load(object sender, EventArgs e)
        {
            server.Text = MainForm.ftpsvr;
            user.Text = MainForm.ftpusr;
            password.Text = MainForm.ftppwd;
            connect_Click(sender, e);
        }
        #endregion

        #region FTP
        void get_ftp_Connected(FTP source)
        {
            // when this happens we're ready to send command
            OnResponse("Connected.");
        }

        void get_ftp_ResponseReceived(FTP source, FTPResponse Response)
        {
            
            OnResponse(Response.Text);
        }

        private void OnResponse(string response)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new StringDelegate(OnResponse), new object[] { response });
                return;
            }
            ListViewItem item = new ListViewItem(new string[] { DateTime.Now.ToShortTimeString(), response });
            status.Items.Insert(0, item);
            status.Columns[1].Width = -1;
            lblStatus.Text = response;
            if (response == "Connected.")
            {
                menuDownload.Enabled = true;
                _connected = true;
            }

        }
        #endregion FTP

        private void connect_Click(object sender, EventArgs e)
        {
            //Timer t = new Timer();
            menuDownload.Enabled = false;
            try
            {
                OnResponse("Connecting...");
                get_ftp = new FTP(server.Text);
                get_ftp.ResponseReceived += new FTPResponseHandler(get_ftp_ResponseReceived);
                get_ftp.Connected += new FTPConnectedHandler(get_ftp_Connected);
                get_ftp.BeginConnect(user.Text, password.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getFileList_Click()
        {

            string path = MainForm.localPath;

            DirectoryInfo dir = new DirectoryInfo(path);
            FileInfo[] fileinfo;
            try
            {
                 fileinfo = dir.GetFiles(MainForm.filePrefix + "*" + MainForm.Storeloggedin + MainForm.fileExtention);
                //fileinfo = dir.GetFiles("*.sav");
            }
            catch (Exception) {return;}
            
            fileList.Items.Clear();

            foreach (FileInfo file in fileinfo)
            {
                fileList.Items.Add(new ListViewItem(new string[] { file.Name, file.CreationTime.ToString() }));
            }

            tabs.SelectedIndex = 1;
            try //select 1st file
            {
                fileList.Items[0].Selected = true;
            }
            catch (Exception) { 
                //No file found
            }

        }

        private void FullDownload_Click(object sender, EventArgs e)
        {
            if (_connected)
            {
                
                Cursor.Current = Cursors.WaitCursor;
                menuDownload.Enabled = false;
                menuConnect.Enabled = false;
                menuClose.Enabled = false;
                string filename = "";
                string path = MainForm.localPath;
                int _count = 0;
                tabs.SelectedIndex = 1;
                lblStatus.Visible = true;

                if (MainForm.debug)
                {
                    try
                    {
                        get_ftp.RemoteDirectory = MainForm.remoteDownDir + "/RELEASE";
                        get_ftp.TransferType = FTPTransferType.Binary;
                        filename = MainForm.filePrefix + "Update.exe";
                        string fullfilename = path + "//" + filename;
                        get_ftp.GetFile(filename, fullfilename, true);
                    }
                    catch (Exception) { //no data found
                    }
                    
                }
                get_ftp.RemoteDirectory = MainForm.remoteDownDir;
                get_ftp.TransferType = FTPTransferType.ASCII;

                try
                {
                    filename = MainForm.filePrefix + "05" + MainForm.Storeloggedin + MainForm.fileExtention;
                    string fullfilename = path + "//" + filename;
                    get_ftp.GetFile(filename, fullfilename, true);
                    _count += 1;
                }
                catch (Exception) { }
                try
                {
                    filename = MainForm.filePrefix + "04" + MainForm.Storeloggedin + MainForm.fileExtention;
                    string fullfilename = path + "//" + filename;
                    get_ftp.GetFile(filename, fullfilename, true);
                    _count += 1;
                }
                catch (Exception) { }
                try
                {
                    filename = MainForm.filePrefix + "03" + MainForm.Storeloggedin + MainForm.fileExtention;
                    string fullfilename = path + "//" + filename;
                    get_ftp.GetFile(filename, fullfilename, true);
                    _count += 1;
                }
                catch (Exception) { }
                try
                {
                    filename = MainForm.filePrefix + "02" + MainForm.Storeloggedin + MainForm.fileExtention;
                    string fullfilename = path + "//" + filename;
                    get_ftp.GetFile(filename, fullfilename, true);
                    _count += 1;
                }
                catch (Exception) { }
                try
                {
                    filename = MainForm.filePrefix + "01" + MainForm.Storeloggedin + MainForm.fileExtention;
                    string fullfilename = path + "//" + filename;
                    get_ftp.GetFile(filename, fullfilename, true);
                    _count += 1;
                }
                catch (Exception) { }

                Cursor.Current = Cursors.Default;
                menuClose.Enabled = true;
                if (_count > 0)
                {
                    MainForm.taskDownload = true;
                    lblStatus.Visible = false;
                    MessageBox.Show(_count + " file(s) downloaded successfully");
                }
                else
                {
                    menuDownload.Enabled = true;
                    menuConnect.Enabled = true;
                    MessageBox.Show("Missing master files!");
                }

            }
            else { lblStatus.Visible = false; 
                MessageBox.Show("Can't download in disconnected mode"); } 

        }

        private void fileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lblFileSelected.Text = fileList.Items[fileList.FocusedItem.Index].Text;
        }

        private void menuClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuDiv_Click(string _div)
        {
            if (_connected)
            {

                Cursor.Current = Cursors.WaitCursor;
                menuDownload.Enabled = false;
                menuConnect.Enabled = false;
                menuClose.Enabled = false;
                string filename = "";
                string path = MainForm.localPath;
                int _count = 0;
                tabs.SelectedIndex = 1;
                lblStatus.Visible = true;
                get_ftp.RemoteDirectory = MainForm.remoteDownDir;
                get_ftp.TransferType = FTPTransferType.ASCII;

                try
                {
                    filename = MainForm.filePrefix + _div + MainForm.Storeloggedin + MainForm.fileExtention;
                    string fullfilename = path + "//" + filename;
                    get_ftp.GetFile(filename, fullfilename, true);
                    _count += 1;
                }
                catch (Exception) { }

                Cursor.Current = Cursors.Default;
                menuClose.Enabled = true;
                if (_count > 0)
                {
                    MainForm.taskDownload = true;
                    lblStatus.Visible = false;
                    MessageBox.Show("Data of Division " + _div +" downloaded successfully");
                }
                else
                {
                    menuDownload.Enabled = true;
                    menuConnect.Enabled = true;
                    MessageBox.Show("Missing master file of Division " + _div);
                }

            }
            else
            {
                lblStatus.Visible = false;
                MessageBox.Show("Can't download in disconnected mode");
            } 
        }

        private void menuDiv01_Click(object sender, EventArgs e)
        {
            menuDiv_Click("01");
        }

        private void menuDiv02_Click(object sender, EventArgs e)
        {
            menuDiv_Click("02");
        }

        private void menuDiv03_Click(object sender, EventArgs e)
        {
            menuDiv_Click("03");
        }

        private void menuDiv04_Click(object sender, EventArgs e)
        {
            menuDiv_Click("04");
        }

        private void menuDiv05_Click(object sender, EventArgs e)
        {
            menuDiv_Click("05");
        }

        private void tabs_GotFocus(object sender, EventArgs e)
        {
            getFileList_Click();
        }
    }
}