namespace CursoWindowsForms
{
    partial class frm_ValidaSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ValidaSenha));
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Limpa = new System.Windows.Forms.Button();
            this.btn_VerSenha = new System.Windows.Forms.Button();
            this.lbl_ForcaSenha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Senha
            // 
            this.txt_Senha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Senha.Location = new System.Drawing.Point(88, 34);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.PasswordChar = '*';
            this.txt_Senha.Size = new System.Drawing.Size(141, 20);
            this.txt_Senha.TabIndex = 0;
            this.txt_Senha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Senha_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Senha:";
            // 
            // btn_Limpa
            // 
            this.btn_Limpa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Limpa.Location = new System.Drawing.Point(247, 32);
            this.btn_Limpa.Name = "btn_Limpa";
            this.btn_Limpa.Size = new System.Drawing.Size(75, 23);
            this.btn_Limpa.TabIndex = 2;
            this.btn_Limpa.Text = "Limpa";
            this.btn_Limpa.UseVisualStyleBackColor = true;
            this.btn_Limpa.Click += new System.EventHandler(this.btn_Limpa_Click);
            // 
            // btn_VerSenha
            // 
            this.btn_VerSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_VerSenha.Location = new System.Drawing.Point(247, 71);
            this.btn_VerSenha.Name = "btn_VerSenha";
            this.btn_VerSenha.Size = new System.Drawing.Size(75, 23);
            this.btn_VerSenha.TabIndex = 2;
            this.btn_VerSenha.Text = "Ver Senha";
            this.btn_VerSenha.UseVisualStyleBackColor = true;
            this.btn_VerSenha.Click += new System.EventHandler(this.btn_VerSenha_Click);
            // 
            // lbl_ForcaSenha
            // 
            this.lbl_ForcaSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_ForcaSenha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_ForcaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ForcaSenha.Location = new System.Drawing.Point(44, 68);
            this.lbl_ForcaSenha.Name = "lbl_ForcaSenha";
            this.lbl_ForcaSenha.Size = new System.Drawing.Size(185, 33);
            this.lbl_ForcaSenha.TabIndex = 1;
            // 
            // frm_ValidaSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 133);
            this.Controls.Add(this.btn_VerSenha);
            this.Controls.Add(this.btn_Limpa);
            this.Controls.Add(this.lbl_ForcaSenha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Senha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_ValidaSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validação de Senha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Limpa;
        private System.Windows.Forms.Button btn_VerSenha;
        private System.Windows.Forms.Label lbl_ForcaSenha;
    }
}