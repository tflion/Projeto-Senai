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
            this.pnlIndicador = new System.Windows.Forms.Panel();
            this.btnVisualizarAlunos = new System.Windows.Forms.Button();
            this.btnAlocarAlunos = new System.Windows.Forms.Button();
            this.btnCadastrarEmpresa = new System.Windows.Forms.Button();
            this.btnImportarDados = new System.Windows.Forms.Button();
            this.userCadastrarEmpresa2 = new ProjetoSenai.userCadastrarEmpresa();
            this.userPrincipal = new ProjetoSenai.userPrincipal();
            this.userImportarDados = new ProjetoSenai.userImportarDados();
            this.userCadastrarEmpresa1 = new ProjetoSenai.userCadastrarEmpresa();
            this.userAlocarAlunos1 = new ProjetoSenai.userAlocarAlunos();
            this.pnlDireito.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDireito
            // 
            this.pnlDireito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            this.pnlDireito.Controls.Add(this.pnlIndicador);
            this.pnlDireito.Controls.Add(this.btnVisualizarAlunos);
            this.pnlDireito.Controls.Add(this.btnAlocarAlunos);
            this.pnlDireito.Controls.Add(this.btnCadastrarEmpresa);
            this.pnlDireito.Controls.Add(this.btnImportarDados);
            this.pnlDireito.Location = new System.Drawing.Point(0, 64);
            this.pnlDireito.Name = "pnlDireito";
            this.pnlDireito.Size = new System.Drawing.Size(194, 490);
            this.pnlDireito.TabIndex = 0;
            this.pnlDireito.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDireito_Paint);
            // 
            // pnlIndicador
            // 
            this.pnlIndicador.BackColor = System.Drawing.Color.White;
            this.pnlIndicador.Location = new System.Drawing.Point(0, 12);
            this.pnlIndicador.Name = "pnlIndicador";
            this.pnlIndicador.Size = new System.Drawing.Size(10, 75);
            this.pnlIndicador.TabIndex = 15;
            this.pnlIndicador.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlIndicador_Paint);
            // 
            // btnVisualizarAlunos
            // 
            this.btnVisualizarAlunos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            this.btnVisualizarAlunos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVisualizarAlunos.FlatAppearance.BorderSize = 0;
            this.btnVisualizarAlunos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizarAlunos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizarAlunos.ForeColor = System.Drawing.Color.White;
            this.btnVisualizarAlunos.Image = ((System.Drawing.Image)(resources.GetObject("btnVisualizarAlunos.Image")));
            this.btnVisualizarAlunos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVisualizarAlunos.Location = new System.Drawing.Point(8, 295);
            this.btnVisualizarAlunos.Name = "btnVisualizarAlunos";
            this.btnVisualizarAlunos.Size = new System.Drawing.Size(187, 67);
            this.btnVisualizarAlunos.TabIndex = 7;
            this.btnVisualizarAlunos.Text = "VISUALIZAR ALUNOS NA  EMPRESA";
            this.btnVisualizarAlunos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVisualizarAlunos.UseVisualStyleBackColor = false;
            this.btnVisualizarAlunos.Click += new System.EventHandler(this.btnVisualizarAlunos_Click);
            // 
            // btnAlocarAlunos
            // 
            this.btnAlocarAlunos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            this.btnAlocarAlunos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlocarAlunos.FlatAppearance.BorderSize = 0;
            this.btnAlocarAlunos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlocarAlunos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlocarAlunos.ForeColor = System.Drawing.Color.White;
            this.btnAlocarAlunos.Image = ((System.Drawing.Image)(resources.GetObject("btnAlocarAlunos.Image")));
            this.btnAlocarAlunos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAlocarAlunos.Location = new System.Drawing.Point(8, 201);
            this.btnAlocarAlunos.Name = "btnAlocarAlunos";
            this.btnAlocarAlunos.Size = new System.Drawing.Size(187, 75);
            this.btnAlocarAlunos.TabIndex = 6;
            this.btnAlocarAlunos.Text = "ALOCAR ALUNOS A EMPRESA";
            this.btnAlocarAlunos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlocarAlunos.UseVisualStyleBackColor = false;
            this.btnAlocarAlunos.Click += new System.EventHandler(this.Button1_Click_2);
            // 
            // btnCadastrarEmpresa
            // 
            this.btnCadastrarEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            this.btnCadastrarEmpresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarEmpresa.FlatAppearance.BorderSize = 0;
            this.btnCadastrarEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarEmpresa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarEmpresa.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarEmpresa.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarEmpresa.Image")));
            this.btnCadastrarEmpresa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadastrarEmpresa.Location = new System.Drawing.Point(6, 111);
            this.btnCadastrarEmpresa.Name = "btnCadastrarEmpresa";
            this.btnCadastrarEmpresa.Size = new System.Drawing.Size(190, 60);
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
            this.btnImportarDados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportarDados.FlatAppearance.BorderSize = 0;
            this.btnImportarDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportarDados.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportarDados.ForeColor = System.Drawing.Color.White;
            this.btnImportarDados.Image = ((System.Drawing.Image)(resources.GetObject("btnImportarDados.Image")));
            this.btnImportarDados.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImportarDados.Location = new System.Drawing.Point(8, 12);
            this.btnImportarDados.Name = "btnImportarDados";
            this.btnImportarDados.Size = new System.Drawing.Size(187, 75);
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
            this.userCadastrarEmpresa2.Margin = new System.Windows.Forms.Padding(4);
            this.userCadastrarEmpresa2.Name = "userCadastrarEmpresa2";
            this.userCadastrarEmpresa2.Size = new System.Drawing.Size(549, 490);
            this.userCadastrarEmpresa2.TabIndex = 3;
            // 
            // userPrincipal
            // 
            this.userPrincipal.BackColor = System.Drawing.Color.White;
            this.userPrincipal.Location = new System.Drawing.Point(196, 64);
            this.userPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.userPrincipal.Name = "userPrincipal";
            this.userPrincipal.Size = new System.Drawing.Size(549, 490);
            this.userPrincipal.TabIndex = 2;
            // 
            // userImportarDados
            // 
            this.userImportarDados.Location = new System.Drawing.Point(196, 64);
            this.userImportarDados.Margin = new System.Windows.Forms.Padding(4);
            this.userImportarDados.Name = "userImportarDados";
            this.userImportarDados.Size = new System.Drawing.Size(549, 490);
            this.userImportarDados.TabIndex = 1;
            // 
            // userCadastrarEmpresa1
            // 
            this.userCadastrarEmpresa1.Location = new System.Drawing.Point(196, 64);
            this.userCadastrarEmpresa1.Margin = new System.Windows.Forms.Padding(4);
            this.userCadastrarEmpresa1.Name = "userCadastrarEmpresa1";
            this.userCadastrarEmpresa1.Size = new System.Drawing.Size(549, 490);
            this.userCadastrarEmpresa1.TabIndex = 3;
            this.userCadastrarEmpresa1.Load += new System.EventHandler(this.userCadastrarEmpresa1_Load);
            // 
            // userAlocarAlunos1
            // 
            this.userAlocarAlunos1.Location = new System.Drawing.Point(196, 64);
            this.userAlocarAlunos1.Name = "userAlocarAlunos1";
            this.userAlocarAlunos1.Size = new System.Drawing.Size(549, 490);
            this.userAlocarAlunos1.TabIndex = 4;
            // 
            // frmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 554);
            this.Controls.Add(this.userAlocarAlunos1);
            this.Controls.Add(this.userCadastrarEmpresa2);
            this.Controls.Add(this.userPrincipal);
            this.Controls.Add(this.userImportarDados);
            this.Controls.Add(this.pnlDireito);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(745, 554);
            this.Name = "frmFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SENAI - Serviço Nacional de Aprendizagem Industrial";
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
        private System.Windows.Forms.Button btnVisualizarAlunos;
        private System.Windows.Forms.Button btnAlocarAlunos;
        private System.Windows.Forms.Panel pnlIndicador;
        private userAlocarAlunos userAlocarAlunos1;
       
    }
}