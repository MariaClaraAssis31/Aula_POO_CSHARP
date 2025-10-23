
namespace Atividade4_Comparacao
{
    public class Programador : Funcionario, ITrabalhador
    {
        public override void Trabalhar() => Console.WriteLine($"{Nome} esta programando...");

        public void ExecutarTarefa() => Console.WriteLine($"{Nome} concluiu uma tarefa.");
    }
    //nao posso criar objeto a partir de classe abstrata
    //Funcinario f = Funcionario {Nome = "Guilherme"};
    //f.Trabalhar();
}