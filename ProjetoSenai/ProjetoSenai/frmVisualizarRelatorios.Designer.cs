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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisualizarRelatorios));
            this.pnlDireito = new System.Windows.Forms.Panel();
            this.btnVisualizarAlunos = new System.Windows.Forms.Button();
            this.btnRelatorioSecretaria = new System.Windows.Forms.Button();
            this.lblEscolha = new System.Windows.Forms.Label();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlDireito.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDireito
            // 
            this.pnlDireito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            this.pnlDireito.Controls.Add(this.btnRelatorioSecretaria);
            this.pnlDireito.Controls.Add(this.btnVisualizarAlunos);
            this.pnlDireito.Location = new System.Drawing.Point(0, 64);
            this.pnlDireito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlDireito.Name = "pnlDireito";
            this.pnlDireito.Size = new System.Drawing.Size(259, 618);
            this.pnlDireito.TabIndex = 1;
            // 
            // btnVisualizarAlunos
            // 
            this.btnVisualizarAlunos.BackColor = System.Drawing.Color.Transparent;
            this.btnVisualizarAlunos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVisualizarAlunos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVisualizarAlunos.FlatAppearance.BorderSize = 0;
            this.btnVisualizarAlunos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizarAlunos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizarAlunos.ForeColor = System.Drawing.Color.White;
            this.btnVisualizarAlunos.Image = ((System.Drawing.Image)(resources.GetObject("btnVisualizarAlunos.Image")));
            this.btnVisualizarAlunos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVisualizarAlunos.Location = new System.Drawing.Point(4, 74);
            this.btnVisualizarAlunos.Margin = new System.Windows.Forms.Padding(4);
            this.btnVisualizarAlunos.Name = "btnVisualizarAlunos";
            this.btnVisualizarAlunos.Size = new System.Drawing.Size(249, 92);
            this.btnVisualizarAlunos.TabIndex = 5;
            this.btnVisualizarAlunos.Text = "VISUALIZAR ALUNOS NAS EMPRESAS";
            this.btnVisualizarAlunos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVisualizarAlunos.UseVisualStyleBackColor = false;
            this.btnVisualizarAlunos.Click += new System.EventHandler(this.btnVisualizarAlunos_Click);
            this.btnVisualizarAlunos.MouseEnter += new System.EventHandler(this.btnVisualizarAlunos_MouseEnter);
            // 
            // btnRelatorioSecretaria
            // 
            this.btnRelatorioSecretaria.BackColor = System.Drawing.Color.Transparent;
            this.btnRelatorioSecretaria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRelatorioSecretaria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelatorioSecretaria.FlatAppearance.BorderSize = 0;
            this.btnRelatorioSecretaria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorioSecretaria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorioSecretaria.ForeColor = System.Drawing.Color.White;
            this.btnRelatorioSecretaria.Image = ((System.Drawing.Image)(resources.GetObject("btnRelatorioSecretaria.Image")));
            this.btnRelatorioSecretaria.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRelatorioSecretaria.Location = new System.Drawing.Point(4, 216);
            this.btnRelatorioSecretaria.Margin = new System.Windows.Forms.Padding(4);
            this.btnRelatorioSecretaria.Name = "btnRelatorioSecretaria";
            this.btnRelatorioSecretaria.Size = new System.Drawing.Size(249, 92);
            this.btnRelatorioSecretaria.TabIndex = 6;
            this.btnRelatorioSecretaria.Text = "RELATÓRIO SECRETARIA";
            this.btnRelatorioSecretaria.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRelatorioSecretaria.UseVisualStyleBackColor = false;
            this.btnRelatorioSecretaria.Click += new System.EventHandler(this.btnRelatorioSecretaria_Click);
            this.btnRelatorioSecretaria.Enter += new System.EventHandler(this.btnRelatorioSecretaria_Enter);
            this.btnRelatorioSecretaria.MouseEnter += new System.EventHandler(this.btnRelatorioSecretaria_MouseEnter);
            // 
            // lblEscolha
            // 
            this.lblEscolha.AutoSize = true;
            this.lblEscolha.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscolha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            this.lblEscolha.Location = new System.Drawing.Point(437, 363);
            this.lblEscolha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEscolha.Name = "lblEscolha";
            this.lblEscolha.Size = new System.Drawing.Size(343, 28);
            this.lblEscolha.TabIndex = 17;
            this.lblEscolha.Text = "Escolha uma opção ao lado";
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            this.lblBemVindo.Location = new System.Drawing.Point(83, 214);
            this.lblBemVindo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(192, 40);
            this.lblBemVindo.TabIndex = 16;
            this.lblBemVindo.Text = "Bem vindo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblBemVindo);
            this.panel1.Location = new System.Drawing.Point(430, 64);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 254);
            this.panel1.TabIndex = 15;
            // 
            // frmVisualizarRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 444);
            this.Controls.Add(this.lblEscolha);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlDireito);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmVisualizarRelatorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SENAI - Serviço Nacional de Aprendizagem Industrial";
            this.pnlDireito.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDireito;
        private System.Windows.Forms.Button btnVisualizarAlunos;
        private System.Windows.Forms.Button btnRelatorioSecretaria;
        private System.Windows.Forms.Label lblEscolha;
        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.Panel panel1;
    }
}