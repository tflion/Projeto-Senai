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
    public partial class userHistoricoEmprego : UserControl
    {
        ClassEmpresa empresa = new ClassEmpresa();

        public userHistoricoEmprego()
        {
            InitializeComponent();
            retAlunosDgv();
        }

        private void retAlunosDgv()
        {
            dgvHistoricoEmprego.DataSource = empresa.RetHistoricoAlunos();
            //Dgv ajustar o tamanho para o conteúdo dentro, não o header
            dgvHistoricoEmprego.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            retAlunosDgv();
        }

        private void btnAtualizar_Click_1(object sender, EventArgs e)
        {
            retAlunosDgv();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscarAluno.Text.Length < 1 || txtBuscarAluno.Text == "ERR0 ")
            {

            }
            else
            {
                //Validação para o caso da tabela não tenha sido selecionada ainda
                if (dgvHistoricoEmprego.Rows.Count == 0)
                {
                    MyMessageBox.Show("Por favor, selecione uma tabela antes de filtrar!", "Atenção", "OK");
                }
                else
                {
                    //Código para filtrar o datagridview, para colocar mais filtros juntos só adicionar AND/OR e a condição, 
                    // como faria no banco de dados 
                    (dgvHistoricoEmprego.DataSource as DataTable).DefaultView.RowFilter =
                    string.Format("nomeAluno LIKE '{0}%' OR idadeAluno LIKE '{0}%' OR cpfAluno LIKE '{0}% OR nomeEmpresa LIKE '{0}%' ", txtBuscarAluno.Text);
                }
                {

                }
            }
        }

        private void UserHistoricoEmprego_Load(object sender, EventArgs e)
        {
            //Dados não necessários no dgv
            dgvHistoricoEmprego.Columns["aluno_codAluno"].Visible = false;
            dgvHistoricoEmprego.Columns["empresa_codEmpresa"].Visible = false;
        }
    }
}
