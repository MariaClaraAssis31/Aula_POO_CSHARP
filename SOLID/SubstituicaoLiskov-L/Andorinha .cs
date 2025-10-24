
namespace SubstituicaoLiskov_L
{
    public class Andorinha : Ave // os ":" estende de Ave 
    {
        public override void Mover() => Console.WriteLine("Voando...");
    }
}