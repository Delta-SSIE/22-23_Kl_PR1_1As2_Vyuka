using System;

namespace _03_While_12_Parsovani_podruhe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Zadej číslo");

            //int cislo;

            //string vstup = Console.ReadLine();

            //if (int.TryParse(vstup, out cislo))
            //{
            //    Console.WriteLine($"Úspěšně jsem parsoval číslo {cislo}");
            //}
            //else
            //{
            //    Console.WriteLine($"Parsování neúspěšné, cislo má hodnotu {cislo}");
            //}

            //while (!int.TryParse(vstup, out cislo))
            //{
            //    global::System.Console.WriteLine( "Chyba vstupu ");
            //    vstup = Console.ReadLine();
            //}

            //int suma = 0;

            //while (vstup.ToLower() != "x")
            //{
            //    if (int.TryParse(vstup, out cislo))
            //    {
            //        suma += cislo;
            //    }
            //    else
            //    {
            //        global::System.Console.WriteLine( "Chybný vstup");
            //    }

            //    vstup = Console.ReadLine();
            //}

            //Console.WriteLine( $"Součet byl {suma}");



            //int suma = 0;
            //string vstup;
            //do
            //{
            //    int cislo;

            //    global::System.Console.WriteLine("Zadej další číslo nebo x");
            //    vstup = Console.ReadLine();

            //    if (int.TryParse(vstup, out cislo))
            //    {
            //        suma += cislo;
            //    }
            //    else if (vstup != "x")
            //    {
            //        global::System.Console.WriteLine("Chybný vstup");
            //    }
            //}
            //while ( vstup != "x" );

            //Console.WriteLine($"Součet byl {suma}");


            int suma = 0;
            int pocet = 0;
            string vstup;
            while (true)
            {
                int cislo;

                Console.WriteLine("Zadej další číslo nebo x");
                vstup = Console.ReadLine();

                if (vstup == "x")
                {
                    break;
                }
                else if (int.TryParse(vstup, out cislo))
                {
                    suma += cislo;
                    pocet++;
                }
                else
                {
                    Console.WriteLine("Chybný vstup");
                }
            }

            Console.WriteLine($"Součet byl {suma}");

            //double prumer = ((double)suma) / pocet;
            //double prumer = suma * 1d / pocet;
            double prumer = Convert.ToDouble(suma) / pocet;
            Console.WriteLine($"Průměr byl {prumer}");
        }
    }
}