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
        }

        private void userHistoricoEmprego_Load(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            retAlunosDgv();
        }

        private void btnAtualizar_Click_1(object sender, EventArgs e)
        {
            retAlunosDgv();
        }
    }
}
