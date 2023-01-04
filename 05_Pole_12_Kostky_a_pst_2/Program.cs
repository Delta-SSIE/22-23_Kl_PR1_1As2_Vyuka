namespace _05_Pole_12_Kostky_a_pst_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10000; //pocet hodu (opakovani)
            int steny = 20;
            int k = 5; //pocet kostek, ktere se scitaji

            int minHod = k;
            int maxHod = k * steny;

            Random rnd = new Random();
            int[] pocty = new int[maxHod + 1];

            for (int i = 0; i < n; i++)
            {
                int soucet = 0;
                for (int j = 0; j < k; j++)
                {
                    int hod = rnd.Next(1, steny + 1);
                    soucet += hod;
                }
                pocty[soucet]++;
            }

            for (int i = minHod; i < pocty.Length; i++)
            {
                double pst = ((double)pocty[i]) / n;
                Console.WriteLine($"{i}: {pocty[i]} - {pst}");
            }


            //zobrazení histogramem
            char symbol = '#';
            int maxDelka = 76; //80 je šířka řádky, 4 znaky na záhlaví

            //najit max
            int max = 0;
            for (int i = 0; i < pocty.Length; i++)
            {
                if (pocty[i] > max)
                    max = pocty[i];
            }

            //zjistit pomer
            double pomer = ((double)max) / maxDelka;

            for (int i = minHod; i < pocty.Length; i++)
            {
                int hodnota = (int)Math.Round(pocty[i] / pomer);

                Console.Write($"{i}: ");
                Console.Write("".PadRight(hodnota, symbol));
                Console.WriteLine();
            }
        }
    }
}