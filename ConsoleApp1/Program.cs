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
            Random generator = new Random();
            int proposition = 0;
            int randomNumber = generator.Next(1, 101);
            Console.WriteLine("Wylosowano liczbe od 1 do 100. \n Odganij ja :");

#if(DEBUG)
            Console.WriteLine(randomNumber);
#endif
            Console.Write("Podaj swoja propozycje :");
            String text = Console.ReadLine();

            try
            {
                proposition = Convert.ToInt32(text);
            }
            catch(OverflowException)
            {
                Console.WriteLine("Prosze podac liczbe !");
            }
            catch(FormatException)
            {
                Console.WriteLine("Liczba poza przedzialem");
            }
            Console.WriteLine($"Podales wartosc : {proposition}");

            if (randomNumber > proposition)
                Console.WriteLine("Za malo");
            else if(randomNumber<proposition)
                Console.WriteLine("Za duzo");
            else
                Console.WriteLine("Trafiono");

            Console.WriteLine("Dzieki za gre");
            

        }
    }
}
