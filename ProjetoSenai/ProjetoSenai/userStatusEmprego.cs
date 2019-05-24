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
    public partial class userStatusEmprego : UserControl
    {
        ClassEmpresa empresa = new ClassEmpresa();
        ClassSolicitarContrato contrato = new ClassSolicitarContrato();
        ClassStatusEmprego status = new ClassStatusEmprego();

        int codAlunoStatusEmprego,codAlunoAlocadoClicado = 0;

        public userStatusEmprego()
        {
            InitializeComponent();
            RetornarAlunosAlucadosDgv();
            RetornarStatusEmpregoDgv();
        }
        private void LimparDados()
        {
            txtNomeEmpresa.Text = "";
            txtNomeAluno.Text = "";
            txtPeriodo.Text = "";
            txtStatus.Text = "";
            rchDescricao.Text = "";
            mskDataInicio.Text = "";
            mskDataFim.Text = "";
        }
        private void RetornarAlunosAlucadosDgv()
        {
            dgvAlunosAlocados.DataSource = empresa.RetAlunosAlocados();
        }
        private void RetornarStatusEmpregoDgv()
        {
            dgvStatusAlunosAlocados.DataSource = empresa.RetStatusAlunosAlocados();
        }
        private void RetornarDados()
        {
            status.nomeEmpresa = txtNomeEmpresa.Text;
            status.nomeAluno = txtNomeAluno.Text;
            status.statusAluno = txtStatus.Text;
            status.descricao = rchDescricao.Text;
            status.periodoContrato = txtPeriodo.Text;
            status.dataInicio = mskDataInicio.Text;
            status.dataFim = mskDataFim.Text;
        }

        private void dgvAlunosAlocados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            //Se clicar em algum codigo no dgv
            if (dgvAlunosAlocados.Rows[e.RowIndex].Cells["codEmprego"].Value.ToString() != "")
            {
                //CodClicado recebe o campo clicado
                codAlunoAlocadoClicado = int.Parse(dgvAlunosAlocados.Rows[e.RowIndex].Cells["codEmprego"].Value.ToString());
            }
            txtNomeEmpresa.Text = dgvAlunosAlocados.Rows[e.RowIndex].Cells["nomeEmpresa"].Value.ToString();
            txtNomeAluno.Text = dgvAlunosAlocados.Rows[e.RowIndex].Cells["nomeAluno"].Value.ToString();
        }

        private void dgvStatusAlunosAlocados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            //Se clicar em algum codigo no dgv
            if (dgvStatusAlunosAlocados.Rows[e.RowIndex].Cells["codStatus"].Value.ToString() != "")
            {
                //CodClicado recebe o campo clicado
                codAlunoStatusEmprego = int.Parse(dgvStatusAlunosAlocados.Rows[e.RowIndex].Cells["codStatus"].Value.ToString());
            }
            txtNomeEmpresa.Text = dgvStatusAlunosAlocados.Rows[e.RowIndex].Cells["nomeEmpresa"].Value.ToString();
            txtNomeAluno.Text = dgvStatusAlunosAlocados.Rows[e.RowIndex].Cells["nomeAluno"].Value.ToString();
            txtStatus.Text = dgvStatusAlunosAlocados.Rows[e.RowIndex].Cells["statusAluno"].Value.ToString();
            rchDescricao.Text = dgvStatusAlunosAlocados.Rows[e.RowIndex].Cells["descricao"].Value.ToString();
            txtPeriodo.Text = dgvStatusAlunosAlocados.Rows[e.RowIndex].Cells["periodoContrato"].Value.ToString();
            mskDataInicio.Text = dgvStatusAlunosAlocados.Rows[e.RowIndex].Cells["dataInicio"].Value.ToString();
            mskDataFim.Text = dgvStatusAlunosAlocados.Rows[e.RowIndex].Cells["dataFim"].Value.ToString();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            RetornarAlunosAlucadosDgv();
            RetornarStatusEmpregoDgv();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            RetornarDados();
            if(status.Inserir() == true)
            {
                MessageBox.Show("Cadastrado");
                RetornarStatusEmpregoDgv();
                LimparDados();
            }
        }

        private void userStatusEmprego_Load(object sender, EventArgs e)
        {
            //Textos não editáveis
            txtNomeEmpresa.ReadOnly = true;
            txtNomeEmpresa.BackColor = SystemColors.Window;
            txtNomeAluno.ReadOnly = true;
            txtNomeAluno.BackColor = SystemColors.Window;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            RetornarDados();
            if(status.Editar(codAlunoStatusEmprego) == true)
            {
                MessageBox.Show("Editado");
                RetornarStatusEmpregoDgv();
                LimparDados();
            }
        }
    }
}
