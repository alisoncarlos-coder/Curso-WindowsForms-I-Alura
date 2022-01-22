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
    public partial class Frm_Menu_Flutuante : Form
    {
        public Frm_Menu_Flutuante()
        {
            InitializeComponent();
        }

        private void Frm_Menu_Flutuante_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                var menuFlutuante = new ContextMenuStrip();
                var menuItem1 = CriaItemMenu("Menu 1", "key");
                var menuItem2 = CriaItemMenu("Menu 2", "Frm_ValidaSenha");
                //menuItem1.DropDownItems.Add("Menu 1.1");
                //menuItem1.DropDownItems.Add("Menu 1.2");
                menuFlutuante.Items.Add(menuItem1);
                menuFlutuante.Items.Add(menuItem2);
                //menuFlutuante.Items.Add(CriaItemMenu("Menu 3"));
                menuFlutuante.Show(this, new Point(e.X, e.Y));
                menuItem1.Click += new EventHandler(menuItem1_Click);
                menuItem2.Click += new EventHandler(menuItem2_Click);
            }
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliquei no Menu 1");
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliquei no Menu 2");
        }

        private ToolStripMenuItem CriaItemMenu(string texto, string imagem)
        {
            var itemMenu = new ToolStripMenuItem();
            itemMenu.Text = texto;

            Image MyImage = (Image) Properties.Resources.ResourceManager.GetObject(imagem);
            itemMenu.Image = MyImage;

            return itemMenu;
        }
    }
}
