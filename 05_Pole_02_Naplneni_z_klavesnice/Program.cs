namespace _05_Pole_02_Naplneni_z_klavesnice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zeptej se uživatele na 10 čísel, pak je vypiš odzadu

            int[] cisla = new int[10]; //založím úložiště - tedy pole

            for (int i = 0; i < cisla.Length; i++)
            {
                Console.WriteLine("Zadej {0}. číslo", i + 1);
                //Console.WriteLine($"Zadej {i + 1}. číslo");
                string nacteno = Console.ReadLine();
                cisla[i] = int.Parse(nacteno);
            }

            Console.WriteLine();
            Console.WriteLine("Výpis:");
            Console.WriteLine();

            for (int i = cisla.Length - 1; i > -1; i--)
            {
                Console.WriteLine(cisla[i]);
            }

            Console.WriteLine();

            //vypsat jen lichá čísla:
            for (int i = 0; i < cisla.Length; i++)
            {
                if (cisla[i] % 2 == 1)
                    Console.WriteLine(cisla[i]);
            }

            Console.WriteLine();

            //sečíst všechny
            int suma = 0;
            for (int i = 0; i < cisla.Length; i++)
            {
                suma += cisla[i];
            }
            Console.WriteLine("Součet je {0}.", suma);
        }
    }
}