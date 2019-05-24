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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnRemoverContrato = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitarEmprego)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmpresa
            // 
            this.dgvEmpresa.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpresa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmpresa.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvEmpresa.EnableHeadersVisualStyles = false;
            this.dgvEmpresa.Location = new System.Drawing.Point(3, 324);
            this.dgvEmpresa.Name = "dgvEmpresa";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpresa.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            this.dgvEmpresa.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvEmpresa.Size = new System.Drawing.Size(227, 163);
            this.dgvEmpresa.TabIndex = 32;
            this.dgvEmpresa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpresa_CellContentClick);
            this.dgvEmpresa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpresa_CellContentClick);
            // 
            // dgvSolicitarEmprego
            // 
            this.dgvSolicitarEmprego.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSolicitarEmprego.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSolicitarEmprego.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvSolicitarEmprego.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSolicitarEmprego.DefaultCellStyle = dataGridViewCellStyle22;
            this.dgvSolicitarEmprego.EnableHeadersVisualStyles = false;
            this.dgvSolicitarEmprego.Location = new System.Drawing.Point(287, 324);
            this.dgvSolicitarEmprego.Name = "dgvSolicitarEmprego";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSolicitarEmprego.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            this.dgvSolicitarEmprego.RowsDefaultCellStyle = dataGridViewCellStyle24;
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
            this.btnEditarContrato.Location = new System.Drawing.Point(195, 181);
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
            // btnRemoverContrato
            // 
            this.btnRemoverContrato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoverContrato.Depth = 0;
            this.btnRemoverContrato.Location = new System.Drawing.Point(387, 181);
            this.btnRemoverContrato.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRemoverContrato.Name = "btnRemoverContrato";
            this.btnRemoverContrato.Primary = true;
            this.btnRemoverContrato.Size = new System.Drawing.Size(159, 43);
            this.btnRemoverContrato.TabIndex = 57;
            this.btnRemoverContrato.Text = "Remover contrato";
            this.btnRemoverContrato.UseVisualStyleBackColor = true;
            this.btnRemoverContrato.Click += new System.EventHandler(this.btnRemoverContrato_Click);
            // 
            // userCadastroDeEmpregos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRemoverContrato);
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
        private MaterialSkin.Controls.MaterialRaisedButton btnRemoverContrato;
    }
}
