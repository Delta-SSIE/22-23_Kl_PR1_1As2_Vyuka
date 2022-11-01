using System.Runtime.CompilerServices;

namespace _03_While_01_Kladne_cislo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cislo = 0;

            while (cislo <= 0) 
            { 
                Console.WriteLine("Zadej kladné číslo");            
                string nacteno = Console.ReadLine();
                cislo = int.Parse(nacteno);
            }

            Console.WriteLine($"Zadal jsi {cislo}.");
        }
    }
}