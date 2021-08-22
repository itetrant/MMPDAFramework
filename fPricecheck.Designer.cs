namespace MMPDA
{
    partial class fPricecheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPricecheck));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuBack = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuSave = new System.Windows.Forms.MenuItem();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblArt = new System.Windows.Forms.Label();
            this.txtArt = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPricePerm = new System.Windows.Forms.TextBox();
            this.txtMMUN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVAT = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkPrint = new System.Windows.Forms.CheckBox();
            this.chkWrongprice = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.NumericUpDown();
            this.lblFindArt = new System.Windows.Forms.Label();
            this.chkArt = new System.Windows.Forms.CheckBox();
            this.cbDiv = new System.Windows.Forms.ComboBox();
            this.lblDiv = new System.Windows.Forms.Label();
            this.txtFixture = new System.Windows.Forms.TextBox();
            this.lblFixture = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuBack);
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            this.mainMenu1.MenuItems.Add(this.menuItem2);
            this.mainMenu1.MenuItems.Add(this.menuItem5);
            this.mainMenu1.MenuItems.Add(this.menuSave);
            // 
            // menuBack
            // 
            this.menuBack.Text = "&Back";
            this.menuBack.Click += new System.EventHandler(this.menuBack_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Enabled = false;
            this.menuItem1.Text = "|";
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "&New";
            this.menuItem2.Click += new System.EventHandler(this.menuNew);
            // 
            // menuItem5
            // 
            this.menuItem5.Enabled = false;
            this.menuItem5.Text = "|";
            // 
            // menuSave
            // 
            this.menuSave.Enabled = false;
            this.menuSave.Text = "&Save";
            this.menuSave.Click += new System.EventHandler(this.menuSave_Click);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.txtBarcode.Location = new System.Drawing.Point(33, 55);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(204, 24);
            this.txtBarcode.TabIndex = 1;
            this.txtBarcode.TextChanged += new System.EventHandler(this.txtBarcode_TextChanged);
            this.txtBarcode.Validated += new System.EventHandler(this.txtBarcode_Validated);
            this.txtBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // lblArt
            // 
            this.lblArt.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.lblArt.Location = new System.Drawing.Point(4, 115);
            this.lblArt.Name = "lblArt";
            this.lblArt.Size = new System.Drawing.Size(36, 20);
            this.lblArt.Text = "Art#";
            // 
            // txtArt
            // 
            this.txtArt.BackColor = System.Drawing.Color.White;
            this.txtArt.Location = new System.Drawing.Point(46, 113);
            this.txtArt.Name = "txtArt";
            this.txtArt.ReadOnly = true;
            this.txtArt.Size = new System.Drawing.Size(60, 21);
            this.txtArt.TabIndex = 7;
            this.txtArt.TabStop = false;
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.Color.White;
            this.txtDesc.Location = new System.Drawing.Point(46, 139);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ReadOnly = true;
            this.txtDesc.Size = new System.Drawing.Size(191, 21);
            this.txtDesc.TabIndex = 8;
            this.txtDesc.TabStop = false;
            // 
            // lblDesc
            // 
            this.lblDesc.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.lblDesc.Location = new System.Drawing.Point(4, 140);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(39, 20);
            this.lblDesc.Text = "Desc.";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.White;
            this.txtPrice.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtPrice.Location = new System.Drawing.Point(46, 165);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(70, 21);
            this.txtPrice.TabIndex = 9;
            this.txtPrice.TabStop = false;
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.lblPrice.Location = new System.Drawing.Point(4, 166);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(39, 20);
            this.lblPrice.Text = "Price";
            // 
            // txtType
            // 
            this.txtType.BackColor = System.Drawing.Color.White;
            this.txtType.Location = new System.Drawing.Point(195, 166);
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(42, 21);
            this.txtType.TabIndex = 10;
            this.txtType.TabStop = false;
            // 
            // lblType
            // 
            this.lblType.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.lblType.Location = new System.Drawing.Point(125, 166);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(65, 20);
            this.lblType.Text = "Price type";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 22);
            this.label1.Text = "Product information:";
            // 
            // txtPricePerm
            // 
            this.txtPricePerm.BackColor = System.Drawing.Color.White;
            this.txtPricePerm.Location = new System.Drawing.Point(75, 191);
            this.txtPricePerm.Name = "txtPricePerm";
            this.txtPricePerm.ReadOnly = true;
            this.txtPricePerm.Size = new System.Drawing.Size(72, 21);
            this.txtPricePerm.TabIndex = 11;
            this.txtPricePerm.TabStop = false;
            // 
            // txtMMUN
            // 
            this.txtMMUN.BackColor = System.Drawing.Color.White;
            this.txtMMUN.Location = new System.Drawing.Point(46, 217);
            this.txtMMUN.Name = "txtMMUN";
            this.txtMMUN.ReadOnly = true;
            this.txtMMUN.Size = new System.Drawing.Size(32, 21);
            this.txtMMUN.TabIndex = 13;
            this.txtMMUN.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(4, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.Text = "Perm.Price";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(4, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.Text = "MMUN";
            // 
            // txtVAT
            // 
            this.txtVAT.BackColor = System.Drawing.Color.White;
            this.txtVAT.Location = new System.Drawing.Point(195, 191);
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.ReadOnly = true;
            this.txtVAT.Size = new System.Drawing.Size(42, 21);
            this.txtVAT.TabIndex = 12;
            this.txtVAT.TabStop = false;
            // 
            // txtUnit
            // 
            this.txtUnit.BackColor = System.Drawing.Color.White;
            this.txtUnit.Location = new System.Drawing.Point(128, 217);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.ReadOnly = true;
            this.txtUnit.Size = new System.Drawing.Size(109, 21);
            this.txtUnit.TabIndex = 14;
            this.txtUnit.TabStop = false;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(161, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 20);
            this.label4.Text = "VAT";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(87, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.Text = "UNIT";
            // 
            // chkPrint
            // 
            this.chkPrint.BackColor = System.Drawing.Color.White;
            this.chkPrint.Location = new System.Drawing.Point(138, 245);
            this.chkPrint.Name = "chkPrint";
            this.chkPrint.Size = new System.Drawing.Size(15, 20);
            this.chkPrint.TabIndex = 3;
            this.chkPrint.CheckStateChanged += new System.EventHandler(this.chkPrint_CheckStateChanged);
            // 
            // chkWrongprice
            // 
            this.chkWrongprice.BackColor = System.Drawing.Color.White;
            this.chkWrongprice.Location = new System.Drawing.Point(83, 245);
            this.chkWrongprice.Name = "chkWrongprice";
            this.chkWrongprice.Size = new System.Drawing.Size(15, 20);
            this.chkWrongprice.TabIndex = 2;
            this.chkWrongprice.CheckStateChanged += new System.EventHandler(this.chkWrongprice_CheckStateChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.label6.Location = new System.Drawing.Point(4, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.Text = "Wrong Price?";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.label7.Location = new System.Drawing.Point(107, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 20);
            this.label7.Text = "Print";
            // 
            // lblQty
            // 
            this.lblQty.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.lblQty.Location = new System.Drawing.Point(165, 245);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(26, 20);
            this.lblQty.Text = "Qty";
            this.lblQty.Visible = false;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(196, 245);
            this.txtQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(41, 22);
            this.txtQty.TabIndex = 4;
            this.txtQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQty.Visible = false;
            // 
            // lblFindArt
            // 
            this.lblFindArt.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.lblFindArt.Location = new System.Drawing.Point(138, 115);
            this.lblFindArt.Name = "lblFindArt";
            this.lblFindArt.Size = new System.Drawing.Size(83, 19);
            this.lblFindArt.Text = "Find by Art#";
            // 
            // chkArt
            // 
            this.chkArt.BackColor = System.Drawing.Color.White;
            this.chkArt.Location = new System.Drawing.Point(222, 116);
            this.chkArt.Name = "chkArt";
            this.chkArt.Size = new System.Drawing.Size(15, 15);
            this.chkArt.TabIndex = 5;
            // 
            // cbDiv
            // 
            this.cbDiv.Items.Add("01-HardLine");
            this.cbDiv.Items.Add("02-HomeLine");
            this.cbDiv.Items.Add("03-SoftLine");
            this.cbDiv.Items.Add("04-DryFood");
            this.cbDiv.Items.Add("05-FreshFood");
            this.cbDiv.Location = new System.Drawing.Point(139, 29);
            this.cbDiv.Name = "cbDiv";
            this.cbDiv.Size = new System.Drawing.Size(98, 22);
            this.cbDiv.TabIndex = 6;
            this.cbDiv.SelectedIndexChanged += new System.EventHandler(this.cbDiv_SelectedIndexChanged);
            // 
            // lblDiv
            // 
            this.lblDiv.Location = new System.Drawing.Point(112, 32);
            this.lblDiv.Name = "lblDiv";
            this.lblDiv.Size = new System.Drawing.Size(26, 20);
            this.lblDiv.Text = "Div:";
            // 
            // txtFixture
            // 
            this.txtFixture.BackColor = System.Drawing.Color.White;
            this.txtFixture.Location = new System.Drawing.Point(59, 30);
            this.txtFixture.Name = "txtFixture";
            this.txtFixture.Size = new System.Drawing.Size(49, 21);
            this.txtFixture.TabIndex = 0;
            this.txtFixture.Validated += new System.EventHandler(this.txtFixture_Validated);
            this.txtFixture.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFixture_KeyDown);
            // 
            // lblFixture
            // 
            this.lblFixture.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.lblFixture.Location = new System.Drawing.Point(3, 31);
            this.lblFixture.Name = "lblFixture";
            this.lblFixture.Size = new System.Drawing.Size(56, 20);
            this.lblFixture.Text = "Fixture#";
            // 
            // fPricecheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.lblDiv);
            this.Controls.Add(this.cbDiv);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.chkArt);
            this.Controls.Add(this.chkWrongprice);
            this.Controls.Add(this.chkPrint);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblFindArt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.lblFixture);
            this.Controls.Add(this.lblArt);
            this.Controls.Add(this.txtMMUN);
            this.Controls.Add(this.txtVAT);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPricePerm);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtFixture);
            this.Controls.Add(this.txtArt);
            this.Controls.Add(this.txtBarcode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Menu = this.mainMenu1;
            this.Name = "fPricecheck";
            this.Text = "Price checker";
            this.Load += new System.EventHandler(this.fPricecheck_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fPricecheck_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuBack;
        private System.Windows.Forms.MenuItem menuSave;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblArt;
        private System.Windows.Forms.TextBox txtArt;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPricePerm;
        private System.Windows.Forms.TextBox txtMMUN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVAT;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkPrint;
        private System.Windows.Forms.CheckBox chkWrongprice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.NumericUpDown txtQty;
        private System.Windows.Forms.Label lblFindArt;
        private System.Windows.Forms.CheckBox chkArt;
        private System.Windows.Forms.Label lblDiv;
        private System.Windows.Forms.ComboBox cbDiv;
        private System.Windows.Forms.TextBox txtFixture;
        private System.Windows.Forms.Label lblFixture;
    }
}