namespace _01_Uvod_03_Uzivatelsky_vstup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jak se jmenuješ?");

            //datový_typ název_proměnné = co_do_ní_uložit
            string jmeno = Console.ReadLine();

            Console.WriteLine("Ať žije " + jmeno + "!");
        }
    }
}