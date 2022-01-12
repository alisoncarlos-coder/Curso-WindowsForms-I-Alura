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
    public partial class Frm_ValidaCPFMessageBox : Form
    {
        public Frm_ValidaCPFMessageBox()
        {
            InitializeComponent();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Msk_CPF.Text = "";
        }

        private void Btn_Valida_Click(object sender, EventArgs e)
        {
            var conteudoCPF = Msk_CPF.Text;
            conteudoCPF = conteudoCPF.Replace("-", "").Replace(".", "").Trim();

            if (conteudoCPF == "")
            {
                MessageBox.Show("Digite um CPF para validação", "Validação do CPF", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            else if (conteudoCPF.Length < 11)
            {
                MessageBox.Show("O n° de CPF deve conter 11 digitos", "Validação do CPF", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                Btn_Reset_Click(sender, e);
                Msk_CPF.Focus();
            }
            else
            {
                if (MessageBox.Show("Tem certeza que deseja validar o CPF?", "Validação do CPF", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool valido = Utilitarios.Valida(Msk_CPF.Text);
                    if (valido)
                    {
                        MessageBox.Show("CPF VALIDO", "Validação do CPF", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("CPF inVALIDO", "Validação do CPF", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        Btn_Reset_Click(sender, e);
                        Msk_CPF.Focus();
                    }
                }
            }

        }

        private void Msk_CPF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btn_Valida_Click(sender, e);
            }
        }
    }
}
