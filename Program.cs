using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doga_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pozitivOsszeg = 0;
            int negativOsszeg = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Kérem, adjon meg egy egész számot ({i + 1}/10): ");
                int szam = int.Parse(Console.ReadLine());

                if (szam > 0)
                {
                    pozitivOsszeg += szam; 
                }
                else if (szam < 0)
                {
                    negativOsszeg += szam; 
                }
                
            }

            Console.WriteLine($"A pozitív számok összege: {pozitivOsszeg}");
            Console.WriteLine($"A negatív számok összege: {negativOsszeg}");
        }
    }
}
