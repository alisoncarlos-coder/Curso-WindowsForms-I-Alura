﻿using System;
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
    public partial class frm_TrocaTexto : Form
    {
        public frm_TrocaTexto()
        {
            InitializeComponent();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_trocar_texto_label_Click(object sender, EventArgs e)
        {
            lbl_Titulo.Text = txt_Digitado.Text;
        }
    }
}
