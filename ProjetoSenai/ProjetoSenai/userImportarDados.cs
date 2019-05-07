﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ExcelDataReader;

//Material Design
using MaterialSkin;
using MaterialSkin.Controls;

using System.Data.OleDb;


namespace ProjetoSenai
{
    public partial class userImportarDados : UserControl
    {
        public userImportarDados()
        {
            InitializeComponent();

            MaterialSkinManager materialSkin = MaterialSkinManager.Instance;
            materialSkin.Theme = MaterialSkinManager.Themes.LIGHT;

            //Cores do form
            materialSkin.ColorScheme = new ColorScheme(
                Primary.Red500, Primary.Red500,
                Primary.Red500, Accent.Red400,
                TextShade.WHITE
            );
        }

        DataSet result;

        private void CboFolha_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }


        private void btnSelecionarArquivo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog of = new OpenFileDialog() { Filter = "Excel Work Book 97-2003|*.xls|Excel Workbook|* .xlsx", ValidateNames = true })
            {
                if (of.ShowDialog() == DialogResult.OK)
                {

                    FileStream fs = File.Open(of.FileName, FileMode.Open, FileAccess.Read);
                    IExcelDataReader reader;
                    if (of.FilterIndex == 1)
                        reader = ExcelReaderFactory.CreateBinaryReader(fs);
                    else
                        reader = ExcelReaderFactory.CreateOpenXmlReader(fs);



                    result = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true  // set to true to use excel first row as column in datagridview
                        }

                    });

                    cboTipo.Items.Clear();
                    foreach (DataTable dt in result.Tables)
                    {
                        cboTipo.Items.Add(dt.TableName);

                    }
                    reader.Close();


                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvExcel.DataSource = result.Tables[cboTipo.SelectedIndex];
        }
    }
}

