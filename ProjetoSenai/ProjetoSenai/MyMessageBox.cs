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
        #region Variables
        public static MyMessageBox MsgBox;
        public static DialogResult result;
        public enum CustomMessageBoxButtons { Ok, OkCancel }
        public enum CustomMessageBoxTxtBoxState { VisibleChar, PasswordChar, VisibleCharReadOnly }
        #endregion

        public static DialogResult Show(string text, string title, CustomMessageBoxButtons buttons)
        {
            MsgBox = new MyMessageBox();
            MsgBox.lblMensagem.Text = text;
            MsgBox.lblTitulo.Text = title;
            result = DialogResult.No;
            if (buttons == CustomMessageBoxButtons.Ok)
            {
                MsgBox.btnOk.Location = new Point(86, 70);
                MsgBox.btnCancel.Visible = false;
            }
            MsgBox.ShowDialog();
            return result;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
