
namespace Atividade2_ClasseAbstrata
{
    public abstract class Forma
    {
        //metodo abstrato obriga a classe filha a implementar o metodo
        //e sobreviver (override)
        public abstract double CalcularArea();

        public void MostrarTipo()
        {
            Console.WriteLine("Sou uma forma geométrica.");
        }
    }
}