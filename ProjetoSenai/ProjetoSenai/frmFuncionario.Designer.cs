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
            this.btnCadastrarEmpresa = new System.Windows.Forms.Button();
            this.btnImportarDados = new System.Windows.Forms.Button();
            this.userCadastrarEmpresa2 = new ProjetoSenai.userCadastrarEmpresa();
            this.userPrincipal = new ProjetoSenai.userPrincipal();
            this.userImportarDados = new ProjetoSenai.userImportarDados();
            this.userCadastrarEmpresa1 = new ProjetoSenai.userCadastrarEmpresa();
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
            this.pnlDireito.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDireito_Paint);
            // 
            // btnCadastrarEmpresa
            // 
            this.btnCadastrarEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            this.btnCadastrarEmpresa.FlatAppearance.BorderSize = 0;
            this.btnCadastrarEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarEmpresa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarEmpresa.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarEmpresa.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarEmpresa.Image")));
            this.btnCadastrarEmpresa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadastrarEmpresa.Location = new System.Drawing.Point(3, 184);
            this.btnCadastrarEmpresa.Name = "btnCadastrarEmpresa";
            this.btnCadastrarEmpresa.Size = new System.Drawing.Size(187, 62);
            this.btnCadastrarEmpresa.TabIndex = 5;
            this.btnCadastrarEmpresa.Text = "CADASTRAR EMPRESA";
            this.btnCadastrarEmpresa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastrarEmpresa.UseVisualStyleBackColor = false;
            this.btnCadastrarEmpresa.Click += new System.EventHandler(this.button1_Click_1);
            this.btnCadastrarEmpresa.MouseEnter += new System.EventHandler(this.btnCadastrarEmpresa_MouseEnter);
            this.btnCadastrarEmpresa.MouseHover += new System.EventHandler(this.btnCadastrarEmpresa_MouseHover);
            // 
            // btnImportarDados
            // 
            this.btnImportarDados.BackColor = System.Drawing.Color.Transparent;
            this.btnImportarDados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnImportarDados.FlatAppearance.BorderSize = 0;
            this.btnImportarDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportarDados.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportarDados.ForeColor = System.Drawing.Color.White;
            this.btnImportarDados.Image = ((System.Drawing.Image)(resources.GetObject("btnImportarDados.Image")));
            this.btnImportarDados.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImportarDados.Location = new System.Drawing.Point(3, 61);
            this.btnImportarDados.Name = "btnImportarDados";
            this.btnImportarDados.Size = new System.Drawing.Size(187, 77);
            this.btnImportarDados.TabIndex = 4;
            this.btnImportarDados.Text = "IMPORTAR DADOS DO EXCEL";
            this.btnImportarDados.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImportarDados.UseVisualStyleBackColor = false;
            this.btnImportarDados.Click += new System.EventHandler(this.button1_Click);
            this.btnImportarDados.MouseEnter += new System.EventHandler(this.btnImportarDados_MouseEnter);
            this.btnImportarDados.MouseHover += new System.EventHandler(this.btnImportarDados_MouseHover_1);
            // 
            // userCadastrarEmpresa2
            // 
            this.userCadastrarEmpresa2.Location = new System.Drawing.Point(196, 64);
            this.userCadastrarEmpresa2.Name = "userCadastrarEmpresa2";
            this.userCadastrarEmpresa2.Size = new System.Drawing.Size(549, 490);
            this.userCadastrarEmpresa2.TabIndex = 3;
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
            // userCadastrarEmpresa1
            // 
            this.userCadastrarEmpresa1.Location = new System.Drawing.Point(196, 64);
            this.userCadastrarEmpresa1.Name = "userCadastrarEmpresa1";
            this.userCadastrarEmpresa1.Size = new System.Drawing.Size(549, 490);
            this.userCadastrarEmpresa1.TabIndex = 3;
            this.userCadastrarEmpresa1.Load += new System.EventHandler(this.userCadastrarEmpresa1_Load);
            // 
            // frmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 554);
            this.Controls.Add(this.userCadastrarEmpresa2);
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
        private userImportarDados userImportarDados;
        private userPrincipal userPrincipal;
        private userCadastrarEmpresa userCadastrarEmpresa1;
        private userCadastrarEmpresa userCadastrarEmpresa2;
        private System.Windows.Forms.Button btnImportarDados;
        private System.Windows.Forms.Button btnCadastrarEmpresa;
    }
}