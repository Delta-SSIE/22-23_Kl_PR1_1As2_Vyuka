using System;

namespace _05_Pole_01_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pole - array
            //udržuje data stejného typu v jedné proměnné

            string[] sousedi = new string[3]; //vytvoř pole řetězců délky 3;

            sousedi[0] = "Novákovi";
            sousedi[1] = "Novotní";
            sousedi[2] = "Černí";

            //Console.WriteLine(sousedi[3]); //chyba - mimo hranice pole
            Console.WriteLine(sousedi[1]);
            Console.WriteLine();

            //vypiš vše
            for (int i = 0; i < sousedi.Length; i++)
            {
                Console.WriteLine(sousedi[i]);
            }

            Console.WriteLine();

            //vypiš vše odzadu
            for (int i = sousedi.Length - 1; i > -1; i--)
            {
                Console.WriteLine(sousedi[i]);
            }

            //jednodušší naplnění
            int[] fibonacci = { 1, 1, 2, 3, 5, 8 };
            Console.WriteLine(fibonacci); //vypíše jen název datového typu

            for (int i = 0; i < fibonacci.Length; i++)
            {
                Console.Write(fibonacci[i] + ", ");
            }
        }
    }
}