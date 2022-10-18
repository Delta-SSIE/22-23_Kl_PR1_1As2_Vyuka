#nullable disable
namespace temp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Napiš dopravní prostředek, kterým chceš cestovat.");

            string DP = Console.ReadLine();

            Console.WriteLine("Napiš druhý dopravní prostředek, kterým chceš cestovat");

            string DP2 = Console.ReadLine();



            Console.WriteLine($"Jak daleko pojedeš dopravním prostředkem {DP}?");

            string nacteno = Console.ReadLine();

            double draha = double.Parse(nacteno);



            Console.WriteLine($"Jak daleko pojedeš dopravním prostředkem {DP2}?");

            string nacteno2 = Console.ReadLine();

            double draha2 = double.Parse(nacteno2);



            double CelkovaDraha = draha + draha2;

            Console.WriteLine($"Celková cesta dopravními prostředky {DP} a {DP2} bude dlouhá {CelkovaDraha} km");
        }
    }
}