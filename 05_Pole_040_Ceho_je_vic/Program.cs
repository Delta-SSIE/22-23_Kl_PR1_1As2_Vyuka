namespace _05_Pole_04_Ceho_je_vic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cisla = { -20, 11, 0, 10, -7, 12, -83, 0, 0, 15 };

            int kladne = 0;
            int zaporne = 0;

            for (int i = 0; i < cisla.Length; i++)
            {
                int cislo = cisla[i];
                if (cislo > 0)
                    kladne++;
                else if (cislo < 0)
                    zaporne++;
            }

            if (kladne > zaporne)
                Console.WriteLine("Kladných je víc.");
            else if (zaporne > kladne)
                Console.WriteLine("Záporných je víc.");
            else
                Console.WriteLine("Záporných je stejně jako kladných.");

        }
    }
}