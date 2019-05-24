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
    public partial class userCadastroDeEmpregos : UserControl
    {
        ClassEmpresa empresa = new ClassEmpresa();
        ClassSolicitarContrato contrato = new ClassSolicitarContrato();

        public userCadastroDeEmpregos()
        {
            InitializeComponent();
            retornarEmpresaDgv();
            retornarSolicitacaoDgv();
        }

        int codEmpresaClicada, codSolicitacaoClicada = 0;

        private void LimparTxt()
        {
            txtNomeEmpresa.Text = "";
            cboTipoContrato.Text = "";
        }
        private void retornarEmpresaDgv()
        {
            dgvEmpresa.DataSource = empresa.RetEmpresas();
        }
        private void retornarSolicitacaoDgv()
        {
            dgvSolicitarEmprego.DataSource = contrato.RetSolicitacao();
        }

        private void btnCadastrarContrato_Click(object sender, EventArgs e)
        {
            contrato.empresa_codEmpresa = codEmpresaClicada;
            contrato.nomeEmpresa = txtNomeEmpresa.Text;
            contrato.tipoContrato = cboTipoContrato.Text;
            if (contrato.InserirSolicitacao() == true)
            {
                MessageBox.Show("Cadastrado");
                LimparTxt();
                retornarSolicitacaoDgv();
            }
        }

        private void btnEditarContrato_Click(object sender, EventArgs e)
        {
            contrato.nomeEmpresa = txtNomeEmpresa.Text;
            contrato.tipoContrato = cboTipoContrato.Text;
            if (contrato.EditarSolicitacao(codSolicitacaoClicada) == true)
            {
                MessageBox.Show("Editado");
                LimparTxt();
                retornarSolicitacaoDgv();
            }
        }

        private void dgvEmpresa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            //Se clicar em algum codigo no dgv
            if (dgvEmpresa.Rows[e.RowIndex].Cells["codEmpresa"].Value.ToString() != "")
            {
                //CodClicado recebe o campo clicado
                codEmpresaClicada = int.Parse(dgvEmpresa.Rows[e.RowIndex].Cells["codEmpresa"].Value.ToString());
            }
            txtNomeEmpresa.Text = dgvEmpresa.Rows[e.RowIndex].Cells["nomeEmpresa"].Value.ToString();

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            retornarEmpresaDgv();
            retornarSolicitacaoDgv();
        }

        private void userCadastroDeEmpregos_Load(object sender, EventArgs e)
        {
            //Textos não editáveis
            txtNomeEmpresa.ReadOnly = true;
            txtNomeEmpresa.BackColor = SystemColors.Window;
        }

        private void btnRemoverContrato_Click(object sender, EventArgs e)
        {
            if(contrato.ExcluirSolicitacao(codSolicitacaoClicada) == true)
            {
                MessageBox.Show("Excluido");
                LimparTxt();
                retornarSolicitacaoDgv();
            }
        }

        private void dgvSolicitarEmprego_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            //Se clicar em algum codigo no dgv
            if (dgvSolicitarEmprego.Rows[e.RowIndex].Cells["codContrato"].Value.ToString() != "")
            {
                //CodClicado recebe o campo clicado
                codSolicitacaoClicada = int.Parse(dgvSolicitarEmprego.Rows[e.RowIndex].Cells["codContrato"].Value.ToString());
            }
            cboTipoContrato.Text = dgvSolicitarEmprego.Rows[e.RowIndex].Cells["tipoContrato"].Value.ToString();
            txtNomeEmpresa.Text = dgvSolicitarEmprego.Rows[e.RowIndex].Cells["nomeEmpresa"].Value.ToString();
        }
    }
}
