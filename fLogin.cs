using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MMPDA
{
    
    public partial class fLogin : Form
    {
        //public static Boolean loggedin = false;  
        public fLogin()
        {
            InitializeComponent();
        }

         private void button8_Click(object sender, EventArgs e)
        {
            // Do validity check here
            try {
                if (int.Parse(txtUser.Text) > 0)
                {

                    if (txtUser.Text == txtPass.Text && txtUser.Text.Length == 5)
                    {
                        MainForm.loggedin = true;
                        MainForm.Storeloggedin = txtUser.Text;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid store code or password.");
                    }
                }
                else {
                    MessageBox.Show("Invalid store code.");
                }
            } catch (Exception){
                MessageBox.Show("Invalid store code");
            }
        }

         private void txtUser_Enter(object sender, EventArgs e)
         {
             if (txtUser.Text == "Enter a store code")
             {
                 txtUser.Text = "";
             }
         }
 
         private void txtUser_Leave(object sender, EventArgs e)
         {
             if (txtUser.Text == "")
             {
                 txtUser.Text = "Enter a store code";
             }
         }

         private void txtPass_Enter(object sender, EventArgs e)
         {
             if (txtPass.Text == "Password")
             {
                 txtPass.Text = "";
                 txtPass.PasswordChar = '*';
             }
         }

         private void txtPass_Leave(object sender, EventArgs e)
         {
             if (txtPass.Text == "")
             {
                 txtPass.Text = "Password";
                 txtPass.PasswordChar = '\0';

             }
         }

         private void fLogin_Validated(object sender, EventArgs e)
         {
             button8_Click(sender,e);
         }

         private void button1_Click(object sender, EventArgs e)
         {
             MainForm.closeapp = true;
             this.Close();
         }

         private void fLogin_KeyDown(object sender, KeyEventArgs e)
         {
              if ((e.KeyCode == System.Windows.Forms.Keys.Enter))
             {
                 // Enter
                 button8_Click(sender, e);
             }
         }

         private void fLogin_Closing(object sender, CancelEventArgs e)
         {
             MainForm.closeapp = true;
         }

         private void menuItem1_Click(object sender, EventArgs e)
         {
             Close();
         }

         private void fLogin_Load(object sender, EventArgs e)
         {
             string ver;
             try { ver = typeof(Program).Assembly.GetName().Version.ToString();
             MainForm.pda_version = ver;
             }
             catch (Exception) { ver = "1.0.0.0"; }
             this.Text = "PDA v" + ver + " | Login";
             txtUser.Text = MainForm.Storeloggedin;
         }
    }
}