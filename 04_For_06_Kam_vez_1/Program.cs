using System;
using System.Security.Cryptography;

namespace _04_For_06_Kam_vez_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string vstup;
            bool jeChyba;
            char radek = '\0';
            char sloupec = '\0';

            do
            {
                jeChyba = false;

                //načíst vstup
                Console.WriteLine("Zadej pozici věže: ");
                vstup = Console.ReadLine().ToUpper();

                //zkontrolovat a rozdělit na souřadnice
                if (vstup.Length != 2)
                {
                    Console.WriteLine("Neplatný vstup");
                    jeChyba = true;
                    continue;
                }

                radek = vstup[1];
                sloupec = vstup[0];

                if (radek < '1' || radek > '8' || sloupec < 'A' || sloupec > 'H')
                {
                    Console.WriteLine("Neplatný vstup");
                    jeChyba = true;
                    continue;
                }
            } 
            while (jeChyba);

            Console.WriteLine();
            Console.WriteLine("Věž útočí na:");

            //zachovat řádek, přidat všechny sloupce
            for (int i = 0; i < 8; i++)
            {
                char cilSloupec = (char)('A' + i);
                if (cilSloupec == sloupec)
                    continue;

                Console.WriteLine("" + cilSloupec + radek);
            }

            //zachovat sloupec, přidat všechny řádky
            for (int i = 0; i < 8; i++)
            {
                char cilRadek = (char)('1' + i);
                if (cilRadek == radek)
                    continue;

                Console.WriteLine("" + sloupec + cilRadek);
            }
        }
    }
}