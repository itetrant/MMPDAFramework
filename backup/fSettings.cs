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
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            saveConfig();
            bool save = MainForm.writeConfig();
            if (save) { MessageBox.Show("Config file saved successful"); }
            else { MessageBox.Show("Can't save Config file"); }
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

    }
}