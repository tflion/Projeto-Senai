using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSenai
{
    public partial class MyMessageBox : Form
    {
        public MyMessageBox()
        {
            InitializeComponent();
        }
        static MyMessageBox MsgBox; static DialogResult result = DialogResult.No;

        public static DialogResult Show(string text, string title, string btnOK, string btnCancel)
        {
            MsgBox = new MyMessageBox();
            MsgBox.lblMensagem.Text = text;
            MsgBox.btnOk.Text = btnOK;
            MsgBox.btnCancel.Text = btnCancel;
            MsgBox.lblTitulo.Text = title;
            MsgBox.ShowDialog();
            return result;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            result = DialogResult.Yes; MsgBox.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
