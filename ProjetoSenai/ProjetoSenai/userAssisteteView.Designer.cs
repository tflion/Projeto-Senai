namespace ProjetoSenai
{
    partial class userAssisteteView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvVisualizar = new System.Windows.Forms.DataGridView();
            this.btnVerAlunos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnVerEmpresa = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVisualizar
            // 
            this.dgvVisualizar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisualizar.Location = new System.Drawing.Point(20, 19);
            this.dgvVisualizar.Name = "dgvVisualizar";
            this.dgvVisualizar.Size = new System.Drawing.Size(509, 370);
            this.dgvVisualizar.TabIndex = 0;
            // 
            // btnVerAlunos
            // 
            this.btnVerAlunos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerAlunos.Depth = 0;
            this.btnVerAlunos.Location = new System.Drawing.Point(102, 431);
            this.btnVerAlunos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVerAlunos.Name = "btnVerAlunos";
            this.btnVerAlunos.Primary = true;
            this.btnVerAlunos.Size = new System.Drawing.Size(141, 43);
            this.btnVerAlunos.TabIndex = 12;
            this.btnVerAlunos.Text = "Visualizar Alunos";
            this.btnVerAlunos.UseVisualStyleBackColor = true;
            // 
            // btnVerEmpresa
            // 
            this.btnVerEmpresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerEmpresa.Depth = 0;
            this.btnVerEmpresa.Location = new System.Drawing.Point(311, 431);
            this.btnVerEmpresa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVerEmpresa.Name = "btnVerEmpresa";
            this.btnVerEmpresa.Primary = true;
            this.btnVerEmpresa.Size = new System.Drawing.Size(141, 43);
            this.btnVerEmpresa.TabIndex = 13;
            this.btnVerEmpresa.Text = "Visualizar Empresas";
            this.btnVerEmpresa.UseVisualStyleBackColor = true;
            this.btnVerEmpresa.Click += new System.EventHandler(this.btnVerEmpresa_Click);
            // 
            // userAssisteteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnVerEmpresa);
            this.Controls.Add(this.btnVerAlunos);
            this.Controls.Add(this.dgvVisualizar);
            this.Name = "userAssisteteView";
            this.Size = new System.Drawing.Size(549, 490);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVisualizar;
        private MaterialSkin.Controls.MaterialRaisedButton btnVerAlunos;
        private MaterialSkin.Controls.MaterialRaisedButton btnVerEmpresa;
    }
}
