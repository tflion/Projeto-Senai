namespace ProjetoSenai
{
    partial class userPrincipal
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
            this.lblEscolha = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // lblEscolha
            // 
            this.lblEscolha.AutoSize = true;
            this.lblEscolha.Depth = 0;
            this.lblEscolha.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEscolha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEscolha.Location = new System.Drawing.Point(23, 69);
            this.lblEscolha.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEscolha.Name = "lblEscolha";
            this.lblEscolha.Size = new System.Drawing.Size(232, 19);
            this.lblEscolha.TabIndex = 0;
            this.lblEscolha.Text = "Escolha uma das opções ao lado";
            // 
            // userPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblEscolha);
            this.Name = "userPrincipal";
            this.Size = new System.Drawing.Size(549, 490);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblEscolha;
    }
}
