namespace _03_While_07_Kolik_bude_sestek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int celkem = 180000;

            int pocet = 0;
            int pocetSestek = 0;

            Random rnd = new Random();

            while (pocet < celkem)
            {
                int hod = rnd.Next(1, 7);
                if (hod == 6)
                {
                    pocetSestek++;
                }
                pocet++;
            }

            Console.WriteLine($"Z {pocet} hodů bylo {pocetSestek}.");

        }
    }
}