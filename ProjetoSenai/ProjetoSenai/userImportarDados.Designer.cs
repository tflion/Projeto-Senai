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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSelecionarArquivo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new MaterialSkin.Controls.MaterialLabel();
            this.btnAdicionar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dgvExcel = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelecionarArquivo
            // 
            this.btnSelecionarArquivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelecionarArquivo.Depth = 0;
            this.btnSelecionarArquivo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarArquivo.Location = new System.Drawing.Point(23, 145);
            this.btnSelecionarArquivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelecionarArquivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSelecionarArquivo.Name = "btnSelecionarArquivo";
            this.btnSelecionarArquivo.Primary = true;
            this.btnSelecionarArquivo.Size = new System.Drawing.Size(131, 28);
            this.btnSelecionarArquivo.TabIndex = 6;
            this.btnSelecionarArquivo.Text = "Arquivo";
            this.btnSelecionarArquivo.UseVisualStyleBackColor = true;
            this.btnSelecionarArquivo.Click += new System.EventHandler(this.btnSelecionarArquivo_Click);
            // 
            // cboTipo
            // 
            this.cboTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipo.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(311, 145);
            this.cboTipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(160, 25);
            this.cboTipo.TabIndex = 7;
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.cboTipo_SelectedIndexChanged);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Depth = 0;
            this.lblTipo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTipo.Location = new System.Drawing.Point(229, 148);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(53, 24);
            this.lblTipo.TabIndex = 8;
            this.lblTipo.Text = "Tipo:";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.Depth = 0;
            this.btnAdicionar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(527, 539);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdicionar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Primary = true;
            this.btnAdicionar.Size = new System.Drawing.Size(201, 36);
            this.btnAdicionar.TabIndex = 9;
            this.btnAdicionar.Text = "Cadastrar Alunos";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // dgvExcel
            // 
            this.dgvExcel.BackgroundColor = System.Drawing.Color.White;
            this.dgvExcel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExcel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExcel.DefaultCellStyle = dataGridViewCellStyle26;
            this.dgvExcel.EnableHeadersVisualStyles = false;
            this.dgvExcel.Location = new System.Drawing.Point(4, 214);
            this.dgvExcel.Margin = new System.Windows.Forms.Padding(4);
            this.dgvExcel.Name = "dgvExcel";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExcel.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.White;
            this.dgvExcel.RowsDefaultCellStyle = dataGridViewCellStyle28;
            this.dgvExcel.Size = new System.Drawing.Size(724, 303);
            this.dgvExcel.TabIndex = 33;
            // 
            // userImportarDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvExcel);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.btnSelecionarArquivo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "userImportarDados";
            this.Size = new System.Drawing.Size(732, 603);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton btnSelecionarArquivo;
        private System.Windows.Forms.ComboBox cboTipo;
        private MaterialSkin.Controls.MaterialLabel lblTipo;
        private MaterialSkin.Controls.MaterialRaisedButton btnAdicionar;
        private System.Windows.Forms.DataGridView dgvExcel;
    }
}
