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
    public partial class frmLogin : MaterialForm
    {
        ClassUsuario usuario = new ClassUsuario();
        public frmLogin()
        {
            InitializeComponent();

            MaterialSkinManager materialSkin = MaterialSkinManager.Instance;
            materialSkin.AddFormToManage(this);
            materialSkin.Theme = MaterialSkinManager.Themes.LIGHT;

            //Cores do form
            materialSkin.ColorScheme = new ColorScheme(
                Primary.Red500,Primary.Red500,
                Primary.Red400,Accent.Red400,
                TextShade.WHITE
            );
        }

        private void lblEsqueceuSenha_Click(object sender, EventArgs e)
        {
            //Ir para um novo form e fechar o recente
            this.Hide();
            frmEsqueceuSenha form = new frmEsqueceuSenha();
            form.ShowDialog();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Se for maior que 0 então achou o login
            if(usuario.VerificarLogin(txtEmail.Text, txtSenha.Text) >0)
            {
                this.Hide();
                frmFuncionario form = new frmFuncionario();
                form.ShowDialog();
                this.Close();
            }
            else
            {
                MyMessageBox.Show("        E-mail ou senha incorretos! \n                Tente novamente.", "Usuário não cadastrado", "OK");
                txtEmail.Text = "";
                txtSenha.Text = "";
            }
            
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            //Tampar senha
            txtSenha.UseSystemPasswordChar = true;
        }

        private void lblRegistro_Click(object sender, EventArgs e)
        {
            //Ir para um novo form e fechar o recente
            this.Hide();
            frmRegistrarUsuario form = new frmRegistrarUsuario();
            form.ShowDialog();
            this.Close();
        }

        private void TxtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            //Fazendo o click no botão caso apertar enter
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void TxtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            //Fazendo o click no botão caso apertar enter
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
        Label clickedLabel;
        private void lblEsqueceuSenha_MouseHover(object sender, EventArgs e)
        {
            Label theLabel = (Label)sender;
            if (theLabel != clickedLabel)
                theLabel.ForeColor = Color.Red;
        }

        private void lblEsqueceuSenha_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void lblEsqueceuSenha_MouseLeave(object sender, EventArgs e)
        {
            Label theLabel = (Label)sender;
            if (theLabel != clickedLabel)
                theLabel.ForeColor = Color.Black;
        }

        private void lblRegistro_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void lblRegistro_MouseHover(object sender, EventArgs e)
        {
            Label theLabel = (Label)sender;
            if (theLabel != clickedLabel)
                theLabel.ForeColor = Color.Red;
        }

        private void lblRegistro_MouseLeave(object sender, EventArgs e)
        {
            Label theLabel = (Label)sender;
            if (theLabel != clickedLabel)
                theLabel.ForeColor = Color.Black;
        }
    }
}
