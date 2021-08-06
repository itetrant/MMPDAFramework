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
            this.btnRemote = new System.Windows.Forms.PictureBox();
            this.lblRemote = new System.Windows.Forms.Label();
            this.btnCCOD = new System.Windows.Forms.PictureBox();
            this.lblCCOD = new System.Windows.Forms.Label();
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
            this.btnChecklist.Location = new System.Drawing.Point(72, 42);
            this.btnChecklist.Name = "btnChecklist";
            this.btnChecklist.Size = new System.Drawing.Size(32, 32);
            this.btnChecklist.Tag = "4";
            this.btnChecklist.DoubleClick += new System.EventHandler(this.btnButton_Click);
            this.btnChecklist.Click += new System.EventHandler(this.btnButton_GotFocus);
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.Color.Transparent;
            this.btnDownload.Image = ((System.Drawing.Image)(resources.GetObject("btnDownload.Image")));
            this.btnDownload.Location = new System.Drawing.Point(133, 42);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(32, 32);
            this.btnDownload.Tag = "6";
            this.btnDownload.DoubleClick += new System.EventHandler(this.btnButton_Click);
            this.btnDownload.Click += new System.EventHandler(this.btnButton_GotFocus);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.Location = new System.Drawing.Point(14, 42);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(32, 32);
            this.btnSettings.Tag = "3";
            this.btnSettings.DoubleClick += new System.EventHandler(this.btnButton_Click);
            this.btnSettings.Click += new System.EventHandler(this.btnButton_GotFocus);
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.Transparent;
            this.btnUpload.Image = ((System.Drawing.Image)(resources.GetObject("btnUpload.Image")));
            this.btnUpload.Location = new System.Drawing.Point(14, 121);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(32, 32);
            this.btnUpload.Tag = "5";
            this.btnUpload.DoubleClick += new System.EventHandler(this.btnButton_Click);
            this.btnUpload.Click += new System.EventHandler(this.btnButton_GotFocus);
            // 
            // btnPricecheck
            // 
            this.btnPricecheck.BackColor = System.Drawing.Color.Transparent;
            this.btnPricecheck.Image = ((System.Drawing.Image)(resources.GetObject("btnPricecheck.Image")));
            this.btnPricecheck.Location = new System.Drawing.Point(72, 121);
            this.btnPricecheck.Name = "btnPricecheck";
            this.btnPricecheck.Size = new System.Drawing.Size(32, 32);
            this.btnPricecheck.Tag = "1";
            this.btnPricecheck.DoubleClick += new System.EventHandler(this.btnButton_Click);
            this.btnPricecheck.Click += new System.EventHandler(this.btnButton_GotFocus);
            // 
            // lblPricecheck
            // 
            this.lblPricecheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.lblPricecheck.ForeColor = System.Drawing.Color.Black;
            this.lblPricecheck.Location = new System.Drawing.Point(56, 154);
            this.lblPricecheck.Name = "lblPricecheck";
            this.lblPricecheck.Size = new System.Drawing.Size(64, 16);
            this.lblPricecheck.Text = "&PriceCheck";
            this.lblPricecheck.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSettings
            // 
            this.lblSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.lblSettings.ForeColor = System.Drawing.Color.Black;
            this.lblSettings.Location = new System.Drawing.Point(6, 75);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(48, 16);
            this.lblSettings.Text = "&Settings";
            this.lblSettings.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblChecklist
            // 
            this.lblChecklist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.lblChecklist.ForeColor = System.Drawing.Color.Black;
            this.lblChecklist.Location = new System.Drawing.Point(62, 75);
            this.lblChecklist.Name = "lblChecklist";
            this.lblChecklist.Size = new System.Drawing.Size(53, 16);
            this.lblChecklist.Text = "Check&list";
            this.lblChecklist.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblUpload
            // 
            this.lblUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.lblUpload.ForeColor = System.Drawing.Color.Black;
            this.lblUpload.Location = new System.Drawing.Point(8, 154);
            this.lblUpload.Name = "lblUpload";
            this.lblUpload.Size = new System.Drawing.Size(45, 16);
            this.lblUpload.Text = "Up&load";
            this.lblUpload.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDownload
            // 
            this.lblDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.lblDownload.ForeColor = System.Drawing.Color.Black;
            this.lblDownload.Location = new System.Drawing.Point(119, 75);
            this.lblDownload.Name = "lblDownload";
            this.lblDownload.Size = new System.Drawing.Size(61, 16);
            this.lblDownload.Text = "&Download";
            this.lblDownload.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.btnUpdate.Location = new System.Drawing.Point(192, 42);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(32, 32);
            this.btnUpdate.Tag = "2";
            this.btnUpdate.DoubleClick += new System.EventHandler(this.btnButton_Click);
            this.btnUpdate.Click += new System.EventHandler(this.btnButton_GotFocus);
            // 
            // lblUpdate
            // 
            this.lblUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.lblUpdate.ForeColor = System.Drawing.Color.Black;
            this.lblUpdate.Location = new System.Drawing.Point(184, 75);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(49, 16);
            this.lblUpdate.Text = "&Update";
            this.lblUpdate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnRemote
            // 
            this.btnRemote.BackColor = System.Drawing.Color.Transparent;
            this.btnRemote.Image = ((System.Drawing.Image)(resources.GetObject("btnRemote.Image")));
            this.btnRemote.Location = new System.Drawing.Point(133, 121);
            this.btnRemote.Name = "btnRemote";
            this.btnRemote.Size = new System.Drawing.Size(32, 32);
            this.btnRemote.Tag = "2";
            this.btnRemote.DoubleClick += new System.EventHandler(this.btnButton_Click);
            this.btnRemote.Click += new System.EventHandler(this.btnButton_GotFocus);
            // 
            // lblRemote
            // 
            this.lblRemote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.lblRemote.ForeColor = System.Drawing.Color.Black;
            this.lblRemote.Location = new System.Drawing.Point(125, 154);
            this.lblRemote.Name = "lblRemote";
            this.lblRemote.Size = new System.Drawing.Size(48, 16);
            this.lblRemote.Text = "&Remote";
            this.lblRemote.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCCOD
            // 
            this.btnCCOD.BackColor = System.Drawing.Color.Transparent;
            this.btnCCOD.Image = ((System.Drawing.Image)(resources.GetObject("btnCCOD.Image")));
            this.btnCCOD.Location = new System.Drawing.Point(192, 121);
            this.btnCCOD.Name = "btnCCOD";
            this.btnCCOD.Size = new System.Drawing.Size(32, 32);
            this.btnCCOD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCCOD.Tag = "2";
            this.btnCCOD.DoubleClick += new System.EventHandler(this.btnButton_Click);
            this.btnCCOD.Click += new System.EventHandler(this.btnButton_GotFocus);
            // 
            // lblCCOD
            // 
            this.lblCCOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.lblCCOD.ForeColor = System.Drawing.Color.Blue;
            this.lblCCOD.Location = new System.Drawing.Point(184, 154);
            this.lblCCOD.Name = "lblCCOD";
            this.lblCCOD.Size = new System.Drawing.Size(49, 16);
            this.lblCCOD.Text = "&Picker";
            this.lblCCOD.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.Controls.Add(this.lblCCOD);
            this.Controls.Add(this.lblRemote);
            this.Controls.Add(this.lblUpdate);
            this.Controls.Add(this.lblUpload);
            this.Controls.Add(this.lblPricecheck);
            this.Controls.Add(this.btnChecklist);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnCCOD);
            this.Controls.Add(this.btnRemote);
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
        private System.Windows.Forms.PictureBox btnRemote;
        private System.Windows.Forms.Label lblRemote;
        private System.Windows.Forms.PictureBox btnCCOD;
        private System.Windows.Forms.Label lblCCOD;

    }
}

