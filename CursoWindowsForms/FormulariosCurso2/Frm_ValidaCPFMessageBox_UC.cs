using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CursoWindowsFormsLib;

namespace CursoWindowsForms
{
    public partial class Frm_ValidaCPFMessageBox_UC : UserControl
    {
        public Frm_ValidaCPFMessageBox_UC()
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
                var db = new Frm_Questao("Frm_ValidaCPF2", "Deseja validar o CPF?");
                db.ShowDialog();
                //if (MessageBox.Show("Tem certeza que deseja validar o CPF?", "Validação do CPF", MessageBoxButtons.YesNo,
                //MessageBoxIcon.Question) == DialogResult.Yes)
                if (db.DialogResult == DialogResult.Yes)
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
    }
}
