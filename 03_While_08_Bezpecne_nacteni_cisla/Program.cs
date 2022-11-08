namespace _03_While_08_Bezpecne_nacteni_cisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cislo;
            string nacteno;
            bool poprve = true;

            do
            {
                if(!poprve)                
                    Console.WriteLine("Špatný formát");                
                else
                    poprve = false;
                

                Console.WriteLine("Zadej celé číslo:");
                nacteno = Console.ReadLine();
            }
            while (!int.TryParse(nacteno, out cislo));

            Console.WriteLine($"Zadal jsi {cislo}.");
        }
    }
}