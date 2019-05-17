using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSenai
{
    public partial class userAlocarAlunos : UserControl
    {
        ClassEmpresa empresa = new ClassEmpresa();
        ClassAluno aluno = new ClassAluno();

        int codEmpresaClicada, codAlunoClicado = 0;

        public userAlocarAlunos()
        {
            InitializeComponent();
            RetornarAlunoDgv();
            RetornarEmpresaDgv();
        }
        private void RetornarEmpresaDgv()
        {
            dgvEmpresa.DataSource = empresa.RetEmpresas();
        }
        private void RetornarAlunoDgv()
        {
            dgvAluno.DataSource = aluno.retAlunos();
        }
        private void LimparTxt()
        {
            txtNomeAluno.Text = "";
            txtCpfAluno.Text = "";
            txtNomeEmpresa.Text = "";
            txtCnpj.Text = "";
            txtIdade.Text = "";
        }
        private bool VerificarDados()
        {
            if(String.IsNullOrEmpty(txtNomeAluno.Text) || String.IsNullOrEmpty(txtCpfAluno.Text) || String.IsNullOrEmpty(txtNomeEmpresa.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        private void dgvAluno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Se clicar em algum codigo no dgv
            if (dgvAluno.Rows[e.RowIndex].Cells["codAluno"].Value.ToString() != "")
            {
                //CodClicado recebe o campo clicado
                codAlunoClicado = int.Parse(dgvAluno.Rows[e.RowIndex].Cells["codAluno"].Value.ToString());
            }
            txtNomeAluno.Text = dgvAluno.Rows[e.RowIndex].Cells["nomeAluno"].Value.ToString();
            txtCpfAluno.Text = dgvAluno.Rows[e.RowIndex].Cells["cpf"].Value.ToString();
            txtIdade.Text = dgvAluno.Rows[e.RowIndex].Cells["idade"].Value.ToString();

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            RetornarAlunoDgv();
            RetornarEmpresaDgv();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            if(VerificarDados() == true)
            {
                empresa.aluno_codAluno = codAlunoClicado;
                empresa.nomeEmpresa = txtNomeEmpresa.Text;
                empresa.cnpj = txtCnpj.Text;
                if(empresa.AlocarAluno(codEmpresaClicada,txtNomeAluno.Text,txtCpfAluno.Text,txtIdade.Text) == true)
                {
                    MessageBox.Show("Aluno alocado a empresa com sucesso.");
                    LimparTxt();
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscarAluno.Text.Length < 1 || txtBuscarAluno.Text == "Insira o código da Turma")
            {
                MessageBox.Show("Insira um valor no campo de filtro de Turma ao lado da opção 'Filtrar por Turma'");
            }
            else
            {
                //Validação para o caso da tabela não tenha sido selecionada ainda
                if (dgvAluno.Rows.Count == 0)
                {
                    MessageBox.Show("Por favor, selecione uma tabela antes de filtrar!");
                }
                else
                {
                    //Código para filtrar o datagridview, para colocar mais filtros juntos só adicionar AND/OR e a condição, 
                    // como faria no banco de dados 
                    (dgvAluno.DataSource as DataTable).DefaultView.RowFilter =
                    string.Format("sexo LIKE '{0}%' OR idade LIKE '{0}%' OR nomeAluno LIKE '{0}%' OR cidade LIKE '{0}%' OR bairro LIKE '{0}%' ", txtBuscarAluno.Text);
                }
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (txtBuscarEmpresa.Text.Length < 1 || txtBuscarEmpresa.Text == "Insira o código da Turma")
            {
                MessageBox.Show("Insira um valor no campo de filtro de Turma ao lado da opção 'Filtrar por Turma'");
            }
            else
            {
                //Validação para o caso da tabela não tenha sido selecionada ainda
                if (dgvEmpresa.Rows.Count == 0)
                {
                    MessageBox.Show("Por favor, selecione uma tabela antes de filtrar!");
                }
                else
                {
                    //Código para filtrar o datagridview, para colocar mais filtros juntos só adicionar AND/OR e a condição, 
                    // como faria no banco de dados 
                    (dgvEmpresa.DataSource as DataTable).DefaultView.RowFilter =
                    string.Format("nomeEmpresa LIKE '{0}%' OR cidade LIKE '{0}%'  ", txtBuscarEmpresa.Text);
                }
            }
        }

        private void userAlocarAlunos_Load(object sender, EventArgs e)
        {

        }

        private void lblBuscarEmpresa_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscarEmpresa_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblIdade_Click(object sender, EventArgs e)
        {

        }

        private void dgvEmpresa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Se clicar em algum codigo no dgv
            if (dgvEmpresa.Rows[e.RowIndex].Cells["codEmpresa"].Value.ToString() != "")
            {
                //CodClicado recebe o campo clicado
                codEmpresaClicada = int.Parse(dgvEmpresa.Rows[e.RowIndex].Cells["codEmpresa"].Value.ToString());
            }
            txtNomeEmpresa.Text = dgvEmpresa.Rows[e.RowIndex].Cells["nomeEmpresa"].Value.ToString();
            txtCnpj.Text = dgvEmpresa.Rows[e.RowIndex].Cells["cnpj"].Value.ToString();

        }
    }  
}
