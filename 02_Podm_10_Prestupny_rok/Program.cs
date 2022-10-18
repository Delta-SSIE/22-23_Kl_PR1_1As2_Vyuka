using System;

namespace _02_Podm_10_Prestupny_rok
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej rok");
            string vstup = Console.ReadLine();
            int rok = int.Parse(vstup);

            bool jePrestupny;

            if (rok % 4 == 0)
            {
                jePrestupny = true;
            }
            else
            {
                if(rok % 100 == 0)
                {
                    if (rok % 400 == 0)
                    {
                        jePrestupny = true;
                    }
                    else
                    {
                        jePrestupny = false;
                    }
                }
                else
                {
                    jePrestupny = false;
                }
            }
        }
    }
}
