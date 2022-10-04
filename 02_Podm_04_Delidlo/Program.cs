namespace _02_Podm_04_Delidlo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int delenec = 10;

            Console.WriteLine("Čím se bude dělit?");
            string nacteno = Console.ReadLine();
            int delitel = int.Parse(nacteno);

            //if (delitel == 0) //dve rovnitka = porovnání
            //{
            //    Console.WriteLine("Nulou se nedělí, ty nulo.");
            //}
            //else
            //{
            //    int podil = delenec / delitel;
            //    int zbytek = delenec % delitel;

                //    Console.WriteLine($"Podíl {delenec} / {delitel} je {podil}, zbytek je {zbytek}.");
                //}

            if (delitel != 0) //nerovnost
            {
                int podil = delenec / delitel;
                int zbytek = delenec % delitel;

                Console.WriteLine($"Podíl {delenec} / {delitel} je {podil}, zbytek je {zbytek}.");
            }
            else 
            {
                Console.WriteLine("Nulou se nedělí, ty nulo.");
            }

        }
    }
}