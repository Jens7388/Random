using System;
using System.Linq;

namespace Opgave3
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Se gennemsnit, højeste tal og laveste tal af 10001 tilfældigt genererede tal mellem -100 og 100:");
                int[] numbers = new int[10001];
                Random generator = new Random();
                double sum = 0;
                for(int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = generator.Next(-100, 101);
                    sum += numbers[i];
                }
                double average = sum / numbers.Length;
                int highestNumber = numbers.Max();
                int lowestNumber = numbers.Min();
                /* // Find højeste og laveste tal med en løkke
                int highestNumber = numbers[0];
                int lowestNumber = numbers[0];
                foreach(int value in numbers)
                {
                    if(value > highestNumber)
                    {
                        highestNumber = value;
                    }
                    else if(value < lowestNumber)
                    {
                        lowestNumber = value;
                    }
                }*/
                Console.WriteLine($"Gennemsnit: {average:f}");
                Console.WriteLine($"Største tal: {highestNumber}");
                Console.WriteLine($"Mindste tal: {lowestNumber}");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
