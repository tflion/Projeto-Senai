namespace ProjetoSenai
{
    partial class userAlocarAlunos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userAlocarAlunos));
            this.dgvAluno = new System.Windows.Forms.DataGridView();
            this.dgvEmpresa = new System.Windows.Forms.DataGridView();
            this.lblNomeAluno = new System.Windows.Forms.Label();
            this.lblCpfAluno = new System.Windows.Forms.Label();
            this.lblNomeEmpresa = new System.Windows.Forms.Label();
            this.txtNomeEmpresa = new System.Windows.Forms.TextBox();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.txtCpfAluno = new System.Windows.Forms.TextBox();
            this.txtBuscarEmpresa = new System.Windows.Forms.TextBox();
            this.lblBuscarEmpresa = new System.Windows.Forms.Label();
            this.lblBuscarAluno = new System.Windows.Forms.Label();
            this.txtBuscarAluno = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEmpresa = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.lblIdade = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAluno
            // 
            this.dgvAluno.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAluno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAluno.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAluno.DefaultCellStyle = dataGridViewCellStyle26;
            this.dgvAluno.EnableHeadersVisualStyles = false;
            this.dgvAluno.Location = new System.Drawing.Point(13, 301);
            this.dgvAluno.Name = "dgvAluno";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAluno.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.White;
            this.dgvAluno.RowsDefaultCellStyle = dataGridViewCellStyle28;
            this.dgvAluno.Size = new System.Drawing.Size(231, 165);
            this.dgvAluno.TabIndex = 32;
            this.dgvAluno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAluno_CellContentClick);
            // 
            // dgvEmpresa
            // 
            this.dgvEmpresa.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpresa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dgvEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmpresa.DefaultCellStyle = dataGridViewCellStyle30;
            this.dgvEmpresa.EnableHeadersVisualStyles = false;
            this.dgvEmpresa.Location = new System.Drawing.Point(298, 301);
            this.dgvEmpresa.Name = "dgvEmpresa";
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpresa.RowHeadersDefaultCellStyle = dataGridViewCellStyle31;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.White;
            this.dgvEmpresa.RowsDefaultCellStyle = dataGridViewCellStyle32;
            this.dgvEmpresa.Size = new System.Drawing.Size(231, 165);
            this.dgvEmpresa.TabIndex = 33;
            this.dgvEmpresa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpresa_CellContentClick);
            // 
            // lblNomeAluno
            // 
            this.lblNomeAluno.AutoSize = true;
            this.lblNomeAluno.Location = new System.Drawing.Point(26, 18);
            this.lblNomeAluno.Name = "lblNomeAluno";
            this.lblNomeAluno.Size = new System.Drawing.Size(82, 13);
            this.lblNomeAluno.TabIndex = 34;
            this.lblNomeAluno.Text = "Nome do aluno:";
            // 
            // lblCpfAluno
            // 
            this.lblCpfAluno.AutoSize = true;
            this.lblCpfAluno.Location = new System.Drawing.Point(38, 44);
            this.lblCpfAluno.Name = "lblCpfAluno";
            this.lblCpfAluno.Size = new System.Drawing.Size(70, 13);
            this.lblCpfAluno.TabIndex = 35;
            this.lblCpfAluno.Text = "Cpf do aluno:";
            // 
            // lblNomeEmpresa
            // 
            this.lblNomeEmpresa.AutoSize = true;
            this.lblNomeEmpresa.Location = new System.Drawing.Point(10, 106);
            this.lblNomeEmpresa.Name = "lblNomeEmpresa";
            this.lblNomeEmpresa.Size = new System.Drawing.Size(96, 13);
            this.lblNomeEmpresa.TabIndex = 36;
            this.lblNomeEmpresa.Text = "Nome da empresa:";
            // 
            // txtNomeEmpresa
            // 
            this.txtNomeEmpresa.Location = new System.Drawing.Point(112, 103);
            this.txtNomeEmpresa.Name = "txtNomeEmpresa";
            this.txtNomeEmpresa.Size = new System.Drawing.Size(257, 20);
            this.txtNomeEmpresa.TabIndex = 37;
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Location = new System.Drawing.Point(111, 15);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(257, 20);
            this.txtNomeAluno.TabIndex = 38;
            // 
            // txtCpfAluno
            // 
            this.txtCpfAluno.Location = new System.Drawing.Point(112, 41);
            this.txtCpfAluno.Name = "txtCpfAluno";
            this.txtCpfAluno.Size = new System.Drawing.Size(100, 20);
            this.txtCpfAluno.TabIndex = 39;
            // 
            // txtBuscarEmpresa
            // 
            this.txtBuscarEmpresa.Location = new System.Drawing.Point(365, 274);
            this.txtBuscarEmpresa.Name = "txtBuscarEmpresa";
            this.txtBuscarEmpresa.Size = new System.Drawing.Size(109, 20);
            this.txtBuscarEmpresa.TabIndex = 41;
            this.txtBuscarEmpresa.TextChanged += new System.EventHandler(this.txtBuscarEmpresa_TextChanged);
            // 
            // lblBuscarEmpresa
            // 
            this.lblBuscarEmpresa.AutoSize = true;
            this.lblBuscarEmpresa.Location = new System.Drawing.Point(275, 277);
            this.lblBuscarEmpresa.Name = "lblBuscarEmpresa";
            this.lblBuscarEmpresa.Size = new System.Drawing.Size(84, 13);
            this.lblBuscarEmpresa.TabIndex = 42;
            this.lblBuscarEmpresa.Text = "Buscar Empresa";
            this.lblBuscarEmpresa.Click += new System.EventHandler(this.lblBuscarEmpresa_Click);
            // 
            // lblBuscarAluno
            // 
            this.lblBuscarAluno.AutoSize = true;
            this.lblBuscarAluno.Location = new System.Drawing.Point(16, 278);
            this.lblBuscarAluno.Name = "lblBuscarAluno";
            this.lblBuscarAluno.Size = new System.Drawing.Size(70, 13);
            this.lblBuscarAluno.TabIndex = 44;
            this.lblBuscarAluno.Text = "Buscar Aluno";
            // 
            // txtBuscarAluno
            // 
            this.txtBuscarAluno.Location = new System.Drawing.Point(92, 274);
            this.txtBuscarAluno.Name = "txtBuscarAluno";
            this.txtBuscarAluno.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarAluno.TabIndex = 43;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.Depth = 0;
            this.btnAdicionar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(170, 192);
            this.btnAdicionar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Primary = true;
            this.btnAdicionar.Size = new System.Drawing.Size(186, 41);
            this.btnAdicionar.TabIndex = 45;
            this.btnAdicionar.Text = "Alocar Aluno a empresa";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FlatAppearance.BorderSize = 0;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.Location = new System.Drawing.Point(247, 424);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(45, 42);
            this.btnAtualizar.TabIndex = 46;
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Depth = 0;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(198, 278);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Primary = true;
            this.btnBuscar.Size = new System.Drawing.Size(66, 17);
            this.btnBuscar.TabIndex = 47;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEmpresa
            // 
            this.btnEmpresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpresa.Depth = 0;
            this.btnEmpresa.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpresa.Location = new System.Drawing.Point(480, 277);
            this.btnEmpresa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Primary = true;
            this.btnEmpresa.Size = new System.Drawing.Size(66, 17);
            this.btnEmpresa.TabIndex = 48;
            this.btnEmpresa.Text = "Buscar";
            this.btnEmpresa.UseVisualStyleBackColor = true;
            this.btnEmpresa.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(112, 129);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(100, 20);
            this.txtCnpj.TabIndex = 50;
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Location = new System.Drawing.Point(17, 132);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(89, 13);
            this.lblCnpj.TabIndex = 49;
            this.lblCnpj.Text = "Cnpj da empresa:";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(112, 67);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(100, 20);
            this.txtIdade.TabIndex = 52;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(27, 70);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(81, 13);
            this.lblIdade.TabIndex = 51;
            this.lblIdade.Text = "Idade do aluno:";
            this.lblIdade.Click += new System.EventHandler(this.LblIdade_Click);
            // 
            // userAlocarAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.txtCnpj);
            this.Controls.Add(this.lblCnpj);
            this.Controls.Add(this.btnEmpresa);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.lblBuscarAluno);
            this.Controls.Add(this.txtBuscarAluno);
            this.Controls.Add(this.lblBuscarEmpresa);
            this.Controls.Add(this.txtBuscarEmpresa);
            this.Controls.Add(this.txtCpfAluno);
            this.Controls.Add(this.txtNomeAluno);
            this.Controls.Add(this.txtNomeEmpresa);
            this.Controls.Add(this.lblNomeEmpresa);
            this.Controls.Add(this.lblCpfAluno);
            this.Controls.Add(this.lblNomeAluno);
            this.Controls.Add(this.dgvEmpresa);
            this.Controls.Add(this.dgvAluno);
            this.Name = "userAlocarAlunos";
            this.Size = new System.Drawing.Size(549, 490);
            this.Load += new System.EventHandler(this.userAlocarAlunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAluno;
        private System.Windows.Forms.DataGridView dgvEmpresa;
        private System.Windows.Forms.Label lblNomeAluno;
        private System.Windows.Forms.Label lblCpfAluno;
        private System.Windows.Forms.Label lblNomeEmpresa;
        private System.Windows.Forms.TextBox txtNomeEmpresa;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.TextBox txtCpfAluno;
        private System.Windows.Forms.TextBox txtBuscarEmpresa;
        private System.Windows.Forms.Label lblBuscarEmpresa;
        private System.Windows.Forms.Label lblBuscarAluno;
        private System.Windows.Forms.TextBox txtBuscarAluno;
        private MaterialSkin.Controls.MaterialRaisedButton btnAdicionar;
        private System.Windows.Forms.Button btnAtualizar;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscar;
        private MaterialSkin.Controls.MaterialRaisedButton btnEmpresa;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label lblIdade;
    }
}
