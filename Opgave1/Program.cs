using System;

namespace Opgave1
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Tryk enter for at generere nye tal\n");
                Random generator = new Random();
                Console.WriteLine("5 tilfældige tal fra 0-9:");
                for(int i = 0; i < 5; i++)
                {
                    //Sidste tal i rækken tæller IKKE med!
                    int firstRandomNumber = generator.Next(0, 10);
                    Console.WriteLine(firstRandomNumber);
                }
                Console.WriteLine("\n5 tilfældige tal fra -10-10");
                for(int i = 0; i < 5; i++)
                {
                    int secondRandomNumber = generator.Next(-10, 11);
                    Console.WriteLine(secondRandomNumber);
                }
                Console.WriteLine("\n5 tilfældige tal fra 0.0-0.9");
                for(int i = 0; i < 5; i++)
                {
                    double thirdRandomNumber = generator.NextDouble();
                    Console.WriteLine(thirdRandomNumber);
                }
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
