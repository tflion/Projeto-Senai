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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cboFolha = new System.Windows.Forms.ComboBox();
            this.lblFolha = new System.Windows.Forms.Label();
            this.dgvExcel = new System.Windows.Forms.DataGridView();
            this.btnAbrir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(265, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // cboFolha
            // 
            this.cboFolha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFolha.FormattingEnabled = true;
            this.cboFolha.Location = new System.Drawing.Point(265, 53);
            this.cboFolha.Name = "cboFolha";
            this.cboFolha.Size = new System.Drawing.Size(121, 21);
            this.cboFolha.TabIndex = 0;
            this.cboFolha.SelectedIndexChanged += new System.EventHandler(this.CboFolha_SelectedIndexChanged);
            // 
            // lblFolha
            // 
            this.lblFolha.AutoSize = true;
            this.lblFolha.Location = new System.Drawing.Point(193, 56);
            this.lblFolha.Name = "lblFolha";
            this.lblFolha.Size = new System.Drawing.Size(36, 13);
            this.lblFolha.TabIndex = 1;
            this.lblFolha.Text = "Folha:";
            // 
            // dgvExcel
            // 
            this.dgvExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExcel.Location = new System.Drawing.Point(3, 186);
            this.dgvExcel.Name = "dgvExcel";
            this.dgvExcel.Size = new System.Drawing.Size(543, 246);
            this.dgvExcel.TabIndex = 2;
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(445, 438);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(101, 37);
            this.btnAbrir.TabIndex = 3;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.BtnAbrir_Click);
            // 
            // userImportarDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.dgvExcel);
            this.Controls.Add(this.lblFolha);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cboFolha);
            this.Name = "userImportarDados";
            this.Size = new System.Drawing.Size(549, 490);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cboFolha;
        private System.Windows.Forms.Label lblFolha;
        private System.Windows.Forms.DataGridView dgvExcel;
        private System.Windows.Forms.Button btnAbrir;
    }
}
