namespace MMPDA
{
    partial class fSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuClose = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuSave = new System.Windows.Forms.MenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.server = new System.Windows.Forms.TextBox();
            this.txtUDir = new System.Windows.Forms.TextBox();
            this.lblUpDir = new System.Windows.Forms.Label();
            this.txtDDir = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLDir = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.lblAdmTitle = new System.Windows.Forms.Label();
            this.btnAdmCancel = new System.Windows.Forms.Button();
            this.btnAdmConfirm = new System.Windows.Forms.Button();
            this.txtAdmPass = new System.Windows.Forms.TextBox();
            this.chkDebug = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuClose);
            this.mainMenu1.MenuItems.Add(this.menuItem3);
            this.mainMenu1.MenuItems.Add(this.menuSave);
            // 
            // menuClose
            // 
            this.menuClose.Text = "&Close";
            this.menuClose.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Enabled = false;
            this.menuItem3.Text = "|";
            // 
            // menuSave
            // 
            this.menuSave.Text = "&Save";
            this.menuSave.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.Text = "pwd";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(47, 91);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(188, 21);
            this.password.TabIndex = 13;
            this.password.Text = "gaia510";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.Text = "user";
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(47, 64);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(188, 21);
            this.user.TabIndex = 12;
            this.user.Text = "gaia510";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.Text = "ftp://";
            // 
            // server
            // 
            this.server.Location = new System.Drawing.Point(47, 37);
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(188, 21);
            this.server.TabIndex = 10;
            this.server.Text = "172.26.24.101";
            // 
            // txtUDir
            // 
            this.txtUDir.Location = new System.Drawing.Point(47, 118);
            this.txtUDir.Name = "txtUDir";
            this.txtUDir.Size = new System.Drawing.Size(188, 21);
            this.txtUDir.TabIndex = 10;
            this.txtUDir.Text = "/Aldata/LIFE/HEAD/UP/PDA";
            // 
            // lblUpDir
            // 
            this.lblUpDir.Location = new System.Drawing.Point(7, 119);
            this.lblUpDir.Name = "lblUpDir";
            this.lblUpDir.Size = new System.Drawing.Size(40, 20);
            this.lblUpDir.Text = "UDir";
            // 
            // txtDDir
            // 
            this.txtDDir.Location = new System.Drawing.Point(47, 145);
            this.txtDDir.Name = "txtDDir";
            this.txtDDir.Size = new System.Drawing.Size(188, 21);
            this.txtDDir.TabIndex = 10;
            this.txtDDir.Text = "/Aldata/LIFE/HEAD/DOWN/PDA";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(7, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.Text = "DDir";
            // 
            // txtSite
            // 
            this.txtSite.Location = new System.Drawing.Point(47, 196);
            this.txtSite.Name = "txtSite";
            this.txtSite.Size = new System.Drawing.Size(188, 21);
            this.txtSite.TabIndex = 10;
            this.txtSite.Text = "10010";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(7, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.Text = "Site";
            // 
            // txtLDir
            // 
            this.txtLDir.Location = new System.Drawing.Point(47, 220);
            this.txtLDir.Name = "txtLDir";
            this.txtLDir.Size = new System.Drawing.Size(188, 21);
            this.txtLDir.TabIndex = 10;
            this.txtLDir.Text = "/FlashDisk/MMPDA";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(7, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.Text = "LDir";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(7, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 20);
            this.label7.Text = "Remote";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(7, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 20);
            this.label8.Text = "Local";
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlAdmin.Controls.Add(this.lblAdmTitle);
            this.pnlAdmin.Controls.Add(this.btnAdmCancel);
            this.pnlAdmin.Controls.Add(this.btnAdmConfirm);
            this.pnlAdmin.Controls.Add(this.txtAdmPass);
            this.pnlAdmin.Location = new System.Drawing.Point(47, 61);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(158, 93);
            this.pnlAdmin.Visible = false;
            // 
            // lblAdmTitle
            // 
            this.lblAdmTitle.BackColor = System.Drawing.Color.Black;
            this.lblAdmTitle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblAdmTitle.ForeColor = System.Drawing.Color.White;
            this.lblAdmTitle.Location = new System.Drawing.Point(0, 0);
            this.lblAdmTitle.Name = "lblAdmTitle";
            this.lblAdmTitle.Size = new System.Drawing.Size(158, 19);
            this.lblAdmTitle.Text = "Enter Admin Password";
            this.lblAdmTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAdmCancel
            // 
            this.btnAdmCancel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.btnAdmCancel.Location = new System.Drawing.Point(80, 67);
            this.btnAdmCancel.Name = "btnAdmCancel";
            this.btnAdmCancel.Size = new System.Drawing.Size(58, 20);
            this.btnAdmCancel.TabIndex = 2;
            this.btnAdmCancel.Text = "Cancel";
            this.btnAdmCancel.Click += new System.EventHandler(this.btnAdmCancel_Click);
            // 
            // btnAdmConfirm
            // 
            this.btnAdmConfirm.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.btnAdmConfirm.Location = new System.Drawing.Point(20, 67);
            this.btnAdmConfirm.Name = "btnAdmConfirm";
            this.btnAdmConfirm.Size = new System.Drawing.Size(58, 20);
            this.btnAdmConfirm.TabIndex = 1;
            this.btnAdmConfirm.Text = "Confirm";
            this.btnAdmConfirm.Click += new System.EventHandler(this.btnAdmConfirm_Click);
            // 
            // txtAdmPass
            // 
            this.txtAdmPass.Location = new System.Drawing.Point(19, 31);
            this.txtAdmPass.Name = "txtAdmPass";
            this.txtAdmPass.PasswordChar = '*';
            this.txtAdmPass.Size = new System.Drawing.Size(122, 21);
            this.txtAdmPass.TabIndex = 0;
            this.txtAdmPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAdmPass_KeyDown);
            // 
            // chkDebug
            // 
            this.chkDebug.BackColor = System.Drawing.Color.White;
            this.chkDebug.Location = new System.Drawing.Point(134, 174);
            this.chkDebug.Name = "chkDebug";
            this.chkDebug.Size = new System.Drawing.Size(15, 15);
            this.chkDebug.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.label9.Location = new System.Drawing.Point(47, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 19);
            this.label9.Text = "Debug mode:";
            // 
            // fSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.chkDebug);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pnlAdmin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.user);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblUpDir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLDir);
            this.Controls.Add(this.txtSite);
            this.Controls.Add(this.txtDDir);
            this.Controls.Add(this.txtUDir);
            this.Controls.Add(this.server);
            this.Menu = this.mainMenu1;
            this.Name = "fSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.fSettings_Load);
            this.pnlAdmin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox server;
        private System.Windows.Forms.TextBox txtUDir;
        private System.Windows.Forms.Label lblUpDir;
        private System.Windows.Forms.TextBox txtDDir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLDir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MenuItem menuSave;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.Panel pnlAdmin;
        private System.Windows.Forms.TextBox txtAdmPass;
        private System.Windows.Forms.Button btnAdmCancel;
        private System.Windows.Forms.Button btnAdmConfirm;
        private System.Windows.Forms.Label lblAdmTitle;
        private System.Windows.Forms.CheckBox chkDebug;
        private System.Windows.Forms.Label label9;
    }
}