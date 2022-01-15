namespace CursoWindowsForms
{
    partial class Frm_TrocaTexto_UC
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
            this.txt_Digitado = new System.Windows.Forms.TextBox();
            this.lbl_trocar_texto_label = new System.Windows.Forms.Button();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Digitado
            // 
            this.txt_Digitado.Location = new System.Drawing.Point(35, 110);
            this.txt_Digitado.Name = "txt_Digitado";
            this.txt_Digitado.Size = new System.Drawing.Size(253, 20);
            this.txt_Digitado.TabIndex = 6;
            // 
            // lbl_trocar_texto_label
            // 
            this.lbl_trocar_texto_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_trocar_texto_label.Location = new System.Drawing.Point(35, 62);
            this.lbl_trocar_texto_label.Margin = new System.Windows.Forms.Padding(4);
            this.lbl_trocar_texto_label.Name = "lbl_trocar_texto_label";
            this.lbl_trocar_texto_label.Size = new System.Drawing.Size(253, 32);
            this.lbl_trocar_texto_label.TabIndex = 5;
            this.lbl_trocar_texto_label.Text = "Trocar texto da label ";
            this.lbl_trocar_texto_label.UseVisualStyleBackColor = true;
            this.lbl_trocar_texto_label.Click += new System.EventHandler(this.lbl_trocar_texto_label_Click);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(35, 27);
            this.lbl_Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(190, 16);
            this.lbl_Titulo.TabIndex = 4;
            this.lbl_Titulo.Text = "Visual Studio .NET Framework";
            this.lbl_Titulo.UseMnemonic = false;
            // 
            // Frm_TrocaTexto_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_Digitado);
            this.Controls.Add(this.lbl_trocar_texto_label);
            this.Controls.Add(this.lbl_Titulo);
            this.Name = "Frm_TrocaTexto_UC";
            this.Size = new System.Drawing.Size(508, 329);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Digitado;
        private System.Windows.Forms.Button lbl_trocar_texto_label;
        private System.Windows.Forms.Label lbl_Titulo;
    }
}
