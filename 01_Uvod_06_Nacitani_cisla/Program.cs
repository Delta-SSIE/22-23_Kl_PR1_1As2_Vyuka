namespace _01_Uvod_06_Nacitani_cisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolik lidí přijde?");
            //int pocet = Console.ReadLine(); //nelze - Readline načte od uživatele text, ne číslo
            string nacteno = Console.ReadLine();
            Console.WriteLine("Přijde k nám {0} lidí, i s námi tu bude na večeři {1} osob.", nacteno, nacteno + 2); //nesčítá, ale spojuje řetězce!
            int navsteva = int.Parse(nacteno); //parsování = převod na zadaný typ, zde celé číslo
            Console.WriteLine("Přijde k nám {0} lidí, i s námi tu bude na večeři {1} osob.", navsteva, navsteva + 2);

            Console.WriteLine("kolik to bude stát?");
            string nactenaCena = Console.ReadLine();
            double cena = double.Parse(nactenaCena); //převede načtený řetězec na desetinné
            double cenaZaOsobu = cena / (navsteva + 2);
            Console.WriteLine($"každý musí zaplatit {cenaZaOsobu}");
        }
    }
}