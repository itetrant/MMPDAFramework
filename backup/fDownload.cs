﻿using System;

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
        }
        #endregion FTP

        private void connect_Click(object sender, EventArgs e)
        {
            //Timer t = new Timer();

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

        private void getFileList_Click(object sender, EventArgs e)
        {

            string path = MainForm.localPath;

            DirectoryInfo dir = new DirectoryInfo(path);
            FileInfo[] fileinfo;
            try
            {
                 fileinfo = dir.GetFiles();
            }
            catch (Exception) {
                return;
            }
            
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

        private void Download_Click(object sender, EventArgs e)
        {
            string filename = "";
            string path = MainForm.localPath;

            try
            {
                filename = MainForm.filePrefix + MainForm.Storeloggedin + MainForm.fileExtention;
                string fullfilename = path + "//" + filename;
                tabs.SelectedIndex = 0;
                get_ftp.RemoteDirectory = MainForm.remoteDownDir;
                get_ftp.GetFile(filename, fullfilename,true);
                MainForm.taskDownload = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message);
            MainForm.taskDownload = false;
            }
        }

        private void fileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lblFileSelected.Text = fileList.Items[fileList.FocusedItem.Index].Text;
        }

        private void menuClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}