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
    public partial class userVisualizarAlunos : UserControl
    {
        ClassEmpresa empresa = new ClassEmpresa();

        public userVisualizarAlunos()
        {
            InitializeComponent();
            RetornarAlunosAlocadosDgv();
        }

        private void RetornarAlunosAlocadosDgv()
        {
            dgvAlunosNaEmpresa.DataSource = empresa.RetAlunosAlocados();
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            RetornarAlunosAlocadosDgv();
        }
    }
}
