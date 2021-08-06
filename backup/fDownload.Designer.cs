namespace MMPDA
{
    partial class fDownload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDownload));
            this.tabs = new System.Windows.Forms.TabControl();
            this.statusTab = new System.Windows.Forms.TabPage();
            this.status = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.fileTab = new System.Windows.Forms.TabPage();
            this.fileList = new System.Windows.Forms.ListView();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.server = new System.Windows.Forms.TextBox();
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuConnect = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuDownload = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuClose = new System.Windows.Forms.MenuItem();
            this.tabs.SuspendLayout();
            this.statusTab.SuspendLayout();
            this.fileTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.statusTab);
            this.tabs.Controls.Add(this.fileTab);
            this.tabs.Dock = System.Windows.Forms.DockStyle.None;
            this.tabs.Location = new System.Drawing.Point(0, 111);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(240, 156);
            this.tabs.TabIndex = 9;
            this.tabs.GotFocus += new System.EventHandler(this.getFileList_Click);
            // 
            // statusTab
            // 
            this.statusTab.Controls.Add(this.status);
            this.statusTab.Location = new System.Drawing.Point(0, 0);
            this.statusTab.Name = "statusTab";
            this.statusTab.Size = new System.Drawing.Size(240, 133);
            this.statusTab.Text = "Status";
            // 
            // status
            // 
            this.status.Columns.Add(this.columnHeader1);
            this.status.Columns.Add(this.columnHeader2);
            this.status.Location = new System.Drawing.Point(3, 0);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(234, 133);
            this.status.TabIndex = 0;
            this.status.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Time";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Response";
            this.columnHeader2.Width = 148;
            // 
            // fileTab
            // 
            this.fileTab.Controls.Add(this.fileList);
            this.fileTab.Location = new System.Drawing.Point(0, 0);
            this.fileTab.Name = "fileTab";
            this.fileTab.Size = new System.Drawing.Size(232, 130);
            this.fileTab.Text = "File List";
            // 
            // fileList
            // 
            this.fileList.Columns.Add(this.columnHeader3);
            this.fileList.Columns.Add(this.columnHeader4);
            this.fileList.Location = new System.Drawing.Point(0, 0);
            this.fileList.Name = "fileList";
            this.fileList.Size = new System.Drawing.Size(237, 133);
            this.fileList.TabIndex = 1;
            this.fileList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "File Name";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Created date";
            this.columnHeader4.Width = 130;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.Text = "user";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.Text = "ftp://";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.Text = "pwd";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(52, 84);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(174, 21);
            this.password.TabIndex = 14;
            this.password.Text = "gaia510";
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(52, 57);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(174, 21);
            this.user.TabIndex = 13;
            this.user.Text = "gaia510";
            // 
            // server
            // 
            this.server.Location = new System.Drawing.Point(52, 30);
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(174, 21);
            this.server.TabIndex = 8;
            this.server.Text = "172.26.24.101";
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuConnect);
            this.mainMenu1.MenuItems.Add(this.menuItem3);
            this.mainMenu1.MenuItems.Add(this.menuDownload);
            this.mainMenu1.MenuItems.Add(this.menuItem4);
            this.mainMenu1.MenuItems.Add(this.menuClose);
            // 
            // menuConnect
            // 
            this.menuConnect.Text = "Connec&t";
            this.menuConnect.Click += new System.EventHandler(this.connect_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Enabled = false;
            this.menuItem3.Text = "|";
            // 
            // menuDownload
            // 
            this.menuDownload.Text = "&Download";
            this.menuDownload.Click += new System.EventHandler(this.Download_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Enabled = false;
            this.menuItem4.Text = "|";
            // 
            // menuClose
            // 
            this.menuClose.Text = "&Close";
            this.menuClose.Click += new System.EventHandler(this.menuClose_Click);
            // 
            // fDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.password);
            this.Controls.Add(this.user);
            this.Controls.Add(this.server);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.Name = "fDownload";
            this.Text = "Download";
            this.Load += new System.EventHandler(this.fDownload_Load);
            this.tabs.ResumeLayout(false);
            this.statusTab.ResumeLayout(false);
            this.fileTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage statusTab;
        private System.Windows.Forms.ListView status;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TabPage fileTab;
        private System.Windows.Forms.ListView fileList;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox server;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuConnect;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuDownload;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuClose;

    }
}