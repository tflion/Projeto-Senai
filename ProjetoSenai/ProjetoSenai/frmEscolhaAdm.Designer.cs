namespace ProjetoSenai
{
    partial class frmEscolhaAdm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEscolhaAdm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdministrar = new System.Windows.Forms.Button();
            this.btnViewRelato = new System.Windows.Forms.Button();
            this.lblEscolha = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblEscolha);
            this.panel1.Location = new System.Drawing.Point(151, 62);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 201);
            this.panel1.TabIndex = 54;
            // 
            // btnAdministrar
            // 
            this.btnAdministrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            this.btnAdministrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdministrar.FlatAppearance.BorderSize = 0;
            this.btnAdministrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministrar.ForeColor = System.Drawing.Color.White;
            this.btnAdministrar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdministrar.Image")));
            this.btnAdministrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdministrar.Location = new System.Drawing.Point(37, 306);
            this.btnAdministrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdministrar.Name = "btnAdministrar";
            this.btnAdministrar.Size = new System.Drawing.Size(229, 66);
            this.btnAdministrar.TabIndex = 56;
            this.btnAdministrar.Text = "ADMINISTRAR";
            this.btnAdministrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdministrar.UseVisualStyleBackColor = false;
            this.btnAdministrar.Click += new System.EventHandler(this.btnVisualizarAlunos_Click);
            // 
            // btnViewRelato
            // 
            this.btnViewRelato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            this.btnViewRelato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewRelato.FlatAppearance.BorderSize = 0;
            this.btnViewRelato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewRelato.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewRelato.ForeColor = System.Drawing.Color.White;
            this.btnViewRelato.Image = ((System.Drawing.Image)(resources.GetObject("btnViewRelato.Image")));
            this.btnViewRelato.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnViewRelato.Location = new System.Drawing.Point(358, 306);
            this.btnViewRelato.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewRelato.Name = "btnViewRelato";
            this.btnViewRelato.Size = new System.Drawing.Size(229, 66);
            this.btnViewRelato.TabIndex = 57;
            this.btnViewRelato.Text = "VISUALIZAR RELATÓRIOS";
            this.btnViewRelato.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnViewRelato.UseVisualStyleBackColor = false;
            this.btnViewRelato.Click += new System.EventHandler(this.btnViewRelato_Click);
            // 
            // lblEscolha
            // 
            this.lblEscolha.AutoSize = true;
            this.lblEscolha.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscolha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            this.lblEscolha.Location = new System.Drawing.Point(74, 154);
            this.lblEscolha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEscolha.Name = "lblEscolha";
            this.lblEscolha.Size = new System.Drawing.Size(171, 47);
            this.lblEscolha.TabIndex = 58;
            this.lblEscolha.Text = "Escolha";
            // 
            // frmEscolhaAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 403);
            this.Controls.Add(this.btnViewRelato);
            this.Controls.Add(this.btnAdministrar);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEscolhaAdm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SENAI - Serviço Nacional de Aprendizagem Industrial";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdministrar;
        private System.Windows.Forms.Button btnViewRelato;
        private System.Windows.Forms.Label lblEscolha;
    }
}