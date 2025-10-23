namespace AbertoFechado_O;

class Program
{
    static void Main(string[] args)
    {
        Desconto d1 = new DescontoNatal();
        Desconto d2 = new DescontoBlackFriday();
        
        // :C ou .ToString("C") traz no formatp monetario do sistema 
        Console.WriteLine($"Natal: {d1.Calcular(1000):C}");
        Console.WriteLine($"BlackFriday: {d2.Calcular(1000).ToString("C")}");
        Console.WriteLine($"BlackFriday: {d2.Calcular(2000)}");
    }
}
