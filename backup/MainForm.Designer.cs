namespace MMPDA
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.background = new System.Windows.Forms.PictureBox();
            this.btnChecklist = new System.Windows.Forms.PictureBox();
            this.btnDownload = new System.Windows.Forms.PictureBox();
            this.btnSettings = new System.Windows.Forms.PictureBox();
            this.btnUpload = new System.Windows.Forms.PictureBox();
            this.btnPricecheck = new System.Windows.Forms.PictureBox();
            this.lblPricecheck = new System.Windows.Forms.Label();
            this.lblSettings = new System.Windows.Forms.Label();
            this.lblChecklist = new System.Windows.Forms.Label();
            this.lblUpload = new System.Windows.Forms.Label();
            this.lblDownload = new System.Windows.Forms.Label();
            this.menuSettings = new System.Windows.Forms.MenuItem();
            this.menuStart = new System.Windows.Forms.MenuItem();
            this.menuUpdate = new System.Windows.Forms.MenuItem();
            this.menuExit = new System.Windows.Forms.MenuItem();
            this.mMenu = new System.Windows.Forms.MainMenu();
            this.btnUpdate = new System.Windows.Forms.PictureBox();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.Image = ((System.Drawing.Image)(resources.GetObject("background.Image")));
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(240, 268);
            this.background.Paint += new System.Windows.Forms.PaintEventHandler(this.background_Paint);
            // 
            // btnChecklist
            // 
            this.btnChecklist.BackColor = System.Drawing.Color.Transparent;
            this.btnChecklist.Image = ((System.Drawing.Image)(resources.GetObject("btnChecklist.Image")));
            this.btnChecklist.Location = new System.Drawing.Point(77, 42);
            this.btnChecklist.Name = "btnChecklist";
            this.btnChecklist.Size = new System.Drawing.Size(32, 32);
            this.btnChecklist.Tag = "4";
            this.btnChecklist.Click += new System.EventHandler(this.btnButton_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.Color.Transparent;
            this.btnDownload.Image = ((System.Drawing.Image)(resources.GetObject("btnDownload.Image")));
            this.btnDownload.Location = new System.Drawing.Point(19, 121);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(32, 32);
            this.btnDownload.Tag = "6";
            this.btnDownload.Click += new System.EventHandler(this.btnButton_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.Location = new System.Drawing.Point(19, 42);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(32, 32);
            this.btnSettings.Tag = "3";
            this.btnSettings.Click += new System.EventHandler(this.btnButton_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.Transparent;
            this.btnUpload.Image = ((System.Drawing.Image)(resources.GetObject("btnUpload.Image")));
            this.btnUpload.Location = new System.Drawing.Point(192, 42);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(32, 32);
            this.btnUpload.Tag = "5";
            this.btnUpload.Click += new System.EventHandler(this.btnButton_Click);
            // 
            // btnPricecheck
            // 
            this.btnPricecheck.BackColor = System.Drawing.Color.Transparent;
            this.btnPricecheck.Image = ((System.Drawing.Image)(resources.GetObject("btnPricecheck.Image")));
            this.btnPricecheck.Location = new System.Drawing.Point(138, 42);
            this.btnPricecheck.Name = "btnPricecheck";
            this.btnPricecheck.Size = new System.Drawing.Size(32, 32);
            this.btnPricecheck.Tag = "1";
            this.btnPricecheck.Click += new System.EventHandler(this.btnButton_Click);
            // 
            // lblPricecheck
            // 
            this.lblPricecheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.lblPricecheck.ForeColor = System.Drawing.Color.Black;
            this.lblPricecheck.Location = new System.Drawing.Point(122, 75);
            this.lblPricecheck.Name = "lblPricecheck";
            this.lblPricecheck.Size = new System.Drawing.Size(64, 16);
            this.lblPricecheck.Text = "&PriceCheck";
            // 
            // lblSettings
            // 
            this.lblSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.lblSettings.ForeColor = System.Drawing.Color.Black;
            this.lblSettings.Location = new System.Drawing.Point(11, 75);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(48, 16);
            this.lblSettings.Text = "&Settings";
            // 
            // lblChecklist
            // 
            this.lblChecklist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.lblChecklist.ForeColor = System.Drawing.Color.Black;
            this.lblChecklist.Location = new System.Drawing.Point(67, 75);
            this.lblChecklist.Name = "lblChecklist";
            this.lblChecklist.Size = new System.Drawing.Size(53, 16);
            this.lblChecklist.Text = "Check&list";
            // 
            // lblUpload
            // 
            this.lblUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.lblUpload.ForeColor = System.Drawing.Color.Black;
            this.lblUpload.Location = new System.Drawing.Point(188, 75);
            this.lblUpload.Name = "lblUpload";
            this.lblUpload.Size = new System.Drawing.Size(45, 16);
            this.lblUpload.Text = "Up&load";
            // 
            // lblDownload
            // 
            this.lblDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.lblDownload.ForeColor = System.Drawing.Color.Black;
            this.lblDownload.Location = new System.Drawing.Point(5, 154);
            this.lblDownload.Name = "lblDownload";
            this.lblDownload.Size = new System.Drawing.Size(61, 16);
            this.lblDownload.Text = "&Download";
            // 
            // menuSettings
            // 
            this.menuSettings.Text = "&Settings";
            this.menuSettings.Click += new System.EventHandler(this.call_Settings);
            // 
            // menuStart
            // 
            this.menuStart.MenuItems.Add(this.menuSettings);
            this.menuStart.MenuItems.Add(this.menuUpdate);
            this.menuStart.MenuItems.Add(this.menuExit);
            this.menuStart.Text = "&Start";
            // 
            // menuUpdate
            // 
            this.menuUpdate.Text = "U&pdate";
            this.menuUpdate.Click += new System.EventHandler(this.call_Update);
            // 
            // menuExit
            // 
            this.menuExit.Text = "E&xit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // mMenu
            // 
            this.mMenu.MenuItems.Add(this.menuStart);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(77, 121);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(32, 32);
            this.btnUpdate.Tag = "2";
            this.btnUpdate.Click += new System.EventHandler(this.btnButton_Click);
            // 
            // lblUpdate
            // 
            this.lblUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.lblUpdate.ForeColor = System.Drawing.Color.Black;
            this.lblUpdate.Location = new System.Drawing.Point(69, 154);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(49, 16);
            this.lblUpdate.Text = "&Update";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.lblChecklist);
            this.Controls.Add(this.lblSettings);
            this.Controls.Add(this.lblDownload);
            this.Controls.Add(this.lblUpdate);
            this.Controls.Add(this.lblUpload);
            this.Controls.Add(this.lblPricecheck);
            this.Controls.Add(this.btnChecklist);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnPricecheck);
            this.Controls.Add(this.background);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Menu = this.mMenu;
            this.Name = "MainForm";
            this.Text = "Store:SSSSS|vX.X.X";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Closed += new System.EventHandler(this.MainForm_Closed);
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.MainForm_Closing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.PictureBox btnChecklist;
        private System.Windows.Forms.PictureBox btnDownload;
        private System.Windows.Forms.PictureBox btnSettings;
        private System.Windows.Forms.PictureBox btnUpload;
        private System.Windows.Forms.PictureBox btnPricecheck;
        private System.Windows.Forms.Label lblPricecheck;
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.Label lblChecklist;
        private System.Windows.Forms.Label lblUpload;
        private System.Windows.Forms.Label lblDownload;
        private System.Windows.Forms.MenuItem menuSettings;
        private System.Windows.Forms.MenuItem menuStart;
        private System.Windows.Forms.MainMenu mMenu;
        private System.Windows.Forms.MenuItem menuExit;
        private System.Windows.Forms.MenuItem menuUpdate;
        private System.Windows.Forms.PictureBox btnUpdate;
        private System.Windows.Forms.Label lblUpdate;

    }
}

