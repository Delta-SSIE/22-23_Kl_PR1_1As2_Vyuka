namespace _03_While_02_Pocitani
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int cislo = 0;

            //while (cislo <= 100)
            //{
            //    Console.WriteLine(cislo);
            //    cislo += 13;
            //    //cislo++;
            //}

            int cislo = 100;

            while (cislo >= 100)
            {
                Console.WriteLine(cislo);
                cislo -= 5;
            }
        }
    }
}