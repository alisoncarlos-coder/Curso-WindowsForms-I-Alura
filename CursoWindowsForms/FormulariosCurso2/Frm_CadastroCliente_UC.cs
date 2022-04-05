using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using CursoWindowsFormsLib.Classes;
using Microsoft.VisualBasic;
using CursoWindowsFormsLib;


namespace CursoWindowsForms
{
    public partial class Frm_CadastroCliente_UC : UserControl
    {
        public Frm_CadastroCliente_UC()
        {
            InitializeComponent();

            Grp_Codigo.Text = "Código";
            Grp_DadosPessoais.Text = "Dados Pessoais";
            Grp_Endereco.Text = "Endereço";
            Grp_Outros.Text = "Outros";
            Lbl_Bairro.Text = "Bairro";
            Lbl_CEP.Text = "CEP";
            Lbl_Complemento.Text = "Complemento";
            Lbl_CPF.Text = "CPF";
            Lbl_Estado.Text = "Estado";
            Lbl_Logradouro.Text = "Logradouro";
            Lbl_NomeCliente.Text = "Nome";
            Lbl_NomeMae.Text = "Nome da Mãe";
            Lbl_NomePai.Text = "Nome do Pai";
            Lbl_Profissao.Text = "Profissão";
            Lbl_RendaFamiliar.Text = "Renda Familiar";
            Lbl_Telefone.Text = "Telefone";
            Lbl_Cidade.Text = "Cidade";
            Chk_TemPai.Text = "Pai desconhecido";
            Rdb_Masculino.Text = "Masculino";
            Rdb_Feminino.Text = "Feminino";
            Rdb_Indefinido.Text = "Indefinido";
            Grp_Genero.Text = "Genero";

            Cmb_Estados.Items.Clear();
            Cmb_Estados.Items.Add("Acre (AC)");
            Cmb_Estados.Items.Add("Alagoas(AL)");
            Cmb_Estados.Items.Add("Amapá(AP)");
            Cmb_Estados.Items.Add("Amazonas(AM)");
            Cmb_Estados.Items.Add("Bahia(BA)");
            Cmb_Estados.Items.Add("Ceará(CE)");
            Cmb_Estados.Items.Add("Distrito Federal(DF)");
            Cmb_Estados.Items.Add("Espírito Santo(ES)");
            Cmb_Estados.Items.Add("Goiás(GO)");
            Cmb_Estados.Items.Add("Maranhão(MA)");
            Cmb_Estados.Items.Add("Mato Grosso(MT)");
            Cmb_Estados.Items.Add("Mato Grosso do Sul(MS)");
            Cmb_Estados.Items.Add("Minas Gerais(MG)");
            Cmb_Estados.Items.Add("Pará(PA)");
            Cmb_Estados.Items.Add("Paraíba(PB)");
            Cmb_Estados.Items.Add("Paraná(PR)");
            Cmb_Estados.Items.Add("Pernambuco(PE)");
            Cmb_Estados.Items.Add("Piauí(PI)");
            Cmb_Estados.Items.Add("Rio de Janeiro(RJ)");
            Cmb_Estados.Items.Add("Rio Grande do Norte(RN)");
            Cmb_Estados.Items.Add("Rio Grande do Sul(RS)");
            Cmb_Estados.Items.Add("Rondônia(RO)");
            Cmb_Estados.Items.Add("Roraima(RR)");
            Cmb_Estados.Items.Add("Santa Catarina(SC)");
            Cmb_Estados.Items.Add("São Paulo(SP)");
            Cmb_Estados.Items.Add("Sergipe(SE)");
            Cmb_Estados.Items.Add("Tocantins(TO)");

            tls_Principal.Items[0].ToolTipText = "Adicionar um cliente novo";
            tls_Principal.Items[1].ToolTipText = "Encontrar um cliente";
            tls_Principal.Items[2].ToolTipText = "Salvar o cliente que está cadastrando";
            tls_Principal.Items[3].ToolTipText = "Excluir o cliente";
            tls_Principal.Items[4].ToolTipText = "Limpar o formulário de cadastro";


            btn_pesquisar.Text = "Pesquisar";
        }


        private void limpaFormulario()
        {
            Txt_Bairro.Text = "";
            Txt_CEP.Text = "";
            Txt_Complemento.Text = "";
            Txt_CPF.Text = "";
            Cmb_Estados.SelectedIndex = -1;
            Txt_Codigo.Text = "";
            Txt_Logradouro.Text = "";
            Txt_NomeCliente.Text = "";
            Txt_NomeMae.Text = "";
            Txt_NomePai.Text = "";
            Txt_Profissao.Text = "";
            Txt_RendaFamiliar.Text = "";
            Txt_Telefone.Text = "";
            Txt_Cidade.Text = "";
            Chk_TemPai.Checked = false;
            Rdb_Masculino.Checked = true;
        }


        private void Chk_TemPai_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_TemPai.Checked)
            {
                Txt_NomePai.Enabled = false;
            }
            else
            {
                Txt_NomePai.Enabled = true;
            }
        }

        #region Operacao CRUD
        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente.Unit c = new Cliente.Unit();
                c = LeituraFormulario();
                c.ValidaClass();
                c.ValidaComplemento();
                c.IncluirFichario("C:\\Users\\aliso\\Source\\Repos\\Curso-WindowsForms-I-Alura\\Fichario");
                MessageBox.Show("Cliente incluído com sucesso!", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            if (Txt_Codigo.Text == "")
            {
                MessageBox.Show($"Código do cliente não pode ser vazio!", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Cliente.Unit c = new Cliente.Unit();
                try
                {
                    c = c.PesquisarFichario(Txt_Codigo.Text, "C:\\Users\\aliso\\Source\\Repos\\Curso-WindowsForms-I-Alura\\Fichario");
                    if (c != null)
                    {
                        EscreveFormulario(c);
                    }
                    else
                    {
                        MessageBox.Show($"Não foi possível localizar o cliente, pois o código {Txt_Codigo.Text} não existe", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"ERROR: {ex.Message}", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    limpaFormulario();
                }
            }
        }

        private void deletaToolStripButton_Click(object sender, EventArgs e)
        {
            if (Txt_Codigo.Text == "")
            {
                MessageBox.Show($"Código do cliente não pode ser vazio!", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Cliente.Unit c = new Cliente.Unit();
                try
                {
                    c = c.PesquisarFichario(Txt_Codigo.Text, "C:\\Users\\aliso\\Source\\Repos\\Curso-WindowsForms-I-Alura\\Fichario");
                    if (c == null)
                    {
                        MessageBox.Show($"Não foi possível localizar o cliente, pois o código {Txt_Codigo.Text} não existe", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        EscreveFormulario(c);
                    }

                    var questionaExlusao = new Frm_Questao("ExcluirBarra", "Deseja excluir o cliente?");
                    questionaExlusao.ShowDialog();
                    if (questionaExlusao.DialogResult == DialogResult.Yes)
                    {
                        c.ExcluirFichario("C:\\Users\\aliso\\Source\\Repos\\Curso-WindowsForms-I-Alura\\Fichario");
                        limpaFormulario();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"ERROR: {ex.Message}", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    limpaFormulario();
                }
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (Txt_Codigo.Text == "")
            {
                MessageBox.Show($"Código do cliente não pode ser vazio!", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Cliente.Unit c = new Cliente.Unit();
                    c = LeituraFormulario();
                    c.ValidaClass();
                    c.ValidaComplemento();
                    c.AlterarFichario("C:\\Users\\aliso\\Source\\Repos\\Curso-WindowsForms-I-Alura\\Fichario");
                }
                catch (ValidationException ex)
                {
                    MessageBox.Show(ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            Cliente.Unit c = new Cliente.Unit();
            var lista = new List<string>();
            try
            {
                lista = c.PesquisarTodosFichario("C:\\Users\\aliso\\Source\\Repos\\Curso-WindowsForms-I-Alura\\Fichario");
                if (lista == null || lista.Count == 0)
                {
                    MessageBox.Show("Não existe registros nos fichario!", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    limpaFormulario();
                }
                else
                {
                    var listaBusca = new List<List<string>>();
                    foreach (var item in lista)
                    {
                        c = Cliente.DesSerializedClassUnit(item);
                        listaBusca.Add(new List<string> { c.Id, c.Nome });
                    }

                    Frm_Busca frmBusca = new Frm_Busca(listaBusca);
                    frmBusca.ShowDialog();
                    if (frmBusca.DialogResult == DialogResult.OK)
                    {
                        try
                        {
                            var idSelecionado = frmBusca.idSelecionado;
                            c = c.PesquisarFichario(idSelecionado, "C:\\Users\\aliso\\Source\\Repos\\Curso-WindowsForms-I-Alura\\Fichario");
                            if (c == null)
                            {
                                MessageBox.Show($"Não existe a ficha {idSelecionado} !", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                EscreveFormulario(c);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"ERROR: {ex.Message}", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            limpaFormulario();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERR " + ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion

        Cliente.Unit LeituraFormulario()
        {
            Cliente.Unit C = new Cliente.Unit();
            C.Id = Txt_Codigo.Text;
            C.Nome = Txt_NomeCliente.Text;
            C.NomeMae = Txt_NomeMae.Text;
            C.NomePai = Txt_NomePai.Text;
            if (Chk_TemPai.Checked)
            {
                C.NaoTemPai = true;
            }
            else
            {
                C.NaoTemPai = false;
            }
            if (Rdb_Masculino.Checked)
            {
                C.Genero = 0;
            }
            if (Rdb_Feminino.Checked)
            {
                C.Genero = 1;
            }
            if (Rdb_Indefinido.Checked)
            {
                C.Genero = 2;
            }
            C.Cpf = Txt_CPF.Text;

            C.Cep = Txt_CEP.Text;
            C.Logradouro = Txt_Logradouro.Text;
            C.Complemento = Txt_Complemento.Text;
            C.Cidade = Txt_Cidade.Text;
            C.Bairro = Txt_Bairro.Text;

            if (Cmb_Estados.SelectedIndex < 0)
            {
                C.Estado = "";
            }
            else
            {
                C.Estado = Cmb_Estados.Items[Cmb_Estados.SelectedIndex].ToString();
            }

            C.Telefone = Txt_Telefone.Text;
            C.Profissao = Txt_Profissao.Text;

            if (Information.IsNumeric(Txt_RendaFamiliar.Text))
            {
                Double vRenda = Convert.ToDouble(Txt_RendaFamiliar.Text);
                if (vRenda < 0)
                {
                    C.RendaFamiliar = 0;
                }
                else
                {
                    C.RendaFamiliar = vRenda;
                }
            }
            return C;
        }

        private void Txt_CEP_Leave(object sender, EventArgs e)
        {
            string vCep = Txt_CEP.Text;
            if (vCep != "")
            {
                if (vCep.Length == 8)
                {
                    if (Information.IsNumeric(vCep))
                    {
                        var vJson = Utilitarios.GeraJSONCEP(vCep);
                        Cep.Unit CEP = new Cep.Unit();
                        CEP = Cep.DesSerializedClassUnit(vJson);
                        Txt_Logradouro.Text = CEP.logradouro;
                        Txt_Bairro.Text = CEP.bairro;
                        Txt_Cidade.Text = CEP.localidade;

                        Cmb_Estados.SelectedIndex = -1;
                        for (int i = 0; i <= Cmb_Estados.Items.Count - 1; i++)
                        {
                            var vPos = Strings.InStr(Cmb_Estados.Items[i].ToString(), "(" + CEP.uf + ")");
                            if (vPos > 0)
                            {
                                Cmb_Estados.SelectedIndex = i;
                            }
                        }
                    }
                }
            }
        }

        private void limpaToolStripButton_Click(object sender, EventArgs e)
        {
            limpaFormulario();
        }

        private void EscreveFormulario(Cliente.Unit c)
        {
            Txt_Codigo.Text = c.Id;
            Txt_NomeCliente.Text = c.Nome;
            Txt_NomeMae.Text = c.NomeMae;
            if (c.NaoTemPai == true)
            {
                Chk_TemPai.Checked = true;
                Txt_NomePai.Text = "";
            }
            else
            {
                Chk_TemPai.Checked = false;
                Txt_NomePai.Text = c.NomePai;
            }

            if (c.Genero == 0)
            {
                Rdb_Masculino.Checked = true;
            }
            if (c.Genero == 1)
            {
                Rdb_Feminino.Checked = true;
            }
            if (c.Genero == 2)
            {
                Rdb_Indefinido.Checked = true;
            }

            Txt_CPF.Text = c.Cpf;
            Txt_CEP.Text = c.Cep;
            Txt_Logradouro.Text = c.Logradouro;
            Txt_Complemento.Text = c.Complemento;
            Txt_Cidade.Text = c.Cidade;
            Txt_Bairro.Text = c.Bairro;

            if (c.Estado == "")
            {
                Cmb_Estados.SelectedIndex = -1;
            }
            else
            {
                for (int i = 0; i < Cmb_Estados.Items.Count - 1; i++)
                {
                    if (c.Estado == Cmb_Estados.Items[i].ToString())
                    {
                        Cmb_Estados.SelectedIndex = i;
                    }
                }
            }

            Txt_Telefone.Text = c.Telefone;
            Txt_Profissao.Text = c.Profissao;

            Txt_RendaFamiliar.Text = c.RendaFamiliar.ToString();

        }
    }
}
