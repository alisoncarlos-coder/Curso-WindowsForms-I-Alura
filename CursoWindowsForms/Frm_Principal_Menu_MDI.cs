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
    public partial class Frm_Principal_Menu_MDI : Form
    {
        public Frm_Principal_Menu_MDI()
        {
            InitializeComponent();
        }


        private void demonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Frm_DemonstracaoKey();
            f.MdiParent = this;
            f.Show();
        }

        private void máscarasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frm_Mascaras();
            f.MdiParent = this;
            f.Show();
        }

        private void trocaTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frm_TrocaTexto();
            f.MdiParent = this;
            f.Show();
        }

        private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Frm_ValidaCPF();
            f.MdiParent = this;
            f.Show();
        }

        private void validaCPFMessageBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Frm_ValidaCPFMessageBox();
            f.MdiParent = this;
            f.Show();
        }

        private void validaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frm_ValidaSenha();
            f.MdiParent = this;
            f.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
