namespace CursoWindowsForms
{
    partial class frm_TrocaTexto
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
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.lbl_trocar_texto_label = new System.Windows.Forms.Button();
            this.txt_Digitado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(37, 33);
            this.lbl_Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(190, 16);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Visual Studio .NET Framework";
            this.lbl_Titulo.UseMnemonic = false;
            // 
            // btn_Sair
            // 
            this.btn_Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair.Location = new System.Drawing.Point(204, 321);
            this.btn_Sair.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(275, 32);
            this.btn_Sair.TabIndex = 1;
            this.btn_Sair.Text = "Sair da Aplicação";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // lbl_trocar_texto_label
            // 
            this.lbl_trocar_texto_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_trocar_texto_label.Location = new System.Drawing.Point(37, 68);
            this.lbl_trocar_texto_label.Margin = new System.Windows.Forms.Padding(4);
            this.lbl_trocar_texto_label.Name = "lbl_trocar_texto_label";
            this.lbl_trocar_texto_label.Size = new System.Drawing.Size(253, 32);
            this.lbl_trocar_texto_label.TabIndex = 2;
            this.lbl_trocar_texto_label.Text = "Trocar texto da label ";
            this.lbl_trocar_texto_label.UseVisualStyleBackColor = true;
            this.lbl_trocar_texto_label.Click += new System.EventHandler(this.lbl_trocar_texto_label_Click);
            // 
            // txt_Digitado
            // 
            this.txt_Digitado.Location = new System.Drawing.Point(37, 116);
            this.txt_Digitado.Name = "txt_Digitado";
            this.txt_Digitado.Size = new System.Drawing.Size(253, 22);
            this.txt_Digitado.TabIndex = 3;
            // 
            // frm_TrocaTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 396);
            this.Controls.Add(this.txt_Digitado);
            this.Controls.Add(this.lbl_trocar_texto_label);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.lbl_Titulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_TrocaTexto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Troca Texto - Label";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button lbl_trocar_texto_label;
        private System.Windows.Forms.TextBox txt_Digitado;
    }
}

