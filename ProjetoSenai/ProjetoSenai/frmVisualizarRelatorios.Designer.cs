namespace ProjetoSenai
{
    partial class frmVisualizarRelatorios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlDireito = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlDireito
            // 
            this.pnlDireito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            this.pnlDireito.Location = new System.Drawing.Point(0, 64);
            this.pnlDireito.Name = "pnlDireito";
            this.pnlDireito.Size = new System.Drawing.Size(194, 490);
            this.pnlDireito.TabIndex = 1;
            // 
            // frmVisualizarRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 554);
            this.Controls.Add(this.pnlDireito);
            this.Name = "frmVisualizarRelatorios";
            this.Text = "frmVisualizarRelatorios";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDireito;
    }
}