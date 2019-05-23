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
        ClassSolicitarContrato contrato = new ClassSolicitarContrato();
        ClassEmpresa empresa = new ClassEmpresa();

        public userStatusEmprego()
        {
            InitializeComponent();
        }

        private void dgvSolicitacao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvAlunosAlocados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtPeriodo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
