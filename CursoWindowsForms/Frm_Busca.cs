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
    public partial class Frm_Busca : Form
    {
        public List<List<string>> _listaBusca { get; private set; }

        public string idSelecionado { get; set; }

        public Frm_Busca(List<List<string>> listaBusca)
        {
            this._listaBusca = listaBusca;
            InitializeComponent();
            tls_menuPesquisa.Items[0].ToolTipText = "Salvar cliente selecionado";
            tls_menuPesquisa.Items[1].ToolTipText = "Sair da seleção de cliente";
            PreencherLista();
            lst_Clientes.Sorted = true;
        }

        private void PreencherLista()
        {
            lst_Clientes.Items.Clear();
            foreach (var item in this._listaBusca)
            {
                var itemBox = new ItemBox();
                itemBox.id = item[0];
                itemBox.nome = item[1];
                lst_Clientes.Items.Add(itemBox);
            }
        }

        public class ItemBox
        {
            public string id { get; set; }
            public string nome { get; set; }

            public override string ToString()
            {
                return this.nome;
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            ItemBox itemSelecionado = (ItemBox)lst_Clientes.Items[lst_Clientes.SelectedIndex];
            this.idSelecionado = itemSelecionado.id;
            this.Close();
        }

        private void deletaToolStripButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
