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

        private string csv_file_path;
        //Debug
        private bool debug = true;

        #endregion parameters
        #region Not use due to performace issue

        //Load csv file into datatable
        private static DataTable GetDataTabletFromCSVFile(string csv_file_path)
        {
            DataTable dt = new DataTable();
            string csvData;
            using (StreamReader sr = new StreamReader(csv_file_path))
            {
                csvData = sr.ReadToEnd().ToString();
                string[] row = csvData.Split('\n');

                for (int i = 0; i < row.Length - 1; i++)
                {
                    string[] rowData = row[i].Split('|');
                    {
                        if (i == 0)
                        {
                            for (int j = 0; j < rowData.Length; j++)
                            {
                                //dt.Columns.Add(rowData[j].Trim());
                                dt.Columns.Add("Col" + j);
                            }
                        }
                        //else
                        //{
                        DataRow dr = dt.NewRow();
                        for (int k = 0; k < rowData.Length; k++)
                        {
                            dr[k] = rowData[k].ToString();
                        }
                        try
                        {
                            dt.Rows.Add(dr);
                        }
                        catch (Exception)
                        {
                            //add error list
                        }

                        //}
                    }
                }

                return dt;
            }
        }
        
        ///Performance issue, replaced by txtBarcode_Validated
        private void txtBarcode_Scanned (object sender, EventArgs e)
        {
            int len = txtBarcode.Text.Trim().Length;
            if (len == 0) { return; }
            if (len > 0 && len < 15)
            {
                try
                {
                    for (int i = 0; i < MainForm.products.Rows.Count; i++)
                    {
                        if (MainForm.products.Rows[i][2].ToString() == txtBarcode.Text)
                        {
                            txtArt.Text = MainForm.products.Rows[i][3].ToString();
                            txtDesc.Text = MainForm.products.Rows[i][9].ToString();
                            txtPrice.Text = MainForm.products.Rows[i][20].ToString();
                            txtPricePerm.Text = MainForm.products.Rows[i][19].ToString();
                            txtType.Text = MainForm.products.Rows[i][18].ToString();
                            txtMMUN.Text = MainForm.products.Rows[i][27].ToString();
                            txtUnit.Text = MainForm.products.Rows[i][29].ToString();
                            txtVAT.Text = MainForm.products.Rows[i][13].ToString();
                            //Beep
                            return;
                        }
                    }
                    MessageBox.Show("No data found!");
                    txtBarcode.Focus();
                    txtBarcode.SelectAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }else if (len == 24) //PV
            {
                //MessageBox.Show("Please use Price verification module");
                string _pvprice = txtBarcode.Text.Substring(16).Trim();
                int pvprice = 0;
                try
                {
                    pvprice = Int32.Parse(_pvprice);
                }
                catch (FormatException)
                {
                    pvprice = 0;
                }
                string tcode = txtBarcode.Text.Substring(0, 2);
                string pvcode = "";
                if (tcode=="03") {
                    pvcode = txtBarcode.Text.Substring(3,13);
                }
                else if (tcode == "04")
                {
                    pvcode = txtBarcode.Text.Substring(3,7);
                }
                else if (tcode == "02" || tcode == "05")
                {
                    pvcode = txtBarcode.Text.Substring(3, 7);
                }
                else if (tcode == "07")
                {
                    pvcode = txtBarcode.Text.Substring(3, 12);
                }
                else if (tcode == "08" || tcode == "06")
                {
                    pvcode = txtBarcode.Text.Substring(3,8);
                }
                else {
                    pvcode = txtBarcode.Text.Substring(2,14);
                }

                try
                {
                    for (int i = 0; i < MainForm.products.Rows.Count; i++)
                    {
                        
                        if (MainForm.products.Rows[i][2].ToString() == pvcode)
                        {
                            //debug
                            //MessageBox.Show(pvcode + "-" + pvprice.ToString() +"vs" + MainForm.products.Rows[i][20].ToString());
                            string _price = MainForm.products.Rows[i][20].ToString().Trim();

                            txtArt.Text = MainForm.products.Rows[i][3].ToString();
                            txtDesc.Text = MainForm.products.Rows[i][9].ToString();
                            txtPrice.Text = MainForm.products.Rows[i][20].ToString();
                            txtPricePerm.Text = MainForm.products.Rows[i][19].ToString();
                            txtType.Text = MainForm.products.Rows[i][18].ToString();
                            txtMMUN.Text = MainForm.products.Rows[i][27].ToString();
                            txtUnit.Text = MainForm.products.Rows[i][29].ToString();
                            txtVAT.Text = MainForm.products.Rows[i][13].ToString();


                            if (pvprice == Int32.Parse(_price.Substring(0,_price.Length-3)))
                            {
                                //Beep
                                chkWrongprice.Checked = false;
                            }
                            else
                            {
                                
                                chkWrongprice.Checked = true;
                                MessageBox.Show("Wrong price lable");                             
                            }
                            return;
                        }
                    }
                    MessageBox.Show("No data found!");
                    txtBarcode.Focus();
                    txtBarcode.SelectAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }else if (len == 30) //RTC
            {
                //MessageBox.Show("Please use RTC module");
                string _rtcprice = txtBarcode.Text.Substring(21,8).Trim();
                int rtcprice = 0;
                try
                {
                    rtcprice = Int32.Parse(_rtcprice);
                }
                catch (FormatException)
                {
                    rtcprice = 0;
                }
                string rctcode = txtBarcode.Text.Substring(2, 13);
                try
                {
                    for (int i = 0; i < MainForm.products.Rows.Count; i++)
                    {

                        if (MainForm.products.Rows[i][2].ToString() == rctcode)
                        {
                            //debug
                            //MessageBox.Show(rctcode + "vs" + MainForm.products.Rows[i][20].ToString());
                            string _price = MainForm.products.Rows[i][20].ToString().Trim();

                            txtArt.Text = MainForm.products.Rows[i][3].ToString();
                            txtDesc.Text = MainForm.products.Rows[i][9].ToString();
                            txtPrice.Text = rtcprice.ToString();
                            txtPricePerm.Text = MainForm.products.Rows[i][19].ToString();
                            txtType.Text = "RTC";
                            txtMMUN.Text = MainForm.products.Rows[i][27].ToString();
                            txtUnit.Text = MainForm.products.Rows[i][29].ToString();
                            txtVAT.Text = MainForm.products.Rows[i][13].ToString();
                            return;
                        }
                    }
                    MessageBox.Show("No data found!");
                    clear_from(sender, e);
                    txtBarcode.Focus();
                    txtBarcode.SelectAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else {
                MessageBox.Show("Invalid barcode!");
            }
        } 

        #endregion Not use due to performace issue

        #region Form Events

        private void fPricecheck_Load(object sender, EventArgs e)
        {

            string path = MainForm.localPath;
            string filename = MainForm.filePrefix + MainForm.Storeloggedin + MainForm.fileExtention;
            csv_file_path = path + "//" + filename;

            if (!File.Exists(csv_file_path)) // may have to specify path here!
            {
                MessageBox.Show("Master file NOT found!");
            }
        }

        #endregion Form Events

        private static string[] findItem(string barcode, int col, string filename)
        {
            
            if (!File.Exists(filename)) { return null;}

            String[] row = new String[30]; //max column numbers
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

        private void txtBarcode_Validated(object sender, EventArgs e)
        {
            int len = txtBarcode.Text.Trim().Length;
            string[] itemline;
            if (len == 0) { return; }
            if (len > 0 && len < 15)
            {
                try
                {
                    if (debug) { writeLogs("Scan:" + txtBarcode.Text); }
                    itemline = findItem(txtBarcode.Text, 2, csv_file_path);
                    if (debug) { writeLogs("Response:" + txtBarcode.Text); }
                    if (itemline.Length > 0)
                    {
                        txtArt.Text = itemline[3];
                        txtDesc.Text = itemline[9];
                        txtPrice.Text = itemline[20];
                        txtPricePerm.Text = itemline[19];
                        txtType.Text = itemline[18];
                        txtMMUN.Text = itemline[27];
                        txtUnit.Text = itemline[29];
                        txtVAT.Text = itemline[13];
                        //Beep
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No data found!");
                    txtBarcode.Focus();
                    txtBarcode.SelectAll();
                }
            }else if (len == 24) //PV
            {
                //MessageBox.Show("Please use Price verification module");
                string _pvprice = txtBarcode.Text.Substring(16).Trim();
                int pvprice = 0;
                try
                {
                    pvprice = Int32.Parse(_pvprice);
                }
                catch (FormatException)
                {
                    pvprice = 0;
                }
                string tcode = txtBarcode.Text.Substring(0, 2);
                string pvcode = "";
                if (tcode=="03") {
                    pvcode = txtBarcode.Text.Substring(3,13);
                }
                else if (tcode == "04")
                {
                    pvcode = txtBarcode.Text.Substring(3,7);
                }
                else if (tcode == "02" || tcode == "05")
                {
                    pvcode = txtBarcode.Text.Substring(3, 7);
                }
                else if (tcode == "07")
                {
                    pvcode = txtBarcode.Text.Substring(3, 12);
                }
                else if (tcode == "08" || tcode == "06")
                {
                    pvcode = txtBarcode.Text.Substring(3,8);
                }
                else {
                    pvcode = txtBarcode.Text.Substring(2,14);
                }

                try
                {
                    itemline = findItem(pvcode, 2, csv_file_path);
                    if (itemline.Length > 0)
                    {
                        //debug
                        //MessageBox.Show(pvcode + "-" + pvprice.ToString() +"vs" + MainForm.products.Rows[i][20].ToString());
                        string _price = itemline[20];

                        txtArt.Text = itemline[3];
                        txtDesc.Text = itemline[9];
                        txtPrice.Text = itemline[20];
                        txtPricePerm.Text = itemline[19];
                        txtType.Text = itemline[18];
                        txtMMUN.Text = itemline[27];
                        txtUnit.Text = itemline[29];
                        txtVAT.Text = itemline[13];


                        if (pvprice == Int32.Parse(_price.Substring(0,_price.Length-3)))
                        {
                            //Beep
                            chkWrongprice.Checked = false;
                        }
                        else
                        {
                            
                            chkWrongprice.Checked = true;
                            MessageBox.Show("Wrong price lable");                             
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
                string _rtcprice = txtBarcode.Text.Substring(21,8).Trim();
                int rtcprice = 0;
                try
                {
                    rtcprice = Int32.Parse(_rtcprice);
                }
                catch (FormatException)
                {
                    rtcprice = 0;
                }
                string rctcode = txtBarcode.Text.Substring(2, 13);
                
                try
                {
                    itemline = findItem(rctcode, 2, csv_file_path);
                    if (itemline.Length > 0)
                    {
                        //debug
                        //MessageBox.Show(rctcode + "vs" + MainForm.products.Rows[i][20].ToString());
                        string _price = itemline[20];

                        txtArt.Text = itemline[3];
                        txtDesc.Text = itemline[9];
                        txtPrice.Text = rtcprice.ToString();
                        txtPricePerm.Text = itemline[19];
                        txtType.Text = "RTC";
                        txtMMUN.Text = itemline[27];
                        txtUnit.Text = itemline[29];
                        txtVAT.Text = itemline[13];

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
            }
            else
            {
                txtQty.Visible = false;
                lblQty.Visible = true;
            }
        }

    }
}