using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CursoWindowsFormsLib;

namespace CursoWindowsForms
{
    public partial class Frm_ValidaCPF : Form
    {
        public Frm_ValidaCPF()
        {
            InitializeComponent();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Text = "";
            Msk_CPF.Text = "";
        }
        private void Btn_Valida_Click(object sender, EventArgs e)
        {
            bool valido = false;
            valido = Utilitarios.Valida(Msk_CPF.Text);
            if (valido)
            {
                Lbl_Resultado.Text = "CPF VALIDO";
                Lbl_Resultado.ForeColor = Color.Green;
            }
            else
            {
                Lbl_Resultado.Text = "CPF INVALIDO";
                Lbl_Resultado.ForeColor = Color.Red;
            }
        }
    }
}
