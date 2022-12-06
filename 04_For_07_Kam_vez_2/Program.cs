namespace _04_For_07_Kam_vez_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor white = ConsoleColor.DarkYellow;
            ConsoleColor black = ConsoleColor.Black;
            ConsoleColor text = ConsoleColor.DarkGray;

            Console.ForegroundColor = text;

            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 8; x++)
                {
                    if ((x + y) % 2 != 0)
                    {
                        Console.BackgroundColor = black;
                    }
                    else
                    {
                        Console.BackgroundColor = white;
                    }
                    Console.Write("  ");
                }

                Console.WriteLine();
            }

            Console.ResetColor();
        }
    }
}