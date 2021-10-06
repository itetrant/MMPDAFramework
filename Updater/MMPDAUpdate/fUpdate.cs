using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using OpenNETCF.Net.Ftp;
using System.IO;
using System.Reflection;

namespace MMPDAUpdate
{
    public partial class fUpdate : Form
    {
        public fUpdate()
        {
            InitializeComponent();
        }

        public static String ftpsvr = "";
        public static String ftpusr = "";
        public static String ftppwd = "";
        public static String remoteDownDir = "/Aldata/LIFE/HEAD/DOWN/PDA";
        public static String remoteUpDir = "/Aldata/LIFE/HEAD/UP/PDA";
        public static String Storeloggedin = "10010";
        public static String localPath = "";

        private string updateDir = "/Aldata/LIFE/HEAD/DOWN/PDA/RELEASE";
        private string remotefile = "MMPDA.exe";


        delegate void StringDelegate(string value);
        private FTP get_ftp;
        private bool connectStatus = false;
        private bool updateStatus = false;

        private string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        private string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes, 0, base64EncodedBytes.Length);
        }

        private void writelog(bool stats)
        {
            //
            string filename = localPath + "\\update.log";
            if (!File.Exists(filename)) // may have to specify path here!
            {
                // may have to specify path here!
                File.Create(filename).Close();
            }

            // may have to specify path here!
            StreamWriter swFile =
                         new StreamWriter(
                            new FileStream(filename,
                                           FileMode.Append),
                            Encoding.ASCII);
            try
            {
                swFile.WriteLine(DateTime.Now.ToString("dd/MM/yy hh:mm:ss") + "->" + stats.ToString());
            }
            catch (Exception) {
                swFile.WriteLine("Update status: " + stats.ToString());
            }
            swFile.Close();
        }
        private string getLocalPath()
        {
            string path = "";
            try
            {
                if (Platform.PlatformDetection.IsPocketPC())
                {
                    //Emulator   
                    try
                    {
                        string codebase = Assembly.GetExecutingAssembly().GetName().CodeBase;
                        path = Path.GetDirectoryName(codebase);
                    }
                    catch (Exception) { path = "\\Temp"; }
                }
                else if (Platform.PlatformDetection.IsWINCE())
                {
                    //MMPDA
                    try
                    {
                        //path = Directory.GetCurrentDirectory();
                        string codebase = Assembly.GetExecutingAssembly().GetName().CodeBase;
                        path = Path.GetDirectoryName(codebase);
                    }
                    catch (Exception) { path = "\\FlashDisk\\MMPDA"; }
                }
                else
                {
                    path = "\\FlashDisk\\MMPDA";
                }
            }
            catch (Exception)
            {
                //Desktop
                try { path = Directory.GetCurrentDirectory(); }
                catch (Exception) { path = "C:\\MMPDA"; }
            }
            return path;
        }

        private void loadConfig()
        {
            //
            localPath = getLocalPath();
            
            string filename = localPath + "\\pdaconfig.txt";
            try
            {
                if (File.Exists(filename)) // may have to specify path here!
                {
                    //read file
                    int row = 0;
                    string line = "";
                    StreamReader file = new StreamReader(filename);
                    while (row < 7 && (line = file.ReadLine()) != null)
                    {
                        row += 1;
                        if (row == 1)
                        {
                            Storeloggedin = line;
                        }
                        else if (row == 2)
                        {
                            localPath = line;
                        }
                        else if (row == 3)
                        {
                            ftpsvr = line;
                            server.Text = ftpsvr;
                        }
                        else if (row == 4)
                        {
                            ftpusr = line;
                            user.Text = ftpusr;
                        }
                        else if (row == 5)
                        {
                            ftppwd = Base64Decode(line);
                            password.Text = ftppwd;
                        }
                        else if (row == 6)
                        {
                            remoteDownDir = line;
                        }
                        else if (row == 7)
                        {
                            remoteUpDir = line;
                        }
                    }

                    file.Close();
                }
                else
                {
                    //Config not found
                    ftpsvr = "172.26.24.101";
                    ftpusr = Base64Decode("Z2FpYTUxMA==");
                    ftppwd = Base64Decode("Z2FpYTUxMA==");
                    MessageBox.Show("Config file not found. Please return, settings and try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

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
            //Update status bar
            statusBar.Text = response;
              if (response == "Connected.")
            {
                picLoading(false);
                picReady.Visible = true;
                menuUpdate.Enabled = true;
                statusBar.Text = "Connected. Ready for update";
                Cursor.Current = Cursors.Default;
                connectStatus = true;
            }
        }
        #endregion FTP

        private void Connect(object sender, EventArgs e)
        {
            //Timer t = new Timer();
            menuConnect.Enabled = false;
            menuUpdate.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            
            updateDir = remoteDownDir + "/RELEASE";
            server.Text = ftpsvr;
            user.Text = ftpusr;
            password.Text = ftppwd;

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
            Cursor.Current = Cursors.Default;

        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            call_Return(sender,e);
        }

        private void call_Return(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.ProcessStartInfo info = new ProcessStartInfo();
                info.FileName = localPath + "\\MMPDA.exe";
                info.UseShellExecute = false;
                Process.Start(info);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }
        }

        ///Download update

        private void picLoading(bool show){

            picLoading1.Visible = show;
        }

        private void getUpdate(object sender, EventArgs e)
        {
            menuUpdate.Enabled = false;
            picReady.Visible = false;
            picLoading(true);
            Cursor.Current = Cursors.WaitCursor;
            
            if (connectStatus)
            {
                
                string localfile = localPath + "//" + remotefile;
                string tempFile = localPath + "//" + "MMPDA.tmp";
                try
                {
                    get_ftp.RemoteDirectory = updateDir;
                    get_ftp.TransferType = FTPTransferType.Binary;
                    statusBar.Text = "Updating...";
                    
                    try
                    {
                        get_ftp.GetFile(remotefile, tempFile, true);
                        //rename .tmp to .exe
                        statusBar.Text = "Ready for update.";
                        //Check & kill MMPDA.exe if running

                        File.Copy(tempFile, localfile, true);
                        File.Delete(tempFile);
                        
                        statusBar.Text = "Update success!";
                        picLoading(false);
                        picDone.Visible = true;
                        updateStatus = true;
                        menuUpdate.Enabled = false;
                        menuConnect.Enabled = false;
                        writelog(true);

                    }
                    catch (Exception)
                    {
                        writelog(false);
                        File.Delete(tempFile);
                        statusBar.Text = "No new version to update";
                        picLoading(false);
                        picFailed.Visible = false;                        
                    }

                }
                catch (Exception ex)
                {
                    writelog(false);
                    MessageBox.Show(ex.Message);
                    statusBar.Text = "Update failed";
                    picLoading(false);
                    picFailed.Visible = true;
                }
            }
            else { picLoading(false); 
                statusBar.Text = "Disconnected. Try connect & update again";
                menuConnect.Enabled = true;
                menuUpdate.Enabled = true;
            }
            Cursor.Current = Cursors.Default;
        }

        private void picDone_Click(object sender, EventArgs e)
        {
            call_Return(sender, e);
        }

        private void fUpdate_Load(object sender, EventArgs e)
        {

            string ver;
            try
            {
                ver = typeof(Program).Assembly.GetName().Version.ToString();
            }
            catch (Exception) { ver = "1.0.0.0"; }
            this.Text = "PDA v" + ver + " | Update";
            
            loadConfig();
            picLoading(true);
            if (!updateStatus) { Connect(sender, e); }
        }

        private void picReady_Click(object sender, EventArgs e)
        {
            getUpdate(sender,e);
        }
    }
}