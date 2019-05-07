namespace ProjetoSenai
{
    partial class frmEsqueceuSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEsqueceuSenha));
            this.lblEsqueceuSenha = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblDigiteEmail = new MaterialSkin.Controls.MaterialLabel();
            this.btnEnviar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.lblResult = new MaterialSkin.Controls.MaterialLabel();
            this.btnVoltarLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEsqueceuSenha
            // 
            this.lblEsqueceuSenha.AutoSize = true;
            this.lblEsqueceuSenha.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsqueceuSenha.Location = new System.Drawing.Point(73, 215);
            this.lblEsqueceuSenha.Name = "lblEsqueceuSenha";
            this.lblEsqueceuSenha.Size = new System.Drawing.Size(328, 44);
            this.lblEsqueceuSenha.TabIndex = 16;
            this.lblEsqueceuSenha.Text = "Recuperar senha";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(110, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 163);
            this.panel1.TabIndex = 15;
            // 
            // txtEmail
            // 
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Hint = "Email";
            this.txtEmail.Location = new System.Drawing.Point(81, 330);
            this.txtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(316, 23);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.UseSystemPasswordChar = false;
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtEmail_KeyDown);
            // 
            // lblDigiteEmail
            // 
            this.lblDigiteEmail.AutoSize = true;
            this.lblDigiteEmail.Depth = 0;
            this.lblDigiteEmail.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDigiteEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDigiteEmail.Location = new System.Drawing.Point(77, 289);
            this.lblDigiteEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDigiteEmail.Name = "lblDigiteEmail";
            this.lblDigiteEmail.Size = new System.Drawing.Size(264, 19);
            this.lblDigiteEmail.TabIndex = 17;
            this.lblDigiteEmail.Text = "Digite seu e-mail para receber a senha";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.Depth = 0;
            this.btnEnviar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(150, 429);
            this.btnEnviar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Primary = true;
            this.btnEnviar.Size = new System.Drawing.Size(172, 36);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "ENVIAR";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(27, 481);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(400, 2);
            this.materialDivider1.TabIndex = 18;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Depth = 0;
            this.lblResult.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblResult.Location = new System.Drawing.Point(77, 380);
            this.lblResult.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 19);
            this.lblResult.TabIndex = 20;
            // 
            // btnVoltarLogin
            // 
            this.btnVoltarLogin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVoltarLogin.FlatAppearance.BorderSize = 0;
            this.btnVoltarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltarLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltarLogin.Image")));
            this.btnVoltarLogin.Location = new System.Drawing.Point(5, 68);
            this.btnVoltarLogin.Name = "btnVoltarLogin";
            this.btnVoltarLogin.Size = new System.Drawing.Size(63, 32);
            this.btnVoltarLogin.TabIndex = 21;
            this.btnVoltarLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltarLogin.UseVisualStyleBackColor = false;
            this.btnVoltarLogin.Click += new System.EventHandler(this.BtnVoltarLogin_Click);
            // 
            // frmEsqueceuSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 527);
            this.Controls.Add(this.btnVoltarLogin);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.lblDigiteEmail);
            this.Controls.Add(this.lblEsqueceuSenha);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtEmail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEsqueceuSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SENAI - Serviço de aprendizagem industrial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEsqueceuSenha;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmail;
        private MaterialSkin.Controls.MaterialLabel lblDigiteEmail;
        private MaterialSkin.Controls.MaterialRaisedButton btnEnviar;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel lblResult;
        private System.Windows.Forms.Button btnVoltarLogin;
    }
}