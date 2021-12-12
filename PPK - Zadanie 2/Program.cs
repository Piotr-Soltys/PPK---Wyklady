using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPK___Zadanie_2
{
    internal class Program
    {
        static void Main()
        {
            Start:
            UInt64 silnia = 1;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" *** Program wyznaczający wartość n! ***\n\n");
            Console.ResetColor();
            Console.WriteLine(" Wybierz metodę obliczeń\n");
            Console.WriteLine(" 1. Metoda Rekurencyjna");
            Console.WriteLine(" 2. Metoda Iteracyjna\n");
            Console.Write(" Twój wybór: ");
            string wybor = Console.ReadLine();

            UInt64 n;

            switch (wybor)
            {
                case "1": 
                    n = PobieranieWartosci();
                    MetodaRekurencyjna(n);
                    break;
                case "2": 
                    n = PobieranieWartosci();
                    MetodaIteracyjna(n);
                    break;
                default: 
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" Nieprawidłowy wybór metody");
                    Console.ResetColor();
                    Console.ReadKey();
                    goto Start;
            }

            UInt64 PobieranieWartosci()
            {
                PobieranieWartosci:

                Console.Clear();
                Console.Write("\n\n Podaj wartość n: ");
                try
                {
                    UInt64 liczba = Convert.ToUInt32(Console.ReadLine());
                    return liczba;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" Nieprawidłowa wartość");
                    Console.ResetColor();
                    Console.ReadKey();
                    goto PobieranieWartosci;
                }
            }

            UInt64 MetodaRekurencyjna(UInt64 a)
            {
                if (a <= 1)
                {
                    silnia = 1;
                }
                else
                {
                    silnia = a * MetodaRekurencyjna(a - 1);
                    
                }
                return silnia;
            }

            UInt64 MetodaIteracyjna(UInt64 a)
            {
                for(UInt64 i = 1; i <= a; i++)
                {
                    silnia *= i;
                }
                return silnia;
            }


            Console.WriteLine($"\n\n Wartość {n}! wynosi {silnia}");

            Console.ReadKey();

            Console.Clear();
            goto Start;
        }
    }
}
