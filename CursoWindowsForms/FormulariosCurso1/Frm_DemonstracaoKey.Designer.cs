namespace CursoWindowsForms
{
    partial class Frm_DemonstracaoKey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DemonstracaoKey));
            this.lbl_Lower = new System.Windows.Forms.Label();
            this.lbl_Upper = new System.Windows.Forms.Label();
            this.lbl_Minus = new System.Windows.Forms.Label();
            this.lbl_Maius = new System.Windows.Forms.Label();
            this.txt_Msg = new System.Windows.Forms.TextBox();
            this.txt_Input = new System.Windows.Forms.TextBox();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Lower
            // 
            this.lbl_Lower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Lower.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Lower.Location = new System.Drawing.Point(382, 48);
            this.lbl_Lower.Name = "lbl_Lower";
            this.lbl_Lower.Size = new System.Drawing.Size(45, 23);
            this.lbl_Lower.TabIndex = 4;
            // 
            // lbl_Upper
            // 
            this.lbl_Upper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Upper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Upper.Location = new System.Drawing.Point(382, 104);
            this.lbl_Upper.Name = "lbl_Upper";
            this.lbl_Upper.Size = new System.Drawing.Size(45, 23);
            this.lbl_Upper.TabIndex = 6;
            // 
            // lbl_Minus
            // 
            this.lbl_Minus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Minus.AutoSize = true;
            this.lbl_Minus.Location = new System.Drawing.Point(338, 49);
            this.lbl_Minus.Name = "lbl_Minus";
            this.lbl_Minus.Size = new System.Drawing.Size(38, 13);
            this.lbl_Minus.TabIndex = 3;
            this.lbl_Minus.Text = "Minus.";
            // 
            // lbl_Maius
            // 
            this.lbl_Maius.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Maius.AutoSize = true;
            this.lbl_Maius.Location = new System.Drawing.Point(338, 105);
            this.lbl_Maius.Name = "lbl_Maius";
            this.lbl_Maius.Size = new System.Drawing.Size(35, 13);
            this.lbl_Maius.TabIndex = 5;
            this.lbl_Maius.Text = "Maius";
            // 
            // txt_Msg
            // 
            this.txt_Msg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Msg.Location = new System.Drawing.Point(12, 51);
            this.txt_Msg.Multiline = true;
            this.txt_Msg.Name = "txt_Msg";
            this.txt_Msg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Msg.Size = new System.Drawing.Size(320, 192);
            this.txt_Msg.TabIndex = 2;
            this.txt_Msg.TabStop = false;
            // 
            // txt_Input
            // 
            this.txt_Input.Location = new System.Drawing.Point(12, 12);
            this.txt_Input.Name = "txt_Input";
            this.txt_Input.Size = new System.Drawing.Size(126, 20);
            this.txt_Input.TabIndex = 0;
            this.txt_Input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Input_KeyDown);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Limpar.Location = new System.Drawing.Point(341, 10);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(86, 23);
            this.btn_Limpar.TabIndex = 1;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // Frm_DemonstracaoKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 281);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.txt_Input);
            this.Controls.Add(this.txt_Msg);
            this.Controls.Add(this.lbl_Maius);
            this.Controls.Add(this.lbl_Upper);
            this.Controls.Add(this.lbl_Minus);
            this.Controls.Add(this.lbl_Lower);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_DemonstracaoKey";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demonstração de Evento Key";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Lower;
        private System.Windows.Forms.Label lbl_Upper;
        private System.Windows.Forms.Label lbl_Minus;
        private System.Windows.Forms.Label lbl_Maius;
        private System.Windows.Forms.TextBox txt_Msg;
        private System.Windows.Forms.TextBox txt_Input;
        private System.Windows.Forms.Button btn_Limpar;
    }
}