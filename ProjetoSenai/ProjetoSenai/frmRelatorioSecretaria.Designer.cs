namespace ProjetoSenai
{
    partial class frmRelatorioSecretaria
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorioSecretaria));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.EmpresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetSecretaria = new ProjetoSenai.DataSetSecretaria();
            this.AlunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnVoltarLogin = new System.Windows.Forms.Button();
            this.EmpresaTableAdapter = new ProjetoSenai.DataSetSecretariaTableAdapters.EmpresaTableAdapter();
            this.AlunoTableAdapter = new ProjetoSenai.DataSetSecretariaTableAdapters.AlunoTableAdapter();
            this.DataSetEmprego = new ProjetoSenai.DataSetEmprego();
            this.EmpregoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EmpregoTableAdapter = new ProjetoSenai.DataSetEmpregoTableAdapters.EmpregoTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.EmpresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetSecretaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlunoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetEmprego)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpregoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // EmpresaBindingSource
            // 
            this.EmpresaBindingSource.DataMember = "Empresa";
            this.EmpresaBindingSource.DataSource = this.DataSetSecretaria;
            // 
            // DataSetSecretaria
            // 
            this.DataSetSecretaria.DataSetName = "DataSetSecretaria";
            this.DataSetSecretaria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AlunoBindingSource
            // 
            this.AlunoBindingSource.DataMember = "Aluno";
            this.AlunoBindingSource.DataSource = this.DataSetSecretaria;
            // 
            // btnVoltarLogin
            // 
            this.btnVoltarLogin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVoltarLogin.FlatAppearance.BorderSize = 0;
            this.btnVoltarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltarLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltarLogin.Image")));
            this.btnVoltarLogin.Location = new System.Drawing.Point(1, 65);
            this.btnVoltarLogin.Name = "btnVoltarLogin";
            this.btnVoltarLogin.Size = new System.Drawing.Size(63, 33);
            this.btnVoltarLogin.TabIndex = 24;
            this.btnVoltarLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltarLogin.UseVisualStyleBackColor = false;
            this.btnVoltarLogin.Click += new System.EventHandler(this.btnVoltarLogin_Click);
            // 
            // EmpresaTableAdapter
            // 
            this.EmpresaTableAdapter.ClearBeforeFill = true;
            // 
            // AlunoTableAdapter
            // 
            this.AlunoTableAdapter.ClearBeforeFill = true;
            // 
            // DataSetEmprego
            // 
            this.DataSetEmprego.DataSetName = "DataSetEmprego";
            this.DataSetEmprego.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EmpregoBindingSource
            // 
            this.EmpregoBindingSource.DataMember = "Emprego";
            this.EmpregoBindingSource.DataSource = this.DataSetEmprego;
            // 
            // EmpregoTableAdapter
            // 
            this.EmpregoTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetEmpresa";
            reportDataSource1.Value = this.EmpresaBindingSource;
            reportDataSource2.Name = "DataSetAluno";
            reportDataSource2.Value = this.AlunoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProjetoSenai.rptSecretaria.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 104);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(745, 286);
            this.reportViewer1.TabIndex = 25;
            // 
            // frmRelatorioSecretaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 391);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnVoltarLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(745, 391);
            this.MinimumSize = new System.Drawing.Size(745, 391);
            this.Name = "frmRelatorioSecretaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SENAI - Serviço Nacional de Aprendizagem Industrial";
            this.Load += new System.EventHandler(this.frmRelatorioSecretaria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmpresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetSecretaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlunoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetEmprego)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpregoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoltarLogin;
        private System.Windows.Forms.BindingSource EmpresaBindingSource;
        private DataSetSecretaria DataSetSecretaria;
        private System.Windows.Forms.BindingSource AlunoBindingSource;
        private DataSetSecretariaTableAdapters.EmpresaTableAdapter EmpresaTableAdapter;
        private DataSetSecretariaTableAdapters.AlunoTableAdapter AlunoTableAdapter;
        private System.Windows.Forms.BindingSource EmpregoBindingSource;
        private DataSetEmprego DataSetEmprego;
        private DataSetEmpregoTableAdapters.EmpregoTableAdapter EmpregoTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}