using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CursoWindowsFormsLib
{
    public class Fichario
    {
        //Poderia usar o atributo readonly na declaração das propriedades, se a atribuição do valor for somente no construtor
        public string Diretorio { get; private set; }
        public bool Status { get; private set; }
        public string Mensagem { get; private set; }

        public Fichario(string diretorio)
        {
            try
            {
                this.Status = true;
                if (!Directory.Exists(diretorio))
                {
                    Directory.CreateDirectory(diretorio);
                    this.Mensagem = "Fichário criado com sucesso!"; 
                }
                this.Diretorio = diretorio;

            } catch (Exception ex)
            {
                this.Status = false;
                this.Mensagem = $"Fichário não foi criado! Erro {ex.Message}"; 
            }
        }

        public void Incluir(string id, string clienteVJson)
        {
            this.Status = true;
            try
            {
                string filename = $"{this.Diretorio}\\{id}.json";
                if (File.Exists(filename))
                {
                    this.Status = false;
                    this.Mensagem = $"Não é possível criar a ficha do cliente, pois a mesma já existe. Ficha de ID: {id}.json";
                }
                else
                {
                    File.WriteAllText(filename, clienteVJson);
                    this.Mensagem = $"Ficha do cliente criada com sucesso: {id}.json";
                }
            }
            catch (Exception ex)
            {
                this.Status = false;
                this.Mensagem = $"Erro ao criar ficha do cliente. {ex.Message}";
            }
            
        }

        public string Pesquisar(string id)
        {
            this.Status = true;
            try
            {
                string filename = $"{this.Diretorio}\\{id}.json";
                if (File.Exists(filename))
                {
                    string clienteVJson = File.ReadAllText(filename);
                    return clienteVJson;
                }
                else
                {
                    this.Status = false;
                    this.Mensagem = $"Não foi possível encontrar a ficha do cliente, pois a mesma não existe.";
                }
            }
            catch (Exception ex)
            {
                this.Status = false;
                this.Mensagem = $"Erro ao encontrar a ficha do cliente. {ex.Message}";
            }

            return "";
        }

        public List<string> PesquisarTodos()
        {
            this.Status = true;
            try
            {
                var listaDeFichas = Directory.GetFiles(this.Diretorio, "*.json");
                var fichas = new List<string>();

                foreach (var ficha in listaDeFichas)
                {
                    var conteudo = File.ReadAllText(ficha);
                    fichas.Add(conteudo);
                }
                return fichas;
            }
            catch (Exception ex)
            {
                this.Status = false;
                this.Mensagem = $"Erro ao encontrar as fichas dos clientes. {ex.Message}";
            }

            throw new Exception("Não houve retorno no fichario.");
        }


        public void Excluir(string id)
        {
            this.Status = true;
            try
            {
                string filename = $"{this.Diretorio}\\{id}.json";
                if (File.Exists(filename))
                {
                    File.Delete(filename);
                    this.Mensagem = $"Ficha excluída com sucesso. Ficha do Cliente: {id}";
                }
                else
                {
                    this.Status = false;
                    this.Mensagem = $"Não foi possível excluir a ficha do cliente, pois a mesma não existe.";
                }
            }
            catch (Exception ex)
            {
                this.Status = false;
                this.Mensagem = $"Erro ao excluir a ficha do cliente. {ex.Message}";
            }

        }

        public void Alterar(string id, string clienteVJson)
        {
            this.Status = true;
            try
            {
                string filename = $"{this.Diretorio}\\{id}.json";
                if (!(File.Exists(filename)))
                {
                    this.Status = false;
                    this.Mensagem = $"Não é possível alterar a ficha do cliente, pois a mesma não existe.";
                }
                else
                {
                    File.Delete(filename);
                    File.WriteAllText(filename, clienteVJson);
                    this.Mensagem = $"Ficha {id}.json alterada com sucesso!";
                }
            }
            catch (Exception ex)
            {
                this.Status = false;
                this.Mensagem = $"Erro ao alterar ficha do cliente. {ex.Message}";
            }

        }

    }
}
