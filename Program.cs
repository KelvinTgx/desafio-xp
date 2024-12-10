namespace ProjetoXp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá Herói");
        Console.WriteLine("Qual seu nome?");

        string? nome = Console.ReadLine();

        int xp;
        bool xpValido = false;

        while (!xpValido)
        {
            Console.WriteLine($"Olá {nome} quanto de xp você tem ?");
            string? entradaXp = Console.ReadLine();

            if (int.TryParse(entradaXp,out xp))
            {
                xpValido = true;

                if (xp >=100);
                {
                    Console.WriteLine("Rank:Ferro");
                }
            }
            else
            {
                Console.WriteLine("Entrada de XP inválida! Por favor, incira um número.");
            }
            
        }
    }
}
