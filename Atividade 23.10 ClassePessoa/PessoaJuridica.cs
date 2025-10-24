
namespace Atividade_23._10_ClassePessoa
{
    public class PessoaJuridica : Pessoa
    {
        public string Cnpj { get; set; } = string.Empty;
        public string RazaoSocial { get; set; } = string.Empty;
        
        public override void PagarImposto()
        {
            Console.WriteLine($"Pessoa Juridica: {RazaoSocial}, CNPJ: {Cnpj} - pagando imposto...");
        }
    }
}