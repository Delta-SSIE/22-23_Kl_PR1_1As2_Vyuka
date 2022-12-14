using System.Diagnostics;

namespace _04_For_11_Je_Prvocislo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopky = new Stopwatch();
            stopky.Start();

            //int cislo = 225;
            for (int i = 2; i < 100000; i++)
            {
                int cislo = i;
                bool jePrvocislo = true;

                int maxDelitel = (int)Math.Sqrt(cislo);
                //int maxDelitel = cislo / 2;

                for (int delitel = 2; delitel <= maxDelitel; delitel++)
                {
                    if (cislo % delitel == 0)
                    {
                        jePrvocislo = false;
                        break;
                    }
                }


                //if (jePrvocislo)
                //    Console.WriteLine("Číslo {0} je prvočíslo.", cislo);
                //else
                //    Console.WriteLine("{0} je složené číslo2.", cislo);
            }

            stopky.Stop();
            Console.WriteLine(stopky.ElapsedMilliseconds);

        }
    }
}