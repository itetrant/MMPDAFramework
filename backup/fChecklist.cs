using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MMPDA
{
    public partial class fChecklist : Form
    {
        public fChecklist()
        {
            InitializeComponent();
        }

       /* private void background_Paint(object sender, PaintEventArgs e)
        {
            
            foreach (Control C in this.Controls)
            {
                if (C is Label)
                {
                    Label L = (Label)C;
                    L.Visible = false;
                    e.Graphics.DrawString(L.Text, L.Font, new
                    SolidBrush(L.ForeColor), L.Left - background.Left, L.Top - background.Top);
                }
            }
             
        }
        */

        private void menuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tskDownload_CheckStateChanged(object sender, EventArgs e)
        {
            if (tskDownload.Checked && !MainForm.taskDownload)
            {
                fDownload f = new fDownload();
                f.ShowDialog();
            }
        }

        private void tskPrint_CheckStateChanged(object sender, EventArgs e)
        {
            if (tskPrint.Checked && !MainForm.taskPrint)
            {
                //fRailcard f = new fRailcard();
                //f.ShowDialog();
            }
        }

        private void tskCheckprice_CheckStateChanged(object sender, EventArgs e)
        {
            if (tskCheckprice.Checked && !MainForm.taskCheckprice)
            {
                fPricecheck f = new fPricecheck();
                f.ShowDialog();
            }
        }

        private void tskUpload_CheckStateChanged(object sender, EventArgs e)
        {
            if (tskUpload.Checked && !MainForm.taskUpload)
            {
                fUpload f = new fUpload();
                f.ShowDialog();
            }
        }

        private void fChecklist_Load(object sender, EventArgs e)
        {
            int tskdone = 0;

            if (MainForm.taskCheckprice ==true ){tskdone +=1;}
            if (MainForm.taskPrint == true) { tskdone += 1; }
            if (MainForm.taskDownload == true) { tskdone += 1; }
            if (MainForm.taskUpload == true) { tskdone += 1; }
            tskCheckprice.Checked = MainForm.taskCheckprice;
            tskPrint.Checked = MainForm.taskPrint;
            tskDownload.Checked = MainForm.taskDownload;
            tskUpload.Checked = MainForm.taskUpload;
            this.Text = "Tasks(" + tskdone.ToString() + "/4) done";

        }

    }
}