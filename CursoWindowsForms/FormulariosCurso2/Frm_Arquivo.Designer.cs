namespace CursoWindowsForms
{
    partial class Frm_Arquivo
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
            this.Lbl_NomeArquivo = new System.Windows.Forms.Label();
            this.Btn_Cor = new System.Windows.Forms.Button();
            this.Btn_Fonte = new System.Windows.Forms.Button();
            this.Pic_Imagem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Imagem)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_NomeArquivo
            // 
            this.Lbl_NomeArquivo.AutoSize = true;
            this.Lbl_NomeArquivo.Location = new System.Drawing.Point(32, 36);
            this.Lbl_NomeArquivo.Name = "Lbl_NomeArquivo";
            this.Lbl_NomeArquivo.Size = new System.Drawing.Size(35, 13);
            this.Lbl_NomeArquivo.TabIndex = 1;
            this.Lbl_NomeArquivo.Text = "label2";
            // 
            // Btn_Cor
            // 
            this.Btn_Cor.Location = new System.Drawing.Point(31, 10);
            this.Btn_Cor.Name = "Btn_Cor";
            this.Btn_Cor.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cor.TabIndex = 3;
            this.Btn_Cor.Text = "Cor";
            this.Btn_Cor.UseVisualStyleBackColor = true;
            this.Btn_Cor.Click += new System.EventHandler(this.Btn_Cor_Click);
            // 
            // Btn_Fonte
            // 
            this.Btn_Fonte.Cursor = System.Windows.Forms.Cursors.Default;
            this.Btn_Fonte.Location = new System.Drawing.Point(112, 10);
            this.Btn_Fonte.Name = "Btn_Fonte";
            this.Btn_Fonte.Size = new System.Drawing.Size(75, 23);
            this.Btn_Fonte.TabIndex = 4;
            this.Btn_Fonte.Text = "Fonte";
            this.Btn_Fonte.UseVisualStyleBackColor = true;
            this.Btn_Fonte.Click += new System.EventHandler(this.Btn_Fonte_Click);
            // 
            // Pic_Imagem
            // 
            this.Pic_Imagem.Location = new System.Drawing.Point(31, 61);
            this.Pic_Imagem.Name = "Pic_Imagem";
            this.Pic_Imagem.Size = new System.Drawing.Size(200, 136);
            this.Pic_Imagem.TabIndex = 2;
            this.Pic_Imagem.TabStop = false;
            // 
            // Frm_Arquivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_Fonte);
            this.Controls.Add(this.Btn_Cor);
            this.Controls.Add(this.Pic_Imagem);
            this.Controls.Add(this.Lbl_NomeArquivo);
            this.Name = "Frm_Arquivo";
            this.Size = new System.Drawing.Size(358, 240);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Imagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_NomeArquivo;
        private System.Windows.Forms.PictureBox Pic_Imagem;
        private System.Windows.Forms.Button Btn_Cor;
        private System.Windows.Forms.Button Btn_Fonte;
    }
}
