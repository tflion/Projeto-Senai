namespace ProjetoSenai
{
    partial class frmRelatorio
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorio));
            this.EmpregoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetEmprego = new ProjetoSenai.DataSetEmprego();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.EmpregoTableAdapter = new ProjetoSenai.DataSetEmpregoTableAdapters.EmpregoTableAdapter();
            this.btnVoltarLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EmpregoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetEmprego)).BeginInit();
            this.SuspendLayout();
            // 
            // EmpregoBindingSource
            // 
            this.EmpregoBindingSource.DataMember = "Emprego";
            this.EmpregoBindingSource.DataSource = this.DataSetEmprego;
            // 
            // DataSetEmprego
            // 
            this.DataSetEmprego.DataSetName = "DataSetEmprego";
            this.DataSetEmprego.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetEmprego";
            reportDataSource1.Value = this.EmpregoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProjetoSenai.rptEmprego.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 105);
            this.reportViewer1.MaximumSize = new System.Drawing.Size(745, 554);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(745, 287);
            this.reportViewer1.TabIndex = 0;
            // 
            // EmpregoTableAdapter
            // 
            this.EmpregoTableAdapter.ClearBeforeFill = true;
            // 
            // btnVoltarLogin
            // 
            this.btnVoltarLogin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVoltarLogin.FlatAppearance.BorderSize = 0;
            this.btnVoltarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltarLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltarLogin.Image")));
            this.btnVoltarLogin.Location = new System.Drawing.Point(-1, 66);
            this.btnVoltarLogin.Name = "btnVoltarLogin";
            this.btnVoltarLogin.Size = new System.Drawing.Size(63, 33);
            this.btnVoltarLogin.TabIndex = 22;
            this.btnVoltarLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltarLogin.UseVisualStyleBackColor = false;
            this.btnVoltarLogin.Click += new System.EventHandler(this.BtnVoltarLogin_Click);
            // 
            // frmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 391);
            this.Controls.Add(this.btnVoltarLogin);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(745, 391);
            this.Name = "frmRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SENAI - Serviço Nacional de Aprendizagem Industrial";
            this.Load += new System.EventHandler(this.FrmTeste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmpregoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetEmprego)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EmpregoBindingSource;
        private DataSetEmprego DataSetEmprego;
        private DataSetEmpregoTableAdapters.EmpregoTableAdapter EmpregoTableAdapter;
        private System.Windows.Forms.Button btnVoltarLogin;
    }
}