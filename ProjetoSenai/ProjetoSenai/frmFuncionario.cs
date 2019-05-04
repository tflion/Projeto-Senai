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

        private void btnImportarDados_Click(object sender, EventArgs e)
        {
            userImportarDados.BringToFront();
        }

        private void BtnCadastrarEmpresa_Click(object sender, EventArgs e)
        {
            userCadastrarEmpresa1.BringToFront();
        }
    }
}
