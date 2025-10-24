
namespace Atividade_23._10_ClassePessoa
{
    public class PessoaFisica : Pessoa
    {
        public string Cpf { get; set; } = string.Empty;
        public DateTime DataNascimento { get; set; } 
        public override void PagarImposto()
        {
           Console.WriteLine($"Pessoa fisica: {Nome}, CPF: {Cpf} - pagando imposto...");
        }
    }
}