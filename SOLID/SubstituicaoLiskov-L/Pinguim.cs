
namespace SubstituicaoLiskov_L
{
    public class Pinguim : Ave 
    {
        public override void Mover() => Console.WriteLine("Andando...");//override sobre escreve o metodo
        
        public override void Dormir() => Console.WriteLine("Pinguim dormindo...");
}

}