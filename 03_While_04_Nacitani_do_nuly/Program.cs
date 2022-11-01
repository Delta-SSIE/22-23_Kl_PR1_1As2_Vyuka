namespace _03_While_04_Nacitani_do_nuly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cislo = -1; //dám tam cokoli - nepoužije se
            int suma = 0;

            while (cislo != 0)
            {
                Console.Write("Zadej číslo, nula ukončí: ");
                cislo = int.Parse(Console.ReadLine());
                suma += cislo;
                Console.WriteLine($"Součet je {suma}.");
            }

            Console.WriteLine("Součet je " + suma);
        }
    }
}