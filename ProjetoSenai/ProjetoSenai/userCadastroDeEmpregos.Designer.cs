namespace ProjetoSenai
{
    partial class userCadastroDeEmpregos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userCadastroDeEmpregos));
            this.dgvEmpresa = new System.Windows.Forms.DataGridView();
            this.dgvSolicitarEmprego = new System.Windows.Forms.DataGridView();
            this.lblNomeEmpresa = new System.Windows.Forms.Label();
            this.txtNomeEmpresa = new System.Windows.Forms.TextBox();
            this.lblTipoContrato = new System.Windows.Forms.Label();
            this.cboTipoContrato = new System.Windows.Forms.ComboBox();
            this.btnCadastrarContrato = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEditarContrato = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnBuscaEmpresa = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblBuscarEmpresa = new System.Windows.Forms.Label();
            this.txtBuscarEmpresa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitarEmprego)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmpresa
            // 
            this.dgvEmpresa.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpresa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmpresa.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmpresa.EnableHeadersVisualStyles = false;
            this.dgvEmpresa.Location = new System.Drawing.Point(3, 324);
            this.dgvEmpresa.Name = "dgvEmpresa";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpresa.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvEmpresa.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEmpresa.Size = new System.Drawing.Size(227, 163);
            this.dgvEmpresa.TabIndex = 32;
            this.dgvEmpresa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpresa_CellContentClick);
            this.dgvEmpresa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpresa_CellContentClick);
            // 
            // dgvSolicitarEmprego
            // 
            this.dgvSolicitarEmprego.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSolicitarEmprego.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSolicitarEmprego.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSolicitarEmprego.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSolicitarEmprego.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSolicitarEmprego.EnableHeadersVisualStyles = false;
            this.dgvSolicitarEmprego.Location = new System.Drawing.Point(287, 324);
            this.dgvSolicitarEmprego.Name = "dgvSolicitarEmprego";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSolicitarEmprego.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            this.dgvSolicitarEmprego.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvSolicitarEmprego.Size = new System.Drawing.Size(259, 163);
            this.dgvSolicitarEmprego.TabIndex = 33;
            this.dgvSolicitarEmprego.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSolicitarEmprego_CellContentClick);
            this.dgvSolicitarEmprego.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSolicitarEmprego_CellContentClick);
            // 
            // lblNomeEmpresa
            // 
            this.lblNomeEmpresa.AutoSize = true;
            this.lblNomeEmpresa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEmpresa.Location = new System.Drawing.Point(7, 46);
            this.lblNomeEmpresa.Name = "lblNomeEmpresa";
            this.lblNomeEmpresa.Size = new System.Drawing.Size(134, 17);
            this.lblNomeEmpresa.TabIndex = 46;
            this.lblNomeEmpresa.Text = "Nome da empresa:";
            // 
            // txtNomeEmpresa
            // 
            this.txtNomeEmpresa.Location = new System.Drawing.Point(147, 45);
            this.txtNomeEmpresa.Name = "txtNomeEmpresa";
            this.txtNomeEmpresa.Size = new System.Drawing.Size(152, 20);
            this.txtNomeEmpresa.TabIndex = 43;
            // 
            // lblTipoContrato
            // 
            this.lblTipoContrato.AutoSize = true;
            this.lblTipoContrato.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoContrato.Location = new System.Drawing.Point(21, 72);
            this.lblTipoContrato.Name = "lblTipoContrato";
            this.lblTipoContrato.Size = new System.Drawing.Size(120, 17);
            this.lblTipoContrato.TabIndex = 48;
            this.lblTipoContrato.Text = "Tipo de contrato:";
            // 
            // cboTipoContrato
            // 
            this.cboTipoContrato.FormattingEnabled = true;
            this.cboTipoContrato.Items.AddRange(new object[] {
            "Fase escolar",
            "Prática sequêncial",
            "Concomitante",
            "Sequêncial",
            "Dual"});
            this.cboTipoContrato.Location = new System.Drawing.Point(147, 71);
            this.cboTipoContrato.Name = "cboTipoContrato";
            this.cboTipoContrato.Size = new System.Drawing.Size(152, 21);
            this.cboTipoContrato.TabIndex = 49;
            // 
            // btnCadastrarContrato
            // 
            this.btnCadastrarContrato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarContrato.Depth = 0;
            this.btnCadastrarContrato.Location = new System.Drawing.Point(3, 181);
            this.btnCadastrarContrato.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCadastrarContrato.Name = "btnCadastrarContrato";
            this.btnCadastrarContrato.Primary = true;
            this.btnCadastrarContrato.Size = new System.Drawing.Size(159, 43);
            this.btnCadastrarContrato.TabIndex = 50;
            this.btnCadastrarContrato.Text = "Solicitar contrato";
            this.btnCadastrarContrato.UseVisualStyleBackColor = true;
            this.btnCadastrarContrato.Click += new System.EventHandler(this.btnCadastrarContrato_Click);
            // 
            // btnEditarContrato
            // 
            this.btnEditarContrato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarContrato.Depth = 0;
            this.btnEditarContrato.Location = new System.Drawing.Point(202, 181);
            this.btnEditarContrato.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditarContrato.Name = "btnEditarContrato";
            this.btnEditarContrato.Primary = true;
            this.btnEditarContrato.Size = new System.Drawing.Size(159, 43);
            this.btnEditarContrato.TabIndex = 51;
            this.btnEditarContrato.Text = "Editar contrato";
            this.btnEditarContrato.UseVisualStyleBackColor = true;
            this.btnEditarContrato.Click += new System.EventHandler(this.btnEditarContrato_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FlatAppearance.BorderSize = 0;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.Location = new System.Drawing.Point(236, 445);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(45, 42);
            this.btnAtualizar.TabIndex = 53;
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnBuscaEmpresa
            // 
            this.btnBuscaEmpresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscaEmpresa.Depth = 0;
            this.btnBuscaEmpresa.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaEmpresa.Location = new System.Drawing.Point(212, 300);
            this.btnBuscaEmpresa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscaEmpresa.Name = "btnBuscaEmpresa";
            this.btnBuscaEmpresa.Primary = true;
            this.btnBuscaEmpresa.Size = new System.Drawing.Size(66, 17);
            this.btnBuscaEmpresa.TabIndex = 56;
            this.btnBuscaEmpresa.Text = "Buscar";
            this.btnBuscaEmpresa.UseVisualStyleBackColor = true;
            // 
            // lblBuscarEmpresa
            // 
            this.lblBuscarEmpresa.AutoSize = true;
            this.lblBuscarEmpresa.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarEmpresa.Location = new System.Drawing.Point(2, 300);
            this.lblBuscarEmpresa.Name = "lblBuscarEmpresa";
            this.lblBuscarEmpresa.Size = new System.Drawing.Size(95, 16);
            this.lblBuscarEmpresa.TabIndex = 55;
            this.lblBuscarEmpresa.Text = "Buscar Empresa:";
            // 
            // txtBuscarEmpresa
            // 
            this.txtBuscarEmpresa.Location = new System.Drawing.Point(97, 298);
            this.txtBuscarEmpresa.Name = "txtBuscarEmpresa";
            this.txtBuscarEmpresa.Size = new System.Drawing.Size(109, 20);
            this.txtBuscarEmpresa.TabIndex = 54;
            // 
            // userCadastroDeEmpregos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBuscaEmpresa);
            this.Controls.Add(this.lblBuscarEmpresa);
            this.Controls.Add(this.txtBuscarEmpresa);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnEditarContrato);
            this.Controls.Add(this.btnCadastrarContrato);
            this.Controls.Add(this.cboTipoContrato);
            this.Controls.Add(this.lblTipoContrato);
            this.Controls.Add(this.lblNomeEmpresa);
            this.Controls.Add(this.txtNomeEmpresa);
            this.Controls.Add(this.dgvSolicitarEmprego);
            this.Controls.Add(this.dgvEmpresa);
            this.Name = "userCadastroDeEmpregos";
            this.Size = new System.Drawing.Size(549, 490);
            this.Load += new System.EventHandler(this.userCadastroDeEmpregos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitarEmprego)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpresa;
        private System.Windows.Forms.DataGridView dgvSolicitarEmprego;
        private System.Windows.Forms.Label lblNomeEmpresa;
        private System.Windows.Forms.TextBox txtNomeEmpresa;
        private System.Windows.Forms.Label lblTipoContrato;
        private System.Windows.Forms.ComboBox cboTipoContrato;
        private MaterialSkin.Controls.MaterialRaisedButton btnCadastrarContrato;
        private MaterialSkin.Controls.MaterialRaisedButton btnEditarContrato;
        private System.Windows.Forms.Button btnAtualizar;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscaEmpresa;
        private System.Windows.Forms.Label lblBuscarEmpresa;
        private System.Windows.Forms.TextBox txtBuscarEmpresa;
    }
}
