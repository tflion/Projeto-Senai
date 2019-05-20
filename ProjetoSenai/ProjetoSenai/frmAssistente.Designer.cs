namespace ProjetoSenai
{
    partial class frmAssistente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAssistente));
            this.pnlDireito = new System.Windows.Forms.Panel();
            this.pnlIndicador = new System.Windows.Forms.Panel();
            this.btnVisualizarAlunos = new System.Windows.Forms.Button();
            this.userPrincipal1 = new ProjetoSenai.userPrincipal();
            this.pnlDireito.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDireito
            // 
            this.pnlDireito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            this.pnlDireito.Controls.Add(this.pnlIndicador);
            this.pnlDireito.Controls.Add(this.btnVisualizarAlunos);
            this.pnlDireito.Location = new System.Drawing.Point(0, 64);
            this.pnlDireito.Name = "pnlDireito";
            this.pnlDireito.Size = new System.Drawing.Size(186, 502);
            this.pnlDireito.TabIndex = 1;
            // 
            // pnlIndicador
            // 
            this.pnlIndicador.BackColor = System.Drawing.Color.White;
            this.pnlIndicador.Location = new System.Drawing.Point(0, 191);
            this.pnlIndicador.Name = "pnlIndicador";
            this.pnlIndicador.Size = new System.Drawing.Size(10, 75);
            this.pnlIndicador.TabIndex = 15;
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
            this.btnVisualizarAlunos.Location = new System.Drawing.Point(8, 191);
            this.btnVisualizarAlunos.Name = "btnVisualizarAlunos";
            this.btnVisualizarAlunos.Size = new System.Drawing.Size(172, 75);
            this.btnVisualizarAlunos.TabIndex = 7;
            this.btnVisualizarAlunos.Text = "VISUALIZAR ALUNOS E EMPRESAS";
            this.btnVisualizarAlunos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVisualizarAlunos.UseVisualStyleBackColor = false;
            this.btnVisualizarAlunos.Click += new System.EventHandler(this.BtnVisualizarAlunos_Click);
            // 
            // userPrincipal1
            // 
            this.userPrincipal1.BackColor = System.Drawing.Color.White;
            this.userPrincipal1.Location = new System.Drawing.Point(180, 64);
            this.userPrincipal1.Name = "userPrincipal1";
            this.userPrincipal1.Size = new System.Drawing.Size(553, 490);
            this.userPrincipal1.TabIndex = 2;
            // 
            // frmAssistente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 554);
            this.Controls.Add(this.userPrincipal1);
            this.Controls.Add(this.pnlDireito);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(733, 554);
            this.Name = "frmAssistente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SENAI - Serviço Nacional de Aprendizagem Industrial";
            this.pnlDireito.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDireito;
        private System.Windows.Forms.Panel pnlIndicador;
        private System.Windows.Forms.Button btnVisualizarAlunos;
        private userPrincipal userPrincipal1;
    }
}