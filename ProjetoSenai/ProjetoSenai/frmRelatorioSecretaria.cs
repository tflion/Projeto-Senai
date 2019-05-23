using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Material Design
using MaterialSkin;
using MaterialSkin.Controls;

namespace ProjetoSenai
{
    public partial class frmRelatorioSecretaria : MaterialForm
    {
        public frmRelatorioSecretaria()
        {
            InitializeComponent();
            MaterialSkinManager materialSkin = MaterialSkinManager.Instance;
            materialSkin.AddFormToManage(this);
            materialSkin.Theme = MaterialSkinManager.Themes.LIGHT;

            //Cores do form
            materialSkin.ColorScheme = new ColorScheme(
                Primary.Red500, Primary.Red500,
                Primary.Red400, Accent.Red400,
                TextShade.WHITE
            );
        }

        private void btnVoltarLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin form = new frmLogin();
            form.ShowDialog();
            this.Close();
        }

        private void frmRelatorioSecretaria_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetEmprego.Emprego' table. You can move, or remove it, as needed.
            this.EmpregoTableAdapter.Fill(this.DataSetEmprego.Emprego);
            // TODO: This line of code loads data into the 'DataSetSecretaria.Empresa' table. You can move, or remove it, as needed.
            this.EmpresaTableAdapter.Fill(this.DataSetSecretaria.Empresa);
            // TODO: This line of code loads data into the 'DataSetSecretaria.Aluno' table. You can move, or remove it, as needed.
            this.AlunoTableAdapter.Fill(this.DataSetSecretaria.Aluno);

        }
    }
}
