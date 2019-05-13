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
        }
        private void RetornarEmpresaDgv()
        {
            dgvEmpresa.DataSource = empresa.RetEmpresas();
        }
        private void RetornarAlunoDgv()
        {
            dgvAluno.DataSource = aluno.retAlunos();
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

        }
    }
}
