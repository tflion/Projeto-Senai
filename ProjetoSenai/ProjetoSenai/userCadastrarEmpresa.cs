using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Correios para buscar cep
using System.Text.RegularExpressions;
using System.Net;
using System.IO;

namespace ProjetoSenai
{
    public partial class userCadastrarEmpresa : UserControl
    {
        public userCadastrarEmpresa()
        {
            InitializeComponent();
        }
        private void MostrarCEP()
        {
            if(txtCep.Text != "")
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://viacep.com.br/ws/" + txtCep.Text + "/json/");
                request.AllowAutoRedirect = false;
                HttpWebResponse ChecaServidor = (HttpWebResponse)request.GetResponse();

                if (ChecaServidor.StatusCode != HttpStatusCode.OK)
                {
                    MessageBox.Show("Servidor indisponível");
                    return; // Sai da rotina
                }

                using (Stream webStream = ChecaServidor.GetResponseStream())
                {
                    if (webStream != null)
                    {
                        using (StreamReader responseReader = new StreamReader(webStream))
                        {
                            string response = responseReader.ReadToEnd();
                            response = Regex.Replace(response, "[{},]", string.Empty);
                            response = response.Replace("\"", "");

                            String[] substrings = response.Split('\n');

                            int cont = 0;
                            foreach (var substring in substrings)
                            {
                                if (cont == 1)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    if (valor[0] == "  erro")
                                    {
                                        MessageBox.Show("CEP não encontrado");
                                        txtCep.Focus();
                                        return;
                                    }
                                }

                                //Logradouro
                                if (cont == 2)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    txtRua.Text = valor[1];
                                }

                                //Complemento
                                if (cont == 3)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    txtComplemento.Text = valor[1];
                                }

                                //Bairro
                                if (cont == 4)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    txtBairro.Text = valor[1];
                                }

                                //Localidade (Cidade)
                                if (cont == 5)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    txtCidade.Text = valor[1];
                                }

                                //Estado (UF)
                                if (cont == 6)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    txtEstado.Text = valor[1];
                                }

                                cont++;
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Cep vazio");
            }
            

        }

        private void TxtCep_Leave(object sender, EventArgs e)
        {
            //Colocar cep nas txtBox a partir do cep dado no mskBox
            MostrarCEP();
        }
    }
}
