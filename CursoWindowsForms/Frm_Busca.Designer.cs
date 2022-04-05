namespace CursoWindowsForms
{
    partial class Frm_Busca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Busca));
            this.tls_menuPesquisa = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.deletaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.lst_Clientes = new System.Windows.Forms.ListBox();
            this.tls_menuPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // tls_menuPesquisa
            // 
            this.tls_menuPesquisa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.deletaToolStripButton});
            this.tls_menuPesquisa.Location = new System.Drawing.Point(0, 0);
            this.tls_menuPesquisa.Name = "tls_menuPesquisa";
            this.tls_menuPesquisa.Size = new System.Drawing.Size(446, 25);
            this.tls_menuPesquisa.TabIndex = 57;
            this.tls_menuPesquisa.Text = "toolStrip1";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // deletaToolStripButton
            // 
            this.deletaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deletaToolStripButton.Image = global::CursoWindowsForms.Properties.Resources.ExcluirBarra;
            this.deletaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deletaToolStripButton.Name = "deletaToolStripButton";
            this.deletaToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.deletaToolStripButton.Text = "toolStripButton1";
            this.deletaToolStripButton.Click += new System.EventHandler(this.deletaToolStripButton_Click);
            // 
            // lst_Clientes
            // 
            this.lst_Clientes.FormattingEnabled = true;
            this.lst_Clientes.Location = new System.Drawing.Point(12, 37);
            this.lst_Clientes.Name = "lst_Clientes";
            this.lst_Clientes.Size = new System.Drawing.Size(422, 238);
            this.lst_Clientes.TabIndex = 58;
            // 
            // Frm_Busca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 283);
            this.Controls.Add(this.lst_Clientes);
            this.Controls.Add(this.tls_menuPesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Busca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Cliente";
            this.tls_menuPesquisa.ResumeLayout(false);
            this.tls_menuPesquisa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tls_menuPesquisa;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton deletaToolStripButton;
        private System.Windows.Forms.ListBox lst_Clientes;
    }
}