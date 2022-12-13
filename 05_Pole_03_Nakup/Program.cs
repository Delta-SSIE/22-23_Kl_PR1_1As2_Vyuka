namespace _05_Pole_03_Nakup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //nákup na 3 položky

            string[] veci = new string[3];
            double[] ceny = new double[3];
            int[] kusy = new int[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Co je {0}. položka:", i + 1);
                veci[i] = Console.ReadLine();

                Console.WriteLine("Kolik to stojí:");
                ceny[i] = double.Parse(Console.ReadLine());

                Console.WriteLine("Kolik jich chceš:");
                kusy[i] = int.Parse(Console.ReadLine());

                Console.WriteLine();
            }

            double celkem = 0;
            for (int i = 0; i < 3; i++)
            {
                double cenaPolozky = ceny[i] * kusy[i];
                Console.WriteLine($"{veci[i]}: {kusy[i]} kusů po {ceny[i]:0.00} Kč, tj. {cenaPolozky:0.00} Kč");
                celkem += cenaPolozky;
            }

            Console.WriteLine($"Cena nákupu: {celkem:0.00} Kč");
        }
    }
}