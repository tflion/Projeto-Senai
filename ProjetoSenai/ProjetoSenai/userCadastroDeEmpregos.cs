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
        private bool ChecarTextos()
        {
            if (String.IsNullOrEmpty(txtNomeEmpresa.Text) || String.IsNullOrEmpty(cboTipoContrato.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void retornarEmpresaDgv()
        {
            dgvEmpresa.DataSource = empresa.RetEmpresas();
            //Dgv ajustar o tamanho para o conteúdo dentro, não o header
            dgvEmpresa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
        private void retornarSolicitacaoDgv()
        {
            dgvSolicitarEmprego.DataSource = contrato.RetSolicitacao();
            //Dgv ajustar o tamanho para o conteúdo dentro, não o header
            dgvSolicitarEmprego.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void btnCadastrarContrato_Click(object sender, EventArgs e)
        {
            if (ChecarTextos() == true)
            {
                contrato.empresa_codEmpresa = codEmpresaClicada;
                contrato.nomeEmpresa = txtNomeEmpresa.Text;
                contrato.tipoContrato = cboTipoContrato.Text;
                if (contrato.InserirSolicitacao() == true)
                {
                    MyMessageBox.Show("Contrato cadastrado com sucesso!", "Cadastro de contrato", "OK");
                    LimparTxt();
                    retornarSolicitacaoDgv();
                }
            }else
            {
                MyMessageBox.Show("         Favor preencher os dados \n                 corretamente.", "Validação", "OK");
            }
        }

        private void btnEditarContrato_Click(object sender, EventArgs e)
        {
            if (ChecarTextos() == true)
            {
                contrato.nomeEmpresa = txtNomeEmpresa.Text;
                contrato.tipoContrato = cboTipoContrato.Text;
                if (contrato.EditarSolicitacao(codSolicitacaoClicada) == true)
                {
                    MyMessageBox.Show("Contrato editado com sucesso!", "Edição de contrato", "OK");
                    LimparTxt();
                    retornarSolicitacaoDgv();
                }
            }else
            {
                MyMessageBox.Show("         Favor preencher os dados \n                 corretamente.", "Validação", "OK");
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

            //Dados não necessários no dgv
            dgvSolicitarEmprego.Columns["empresa_codEmpresa"].Visible = false;
        }

        private void btnRemoverContrato_Click(object sender, EventArgs e)
        {
            if(ChecarTextos() == true)
            {
                if (contrato.ExcluirSolicitacao(codSolicitacaoClicada) == true)
                {
                    MyMessageBox.Show("Contrato excluído com sucesso!", "Exclusão de contrato", "OK");
                    LimparTxt();
                    retornarSolicitacaoDgv();
                }
            }else
            {
                MyMessageBox.Show("         Favor preencher os dados \n                 corretamente.", "Validação", "OK");
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
