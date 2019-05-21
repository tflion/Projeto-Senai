namespace ProjetoSenai
{
    partial class userImportarDados
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
            this.dgvExcel = new System.Windows.Forms.DataGridView();
            this.btnSelecionarArquivo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new MaterialSkin.Controls.MaterialLabel();
            this.btnAdicionar = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvExcel
            // 
            this.dgvExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExcel.Location = new System.Drawing.Point(3, 186);
            this.dgvExcel.Name = "dgvExcel";
            this.dgvExcel.Size = new System.Drawing.Size(543, 246);
            this.dgvExcel.TabIndex = 2;
            // 
            // btnSelecionarArquivo
            // 
            this.btnSelecionarArquivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelecionarArquivo.Depth = 0;
            this.btnSelecionarArquivo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarArquivo.Location = new System.Drawing.Point(17, 118);
            this.btnSelecionarArquivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSelecionarArquivo.Name = "btnSelecionarArquivo";
            this.btnSelecionarArquivo.Primary = true;
            this.btnSelecionarArquivo.Size = new System.Drawing.Size(98, 23);
            this.btnSelecionarArquivo.TabIndex = 6;
            this.btnSelecionarArquivo.Text = "Arquivo";
            this.btnSelecionarArquivo.UseVisualStyleBackColor = true;
            this.btnSelecionarArquivo.Click += new System.EventHandler(this.btnSelecionarArquivo_Click);
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(233, 118);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(121, 21);
            this.cboTipo.TabIndex = 7;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Depth = 0;
            this.lblTipo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTipo.Location = new System.Drawing.Point(172, 120);
            this.lblTipo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(43, 19);
            this.lblTipo.TabIndex = 8;
            this.lblTipo.Text = "Tipo:";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.Depth = 0;
            this.btnAdicionar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(395, 438);
            this.btnAdicionar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Primary = true;
            this.btnAdicionar.Size = new System.Drawing.Size(151, 29);
            this.btnAdicionar.TabIndex = 9;
            this.btnAdicionar.Text = "Cadastrar Alunos";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // userImportarDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.btnSelecionarArquivo);
            this.Controls.Add(this.dgvExcel);
            this.Name = "userImportarDados";
            this.Size = new System.Drawing.Size(549, 490);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvExcel;
        private MaterialSkin.Controls.MaterialRaisedButton btnSelecionarArquivo;
        private System.Windows.Forms.ComboBox cboTipo;
        private MaterialSkin.Controls.MaterialLabel lblTipo;
        private MaterialSkin.Controls.MaterialRaisedButton btnAdicionar;
    }
}
