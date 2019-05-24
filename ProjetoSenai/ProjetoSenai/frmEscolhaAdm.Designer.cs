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
            this.btnAdministrar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnVisualizarRelatorio = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblEscolha = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnAdministrar
            // 
            this.btnAdministrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdministrar.Depth = 0;
            this.btnAdministrar.Location = new System.Drawing.Point(12, 317);
            this.btnAdministrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdministrar.Name = "btnAdministrar";
            this.btnAdministrar.Primary = true;
            this.btnAdministrar.Size = new System.Drawing.Size(186, 80);
            this.btnAdministrar.TabIndex = 52;
            this.btnAdministrar.Text = "Administrar";
            this.btnAdministrar.UseVisualStyleBackColor = true;
            this.btnAdministrar.Click += new System.EventHandler(this.btnAdministrar_Click);
            // 
            // btnVisualizarRelatorio
            // 
            this.btnVisualizarRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVisualizarRelatorio.Depth = 0;
            this.btnVisualizarRelatorio.Location = new System.Drawing.Point(267, 317);
            this.btnVisualizarRelatorio.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVisualizarRelatorio.Name = "btnVisualizarRelatorio";
            this.btnVisualizarRelatorio.Primary = true;
            this.btnVisualizarRelatorio.Size = new System.Drawing.Size(186, 80);
            this.btnVisualizarRelatorio.TabIndex = 53;
            this.btnVisualizarRelatorio.Text = "Visualizar relatórios";
            this.btnVisualizarRelatorio.UseVisualStyleBackColor = true;
            this.btnVisualizarRelatorio.Click += new System.EventHandler(this.btnVisualizarRelatorio_Click);
            // 
            // lblEscolha
            // 
            this.lblEscolha.AutoSize = true;
            this.lblEscolha.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscolha.Location = new System.Drawing.Point(148, 201);
            this.lblEscolha.Name = "lblEscolha";
            this.lblEscolha.Size = new System.Drawing.Size(158, 44);
            this.lblEscolha.TabIndex = 55;
            this.lblEscolha.Text = "Escolha";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(113, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 163);
            this.panel1.TabIndex = 54;
            // 
            // frmEscolhaAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 527);
            this.Controls.Add(this.lblEscolha);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVisualizarRelatorio);
            this.Controls.Add(this.btnAdministrar);
            this.Name = "frmEscolhaAdm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SENAI - Serviço Nacional de Aprendizagem Industrial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnAdministrar;
        private MaterialSkin.Controls.MaterialRaisedButton btnVisualizarRelatorio;
        private System.Windows.Forms.Label lblEscolha;
        private System.Windows.Forms.Panel panel1;
    }
}