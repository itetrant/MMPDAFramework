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
    public partial class fImport : Form
    {
        public fImport()
        {
            InitializeComponent();
        }
        private string path;
        private DataTable csv;
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
                                dt.Columns.Add("Col"+j);
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
                            catch (Exception) { 
                                //add error list
                            }

                        //}
                    }
                }

                return dt;
            }
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (Platform.PlatformDetection.IsPocketPC())
                {
                    path = "\\My Documents";
                }
                else if (Platform.PlatformDetection.IsWINCE())
                {
                    path = "\\FlashDisk\\MMPDA";
                }
                else { path = Directory.GetCurrentDirectory();}

            }catch(Exception)
            {
                path = Directory.GetCurrentDirectory();
            }
            string csv_file_path = path + "\\MMPDA" + MainForm.Storeloggedin + ".txt";

            try
            {
                csv = GetDataTabletFromCSVFile(csv_file_path);
                lblFileName.Text += " MMPDA" + MainForm.Storeloggedin + ".txt";
                lblNoLine.Text += csv.Rows.Count;
                lblFirstLine.Text += csv.Rows[0][0].ToString();
            }
            catch (Exception ex) { lblFileName.Text += ex.Message; }

        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}