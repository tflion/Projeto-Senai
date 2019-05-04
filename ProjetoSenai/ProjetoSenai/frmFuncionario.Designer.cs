namespace ProjetoSenai
{
    partial class frmFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuncionario));
            this.pnlDireito = new System.Windows.Forms.Panel();
            this.btnImportarDados = new MaterialSkin.Controls.MaterialRaisedButton();
            this.userPrincipal = new ProjetoSenai.userPrincipal();
            this.userImportarDados = new ProjetoSenai.userImportarDados();
            this.btnCadastrarEmpresa = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pnlDireito.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDireito
            // 
            this.pnlDireito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            this.pnlDireito.Controls.Add(this.btnCadastrarEmpresa);
            this.pnlDireito.Controls.Add(this.btnImportarDados);
            this.pnlDireito.Location = new System.Drawing.Point(0, 64);
            this.pnlDireito.Name = "pnlDireito";
            this.pnlDireito.Size = new System.Drawing.Size(199, 490);
            this.pnlDireito.TabIndex = 0;
            // 
            // btnImportarDados
            // 
            this.btnImportarDados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportarDados.Depth = 0;
            this.btnImportarDados.Location = new System.Drawing.Point(-3, 53);
            this.btnImportarDados.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnImportarDados.Name = "btnImportarDados";
            this.btnImportarDados.Primary = true;
            this.btnImportarDados.Size = new System.Drawing.Size(199, 51);
            this.btnImportarDados.TabIndex = 2;
            this.btnImportarDados.Text = "Importar dados do excel";
            this.btnImportarDados.UseVisualStyleBackColor = true;
            this.btnImportarDados.Click += new System.EventHandler(this.btnImportarDados_Click);
            // 
            // userPrincipal
            // 
            this.userPrincipal.Location = new System.Drawing.Point(196, 64);
            this.userPrincipal.Name = "userPrincipal";
            this.userPrincipal.Size = new System.Drawing.Size(549, 490);
            this.userPrincipal.TabIndex = 2;
            // 
            // userImportarDados
            // 
            this.userImportarDados.Location = new System.Drawing.Point(196, 64);
            this.userImportarDados.Name = "userImportarDados";
            this.userImportarDados.Size = new System.Drawing.Size(549, 490);
            this.userImportarDados.TabIndex = 1;
            // 
            // btnCadastrarEmpresa
            // 
            this.btnCadastrarEmpresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarEmpresa.Depth = 0;
            this.btnCadastrarEmpresa.Location = new System.Drawing.Point(-3, 110);
            this.btnCadastrarEmpresa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCadastrarEmpresa.Name = "btnCadastrarEmpresa";
            this.btnCadastrarEmpresa.Primary = true;
            this.btnCadastrarEmpresa.Size = new System.Drawing.Size(199, 51);
            this.btnCadastrarEmpresa.TabIndex = 3;
            this.btnCadastrarEmpresa.Text = "CADASTRAR EMPRESA";
            this.btnCadastrarEmpresa.UseVisualStyleBackColor = true;
            // 
            // frmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 554);
            this.Controls.Add(this.userPrincipal);
            this.Controls.Add(this.userImportarDados);
            this.Controls.Add(this.pnlDireito);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(745, 554);
            this.Name = "frmFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SENAI - serviço de aprendizagem industrial";
            this.pnlDireito.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDireito;
        private MaterialSkin.Controls.MaterialRaisedButton btnImportarDados;
        private userImportarDados userImportarDados;
        private userPrincipal userPrincipal;
        private MaterialSkin.Controls.MaterialRaisedButton btnCadastrarEmpresa;
    }
}