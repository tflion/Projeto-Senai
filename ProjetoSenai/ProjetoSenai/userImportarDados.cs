using System;
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
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if(openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.textBox_path.Text = openFileDialog.FileName;
            }
        }

        private void textBox_path_Click(object sender, EventArgs e)
        {

        }

        private void btnCarregarExcel_Click(object sender, EventArgs e)
        {
            string PatchConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + textBox_path.Text + ";Extended Properties = \"Excel 12.0 Xml;HDR=YES;Format=xls\"; ";
            OleDbConnection conn = new OleDbConnection(PatchConn);

            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter("Select * From [" + textBox_sheet.Text + "]", conn);
            DataTable dt = new DataTable();

            myDataAdapter.Fill(dt);

            dgvExcel.DataSource = dt;
        }

        private void userImportarDados_Load(object sender, EventArgs e)
        {

        }
    }
}
