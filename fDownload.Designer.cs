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
            this.colTime = new System.Windows.Forms.ColumnHeader();
            this.colResponse = new System.Windows.Forms.ColumnHeader();
            this.fileTab = new System.Windows.Forms.TabPage();
            this.lblStatus = new System.Windows.Forms.Label();
            this.fileList = new System.Windows.Forms.ListView();
            this.colFileName = new System.Windows.Forms.ColumnHeader();
            this.colCreatedDate = new System.Windows.Forms.ColumnHeader();
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
            this.menuAll = new System.Windows.Forms.MenuItem();
            this.menuDiv01 = new System.Windows.Forms.MenuItem();
            this.menuDiv02 = new System.Windows.Forms.MenuItem();
            this.menuDiv03 = new System.Windows.Forms.MenuItem();
            this.menuDiv04 = new System.Windows.Forms.MenuItem();
            this.menuDiv05 = new System.Windows.Forms.MenuItem();
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
            this.tabs.GotFocus += new System.EventHandler(this.tabs_GotFocus);
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
            this.status.Columns.Add(this.colTime);
            this.status.Columns.Add(this.colResponse);
            this.status.Location = new System.Drawing.Point(0, 0);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(240, 133);
            this.status.TabIndex = 0;
            this.status.View = System.Windows.Forms.View.Details;
            // 
            // colTime
            // 
            this.colTime.Text = "Time";
            this.colTime.Width = 60;
            // 
            // colResponse
            // 
            this.colResponse.Text = "Response";
            this.colResponse.Width = 177;
            // 
            // fileTab
            // 
            this.fileTab.Controls.Add(this.lblStatus);
            this.fileTab.Controls.Add(this.fileList);
            this.fileTab.Location = new System.Drawing.Point(0, 0);
            this.fileTab.Name = "fileTab";
            this.fileTab.Size = new System.Drawing.Size(240, 133);
            this.fileTab.Text = "File List";
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(7, 24);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(226, 109);
            this.lblStatus.Text = "Downloading...";
            this.lblStatus.Visible = false;
            // 
            // fileList
            // 
            this.fileList.Columns.Add(this.colFileName);
            this.fileList.Columns.Add(this.colCreatedDate);
            this.fileList.Location = new System.Drawing.Point(0, 0);
            this.fileList.Name = "fileList";
            this.fileList.Size = new System.Drawing.Size(240, 133);
            this.fileList.TabIndex = 1;
            this.fileList.View = System.Windows.Forms.View.Details;
            // 
            // colFileName
            // 
            this.colFileName.Text = "File Name";
            this.colFileName.Width = 130;
            // 
            // colCreatedDate
            // 
            this.colCreatedDate.Text = "Created date";
            this.colCreatedDate.Width = 103;
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
            this.menuDownload.MenuItems.Add(this.menuAll);
            this.menuDownload.MenuItems.Add(this.menuDiv01);
            this.menuDownload.MenuItems.Add(this.menuDiv02);
            this.menuDownload.MenuItems.Add(this.menuDiv03);
            this.menuDownload.MenuItems.Add(this.menuDiv04);
            this.menuDownload.MenuItems.Add(this.menuDiv05);
            this.menuDownload.Text = "&Download";
            // 
            // menuAll
            // 
            this.menuAll.Text = "00-Full data";
            this.menuAll.Click += new System.EventHandler(this.FullDownload_Click);
            // 
            // menuDiv01
            // 
            this.menuDiv01.Text = "01-HardLine";
            this.menuDiv01.Click += new System.EventHandler(this.menuDiv01_Click);
            // 
            // menuDiv02
            // 
            this.menuDiv02.Text = "02-HomeLine";
            this.menuDiv02.Click += new System.EventHandler(this.menuDiv02_Click);
            // 
            // menuDiv03
            // 
            this.menuDiv03.Text = "03-SoftLine";
            this.menuDiv03.Click += new System.EventHandler(this.menuDiv03_Click);
            // 
            // menuDiv04
            // 
            this.menuDiv04.Text = "04-DryFood";
            this.menuDiv04.Click += new System.EventHandler(this.menuDiv04_Click);
            // 
            // menuDiv05
            // 
            this.menuDiv05.Text = "05-FreshFood";
            this.menuDiv05.Click += new System.EventHandler(this.menuDiv05_Click);
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
        private System.Windows.Forms.ColumnHeader colTime;
        private System.Windows.Forms.ColumnHeader colResponse;
        private System.Windows.Forms.TabPage fileTab;
        private System.Windows.Forms.ListView fileList;
        private System.Windows.Forms.ColumnHeader colFileName;
        private System.Windows.Forms.ColumnHeader colCreatedDate;
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
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.MenuItem menuDiv01;
        private System.Windows.Forms.MenuItem menuDiv02;
        private System.Windows.Forms.MenuItem menuDiv03;
        private System.Windows.Forms.MenuItem menuDiv04;
        private System.Windows.Forms.MenuItem menuDiv05;
        private System.Windows.Forms.MenuItem menuAll;

    }
}