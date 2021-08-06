using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MMPDA
{
    public partial class fSettings : Form
    {
        public fSettings()
        {
            InitializeComponent();
        }

        private void background_Paint(object sender, PaintEventArgs e)
        {
            /*
            foreach (Control C in this.Controls)
            {
                if (C is Label)
                {
                    Label L = (Label)C;
                    L.Visible = false;
                    e.Graphics.DrawString(L.Text, L.Font, new
                    SolidBrush(L.ForeColor), L.Left - pictureBox6.Left, L.Top - pictureBox6.Top);
                }
            }
             */
        }
        private void saveConfig()
        {
            MainForm.ftpsvr = server.Text.Trim();
            MainForm.ftpusr = user.Text.Trim();
            MainForm.ftppwd = password.Text.Trim();
            MainForm.remoteDownDir = txtDDir.Text.Trim();
            MainForm.remoteUpDir = txtUDir.Text.Trim();
            MainForm.localPath = txtLDir.Text.Trim();
            MainForm.Storeloggedin =txtSite.Text.Trim();
            MainForm.debug = chkDebug.Checked;
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            pnlAdmin.Visible = true;
            txtAdmPass.Focus();
            menuSave.Enabled = false;

        }

        private void fSettings_Load(object sender, EventArgs e)
        {
            server.Text = MainForm.ftpsvr;
            user.Text = MainForm.ftpusr;
            password.Text = MainForm.ftppwd;
            txtDDir.Text = MainForm.remoteDownDir;
            txtUDir.Text = MainForm.remoteUpDir;
            txtLDir.Text = MainForm.localPath;
            txtSite.Text = MainForm.Storeloggedin;
        }

        private void btnAdmCancel_Click(object sender, EventArgs e)
        {
            pnlAdmin.Visible = false;
            menuSave.Enabled = true;
        }

        private void btnAdmConfirm_Click(object sender, EventArgs e)
        {
            if (MainForm.Base64Encode(txtAdmPass.Text) == "TU1WTkAyMDIx")
            {
                string oldlocalPath = MainForm.localPath;
                MainForm.localPath = txtLDir.Text.Trim();
                bool save = MainForm.writeConfig();
                if (save) { 
                    MessageBox.Show("Config file saved successful"); 
                    saveConfig(); 
                }
                else { 
                    MessageBox.Show("Can't save config in Folder " + txtLDir.Text);
                    txtLDir.Focus();
                    menuSave.Enabled = true;
                    MainForm.localPath = oldlocalPath;
                }
                pnlAdmin.Visible = false;
            }
            else {
                MessageBox.Show("Invalid password!");
                txtAdmPass.Focus();
            }
        }

        private void txtAdmPass_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == System.Windows.Forms.Keys.Enter))
            {
                // Enter
                btnAdmConfirm_Click(sender,e);
            }
        }
    }
}