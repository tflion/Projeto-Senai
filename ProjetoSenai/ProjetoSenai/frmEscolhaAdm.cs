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
    public partial class frmEscolhaAdm : MaterialForm
    {
        public frmEscolhaAdm()
        {
            InitializeComponent();

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

        private void btnVisualizarRelatorio_Click(object sender, EventArgs e)
        {
            
        }

        private void btnVisualizarAlunos_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFuncionario form = new frmFuncionario();
            form.ShowDialog();
            this.Close();
        }

        private void btnViewRelato_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmVisualizarRelatorios form = new frmVisualizarRelatorios();
            form.ShowDialog();
            this.Close();
        }
    }
}
