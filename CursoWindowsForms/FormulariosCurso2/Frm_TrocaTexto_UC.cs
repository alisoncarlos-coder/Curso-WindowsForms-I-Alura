using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_TrocaTexto_UC : UserControl
    {
        public Frm_TrocaTexto_UC()
        {
            InitializeComponent();
        }

        private void lbl_trocar_texto_label_Click(object sender, EventArgs e)
        {
            lbl_Titulo.Text = txt_Digitado.Text;
        }
    }
}
