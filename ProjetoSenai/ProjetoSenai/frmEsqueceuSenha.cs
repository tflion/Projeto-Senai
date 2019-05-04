using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
//Material Design
using MaterialSkin;
using MaterialSkin.Controls;

namespace ProjetoSenai
{
    public partial class frmEsqueceuSenha : MaterialForm
    {
        ClassUsuario usuario = new ClassUsuario();
        public frmEsqueceuSenha()
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

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            

            if (usuario.VerificarLogin(txtEmail.Text) > 0)
            {
                //Mandar email
                MailMessage mail = new MailMessage();

                //Colocando email e senha do cliente
                string emailCliente = txtEmail.Text;
                string senhaCliente = usuario.RetSenha(txtEmail.Text).Rows[0]["senha"].ToString();
                //Quem vai mandar
                mail.From = new MailAddress("no.suporte.reply@gmail.com");
                //Quem vai receber
                mail.To.Add(emailCliente);
                //Assunto
                mail.Subject = "Recuperação de senha";
                //Mensagem
                mail.Body = "Sua senha do programa: " + senhaCliente + " ";

                //Criar smtp para enviar o email
                using (var smtp = new SmtpClient("smtp.gmail.com"))
                {
                    smtp.EnableSsl = true; // GMail requer SSL
                    smtp.Port = 587;       // porta para SSL
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network; // modo de envio
                    smtp.UseDefaultCredentials = false; // utilizar credencias especificas

                    //Usuário e senha do email que irá mandar
                    smtp.Credentials = new NetworkCredential("no.suporte.reply@gmail.com", "suporte123");
                    //Envia o email
                    smtp.Send(mail);
                    lblResult.Text = "E-mail enviado com sucesso.";
                    txtEmail.Text = "";

                }
            }
            else
            {
                lblResult.Text = "E-mail não cadastrado no sistema";
            }
            
        }

        private void BtnVoltarLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin form = new frmLogin();
            form.ShowDialog();
            this.Close();
        }
    }
    
}
