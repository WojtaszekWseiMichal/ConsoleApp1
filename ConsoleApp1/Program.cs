using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj !");
            Console.Write("Podaj swoje imie : ");
            string x = Console.ReadLine();
            Console.WriteLine($"Witaj, {x}");

            Random generator = new Random();
            int randomNumber = generator.Next(1, 101);
            Console.WriteLine("Wylosowano liczbe od 1 do 100. \n Odganij ja :");
        }
    }
}
