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
            this.textBox_path = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBox_sheet = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSelecionarArquivo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCarregarExcel = new MaterialSkin.Controls.MaterialRaisedButton();
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
            // textBox_path
            // 
            this.textBox_path.Depth = 0;
            this.textBox_path.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_path.Hint = "...";
            this.textBox_path.Location = new System.Drawing.Point(127, 101);
            this.textBox_path.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBox_path.Name = "textBox_path";
            this.textBox_path.PasswordChar = '\0';
            this.textBox_path.SelectedText = "";
            this.textBox_path.SelectionLength = 0;
            this.textBox_path.SelectionStart = 0;
            this.textBox_path.Size = new System.Drawing.Size(314, 23);
            this.textBox_path.TabIndex = 4;
            this.textBox_path.UseSystemPasswordChar = false;
            this.textBox_path.Click += new System.EventHandler(this.textBox_path_Click);
            // 
            // textBox_sheet
            // 
            this.textBox_sheet.Depth = 0;
            this.textBox_sheet.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_sheet.Hint = "Nome do arquivo";
            this.textBox_sheet.Location = new System.Drawing.Point(127, 152);
            this.textBox_sheet.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBox_sheet.Name = "textBox_sheet";
            this.textBox_sheet.PasswordChar = '\0';
            this.textBox_sheet.SelectedText = "";
            this.textBox_sheet.SelectionLength = 0;
            this.textBox_sheet.SelectionStart = 0;
            this.textBox_sheet.Size = new System.Drawing.Size(314, 23);
            this.textBox_sheet.TabIndex = 5;
            this.textBox_sheet.UseSystemPasswordChar = false;
            // 
            // btnSelecionarArquivo
            // 
            this.btnSelecionarArquivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelecionarArquivo.Depth = 0;
            this.btnSelecionarArquivo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarArquivo.Location = new System.Drawing.Point(3, 101);
            this.btnSelecionarArquivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSelecionarArquivo.Name = "btnSelecionarArquivo";
            this.btnSelecionarArquivo.Primary = true;
            this.btnSelecionarArquivo.Size = new System.Drawing.Size(98, 23);
            this.btnSelecionarArquivo.TabIndex = 6;
            this.btnSelecionarArquivo.Text = "Arquivo";
            this.btnSelecionarArquivo.UseVisualStyleBackColor = true;
            this.btnSelecionarArquivo.Click += new System.EventHandler(this.btnSelecionarArquivo_Click);
            // 
            // btnCarregarExcel
            // 
            this.btnCarregarExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCarregarExcel.Depth = 0;
            this.btnCarregarExcel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregarExcel.Location = new System.Drawing.Point(3, 144);
            this.btnCarregarExcel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCarregarExcel.Name = "btnCarregarExcel";
            this.btnCarregarExcel.Primary = true;
            this.btnCarregarExcel.Size = new System.Drawing.Size(98, 36);
            this.btnCarregarExcel.TabIndex = 7;
            this.btnCarregarExcel.Text = "Carregar Excel";
            this.btnCarregarExcel.UseVisualStyleBackColor = true;
            this.btnCarregarExcel.Click += new System.EventHandler(this.btnCarregarExcel_Click);
            // 
            // userImportarDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCarregarExcel);
            this.Controls.Add(this.btnSelecionarArquivo);
            this.Controls.Add(this.textBox_sheet);
            this.Controls.Add(this.textBox_path);
            this.Controls.Add(this.dgvExcel);
            this.Name = "userImportarDados";
            this.Size = new System.Drawing.Size(549, 490);
            this.Load += new System.EventHandler(this.userImportarDados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvExcel;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBox_path;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBox_sheet;
        private MaterialSkin.Controls.MaterialRaisedButton btnSelecionarArquivo;
        private MaterialSkin.Controls.MaterialRaisedButton btnCarregarExcel;
    }
}
