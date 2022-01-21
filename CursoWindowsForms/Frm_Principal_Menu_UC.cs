using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_Principal_Menu_UC : Form
    {

        int ContadorTabs = 0;
        public Frm_Principal_Menu_UC()
        {
            InitializeComponent();

            desconectarToolStripMenuItem.Enabled = false;
            novoToolStripMenuItem.Enabled = false;
            fecharTabToolStripMenuItem.Enabled = false;
            arquivoImagemToolStripMenuItem.Enabled = false;
        }


        private void demonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContadorTabs += 1;
            var f = new Frm_DemonstracaoKey_UC();
            f.Dock = DockStyle.Fill;
            var tb = new TabPage();
            tb.Controls.Add(f);
            tb.Name = "Tbp_DemonstracaoKey";
            tb.Text = "Demonstração Key " + ContadorTabs;
            tb.ImageIndex = 0;
            Tbc_Principal.Controls.Add(tb);
        }

        private void máscarasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frm_Mascaras();
            f.ShowDialog();
        }

        private void trocaTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContadorTabs += 1;
            var f = new Frm_TrocaTexto_UC();
            f.Dock = DockStyle.Fill;
            var tb = new TabPage();
            tb.Controls.Add(f);
            tb.Name = "Tbp_TrocaTexto";
            tb.Text = "Troca Texto " + ContadorTabs;
            tb.ImageIndex = 1;
            Tbc_Principal.Controls.Add(tb);
        }

        private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Frm_ValidaCPF();
            f.ShowDialog();
        }

        private void validaCPFMessageBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContadorTabs += 1;
            var f = new Frm_ValidaCPFMessageBox_UC();
            f.Dock = DockStyle.Fill;
            var tb = new TabPage();
            tb.Controls.Add(f);
            tb.Name = "Tbp_ValidaCPFMessageBox";
            tb.Text = "Valida CPF (MessageBox) " + ContadorTabs;
            tb.ImageIndex = 5;
            Tbc_Principal.Controls.Add(tb);
        }

        private void validaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frm_ValidaSenha();
            f.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Frm_Principal_Menu_Load(object sender, EventArgs e)
        {

        }

        private void fecharTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tbc_Principal.SelectedTab != null)
                Tbc_Principal.TabPages.Remove(Tbc_Principal.SelectedTab);
        }

        private void arquivoImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var fd = new OpenFileDialog();
            fd.InitialDirectory = "C:\\Users\\aliso\\Source\\Repos\\Curso-WindowsForms-I-Alura\\CursoWindowsForms\\Imagens";
            fd.Filter = "PNG|*.PNG";
            fd.Title = "Escolha uma imagem";

            if (fd.ShowDialog() == DialogResult.OK)
            {
                string nomeArquivoImagem = fd.FileName;

                ContadorTabs += 1;
                var f = new Frm_Arquivo(nomeArquivoImagem);
                f.Dock = DockStyle.Fill;
                var tb = new TabPage();
                tb.Controls.Add(f);
                tb.Name = "Tbp_Arquivo";
                tb.Text = "Arquivo " + ContadorTabs;
                tb.ImageIndex = 6;
                Tbc_Principal.Controls.Add(tb);
            }
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Frm_Login();
            f.ShowDialog();

            if (f.DialogResult == DialogResult.OK)
            {

                var login = f.login;
                var senha = f.senha;

                if (Utilitarios.ValidaSenha(senha))
                {
                    conectarToolStripMenuItem.Enabled = false;
                    desconectarToolStripMenuItem.Enabled = true;
                    novoToolStripMenuItem.Enabled = true;
                    fecharTabToolStripMenuItem.Enabled = true;
                    arquivoImagemToolStripMenuItem.Enabled = true;

                    MessageBox.Show("Bem vindo " + login + " !", "Mensagem - Boas Vindas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Senha Inválida !", "Mensagem - Senha Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var db = new Frm_Questao("icons8_question_mark_96", "Você deseja se desconectar ?");
            db.ShowDialog();

            if (db.DialogResult == DialogResult.Yes)
            {

                for (int i = Tbc_Principal.TabPages.Count - 1; i >= 0; i += -1)
                {
                    Tbc_Principal.TabPages.Remove(Tbc_Principal.TabPages[i]);
                }

                conectarToolStripMenuItem.Enabled = true;
                desconectarToolStripMenuItem.Enabled = false;
                novoToolStripMenuItem.Enabled = false;
                fecharTabToolStripMenuItem.Enabled = false;
                arquivoImagemToolStripMenuItem.Enabled = false;
            }

        }

        private void Tbc_Principal_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var menuFlutuante = new ContextMenuStrip();
                var deleteTab = CriaItemMenu("Apagar Tab Selecionada", "DeleteTab");
                var deleteLeft = CriaItemMenu("Apagar Tabs a Esquerda", "DeleteLeft");
                var deleteRight = CriaItemMenu("Apagar Tabs a Direita", "DeleteRight");
                var deleteAll = CriaItemMenu("Apagar Todas as Tabs", "DeleteAll");

                menuFlutuante.Items.Add(deleteTab);
                menuFlutuante.Items.Add(deleteLeft);
                menuFlutuante.Items.Add(deleteRight);
                menuFlutuante.Items.Add(deleteAll);

                menuFlutuante.Show(this, new Point(e.X, e.Y));

                deleteTab.Click += new EventHandler(deleteTab_Click);
                deleteLeft.Click += new EventHandler(deleteLeft_Click);
                deleteRight.Click += new EventHandler(deleteRight_Click);
                deleteAll.Click += new EventHandler(deleteAll_Click);
            }

            void deleteTab_Click(object sender1, EventArgs e1)
            {
                Tbc_Principal.TabPages.Remove(Tbc_Principal.SelectedTab);
            }

            void deleteLeft_Click(object sender1, EventArgs e1)
            {
                apagaTabsEsquerda(Tbc_Principal.SelectedIndex - 1);
            }

            void deleteRight_Click(object sender1, EventArgs e1)
            {
                
                var tabSelecionada = Tbc_Principal.SelectedIndex + 1;
                apagaTabsDireita(tabSelecionada);
            }

            void deleteAll_Click(object sender1, EventArgs e1)
            {
                //var ultimaTab = Tbc_Principal.TabPages.Count - 1;
                //for (int i = ultimaTab; i >= 0; i += -1)
                //{
                //    Tbc_Principal.TabPages.Remove(Tbc_Principal.TabPages[i]);
                //}
                apagaTabsEsquerda(Tbc_Principal.SelectedIndex - 1);
                var tabSelecionada = Tbc_Principal.SelectedIndex + 1;
                apagaTabsDireita(tabSelecionada);
                Tbc_Principal.TabPages.Remove(Tbc_Principal.SelectedTab);
            }

            void apagaTabsEsquerda(int tabI)
            {
                for (int i = tabI; i >= 0; i += -1)
                {
                    Tbc_Principal.TabPages.Remove(Tbc_Principal.TabPages[i]);
                }
            }

            void apagaTabsDireita(int tabI)
            {
                var ultimaTab = Tbc_Principal.TabPages.Count - 1;
                for (int i = ultimaTab; i >= tabI; i += -1)
                {
                    Tbc_Principal.TabPages.Remove(Tbc_Principal.TabPages[i]);
                }
            }


            ToolStripMenuItem CriaItemMenu(string texto, string imagem)
            {
                var itemMenu = new ToolStripMenuItem();
                itemMenu.Text = texto;

                Image MyImage = (Image)Properties.Resources.ResourceManager.GetObject(imagem);
                itemMenu.Image = MyImage;

                return itemMenu;
            }
        }

        private void Frm_Principal_Menu_UC_Load(object sender, EventArgs e)
        {

        }
    }
}
