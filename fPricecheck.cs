using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MMPDA
{
    public partial class fPricecheck : Form
    {
        public fPricecheck()
        {
            InitializeComponent();
        }
        #region parameters

        private string _filepath;
        private string _type = "_label_";
        private string _ext = ".sav";
        private string _delimited = "|";
        private DataRow row = null;
        private int _lineNo = 0;
        private string path, filename;
        private string filename1, filename2, filename3, filename4, filename5;
        //Debug
        private bool _debug = MainForm.debug;
        #endregion parameters

        #region Form Events

        private void fPricecheck_Load(object sender, EventArgs e)
        {
            path = MainForm.localPath;
            filename5 = MainForm.filePrefix + "05" + MainForm.Storeloggedin + MainForm.fileExtention;
            filename4 = MainForm.filePrefix + "04" + MainForm.Storeloggedin + MainForm.fileExtention;
            filename3 = MainForm.filePrefix + "03" + MainForm.Storeloggedin + MainForm.fileExtention;
            filename2 = MainForm.filePrefix + "02" + MainForm.Storeloggedin + MainForm.fileExtention;
            filename1 = MainForm.filePrefix + "01" + MainForm.Storeloggedin + MainForm.fileExtention;

            _filepath = path + "//" + filename5;

            if (!File.Exists(_filepath)) // may have to specify path here!
            {
                _filepath = path + "//" + filename4;

                if (!File.Exists(_filepath))
                {
                    _filepath = path + "//" + filename3;

                    if (!File.Exists(_filepath))
                    {
                        _filepath = path + "//" + filename2;

                        if (!File.Exists(_filepath))
                        {
                            _filepath = path + "//" + filename1;

                            if (!File.Exists(_filepath))
                            {
                                MessageBox.Show("Naster files not found");
                            }
                            else { cbDiv.Text = "01-HardLine";}
                        }
                        else { cbDiv.Text = "02-HomeLine"; }
                    }
                    else { cbDiv.Text = "03-SoftLine"; }
                }
                else { cbDiv.Text = "04-DryFood"; }
            }
            else { cbDiv.Text = "05-FreshFood"; }

            txtFixture.Text = MainForm.FixtureNo;
            txtFixture.Focus();
            txtFixture.SelectAll();
        }

        #endregion Form Events

        private static string[] findItem(string barcode, int col, string filename)
        {
            
            if (!File.Exists(filename)) { return null;}

            String[] row = new String[10]; //max column numbers
            StreamReader file = new StreamReader(filename);
            string line = "";
            while (true)
            {
                line = file.ReadLine();
                if (line != null)
                {
                    row = line.Split('|'); //csv separator
                    if (row.Length >= col)
                    {
                        if (row[col] == barcode){
                            break; //Found item and return
                        }
                    }
                } else //EOF  = not found
                { row = null; break; }
            }
            file.Close();
            return row;
        }
        //Write log
        private void writeLogs(string text)
        {
            //
            string filename = MainForm.localPath + "\\pricecheck.log";
            if (!File.Exists(filename)) // may have to specify path here!
            {
                // may have to specify path here!
                File.Create(filename).Close();
            }

            // may have to specify path here!
            StreamWriter swFile =
                         new StreamWriter(
                            new FileStream(filename,
                                           FileMode.Append),
                            Encoding.ASCII);

            try
            {
                swFile.WriteLine(DateTime.Now.ToString("dd/MM/yy hh:mm:ss") + "->" + text);
            }
            catch (Exception ex)
            {
                swFile.WriteLine(ex.Message + "->" + text);
            }

            swFile.Close();
        }

        private bool savePricecheck(string _fixture)
        {
            //
            string filename = MainForm.localPath + "\\" + MainForm.Storeloggedin + "_"+ MainForm.PDA_ID + _type + _fixture + _ext;
            if (!File.Exists(filename)) // may have to specify path here!
            {
                // may have to specify path here!
                File.Create(filename).Close();
            }
            try
            {
                // may have to specify path here!
                StreamWriter swFile =
                             new StreamWriter(
                                new FileStream(filename,
                                               FileMode.Append),
                                Encoding.ASCII);
                foreach (DataRow datarow in MainForm.priceData.Rows)
                {
                    string row = string.Empty;
                    foreach (object items in datarow.ItemArray)
                    {
                        row += items.ToString() + _delimited;
                    }
                    swFile.WriteLine(row.Remove(row.Length - 1, 1));
                }
                swFile.Flush();
                swFile.Close();
                MainForm.priceData.Clear();
            }
            catch (Exception) { return false; }
            return true;
        }

        private void txtBarcode_Validated(object sender, EventArgs e)
        {

            string code = txtBarcode.Text;
            int len = code.Length;
            string[] itemline;
            if (len == 0) { return; }

            if (len > 0 && len < 15)
            {
                try
                {
                    if (_debug) { writeLogs("Scan:" + code); }

                    if (chkArt.Checked)
                    {
                        itemline = findItem(code, 2, _filepath);
                    }
                    else { itemline = findItem(code, 1, _filepath); }

                    if (_debug) { writeLogs("Response:" + code); }
                    if (itemline.Length > 0)
                    {
                        txtArt.Text = itemline[2];
                        txtDesc.Text = itemline[3];
                        txtVAT.Text = itemline[4];
                        txtType.Text = itemline[5];
                        txtPricePerm.Text = itemline[6];
                        txtPrice.Text = itemline[7];
                        txtMMUN.Text = itemline[8];
                        txtUnit.Text = itemline[9];

                        row = MainForm.priceData.NewRow();
                        for (int i=0; i < 10; i++)
                        {
                            row[i] = itemline[i];
                        }
                        row[10] = 0; row[11] = 0;
                        MainForm.priceData.Rows.Add(row);
                        _lineNo += 1;
                        //Beep
                        return;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Barcode not found!");
                    txtBarcode.Focus();
                    txtBarcode.SelectAll();
                }
            }else if (len == 24) //PV
            {
                //MessageBox.Show("Please use Price verification module");
                string _pvprice = code.Substring(16);
                int pvprice = 0;
                try
                {
                    pvprice = Int32.Parse(_pvprice);
                }
                catch (FormatException)
                {
                    pvprice = 0;
                }
                string tcode = code.Substring(0, 2);
                string pvcode = "";
                if (tcode=="03") {
                    pvcode = code.Substring(3, 13);
                }
                else if (tcode == "04")
                {
                    pvcode = code.Substring(3, 7);
                }
                else if (tcode == "02" || tcode == "05")
                {
                    pvcode = code.Substring(3, 7);
                }
                else if (tcode == "07")
                {
                    pvcode = code.Substring(3, 12);
                }
                else if (tcode == "08" || tcode == "06")
                {
                    pvcode = code.Substring(3, 8);
                }
                else {
                    pvcode = code.Substring(2, 14);
                }

                try
                {
                    if (_debug) { writeLogs("Scan:" + code); }

                    if (chkArt.Checked)
                    {
                        itemline = findItem(pvcode, 2, _filepath);
                    }
                    else { itemline = findItem(pvcode, 1, _filepath); }

                    if (_debug) { writeLogs("Response:" + code); }

                    if (itemline.Length > 0)
                    {
                        string _price = itemline[7];
                        txtArt.Text = itemline[2];
                        txtDesc.Text = itemline[3];
                        txtVAT.Text = itemline[4];
                        txtType.Text = itemline[5];
                        txtPricePerm.Text = itemline[6];
                        txtPrice.Text = itemline[7];
                        txtMMUN.Text = itemline[8];
                        txtUnit.Text = itemline[9];

                        row = MainForm.priceData.NewRow();
                        for (int i = 0; i < 10; i++)
                        {
                            row[i] = itemline[i];
                        }
                        row[10] = 0; row[11] = 0;
                        MainForm.priceData.Rows.Add(row);
                        _lineNo += 1;

                        if (pvprice == Int32.Parse(_price.Substring(0,_price.Length-3)))
                        {
                            //Beep
                            chkWrongprice.Checked = false;
                        }
                        else
                        {
                            chkWrongprice.Checked = true;
                            MessageBox.Show("Wrong price!PV price=" + pvprice.ToString());                             
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No data found!");
                    txtBarcode.Focus();
                    txtBarcode.SelectAll();
                }

            }else if (len == 30) //RTC
            {
                //MessageBox.Show("Please use RTC module");
                string _rtcprice = code.Substring(21, 8);
                int rtcprice = 0;
                try
                {
                    rtcprice = Int32.Parse(_rtcprice);
                }
                catch (FormatException)
                {
                    rtcprice = 0;
                }
                string rctcode = code.Substring(2, 13);
                
                try
                {
                    if (_debug) { writeLogs("Scan:" + code); }

                    if (chkArt.Checked)
                    {
                        itemline = findItem(rctcode, 2, _filepath);
                    }
                    else { itemline = findItem(rctcode, 1, _filepath); }

                    if (_debug) { writeLogs("Response:" + code); }

                    if (itemline.Length > 0)
                    {
                        //debug
                        //MessageBox.Show(rctcode + "vs" + MainForm.priceData.Rows[i][20].ToString());
                        string _price = itemline[7];
                        txtArt.Text = itemline[2];
                        txtDesc.Text = itemline[3];
                        txtVAT.Text = itemline[4];
                        txtType.Text = "RTC";
                        txtPricePerm.Text = itemline[6];
                        txtPrice.Text = rtcprice.ToString();
                        txtMMUN.Text = itemline[8];
                        txtUnit.Text = itemline[9];
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No data found!");
                    txtBarcode.Focus();
                    txtBarcode.SelectAll();
                }
            }
            else {
                MessageBox.Show("Invalid barcode!");
            }
        }

        private void chkWrongprice_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkWrongprice.Checked)
            {
                txtQty.Visible = true;
                lblQty.Visible = true;
                chkPrint.Checked = true;
            }
            else {
                txtQty.Visible = false;
                lblQty.Visible = false;
            }
        }

        private void clear_from(object sender, EventArgs e)
        {
            //

            txtBarcode.Text = "";
            txtArt.Text = "";
            txtDesc.Text = "";
            txtPrice.Text = "";
            txtPricePerm.Text = "";
            txtType.Text = "";
            txtMMUN.Text = "";
            txtUnit.Text = "";
            txtVAT.Text = "";

            chkWrongprice.Checked = false;
            chkPrint.Checked = false;
            txtQty.Value = 1;
            txtQty.Visible = false;
            lblQty.Visible = false;


        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == System.Windows.Forms.Keys.Enter))
            {
                // Enter
                txtBarcode_Validated(sender, e);
            }
        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (chkWrongprice.Checked) { MainForm.priceData.Rows[MainForm.priceData.Rows.Count - 1][10] = 1; }
                else { MainForm.priceData.Rows[MainForm.priceData.Rows.Count-1][10] = 0; }
                MainForm.priceData.Rows[MainForm.priceData.Rows.Count - 1][11] = txtQty.Value;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            bool _save = savePricecheck(MainForm.FixtureNo);
            if (!_save) { MessageBox.Show("Save file failed!"); }
            else { MainForm.taskCheckprice = true; }
            clear_from(sender, e);
            txtBarcode.Focus();
        }

        private void menuBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuNew(object sender, EventArgs e)
        {
            clear_from(sender, e);
            txtBarcode.Focus();
        }

        private void chkPrint_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkPrint.Checked)
            {
                txtQty.Visible = true;
                lblQty.Visible = true;
                menuSave.Enabled = true;
            }
            else
            {
                txtQty.Visible = false;
                lblQty.Visible = true;
                menuSave.Enabled = false;
            }
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void cbDiv_SelectedIndexChanged(object sender, EventArgs e)
        {

            string _div  = cbDiv.Text.Substring(0,2);
            filename = MainForm.filePrefix + _div + MainForm.Storeloggedin + MainForm.fileExtention;
            _filepath = path + "//" + filename;
            txtBarcode.Focus();

        }

        private void txtFixture_Validated(object sender, EventArgs e)
        {
            if (txtFixture.Text.Length != 5)
            {
                MessageBox.Show("Fixture number must be 5 digits");
                txtFixture.Focus();
                txtFixture.SelectAll();
            }
            else {
                MainForm.FixtureNo = txtFixture.Text;
                txtBarcode.Focus();
            }
        }

        private void txtFixture_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == System.Windows.Forms.Keys.Enter))
            {
                // Enter
                txtFixture_Validated(sender, e);
            }
        }

    }
}