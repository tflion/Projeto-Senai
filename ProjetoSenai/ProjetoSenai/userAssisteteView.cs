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
    public partial class userAssisteteView : UserControl
    {
        ClassEmpresa empresa = new ClassEmpresa();

        public userAssisteteView()
        {
            InitializeComponent();
        }

        private void btnVerEmpresa_Click(object sender, EventArgs e)
        {
            dgvVisualizar.DataSource = empresa.RetEmpresas();
        }
    }
}
