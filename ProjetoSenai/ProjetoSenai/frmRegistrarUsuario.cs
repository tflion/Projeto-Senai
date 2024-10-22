﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Material design
using MaterialSkin;
using MaterialSkin.Controls;

namespace ProjetoSenai
{
    public partial class frmRegistrarUsuario : MaterialForm
    {
        ClassUsuario usuario = new ClassUsuario();

        public frmRegistrarUsuario()
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

        private void BtnVoltarLogin_Click(object sender, EventArgs e)
        {
            //Ir para um novo form e fechar o recente
            this.Hide();
            frmLogin form = new frmLogin();
            form.ShowDialog();
            this.Close();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimparTxt();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            //Se for diferente então irá apagar e mandar msgBox
            if (txtSenha.Text != txtConfirmaSenha.Text)
            {
                MyMessageBox.Show(" Favor informar a senha novamente!", "Senhas não conferem", "OK");
                txtSenha.Text = "";
                txtConfirmaSenha.Text = "";
                txtSenha.Focus();

            //Verificar email
            }else if(usuario.validarEmail(txtEmail.Text) == false)
            {
                MyMessageBox.Show("   Email o email inserido é inválido, \n             tente novamente!", "Email inválido", "OK");
                txtEmail.Text = "";
                txtEmail.Focus();
            }else
            {
                string tipo = (cboTipo.Text == "Administrador") ? "1" : "0";
                usuario.Tipo = int.Parse(tipo);
                //Se for igual irá inserir no banco
                usuario.Email = txtEmail.Text;
                usuario.Senha = txtSenha.Text;
                usuario.Nome = txtNome.Text;

                if (usuario.InserirUsuario() == true)
                {
                    MyMessageBox.Show("  Usuário  cadastrado com sucesso! \n \n \n   Pressione ''voltar'' para efetuar o \n                        login.", "Cadastrado realizado", "OK");
                    LimparTxt();
                }
            }
        }

        private void TxtSenha_TextChanged(object sender, EventArgs e)
        {
            //Tampar senha
            txtSenha.UseSystemPasswordChar = true;
        }

        private void TxtConfirmaSenha_TextChanged(object sender, EventArgs e)
        {
            //Tampar senha
            txtConfirmaSenha.UseSystemPasswordChar = true;
        }
        private void LimparTxt()
        {
            txtNome.Text = "";
            txtEmail.Text = "";
            txtSenha.Text = "";
            txtConfirmaSenha.Text = "";
            cboTipo.Text = "";
        }

        private void btnImportarDados_MouseEnter(object sender, EventArgs e)
        {
            btnCadastrarUsuario.BackColor = Color.FromArgb(245, 62, 56);
        }

        private void btnImportarDados_MouseHover(object sender, EventArgs e)
        {
            btnCadastrarUsuario.BackColor = Color.FromArgb(245, 62, 56);
        }

        private void pnlIndicador_Paint(object sender, PaintEventArgs e)
        {
            pnlIndicador.Height = btnCadastrarUsuario.Height;
            pnlIndicador.Top = btnCadastrarUsuario.Top;
        }

        private void FrmRegistrarUsuario_Load(object sender, EventArgs e)
        {
        }
    }
}
