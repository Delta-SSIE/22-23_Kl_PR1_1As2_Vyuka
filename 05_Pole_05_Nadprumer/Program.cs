namespace _05_Pole_05_Nadprumer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10; //počet zadávaných čísel

            Console.WriteLine($"Zadej {n} čísel.");

            //1. načíst
            double[] cisla = new double[n]; //vyrobím sklad na čísla

            for (int i = 0; i < n; i++) //načtu n čísel
            {
                cisla[i] = double.Parse(Console.ReadLine());
            }

            //2. spočti průměr
            double suma = 0;
            for (int i = 0; i < n; i++)
            {
                suma += cisla[i]; //sečtu všechna zadaná čísla
            }
            double prumer = suma / n;

            Console.WriteLine($"Průměr je {prumer}, vypisuji nadprůměrná čísla:");

            //3. vypsat čísla větší než průměr
            for (int i = 0; i < n; i++)
            {
                if (cisla[i] > prumer)
                    Console.WriteLine(cisla[i]);
            }

        }
    }
}