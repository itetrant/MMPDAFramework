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
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuSave = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuBack = new System.Windows.Forms.MenuItem();
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
            this.label9 = new System.Windows.Forms.Label();
            this.chkArt = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem2);
            this.mainMenu1.MenuItems.Add(this.menuItem5);
            this.mainMenu1.MenuItems.Add(this.menuSave);
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            this.mainMenu1.MenuItems.Add(this.menuBack);
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
            this.menuSave.Text = "&Save";
            this.menuSave.Click += new System.EventHandler(this.menuSave_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Enabled = false;
            this.menuItem1.Text = "|";
            // 
            // menuBack
            // 
            this.menuBack.Text = "&Back";
            this.menuBack.Click += new System.EventHandler(this.menuBack_Click);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.txtBarcode.Location = new System.Drawing.Point(31, 33);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(204, 24);
            this.txtBarcode.TabIndex = 0;
            this.txtBarcode.Validated += new System.EventHandler(this.txtBarcode_Validated);
            this.txtBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // lblArt
            // 
            this.lblArt.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.lblArt.Location = new System.Drawing.Point(3, 96);
            this.lblArt.Name = "lblArt";
            this.lblArt.Size = new System.Drawing.Size(36, 20);
            this.lblArt.Text = "Art#";
            // 
            // txtArt
            // 
            this.txtArt.BackColor = System.Drawing.Color.White;
            this.txtArt.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.txtArt.Location = new System.Drawing.Point(45, 93);
            this.txtArt.Name = "txtArt";
            this.txtArt.ReadOnly = true;
            this.txtArt.Size = new System.Drawing.Size(70, 23);
            this.txtArt.TabIndex = 2;
            this.txtArt.TabStop = false;
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.Color.White;
            this.txtDesc.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.txtDesc.Location = new System.Drawing.Point(45, 122);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ReadOnly = true;
            this.txtDesc.Size = new System.Drawing.Size(191, 23);
            this.txtDesc.TabIndex = 3;
            this.txtDesc.TabStop = false;
            // 
            // lblDesc
            // 
            this.lblDesc.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.lblDesc.Location = new System.Drawing.Point(3, 126);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(39, 19);
            this.lblDesc.Text = "Desc.";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.White;
            this.txtPrice.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.txtPrice.Location = new System.Drawing.Point(45, 151);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(70, 23);
            this.txtPrice.TabIndex = 1;
            this.txtPrice.TabStop = false;
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.lblPrice.Location = new System.Drawing.Point(3, 155);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(39, 18);
            this.lblPrice.Text = "Price";
            // 
            // txtType
            // 
            this.txtType.BackColor = System.Drawing.Color.White;
            this.txtType.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtType.Location = new System.Drawing.Point(194, 151);
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(42, 23);
            this.txtType.TabIndex = 1;
            this.txtType.TabStop = false;
            // 
            // lblType
            // 
            this.lblType.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.lblType.Location = new System.Drawing.Point(121, 155);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(65, 18);
            this.lblType.Text = "Price type";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 22);
            this.label1.Text = "Product information:";
            // 
            // txtPricePerm
            // 
            this.txtPricePerm.BackColor = System.Drawing.Color.White;
            this.txtPricePerm.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.txtPricePerm.Location = new System.Drawing.Point(79, 182);
            this.txtPricePerm.Name = "txtPricePerm";
            this.txtPricePerm.ReadOnly = true;
            this.txtPricePerm.Size = new System.Drawing.Size(72, 23);
            this.txtPricePerm.TabIndex = 1;
            this.txtPricePerm.TabStop = false;
            // 
            // txtMMUN
            // 
            this.txtMMUN.BackColor = System.Drawing.Color.White;
            this.txtMMUN.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtMMUN.Location = new System.Drawing.Point(45, 214);
            this.txtMMUN.Name = "txtMMUN";
            this.txtMMUN.ReadOnly = true;
            this.txtMMUN.Size = new System.Drawing.Size(32, 23);
            this.txtMMUN.TabIndex = 1;
            this.txtMMUN.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(3, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.Text = "Perm.Price";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(2, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 18);
            this.label3.Text = "MMUN";
            // 
            // txtVAT
            // 
            this.txtVAT.BackColor = System.Drawing.Color.White;
            this.txtVAT.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.txtVAT.Location = new System.Drawing.Point(194, 182);
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.ReadOnly = true;
            this.txtVAT.Size = new System.Drawing.Size(42, 23);
            this.txtVAT.TabIndex = 1;
            this.txtVAT.TabStop = false;
            // 
            // txtUnit
            // 
            this.txtUnit.BackColor = System.Drawing.Color.White;
            this.txtUnit.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtUnit.Location = new System.Drawing.Point(127, 214);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.ReadOnly = true;
            this.txtUnit.Size = new System.Drawing.Size(109, 23);
            this.txtUnit.TabIndex = 1;
            this.txtUnit.TabStop = false;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(159, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 18);
            this.label4.Text = "VAT";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(83, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 18);
            this.label5.Text = "UNIT";
            // 
            // chkPrint
            // 
            this.chkPrint.BackColor = System.Drawing.Color.White;
            this.chkPrint.Location = new System.Drawing.Point(137, 246);
            this.chkPrint.Name = "chkPrint";
            this.chkPrint.Size = new System.Drawing.Size(15, 15);
            this.chkPrint.TabIndex = 2;
            this.chkPrint.CheckStateChanged += new System.EventHandler(this.chkPrint_CheckStateChanged);
            // 
            // chkWrongprice
            // 
            this.chkWrongprice.BackColor = System.Drawing.Color.White;
            this.chkWrongprice.Location = new System.Drawing.Point(82, 246);
            this.chkWrongprice.Name = "chkWrongprice";
            this.chkWrongprice.Size = new System.Drawing.Size(15, 15);
            this.chkWrongprice.TabIndex = 1;
            this.chkWrongprice.CheckStateChanged += new System.EventHandler(this.chkWrongprice_CheckStateChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.label6.Location = new System.Drawing.Point(3, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.Text = "Wrong Price?";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.label7.Location = new System.Drawing.Point(106, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 19);
            this.label7.Text = "Print";
            // 
            // lblQty
            // 
            this.lblQty.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.lblQty.Location = new System.Drawing.Point(164, 244);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(26, 19);
            this.lblQty.Text = "Qty";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(194, 244);
            this.txtQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(41, 22);
            this.txtQty.TabIndex = 3;
            this.txtQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQty.Visible = false;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.label9.Location = new System.Drawing.Point(156, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 19);
            this.label9.Text = "Try Art#";
            this.label9.Visible = false;
            // 
            // chkArt
            // 
            this.chkArt.BackColor = System.Drawing.Color.White;
            this.chkArt.Location = new System.Drawing.Point(216, 95);
            this.chkArt.Name = "chkArt";
            this.chkArt.Size = new System.Drawing.Size(15, 15);
            this.chkArt.TabIndex = 1;
            this.chkArt.Visible = false;
            // 
            // fPricecheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.chkArt);
            this.Controls.Add(this.chkWrongprice);
            this.Controls.Add(this.chkPrint);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.lblArt);
            this.Controls.Add(this.txtMMUN);
            this.Controls.Add(this.txtVAT);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPricePerm);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtArt);
            this.Controls.Add(this.txtBarcode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Menu = this.mainMenu1;
            this.Name = "fPricecheck";
            this.Text = "Price checker";
            this.Load += new System.EventHandler(this.fPricecheck_Load);
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkArt;
    }
}