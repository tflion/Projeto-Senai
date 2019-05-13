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
    public partial class frmFuncionario : MaterialForm
    {
        public frmFuncionario()
        {
            InitializeComponent();
            userPrincipal.BringToFront();

            MaterialSkinManager materialSkin = MaterialSkinManager.Instance;
            materialSkin.AddFormToManage(this);
            materialSkin.Theme = MaterialSkinManager.Themes.LIGHT;

            //Cores do form
            materialSkin.ColorScheme = new ColorScheme(
                Primary.Red500, Primary.Red500,
                Primary.Red500, Accent.Red400,
                TextShade.WHITE
            );
        }

        private void userCadastrarEmpresa1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            userImportarDados.BringToFront();
            pnlIndicador.Height = btnImportarDados.Height;
            pnlIndicador.Top = btnImportarDados.Top;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            userCadastrarEmpresa2.BringToFront();
            pnlIndicador.Height = btnCadastrarEmpresa.Height;
            pnlIndicador.Top = btnCadastrarEmpresa.Top;
        }

        private void pnlDireito_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnImportarDados_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnImportarDados_MouseEnter(object sender, EventArgs e)
        {
            btnImportarDados.BackColor = Color.FromArgb(245, 62, 56);
        }

        private void btnImportarDados_MouseHover_1(object sender, EventArgs e)
        {
            btnImportarDados.BackColor = Color.FromArgb(245, 62, 56);
        }

        private void btnCadastrarEmpresa_MouseEnter(object sender, EventArgs e)
        {
            btnImportarDados.BackColor = Color.FromArgb(245, 62, 56);
        }

        private void btnCadastrarEmpresa_MouseHover(object sender, EventArgs e)
        {
            btnImportarDados.BackColor = Color.FromArgb(245, 62, 56);
        }

        private void materialDivider1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_2(object sender, EventArgs e)
        {
            userAlocarAlunos1.BringToFront();
            pnlIndicador.Height = btnAlocarAlunos.Height;
            pnlIndicador.Top = btnAlocarAlunos.Top;
        }

        private void btnVisualizarAlunos_Click(object sender, EventArgs e)
        {
            userVisualizarAlunos1.BringToFront();
            pnlIndicador.Height = btnVisualizarAlunos.Height;
            pnlIndicador.Top = btnVisualizarAlunos.Top;
        }

        private void pnlIndicador_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}
