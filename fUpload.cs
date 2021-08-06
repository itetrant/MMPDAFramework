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
    public partial class fUpload : Form
    {
        delegate void StringDelegate(string value);
        private FTP send_ftp;
        private FileInfo[] files;
        private bool _connected = false;
        private string _ext = "*.sav";
        public fUpload()
        {
            InitializeComponent();
        }

        private void connect_Click(object sender, EventArgs e)
        {
            menuUpload.Enabled = false;
            tabs.SelectedIndex = 0;
            try
            {
                OnResponse("Connecting...");
                
                send_ftp = new FTP(server.Text);
                send_ftp.ResponseReceived += new FTPResponseHandler(send_ftp_ResponseReceived);
                send_ftp.Connected += new FTPConnectedHandler(send_ftp_Connected);
                send_ftp.BeginConnect(user.Text, password.Text);
                
            }
            catch (FTPException ex)
            {
               MessageBox.Show(ex.Message);
            }
        }

        void send_ftp_Connected(FTP source)
        {
            // when this happens we're ready to send command
            OnResponse("Connected.");

        }

        void send_ftp_ResponseReceived(FTP source, FTPResponse Response)
        {
            OnResponse(Response.Text);
        }

        private void OnResponse(string response)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new StringDelegate(OnResponse), new object[] { response } );
                return;
            }
            ListViewItem item = new ListViewItem(new string[] { DateTime.Now.ToShortTimeString(), response });
            status.Items.Insert(0, item);
            status.Columns[1].Width = -1;
            if (response == "Connected.") 
            { 
                _connected = true;
                tabs.SelectedIndex = 1;
                getFileList_Click();
                menuUpload.Enabled = true;
            }
        }

        private void getFileList_Click()
        {

            string path = MainForm.localPath;
            DirectoryInfo dir = new DirectoryInfo(path);
            try
            {
                FileInfo[] fileinfo = dir.GetFiles("*.sav");            
                fileList.Items.Clear();
                if (fileinfo.Length > 0)
                {
                    foreach (FileInfo file in fileinfo)
                    {
                        fileList.Items.Add(new ListViewItem(new string[] { file.Name, file.CreationTime.ToString() }));
                    }
                }
            }
            catch (Exception){return;}
        }

        private void upload_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            menuUpload.Enabled = false;
            string filename ="";
            string path = MainForm.localPath;
            tabs.SelectedIndex = 1;
            int _count = files.Length;
            //fileList.Items[0].Selected = true;
            if (_count > 0)
            {
                foreach (FileInfo file in files)
                {
                    //fileList.Items.Add(new ListViewItem(new string[] { file.Name, file.CreationTime.ToString() }));
                    try
                    {
                        //filename = fileList.Items[fileList.FocusedItem.Index].Text;
                        //tabs.SelectedIndex = 0;
                        filename = file.Name;
                        string fullfilename = path + "\\" + filename;
                        FileStream stream = File.OpenRead(fullfilename);
                        send_ftp.RemoteDirectory = MainForm.remoteUpDir;
                        send_ftp.SendFile(stream, fullfilename);
                        stream.Close();
                        if (MainForm.taskUpload == false)
                        { MainForm.taskUpload = true; }
                        //File.Copy(fullfilename, fullfilename + ".done", true);
                        File.Delete(fullfilename);
                    }
                    catch (Exception){ }
                }

            }else { MessageBox.Show("No file to upload"); }
            MessageBox.Show(_count + " file(s) uploaded");
            Cursor.Current = Cursors.Default;
            menuUpload.Enabled = true;
        }

        private void menuClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fUpload_Load(object sender, EventArgs e)
        {
            server.Text = MainForm.ftpsvr;
            user.Text = MainForm.ftpusr;
            password.Text = MainForm.ftppwd;
            string path = MainForm.localPath;
            DirectoryInfo dir = new DirectoryInfo(path);
            try
            {
                files = dir.GetFiles(_ext);
            }
            catch (Exception) { return; }
            if (!_connected) { connect_Click(sender,e); }
        }
    }
}