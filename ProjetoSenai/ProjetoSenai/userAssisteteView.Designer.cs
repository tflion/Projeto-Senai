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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnVerAlunos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnVerEmpresa = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dgvVisualizar = new System.Windows.Forms.DataGridView();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVerAlunos
            // 
            this.btnVerAlunos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerAlunos.Depth = 0;
            this.btnVerAlunos.Location = new System.Drawing.Point(27, 431);
            this.btnVerAlunos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVerAlunos.Name = "btnVerAlunos";
            this.btnVerAlunos.Primary = true;
            this.btnVerAlunos.Size = new System.Drawing.Size(141, 43);
            this.btnVerAlunos.TabIndex = 12;
            this.btnVerAlunos.Text = "Visualizar Alunos";
            this.btnVerAlunos.UseVisualStyleBackColor = true;
            this.btnVerAlunos.Click += new System.EventHandler(this.btnVerAlunos_Click);
            // 
            // btnVerEmpresa
            // 
            this.btnVerEmpresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerEmpresa.Depth = 0;
            this.btnVerEmpresa.Location = new System.Drawing.Point(203, 431);
            this.btnVerEmpresa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVerEmpresa.Name = "btnVerEmpresa";
            this.btnVerEmpresa.Primary = true;
            this.btnVerEmpresa.Size = new System.Drawing.Size(141, 43);
            this.btnVerEmpresa.TabIndex = 13;
            this.btnVerEmpresa.Text = "Visualizar Empresas";
            this.btnVerEmpresa.UseVisualStyleBackColor = true;
            this.btnVerEmpresa.Click += new System.EventHandler(this.btnVerEmpresa_Click);
            // 
            // dgvVisualizar
            // 
            this.dgvVisualizar.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvVisualizar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVisualizar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvVisualizar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(62)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVisualizar.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvVisualizar.EnableHeadersVisualStyles = false;
            this.dgvVisualizar.Location = new System.Drawing.Point(38, 15);
            this.dgvVisualizar.Name = "dgvVisualizar";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVisualizar.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            this.dgvVisualizar.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvVisualizar.Size = new System.Drawing.Size(472, 358);
            this.dgvVisualizar.TabIndex = 32;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(379, 431);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(141, 43);
            this.materialRaisedButton1.TabIndex = 33;
            this.materialRaisedButton1.Text = "Visualizar Aluno na empresa";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // userAssisteteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.dgvVisualizar);
            this.Controls.Add(this.btnVerEmpresa);
            this.Controls.Add(this.btnVerAlunos);
            this.Name = "userAssisteteView";
            this.Size = new System.Drawing.Size(549, 490);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton btnVerAlunos;
        private MaterialSkin.Controls.MaterialRaisedButton btnVerEmpresa;
        private System.Windows.Forms.DataGridView dgvVisualizar;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
    }
}
