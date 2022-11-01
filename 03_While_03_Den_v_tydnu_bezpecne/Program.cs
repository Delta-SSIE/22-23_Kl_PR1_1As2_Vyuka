namespace _03_While_03_Den_v_tydnu_bezpecne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cisloDne = 0;
            bool prvniPruchod = true;

            while (cisloDne < 1 || cisloDne > 7) //když je den neplatný, načítej
            {
                if (!prvniPruchod)
                    Console.WriteLine("Chyba zadání");

                Console.Write("Zadej číslo dne (1-7): ");
                cisloDne = int.Parse(Console.ReadLine());
                prvniPruchod = false;
            }

            string den;

            switch (cisloDne)
            {
                case 1:
                    den = "pondělí";
                    break;
                case 2:
                    den = "úterý";
                    break;
                case 3:
                    den = "středa";
                    break;
                case 4:
                    den = "čtvrtek";
                    break;
                case 5:
                    den = "pátek";
                    break;
                case 6:
                    den = "sobota";
                    break;
                case 7:
                    den = "neděle";
                    break;
                default:
                    den = string.Empty;
                    break;
            }

            Console.WriteLine($"Dnes je {den}.");

        }
    }
}