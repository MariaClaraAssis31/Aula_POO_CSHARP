
namespace SubstituicaoLiskov_L
{
    public abstract class Ave
    {
        public abstract void Mover();

        public virtual void Dormir() => Console.WriteLine("Dormindo...");
    }
}
//classe abstrata pode ter varios metodos e atributos 
//tudo que ela colocar ali dentro, ela consegue abstrair 