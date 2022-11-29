using System;

namespace _04_For_04_Ctverec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //char znak = '#';
            //int strana = 4;

            //for (int y = 0; y < strana; y++)
            //{
            //    for (int x = 0; x < strana; x++)
            //    {
            //        Console.Write(znak);
            //    }
            //    Console.WriteLine();
            //}


            ////obdelnik
            //char znak = '#';
            //int stranaA = 6;
            //int stranaB = 4;


            //for (int y = 0; y < stranaA; y++)
            //{
            //    for (int x = 0; x < stranaB; x++)
            //    {
            //        Console.Write(znak);
            //    }
            //    Console.WriteLine();
            //}


            // trojuhelnik b
            //char znak = '#';
            //int vyska = 6;


            //for (int y = 0; y < vyska; y++)
            //{
            //    for (int x = 0; x < y + 1; x++)
            //    {
            //        Console.Write(znak);
            //    }
            //    Console.WriteLine();
            //}

            //trojuhelnik p
            //char znak = '#';
            //int vyska = 6;


            //for (int y = 0; y < vyska; y++)
            //{
            //    for (int x = 0; x < vyska - y; x++)
            //    {
            //        Console.Write(znak);
            //    }
            //    Console.WriteLine();
            //}

            //trojuhelnik d
            //char znak = '#';
            //int vyska = 6;


            //for (int y = 0; y < vyska; y++)
            //{
            //    int pocetMezer = vyska - y - 1;
            //    int pocetZnaku = y + 1;

            //    for (int x = 0; x < pocetMezer; x++)
            //    {
            //        Console.Write(' ');
            //    }

            //    for (int x = 0; x < pocetZnaku; x++)
            //    {
            //        Console.Write(znak);
            //    }

            //    Console.WriteLine();
            //}

            //trojuhelnik q
            //    char znak = '#';
            //    int vyska = 6;


            //    for (int y = 0; y < vyska; y++)
            //    {
            //        int pocetMezer = y;
            //        int pocetZnaku = vyska - y;

            //        for (int x = 0; x < pocetMezer; x++)
            //        {
            //            Console.Write(' ');
            //        }

            //        for (int x = 0; x < pocetZnaku; x++)
            //        {
            //            Console.Write(znak);
            //        }

            //        Console.WriteLine();
            //    }


            //trojuhelnik delta
            char znak = '#';
            int vyska = 6;


            for (int y = 0; y < vyska; y++)
            {
                int pocetMezer = vyska - y - 1;
                int pocetZnaku =  2 * y + 1;

                for (int x = 0; x < pocetMezer; x++)
                {
                    Console.Write(' ');
                }

                for (int x = 0; x < pocetZnaku; x++)
                {
                    Console.Write(znak);
                }

                Console.WriteLine();
            }

        }
    }
    
}