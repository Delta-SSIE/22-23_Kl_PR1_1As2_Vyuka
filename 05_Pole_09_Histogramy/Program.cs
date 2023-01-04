namespace _05_Pole_09_Histogramy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] hodnoty = { 1, 3, 2, 4, 7, 12, 4 };
            char symbol = '#';

            for (int i = 0; i < hodnoty.Length; i++)
            {
                int hodnota = hodnoty[i];

                Console.Write($"{i}: ");
                Console.Write("".PadRight(hodnota, symbol));
                //for (int j = 0; j < hodnota; j++)
                //{
                //    Console.Write(symbol);
                //}

                Console.WriteLine();
            }
        }
    }
}