namespace Atividade_23._10_ClassePessoa;

class Program
{
    static void Main(string[] args)
    {
      PessoaFisica pf = new PessoaFisica
      {
        Nome = "Ana Silva",
        Cpf = "123.456.789-00",
        DataNascimento = new DateTime(1995, 4, 2)
      };

      pf.Adicionarendereco(new Endereco
      {
        Rua = "Rua das Flores",
        Numero = 100,
        Cidade = "Sao Paulo",
        Estado = "SP",
        Cep = "01000-000",
        Comercial = false
      });

       PessoaJuridica pj = new PessoaJuridica
       {
        Nome = "Loja Exemplo",
        RazaoSocial = "Loja Exemplo LTDA",
        Cnpj = "12.345.678/0001-09"
       };

       pj.Adicionarendereco(new Endereco
       {
        Rua = "Av.Central",
        Numero = 200,
        Cidade = "Campinas",
        Estado = "SP",
        Cep = "13000-000",
        Comercial = true
       });

       pf.PagarImposto();
       pj.PagarImposto();

    }
}
