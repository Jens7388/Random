using System;

namespace Opgave4
{
    class Program
    {
        static void Main(string[] args)
        {
            int highScore = 99999;    
            int userNumber = 0;
            int correctNumber = 0;
            //Når brugeren svarer rigtigt genstarter programmet
            while(userNumber == correctNumber)
            {
                int guesses = 0;
                Random generator = new Random();
                Console.WriteLine($"Dagens bedste score er: {highScore} gæt");
                Console.WriteLine("Hvor stort et interval ønsker du at gætte i? (minimum 10): ");
                string input = Console.ReadLine();
                int.TryParse(input, out int intervalSize);
                if(intervalSize >= 10)
                {
                    correctNumber = generator.Next(0, intervalSize);
                    Console.Write($"Gæt et tal mellem 0 og {intervalSize}: ");
                    //Bliv ved med at bede om det rigtige svar indtil at brugeren svarer rigtigt
                    while(userNumber != correctNumber)
                    {
                        input = Console.ReadLine();
                        int.TryParse(input, out userNumber);
                        if(userNumber == correctNumber)
                        {
                            Console.WriteLine($"Korrekt! Din score er {guesses} gæt");
                            if(highScore > guesses)
                            {
                                highScore = guesses;
                            }
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            Console.Write("Forkert! Prøv igen: ");
                            guesses++;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Ugyldig størrelse på intervallet! Prøv igen");
                }
            }
        }
    }
}
