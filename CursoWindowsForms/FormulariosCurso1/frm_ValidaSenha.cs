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
    public partial class frm_ValidaSenha : Form
    {
        bool verSenhatxt = false;

        public frm_ValidaSenha()
        {
            InitializeComponent();
        }

        private void txt_Senha_KeyDown(object sender, KeyEventArgs e)
        {
            ChecaForcaSenha cf = new ChecaForcaSenha();
            ChecaForcaSenha.ForcaDaSenha forca;
            forca = cf.GetForcaDaSenha(txt_Senha.Text);
            lbl_ForcaSenha.Text = forca.ToString();

            if (lbl_ForcaSenha.Text == "Inaceitavel" | lbl_ForcaSenha.Text == "Fraca")
            {
                lbl_ForcaSenha.ForeColor = Color.Red;
            }
            if (lbl_ForcaSenha.Text == "Aceitavel")
            {
                lbl_ForcaSenha.ForeColor = Color.Blue;
            }
            if (lbl_ForcaSenha.Text == "Forte" | lbl_ForcaSenha.Text == "Segura")
            {
                lbl_ForcaSenha.ForeColor = Color.Green;
            }
        }

        private void btn_Limpa_Click(object sender, EventArgs e)
        {
            txt_Senha.Text = "";
            lbl_ForcaSenha.Text = "";
        }

        private void btn_VerSenha_Click(object sender, EventArgs e)
        {
            if (verSenhatxt == false)
            {
                txt_Senha.PasswordChar = '\0';
                verSenhatxt = true;
                btn_VerSenha.Text = "Esconder Senha";
            }
            else
            {
                txt_Senha.PasswordChar = '*';
                verSenhatxt = false;
                btn_VerSenha.Text = "Ver Senha";
            }
        }
    }
}
