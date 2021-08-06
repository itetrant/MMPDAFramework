using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MMPDA
{
    public partial class fTemplate : Form
    {
        public fTemplate()
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

        private void menuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}