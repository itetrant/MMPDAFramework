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

namespace MMPDA
{
    /// <summary>
    /// MMPDA Frmework for WINCE/PocketPC
    /// </summary>
    public partial class MainForm : Form
    {
        #region InitializeComponent
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Parameters/ Variants definition

        public static Boolean loggedin = false;
        public static Boolean closeapp = false;
        public static Boolean configStatus = false;
        /// <summary>
        /// Define task list
        /// </summary>
        public static Boolean taskDownload = false;
        public static Boolean taskPrint= false;
        public static Boolean taskUpload = false;
        public static Boolean taskCheckprice = false;
        //End tasklist

        public static DataTable products;
        public static String pda_version = "1.0.0.0";
        public static String filePrefix = "MMPDA";
        public static String fileExtention = ".TXT";
        /// <summary>
        /// Default Parameters, configurable at settings module (or pdaconfig.txt)
        /// </summary>
        public static String ftpsvr = "";
        public static String ftpusr = "";
        public static String ftppwd = "";
        public static String remoteDownDir = "/Aldata/LIFE/HEAD/DOWN/PDA";
        public static String remoteUpDir = "/Aldata/LIFE/HEAD/UP/PDA";
        public static String Storeloggedin = "10010";
        public static String localPath = "";

        #endregion Parameters/ Variants definition

        #region MainForm Events

        //Load file config, get local folder
        private void MainForm_Load(object sender, EventArgs e)
        {
            try //PDA device
            {
                
                if (Platform.PlatformDetection.IsWINCE()) {
                    //We are using this devices 
                    //FullScreen.StartFullScreen(this); 
                }
                else if (Platform.PlatformDetection.IsPocketPC())
                {
                    //Testing this devices;
                    //FullScreen.StartFullScreen(this); 
                }
                else {
                    MessageBox.Show("This App may not work well on " + Platform.PInvoke.GetPlatformType());
                }
                localPath = getLocalPath();
                loadConfig();
                fLogin f = new fLogin();
                f.ShowDialog();
            }
            catch (Exception)
            {
                //Windows 10;
                localPath = getLocalPath();
                loadConfig();
                fLogin f = new fLogin();
                f.ShowDialog();
            }
        }

        //Set title logged in store
        private void MainForm_Activated(object sender, EventArgs e)
        {
            try
            {
                if (loggedin) { 
                    //this.pnlMenu.Show(); 
                    this.Text = "Store:" + MainForm.Storeloggedin + "|v" + pda_version;
                }
                else if (closeapp) { 
                    //FullScreen.StopFullScreen(this); 
                    Application.Exit(); 
                }
            }
            catch (Exception) {
                Application.Exit();
            };
        }

        //Not use
        private void MainForm_Closing(object sender, CancelEventArgs e)
        {
            /* 
             //Check & warning here
             if (MainForm.taskUpload == false && MainForm.taskCheckprice == true)
            {
                DialogResult cf = MessageBox.Show("Close without Upload?", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (cf == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
             */
        }

        //Not use
        private void MainForm_Closed(object sender, EventArgs e)
        {
            //Save stats
            //saveStatus();            
        }

        //Not use
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == System.Windows.Forms.Keys.Up))
            {
                // Rocker Up
                // Up
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Down))
            {
                // Rocker Down
                // Down
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Left))
            {
                // Left
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Right))
            {
                // Right
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Enter))
            {
                // Enter
            }

        }

        #endregion

        #region Public functions

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes, 0, base64EncodedBytes.Length);
        }

        public string getLocalPath()
        {
            string path = "";
            try
            {
                if (Platform.PlatformDetection.IsPocketPC())
                {
                    //Emulator   
                    try { 
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
                else { 
                    path = "\\";
                }
            }
            catch (Exception)
            {
                //Desktop
                try { path = Directory.GetCurrentDirectory(); }
                catch (Exception) { path = "C:\\"; }
            }
            return path;
        }

        #endregion Public functions

        #region Other private funtions - optional

        private void background_Paint(object sender, PaintEventArgs e)
        {
            /* foreach (Control C in this.Controls)
             {
                 if (C is Label)
                 {
                     Label L = (Label)C;
                     L.Visible = false;
                     e.Graphics.DrawString(L.Text, L.Font, new
                     SolidBrush(L.ForeColor), L.Left - background.Left, L.Top - background.Top);
                 }
             }
             */
        }

        #endregion Other private funtions

        #region Write / read files

        private void saveStatus() { 
            //
            string filename = localPath + "\\checklist.txt";
            if (!File.Exists(filename)) // may have to specify path here!
            {
                // may have to specify path here!
                File.Create(filename).Close();
            }

            // may have to specify path here!
            StreamWriter swFile =
                         new StreamWriter(
                            new FileStream(filename,
                                           FileMode.Truncate),
                            Encoding.ASCII);

            swFile.WriteLine("checklist1|false");
            swFile.WriteLine("checklist2|false");
            swFile.WriteLine("checklist2|false");
            swFile.WriteLine("checklist3|false");

            swFile.Close();
        }
        private void loadStatus()
        {
            //
        }
        public static bool writeConfig()
        {

            string filename = localPath + "\\pdaconfig.txt";
            try
            {
                if (!File.Exists(filename)) // may have to specify path here!
                {
                    // may have to specify path here!
                    File.Create(filename).Close();
                }

                // may have to specify path here!
                StreamWriter swFile =
                             new StreamWriter(
                                new FileStream(filename,
                                               FileMode.Truncate),
                                Encoding.ASCII);

                swFile.WriteLine(MainForm.Storeloggedin);
                swFile.WriteLine(MainForm.localPath);
                swFile.WriteLine(MainForm.ftpsvr);
                swFile.WriteLine(MainForm.ftpusr);
                swFile.WriteLine(Base64Encode(MainForm.ftppwd));
                swFile.WriteLine(MainForm.remoteDownDir);
                swFile.WriteLine(MainForm.remoteUpDir);

                swFile.Close();
                return true;
            }
            catch (Exception) { return false; }
        }
        private void loadConfig()
        {
            //
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
                            MainForm.Storeloggedin = line;
                        }
                        else if (row == 2)
                        {
                            MainForm.localPath = line;
                        }
                        else if (row == 3)
                        {
                            MainForm.ftpsvr = line;
                        }
                        else if (row == 4)
                        {
                            MainForm.ftpusr = line;
                        }
                        else if (row == 5)
                        {
                            MainForm.ftppwd = Base64Decode(line);
                        }
                        else if (row == 6)
                        {
                            MainForm.remoteDownDir = line;
                        }
                        else if (row == 7)
                        {
                            MainForm.remoteUpDir = line;
                        }
                    }

                    file.Close();
                    configStatus = true;
                }
                else
                {
                    //Config not found
                    configStatus = false;
                    ftpsvr = "172.26.24.101";
                    ftpusr = Base64Decode("Z2FpYTUxMA==");
                    ftppwd = Base64Decode("Z2FpYTUxMA==");
                    MessageBox.Show("Config file not found");
                }
            }
            catch (Exception ex) {
                configStatus = false;
                MessageBox.Show(ex.Message);
            }

        }
        
        #endregion Write / read files

        #region !!!MAIN funtional buttons!!!
        //One funtion Button_Click for all. EDIT when adding new module!!!
        private void btnButton_Click(object sender, EventArgs e)
        {
            string callfunc = ((PictureBox)sender).Name;
            if (callfunc == "btnDownload")
            {
                call_Download(sender,e);
            }

            else if (callfunc == "btnPricecheck")
            {
                lblPricecheck.Visible = true;
                call_Pricecheck(sender, e);
            }
            else if (callfunc == "btnUpload")
            {
                lblUpload.Visible = true;
                call_Upload(sender, e);
            }
            else if (callfunc == "btnChecklist")
            {
                lblDownload.Visible = true;
                call_Checklist(sender, e);
            }
            else if (callfunc == "btnSettings")
            {
                lblSettings.Visible = true;
                call_Settings(sender, e);
            }
            else if (callfunc == "btnUpdate")
            {
                lblSettings.Visible = true;
                call_Update(sender, e);
            }
            ///New function
            else if (callfunc == "New_button_name")
            {
                //call_New_button_name(sender,e);
            }
            ///End New function
            else
            {
                string lbl = ((PictureBox)sender).Name;
                lbl = "lbl" + lbl.Substring(3);
                foreach (Control C in this.Controls)
                {
                    if (C is Label && C.Name == lbl)
                    {
                        C.Visible = true;
                    }
                }
                MessageBox.Show("You clicked button " + ((PictureBox)sender).Name);
            }
        }
        
        //Download master data
        private void call_Download(object sender, EventArgs e)
        {

            fDownload f = new fDownload();
            f.ShowDialog();

        }
        
        //Config ftp server, U/P, remote, local path
        private void call_Settings(object sender, EventArgs e)
        {

            fSettings f = new fSettings();
            f.ShowDialog();

        }
        
        //Upload work data to server
        private void call_Upload(object sender, EventArgs e)
        {
            fUpload f = new fUpload();
            f.ShowDialog();
        }
        
        //Load Price checker module
        private void call_Pricecheck(object sender, EventArgs e)
        {
            //MessageBox.Show("You call function Pricecheck()");
            //Code here
            fPricecheck f = new fPricecheck();
            f.ShowDialog();
        }
        
        //Import master data into Memory/Datatable for HIGH performance PDA only!!!
        private void call_Import(object sender, EventArgs e)
        {
            //MessageBox.Show("You call function Pricecheck()");
            //Code here
            fImport f = new fImport();
            f.ShowDialog();
        }
        //Load Checlist
        private void call_Checklist(object sender, EventArgs e)
        {
            //Code here
            fChecklist f = new fChecklist();
            f.ShowDialog();
        }
        private void call_Exit(object sender, EventArgs e)
        {
            //Code here
            Close();
        }
        //Update new version
        private void call_Update(object sender, EventArgs e)
        {
            if (taskUpload == false)
            {
                //DialogResult cf = MessageBox.Show("Close without Upload data?", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                //if (cf == DialogResult.OK) { taskUpload = true; }
               // else { return; }
            }

            try
            {
                System.Diagnostics.ProcessStartInfo info = new ProcessStartInfo();
                info.FileName = localPath + "\\MMPDAUpdate.exe";
                info.UseShellExecute = false;
                Process.Start(info);
                Close();

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }

        #endregion funtional buttons

        #region Menu Items

        private void menuExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion Menu
    }
}