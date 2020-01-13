using System;

namespace Opgave2
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Terningespil:");
                Console.WriteLine("Hvor mange terninger ønsker du? (min 1, max 6)");
                string input = Console.ReadLine();
                int.TryParse(input, out int dices);
                if(dices >= 1 && dices <= 6)
                {
                    Random generator = new Random();
                    Console.WriteLine("Hvor mange sider skal terningerne have? (min 2, max 10)");
                    input = Console.ReadLine();
                    int.TryParse(input, out int sides);
                    if(sides >= 2 && sides <= 10)
                    {
                        for(int i = 0; i < dices; i++)
                        {
                            int dice = generator.Next(1, sides + 1);
                            Console.WriteLine($"Du slog: '{dice}' med {i + 1}. terning");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Du valgte et ugyldigt antal sider! prøv igen");
                    }
                }
                else
                {
                    Console.WriteLine("Du valgte et ugyldigt antal terninger! prøv igen");

                }
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
