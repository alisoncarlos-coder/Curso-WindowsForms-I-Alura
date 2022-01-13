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
    public partial class Frm_Principal_Menu : Form
    {
        public Frm_Principal_Menu()
        {
            InitializeComponent();
        }

        private void demonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Frm_DemonstracaoKey();
            f.ShowDialog();
        }

        private void máscarasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frm_Mascaras();
            f.ShowDialog();
        }

        private void trocaTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frm_TrocaTexto();
            f.ShowDialog();
        }

        private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Frm_ValidaCPF();
            f.ShowDialog();
        }

        private void validaCPFMessageBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Frm_ValidaCPFMessageBox();
            f.ShowDialog();
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
    }
}
