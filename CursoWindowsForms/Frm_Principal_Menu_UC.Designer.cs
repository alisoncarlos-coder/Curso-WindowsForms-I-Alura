namespace CursoWindowsForms
{
    partial class Frm_Principal_Menu_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal_Menu_UC));
            this.Mnu_Principal = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desconectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demonstraçãoKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.máscarasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trocaTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validaCPFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validaCPFMessageBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validaSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arquivoImagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tbc_Principal = new System.Windows.Forms.TabControl();
            this.Iml_Imagens = new System.Windows.Forms.ImageList(this.components);
            this.Mnu_Principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mnu_Principal
            // 
            this.Mnu_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.açõesToolStripMenuItem,
            this.windowsToolStripMenuItem});
            this.Mnu_Principal.Location = new System.Drawing.Point(0, 0);
            this.Mnu_Principal.Name = "Mnu_Principal";
            this.Mnu_Principal.Size = new System.Drawing.Size(800, 24);
            this.Mnu_Principal.TabIndex = 0;
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conectarToolStripMenuItem,
            this.desconectarToolStripMenuItem,
            this.novoToolStripMenuItem,
            this.fecharTabToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // conectarToolStripMenuItem
            // 
            this.conectarToolStripMenuItem.Name = "conectarToolStripMenuItem";
            this.conectarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.conectarToolStripMenuItem.Text = "Conectar";
            this.conectarToolStripMenuItem.Click += new System.EventHandler(this.conectarToolStripMenuItem_Click);
            // 
            // desconectarToolStripMenuItem
            // 
            this.desconectarToolStripMenuItem.Name = "desconectarToolStripMenuItem";
            this.desconectarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.desconectarToolStripMenuItem.Text = "Desconectar";
            this.desconectarToolStripMenuItem.Click += new System.EventHandler(this.desconectarToolStripMenuItem_Click);
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.demonstraçãoKeyToolStripMenuItem,
            this.máscarasToolStripMenuItem,
            this.trocaTextoToolStripMenuItem,
            this.validaCPFToolStripMenuItem,
            this.validaCPFMessageBoxToolStripMenuItem,
            this.validaSenhaToolStripMenuItem});
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            // 
            // demonstraçãoKeyToolStripMenuItem
            // 
            this.demonstraçãoKeyToolStripMenuItem.Image = global::CursoWindowsForms.Properties.Resources.Frm_DemonstracaoKey;
            this.demonstraçãoKeyToolStripMenuItem.Name = "demonstraçãoKeyToolStripMenuItem";
            this.demonstraçãoKeyToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.demonstraçãoKeyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.K)));
            this.demonstraçãoKeyToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.demonstraçãoKeyToolStripMenuItem.Text = "Demonstração Key";
            this.demonstraçãoKeyToolStripMenuItem.Click += new System.EventHandler(this.demonstraçãoKeyToolStripMenuItem_Click);
            // 
            // máscarasToolStripMenuItem
            // 
            this.máscarasToolStripMenuItem.Image = global::CursoWindowsForms.Properties.Resources.Frm_Mascara;
            this.máscarasToolStripMenuItem.Name = "máscarasToolStripMenuItem";
            this.máscarasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.máscarasToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.máscarasToolStripMenuItem.Text = "Máscaras";
            this.máscarasToolStripMenuItem.Click += new System.EventHandler(this.máscarasToolStripMenuItem_Click);
            // 
            // trocaTextoToolStripMenuItem
            // 
            this.trocaTextoToolStripMenuItem.Image = global::CursoWindowsForms.Properties.Resources.Frm_HelloWorld;
            this.trocaTextoToolStripMenuItem.Name = "trocaTextoToolStripMenuItem";
            this.trocaTextoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.trocaTextoToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.trocaTextoToolStripMenuItem.Text = "Troca Texto";
            this.trocaTextoToolStripMenuItem.Click += new System.EventHandler(this.trocaTextoToolStripMenuItem_Click);
            // 
            // validaCPFToolStripMenuItem
            // 
            this.validaCPFToolStripMenuItem.Image = global::CursoWindowsForms.Properties.Resources.Frm_ValidaCPF;
            this.validaCPFToolStripMenuItem.Name = "validaCPFToolStripMenuItem";
            this.validaCPFToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.validaCPFToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.validaCPFToolStripMenuItem.Text = "Valida CPF";
            this.validaCPFToolStripMenuItem.Click += new System.EventHandler(this.validaCPFToolStripMenuItem_Click);
            // 
            // validaCPFMessageBoxToolStripMenuItem
            // 
            this.validaCPFMessageBoxToolStripMenuItem.Image = global::CursoWindowsForms.Properties.Resources.Frm_ValidaCPF2;
            this.validaCPFMessageBoxToolStripMenuItem.Name = "validaCPFMessageBoxToolStripMenuItem";
            this.validaCPFMessageBoxToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.validaCPFMessageBoxToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.validaCPFMessageBoxToolStripMenuItem.Text = "Valida CPF (MessageBox)";
            this.validaCPFMessageBoxToolStripMenuItem.Click += new System.EventHandler(this.validaCPFMessageBoxToolStripMenuItem_Click);
            // 
            // validaSenhaToolStripMenuItem
            // 
            this.validaSenhaToolStripMenuItem.Image = global::CursoWindowsForms.Properties.Resources.Frm_ValidaSenha;
            this.validaSenhaToolStripMenuItem.Name = "validaSenhaToolStripMenuItem";
            this.validaSenhaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.validaSenhaToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.validaSenhaToolStripMenuItem.Text = "Valida Senha";
            this.validaSenhaToolStripMenuItem.Click += new System.EventHandler(this.validaSenhaToolStripMenuItem_Click);
            // 
            // fecharTabToolStripMenuItem
            // 
            this.fecharTabToolStripMenuItem.Name = "fecharTabToolStripMenuItem";
            this.fecharTabToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fecharTabToolStripMenuItem.Text = "Fechar Tab";
            this.fecharTabToolStripMenuItem.Click += new System.EventHandler(this.fecharTabToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // açõesToolStripMenuItem
            // 
            this.açõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoImagemToolStripMenuItem});
            this.açõesToolStripMenuItem.Name = "açõesToolStripMenuItem";
            this.açõesToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.açõesToolStripMenuItem.Text = "Ações";
            // 
            // arquivoImagemToolStripMenuItem
            // 
            this.arquivoImagemToolStripMenuItem.Name = "arquivoImagemToolStripMenuItem";
            this.arquivoImagemToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.arquivoImagemToolStripMenuItem.Text = "Arquivo Imagem";
            this.arquivoImagemToolStripMenuItem.Click += new System.EventHandler(this.arquivoImagemToolStripMenuItem_Click);
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.windowsToolStripMenuItem.Text = "Windows";
            // 
            // Tbc_Principal
            // 
            this.Tbc_Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tbc_Principal.ImageList = this.Iml_Imagens;
            this.Tbc_Principal.Location = new System.Drawing.Point(0, 24);
            this.Tbc_Principal.Name = "Tbc_Principal";
            this.Tbc_Principal.SelectedIndex = 0;
            this.Tbc_Principal.Size = new System.Drawing.Size(800, 426);
            this.Tbc_Principal.TabIndex = 1;
            this.Tbc_Principal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tbc_Principal_MouseDown);
            // 
            // Iml_Imagens
            // 
            this.Iml_Imagens.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Iml_Imagens.ImageStream")));
            this.Iml_Imagens.TransparentColor = System.Drawing.Color.Transparent;
            this.Iml_Imagens.Images.SetKeyName(0, "Frm_DemonstracaoKey.ico");
            this.Iml_Imagens.Images.SetKeyName(1, "Frm_HelloWorld.ico");
            this.Iml_Imagens.Images.SetKeyName(2, "Frm_Mascara.ico");
            this.Iml_Imagens.Images.SetKeyName(3, "Frm_Principal.ico");
            this.Iml_Imagens.Images.SetKeyName(4, "Frm_ValidaCPF.ico");
            this.Iml_Imagens.Images.SetKeyName(5, "Frm_ValidaCPF2.ico");
            this.Iml_Imagens.Images.SetKeyName(6, "Frm_ValidaSenha.ico");
            // 
            // Frm_Principal_Menu_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tbc_Principal);
            this.Controls.Add(this.Mnu_Principal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Mnu_Principal;
            this.Name = "Frm_Principal_Menu_UC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Frm_Principal_Menu_UC_Load);
            this.Mnu_Principal.ResumeLayout(false);
            this.Mnu_Principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Mnu_Principal;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem demonstraçãoKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem máscarasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trocaTextoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validaCPFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validaCPFMessageBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validaSenhaToolStripMenuItem;
        private System.Windows.Forms.TabControl Tbc_Principal;
        private System.Windows.Forms.ImageList Iml_Imagens;
        private System.Windows.Forms.ToolStripMenuItem fecharTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arquivoImagemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conectarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desconectarToolStripMenuItem;
    }
}