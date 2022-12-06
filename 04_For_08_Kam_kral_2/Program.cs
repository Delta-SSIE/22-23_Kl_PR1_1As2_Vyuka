namespace _04_For_08_Kam_kral_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor white = ConsoleColor.DarkYellow;
            ConsoleColor black = ConsoleColor.Black;
            ConsoleColor text = ConsoleColor.DarkGray;

            string vstup;
            bool jeChyba;
            char radek = '\0';
            char sloupec = '\0';

            do
            {
                jeChyba = false;

                //načíst vstup
                Console.WriteLine("Zadej pozici krále: ");
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

            //mam nacteno jako char
            int cisloSloupce = sloupec - 'A';
            int cisloRadku = radek - '1';


            Console.ForegroundColor = text;

            for (int y = 7; y >= 0; y--)
            {
                for (int x = 0; x < 8; x++)
                {
                    if ((x + y) % 2 == 0)
                    {
                        Console.BackgroundColor = black;
                    }
                    else
                    {
                        Console.BackgroundColor = white;
                    }

                    int rozdilX = Math.Abs(cisloSloupce - x);
                    int rozdilY = Math.Abs(cisloRadku - y);

                    //označím pozici krále
                    if (rozdilX == 0 && rozdilY == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("R ");
                        Console.ForegroundColor = text;
                    }
                    //označím pozici, kam král dojde - liší se o max 1 v každé souřadnici
                    else if (rozdilX < 2 && rozdilY < 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write("# ");
                        Console.ForegroundColor = text;
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }

                Console.WriteLine();
            }

            Console.ResetColor();
        }
    }
}