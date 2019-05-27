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
    public partial class frmVisualizarRelatorios : MaterialForm
    {
        public frmVisualizarRelatorios()
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

        private void btnVisualizarAlunos_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRelatorio form = new frmRelatorio();
            form.ShowDialog();
            this.Close();
        }

        private void btnRelatorioSecretaria_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRelatorioSecretaria form = new frmRelatorioSecretaria();
            form.ShowDialog();
            this.Close();
        }

        private void btnVisualizarAlunos_MouseEnter(object sender, EventArgs e)
        {
            btnVisualizarAlunos.BackColor = Color.FromArgb(245, 62, 56);
        }

        private void btnRelatorioSecretaria_Enter(object sender, EventArgs e)
        {
           
        }

        private void btnRelatorioSecretaria_MouseEnter(object sender, EventArgs e)
        {
            btnRelatorioSecretaria.BackColor = Color.FromArgb(245, 62, 56);
        }
    }
}
