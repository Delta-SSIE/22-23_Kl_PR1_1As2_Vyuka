namespace _05_Pole_10_Histogramy_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] hodnoty = { 100, 300, 200, 400, 700, 1200, 400 };
            char symbol = '#';
            int maxDelka = 76; //80 je šířka řádky, 4 znaky na záhlaví

            //najit max
            int max = 0;
            for (int i = 0; i < hodnoty.Length; i++)
            {
                if (hodnoty[i] > max)
                    max = hodnoty[i];
            }

            //zjistit pomer
            double pomer = ((double)max) / maxDelka;

            for (int i = 0; i < hodnoty.Length; i++)
            {
                int hodnota = (int)Math.Round(hodnoty[i] / pomer);

                Console.Write($"{i}: ");
                Console.Write("".PadRight(hodnota, symbol));
                Console.WriteLine();
            }
        }
    }
}