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
    public partial class Frm_Arquivo : UserControl
    {
        public Frm_Arquivo(string nomeArquivo)
        {
            InitializeComponent();

            Lbl_NomeArquivo.Text = nomeArquivo;
            Pic_Imagem.Image = Image.FromFile(nomeArquivo);
        }

        private void Btn_Cor_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();
            if(cd.ShowDialog() == DialogResult.OK)
            {
                Lbl_NomeArquivo.ForeColor = cd.Color;
            }
        }

        private void Btn_Fonte_Click(object sender, EventArgs e)
        {
            var fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                Lbl_NomeArquivo.Font = fd.Font;
            }
        }
    }
}
