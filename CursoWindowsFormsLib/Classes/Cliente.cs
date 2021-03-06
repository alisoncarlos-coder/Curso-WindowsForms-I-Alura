using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using CursoWindowsFormsLib.Databases;

namespace CursoWindowsFormsLib.Classes
{
    public class Cliente
    {
        public class Unit
        {
            [Required(ErrorMessage = "Código do Cliente é obrigatório.")]
            [RegularExpression("([0-9]+)", ErrorMessage = "Código do Cliente somente aceita valores numéricos.")]
            [StringLength(6, MinimumLength = 6, ErrorMessage = "Código do Cliente deve ter 6 dígitos.")]
            public string Id { get; set; }

            [Required(ErrorMessage = "Nome do Cliente é obrigatório.")]
            [StringLength(50, ErrorMessage = "Nome do Cliente deve ter no máximo 50 caracteres.")]
            public string Nome { get; set; }

            [StringLength(50, ErrorMessage = "Nome do Pai deve ter no máximo 50 caracteres.")]
            public string NomePai { get; set; }

            [Required(ErrorMessage = "Nome da Mãe é obrigatório.")]
            [StringLength(50, ErrorMessage = "Nome da Mãe deve ter no máximo 50 caracteres.")]
            public string NomeMae { get; set; }

            public bool NaoTemPai { get; set; }

            [Required(ErrorMessage = "CPF obrigatório.")]
            [RegularExpression("([0-9]+)", ErrorMessage = "CPF somente aceita valores numéricos.")]
            [StringLength(11, MinimumLength = 11, ErrorMessage = "CPF deve ter 11 dígitos.")]
            public string Cpf { get; set; }

            [Required(ErrorMessage = "Genero obrigatório.")]
            public int Genero { get; set; }

            [Required(ErrorMessage = "CEP obrigatório.")]
            [RegularExpression("([0-9]+)", ErrorMessage = "CEP somente aceita valores numéricos.")]
            [StringLength(8, MinimumLength = 8, ErrorMessage = "CEP deve ter 8 dígitos.")]
            public string Cep { get; set; }

            [Required(ErrorMessage = "Logradouro é obrigatório.")]
            [StringLength(100, ErrorMessage = "Logradouro deve ter no máximo 100 caracteres.")]
            public string Logradouro { get; set; }

            [Required(ErrorMessage = "Complemento é obrigatório.")]
            [StringLength(100, ErrorMessage = "Complemento deve ter no máximo 100 caracteres.")]
            public string Complemento { get; set; }

            [Required(ErrorMessage = "Bairro é obrigatório.")]
            [StringLength(50, ErrorMessage = "Bairro deve ter no máximo 50 caracteres.")]
            public string Bairro { get; set; }

            [Required(ErrorMessage = "Cidade é obrigatória.")]
            [StringLength(50, ErrorMessage = "Cidade deve ter no máximo 50 caracteres.")]
            public string Cidade { get; set; }

            [Required(ErrorMessage = "Estado é obrigatório.")]
            [StringLength(50, ErrorMessage = "Estado deve ter no máximo 50 caracteres.")]
            public string Estado { get; set; }

            [Required(ErrorMessage = "Número do telefone é obrigatório.")]
            [RegularExpression("([0-9]+)", ErrorMessage = "Número do telefone somente aceita valores numéricos.")]
            public string Telefone { get; set; }

            public string Profissao { get; set; }

            [Required(ErrorMessage = "Renda familiar é obrigatória.")]
            [Range(0, double.MaxValue, ErrorMessage = "Renda familiar deve ser um valor positivo.")]
            public Double RendaFamiliar { get; set; }
            public void ValidaClass()
            {
                ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null);
                List<ValidationResult> results = new List<ValidationResult>();
                bool isValid = Validator.TryValidateObject(this, context, results, true);

                if (isValid == false)
                {
                    StringBuilder sbrErrors = new StringBuilder();
                    foreach (var validationResult in results)
                    {
                        sbrErrors.AppendLine(validationResult.ErrorMessage);
                    }
                    throw new ValidationException(sbrErrors.ToString());
                }
            }

            public void ValidaComplemento()
            {
                if (this.NomePai == this.NomeMae)
                {
                    throw new Exception("Nome do Pai e da Mãe não podem ser iguais.");
                }
                if (this.NaoTemPai == false)
                {
                    if (this.NomePai == "")
                    {
                        throw new Exception("Nome do Pai não pode estar vazio quando a propriedade Pai Desconhecido não estiver marcada.");
                    }
                }
                bool validaCPF = Utilitarios.Valida(this.Cpf);
                if (validaCPF == false)
                {
                    throw new Exception("CPF inválido.");
                }
            }

            #region Operacao CRUD
            public void IncluirFichario(string conexao)
            {
                string clienteJSON = Cliente.SerializedClassUnit(this);
                Fichario f = new Fichario(conexao);
                if (f.Status)
                {
                    f.Incluir(this.Id, clienteJSON);
                    if (!f.Status)
                    {
                        throw new Exception(f.Mensagem);
                    }
                }
                else
                {
                    throw new Exception(f.Mensagem);
                }
            }

            public Unit PesquisarFichario(string id, string conexao)
            {
                Fichario f = new Fichario("C:\\Users\\aliso\\Source\\Repos\\Curso-WindowsForms-I-Alura\\Fichario");
                if (f.Status)
                {
                    string clienteJSON = f.Pesquisar(id);
                    if (!f.Status)
                    {
                        throw new Exception(f.Mensagem);
                    }

                    return Cliente.DesSerializedClassUnit(clienteJSON);
                }
                else
                {
                    throw new Exception(f.Mensagem);
                }
            }

            public void AlterarFichario(string conexao)
            {
                string clienteJSON = Cliente.SerializedClassUnit(this);
                Fichario f = new Fichario("C:\\Users\\aliso\\Source\\Repos\\Curso-WindowsForms-I-Alura\\Fichario");
                if (f.Status)
                {
                    f.Alterar(this.Id, clienteJSON);
                    if (!f.Status)
                    {
                        throw new Exception(f.Mensagem);
                    }
                }
                else
                {
                    throw new Exception(f.Mensagem);
                }
            }

            public void ExcluirFichario(string conexao)
            {
                Fichario f = new Fichario("C:\\Users\\aliso\\Source\\Repos\\Curso-WindowsForms-I-Alura\\Fichario");
                if (f.Status)
                {
                    f.Excluir(this.Id);
                    if (!(f.Status))
                    {
                        throw new Exception(f.Mensagem);
                    }
                }
                else
                {
                    throw new Exception(f.Mensagem);
                }
            }

            public List<string> PesquisarTodosFichario(string conexao)
            {
                Fichario f = new Fichario(conexao);
                if (f.Status)
                {
                    var lista = new List<string>();
                    try
                    {
                        lista = f.PesquisarTodos();
                        if (!f.Status)
                        {
                            throw new Exception(f.Mensagem);
                        }
                        return lista;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(f.Mensagem);
                    }
                }
                else
                {
                    throw new Exception(f.Mensagem);
                }

            }

            #endregion 

        }

        public class List
        {
            public List<Unit> ListUnit { get; set; }
        }

        public static string SerializedClassUnit(Unit unit)
        {
            return JsonConvert.SerializeObject(unit);
        }

        public static Unit DesSerializedClassUnit(string vJson)
        {
            return JsonConvert.DeserializeObject<Unit>(vJson);
        }
    }
}
