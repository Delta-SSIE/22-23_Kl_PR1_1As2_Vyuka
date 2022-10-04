namespace _02_Podm_02_Vice_vetvi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jaké je číslo");

            string nacteno = Console.ReadLine();
            int cislo = int.Parse(nacteno);

            if (cislo < 7)
            {
                Console.WriteLine($"Číslo {cislo} je malé");
            }
            else if (cislo < 14)
            {
                Console.WriteLine($"Číslo {cislo} je tak akorát");
            }
            else
            {
                Console.WriteLine($"Číslo {cislo} je velké");                
            }

        }
    }
}