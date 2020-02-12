using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Losování čísel sportky";
            RandomGenerator gen = new RandomGenerator();

            while (true)
            {
                Console.Write("Zadejte počet polí: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int num))
                {
                    if (num > 100)
                        num = 100;
                    else if (num <= 0)
                        num = 1;

                    Console.WriteLine("------------------------");

                    for (int i = 0; i < num; i++)
                    {
                        Console.WriteLine(string.Format("{0,3}: {1}", i + 1, gen.GenerateField()));
                    }

                    Console.WriteLine("------------------------");
                    Console.WriteLine("Šance: " + gen.GenerateChance());
                }
                else
                {
                    Console.WriteLine("Nezadali jste platné číslo.");
                }

                Console.WriteLine("");

                while (true)
                {
                    Console.WriteLine("");
                    Console.Write("Chcete začít znovu? A/N: ");

                    var key = Console.ReadKey().Key;

                    if (key == ConsoleKey.A)
                    {
                        Console.Clear();
                        break;
                    }
                    else if (key == ConsoleKey.N)
                        Environment.Exit(0);
                }
            }
        }
    }
}
