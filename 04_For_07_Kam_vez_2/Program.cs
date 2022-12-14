namespace _04_For_07_Kam_vez_2
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

                    //označím pozici věže
                    if (y == cisloRadku && x == cisloSloupce)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("R ");
                        Console.ForegroundColor = text;
                    }
                    //označím pozici, kam věž útočí - má jen 1 souřadnici stejnou
                    else if (y == cisloRadku || x == cisloSloupce)
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