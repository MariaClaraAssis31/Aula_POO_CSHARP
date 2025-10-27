
namespace Atividade_27._10

{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoPublicacao { get; set; }
        // {
        //   get
        // {
        //   return AnoPublicacao;
        //  }
        //  set
        //  {
        //     if(value > 0)
        //     {
        //          AnoPublicacao = value;
        //    }

        //     else
        //    {
        //      Console.WriteLine("Erro!Ano de publicacao invalido");
        //  }
        // }
        //}
        public double Preco { get; set; }
        public bool EstaDisponivel { get; set; } = true;

        //Construtor
        //e um metodo especial, usado para inicializar o estado do objeto 

        public Livro(string tituloConstrutor, string autorConstrutor, int anoConstrutor, double precoConstrutor)
        {
           //this.Titulo = titulo
            Titulo = tituloConstrutor;
            Autor = autorConstrutor;
            AnoPublicacao = anoConstrutor;
            Preco = precoConstrutor;

            //definindo valor incial como true 
            EstaDisponivel = true;

            Console.WriteLine($"Novo livro: {tituloConstrutor} criado e disponivel");
        }
        public void ExibirDetalhes()
        {
            Console.WriteLine("***DETALHES DO LIVRO***");
            Console.WriteLine($"Titulo: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Publicacao: {AnoPublicacao}");
            Console.WriteLine($"Preco:  {Preco:F2}"); //F2 formata com duas casas decimais

            if (EstaDisponivel)
            {
                Console.WriteLine("Status: Disponivel para emprestimo");
            }

            else
            {
                Console.WriteLine("Status: Emprestado!(indisponivel)");
            }
        }

        public void Emprestar()
        {
            if (EstaDisponivel)
            {
                EstaDisponivel = false;
                Console.WriteLine($"O livro {Titulo} foi emprestado.");
            }

            else
            {
                Console.WriteLine($"O livro {Titulo} ja esta emprestado.");
            }
        }
    }
}
