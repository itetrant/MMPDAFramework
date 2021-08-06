namespace MMPDAUpdate
{
    partial class fUpdate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fUpdate));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuConnect = new System.Windows.Forms.MenuItem();
            this.menuUpdate = new System.Windows.Forms.MenuItem();
            this.menuReturn = new System.Windows.Forms.MenuItem();
            this.statusBar = new System.Windows.Forms.StatusBar();
            this.picDone = new System.Windows.Forms.PictureBox();
            this.background = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.server = new System.Windows.Forms.TextBox();
            this.picLoading1 = new System.Windows.Forms.PictureBox();
            this.picFailed = new System.Windows.Forms.PictureBox();
            this.picReady = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuConnect);
            this.mainMenu1.MenuItems.Add(this.menuUpdate);
            this.mainMenu1.MenuItems.Add(this.menuReturn);
            // 
            // menuConnect
            // 
            this.menuConnect.Text = "&Connect";
            this.menuConnect.Click += new System.EventHandler(this.Connect);
            // 
            // menuUpdate
            // 
            this.menuUpdate.Text = "&Update";
            this.menuUpdate.Click += new System.EventHandler(this.getUpdate);
            // 
            // menuReturn
            // 
            this.menuReturn.Text = "&Return";
            this.menuReturn.Click += new System.EventHandler(this.call_Return);
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 246);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(240, 22);
            this.statusBar.Text = "Status bar";
            // 
            // picDone
            // 
            this.picDone.Image = ((System.Drawing.Image)(resources.GetObject("picDone.Image")));
            this.picDone.Location = new System.Drawing.Point(82, 84);
            this.picDone.Name = "picDone";
            this.picDone.Size = new System.Drawing.Size(64, 64);
            this.picDone.Visible = false;
            this.picDone.Click += new System.EventHandler(this.picDone_Click);
            // 
            // background
            // 
            this.background.Enabled = false;
            this.background.Image = ((System.Drawing.Image)(resources.GetObject("background.Image")));
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(240, 246);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(11, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.Text = "user";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(11, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.Text = "ftp://";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(11, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.Text = "pwd";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(51, 92);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.ReadOnly = true;
            this.password.Size = new System.Drawing.Size(174, 21);
            this.password.TabIndex = 20;
            this.password.Text = "gaia510";
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(51, 65);
            this.user.Name = "user";
            this.user.ReadOnly = true;
            this.user.Size = new System.Drawing.Size(174, 21);
            this.user.TabIndex = 19;
            this.user.Text = "gaia510";
            // 
            // server
            // 
            this.server.Location = new System.Drawing.Point(51, 38);
            this.server.Name = "server";
            this.server.ReadOnly = true;
            this.server.Size = new System.Drawing.Size(174, 21);
            this.server.TabIndex = 18;
            this.server.Text = "172.26.24.101";
            // 
            // picLoading1
            // 
            this.picLoading1.Image = ((System.Drawing.Image)(resources.GetObject("picLoading1.Image")));
            this.picLoading1.Location = new System.Drawing.Point(82, 84);
            this.picLoading1.Name = "picLoading1";
            this.picLoading1.Size = new System.Drawing.Size(64, 64);
            this.picLoading1.Visible = false;
            // 
            // picFailed
            // 
            this.picFailed.Image = ((System.Drawing.Image)(resources.GetObject("picFailed.Image")));
            this.picFailed.Location = new System.Drawing.Point(82, 84);
            this.picFailed.Name = "picFailed";
            this.picFailed.Size = new System.Drawing.Size(64, 64);
            this.picFailed.Visible = false;
            // 
            // picReady
            // 
            this.picReady.Image = ((System.Drawing.Image)(resources.GetObject("picReady.Image")));
            this.picReady.Location = new System.Drawing.Point(82, 84);
            this.picReady.Name = "picReady";
            this.picReady.Size = new System.Drawing.Size(64, 64);
            this.picReady.Visible = false;
            this.picReady.Click += new System.EventHandler(this.picReady_Click);
            // 
            // fUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.picDone);
            this.Controls.Add(this.picReady);
            this.Controls.Add(this.picFailed);
            this.Controls.Add(this.picLoading1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.password);
            this.Controls.Add(this.user);
            this.Controls.Add(this.server);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.background);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "fUpdate";
            this.Text = "Update";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.fUpdate_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuReturn;
        private System.Windows.Forms.StatusBar statusBar;
        private System.Windows.Forms.PictureBox picDone;
        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox server;
        private System.Windows.Forms.MenuItem menuUpdate;
        private System.Windows.Forms.MenuItem menuConnect;
        private System.Windows.Forms.PictureBox picLoading1;
        private System.Windows.Forms.PictureBox picFailed;
        private System.Windows.Forms.PictureBox picReady;
    }
}

