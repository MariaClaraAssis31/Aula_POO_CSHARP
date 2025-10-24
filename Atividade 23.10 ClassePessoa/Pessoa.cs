
namespace Atividade_23._10_ClassePessoa
{
    public abstract class Pessoa
    {
        public string Nome { get; set; } = string.Empty; //Empty preenche com vazio ao inves de nulo 
       
        public List<Endereco> Enderecos { get; } = new List<Endereco>();

        public abstract void PagarImposto();

        public void Adicionarendereco(Endereco parametro_endereco)
        {
            Enderecos.Add(parametro_endereco);
        }
    }
}
