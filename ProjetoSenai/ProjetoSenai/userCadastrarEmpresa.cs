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
        ClassEmpresa empresa = new ClassEmpresa();
        int codEmpresaClicada = 0;

        public userCadastrarEmpresa()
        {
            InitializeComponent();
            RetornarEmpresaDgv();
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
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ChecarTextos() == true)
            {
                PegarDados();

                if (empresa.Inserir() == true)
                {
                    MessageBox.Show("Empresa cadastrada com sucesso.");
                    LimparTxt();
                    dgvEmpresa.DataSource = empresa.RetEmpresas();
                }
            }
            else
            {
                MessageBox.Show("Preencha corretamento todos os dados");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(ChecarTextos() == true)
            {
                PegarDados();
                empresa.aluno_codAluno = 0;

                if (empresa.Editar(codEmpresaClicada) == true)
                {
                    MessageBox.Show("Empresa editada com sucesso.");
                    LimparTxt();
                    RetornarEmpresaDgv();
                }
            }else
            {
                MessageBox.Show("Preencha corretamento todos os dados");
            }


        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Tem certeza que deseja excluir", "Exclusão", MessageBoxButtons.OKCancel);
            if(dialog == DialogResult.Yes)
            {
                if (empresa.Excluir(codEmpresaClicada) == true)
                {
                    MessageBox.Show("Empresa excluida com sucesso.");
                    LimparTxt();
                    RetornarEmpresaDgv();
                }
            }
            else
            {
                
            }


        }

        private void userCadastrarEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparTxt();
        }


        private void LimparTxt()
        {
            txtNome.Text = "";
            txtTelefone.Text = "";
            txtEmail.Text = "";
            txtCep.Text = "";
            txtEstado.Text = "";
            txtCidade.Text = "";
            txtBairro.Text = "";
            txtRua.Text = "";
            txtComplemento.Text = "";
            txtNumero.Text = "";
        }
        private void PegarDados()
        {
            //Pegar as informações para a inserção
            empresa.nomeEmpresa = txtNome.Text;
            empresa.telefone = txtTelefone.Text;
            empresa.emailContato = txtEmail.Text;
            empresa.cidade = txtCidade.Text;
            empresa.estado = txtEstado.Text;
            empresa.bairro = txtBairro.Text;
            empresa.rua = txtRua.Text;
            empresa.complemento = txtComplemento.Text;
            empresa.numero = txtNumero.Text;
            empresa.cep = txtCep.Text;
        }
        private void RetornarEmpresaDgv()
        {
            dgvEmpresa.DataSource = empresa.RetEmpresas();
        }
        private bool ChecarTextos()
        {
            if (String.IsNullOrEmpty(txtNome.Text) || String.IsNullOrEmpty(txtTelefone.Text) || String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(txtEstado.Text) || String.IsNullOrEmpty(txtCidade.Text) || String.IsNullOrEmpty(txtBairro.Text) || String.IsNullOrEmpty(txtNumero.Text) || String.IsNullOrEmpty(txtComplemento.Text) || String.IsNullOrEmpty(txtRua.Text) || String.IsNullOrEmpty(txtCep.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void dgvEmpresa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Se clicar em algum codigo no dgv
            if (dgvEmpresa.Rows[e.RowIndex].Cells["codEmpresa"].Value.ToString() != "")
            {
                //CodClicado recebe o campo clicado
                codEmpresaClicada = int.Parse(dgvEmpresa.Rows[e.RowIndex].Cells["codEmpresa"].Value.ToString());
            }
            txtNome.Text = dgvEmpresa.Rows[e.RowIndex].Cells["nomeEmpresa"].Value.ToString();
            txtTelefone.Text = dgvEmpresa.Rows[e.RowIndex].Cells["telefone"].Value.ToString();
            txtEmail.Text = dgvEmpresa.Rows[e.RowIndex].Cells["emailContato"].Value.ToString();
            txtCep.Text = dgvEmpresa.Rows[e.RowIndex].Cells["cep"].Value.ToString();
            txtEstado.Text = dgvEmpresa.Rows[e.RowIndex].Cells["estado"].Value.ToString();
            txtCidade.Text = dgvEmpresa.Rows[e.RowIndex].Cells["cidade"].Value.ToString();
            txtBairro.Text = dgvEmpresa.Rows[e.RowIndex].Cells["bairro"].Value.ToString();
            txtRua.Text = dgvEmpresa.Rows[e.RowIndex].Cells["rua"].Value.ToString();
            txtComplemento.Text = dgvEmpresa.Rows[e.RowIndex].Cells["complemento"].Value.ToString();
            txtNumero.Text = dgvEmpresa.Rows[e.RowIndex].Cells["numeroCasa"].Value.ToString();
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
