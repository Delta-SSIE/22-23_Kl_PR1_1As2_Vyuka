using System;

namespace _02_Podm_08_Je_Torjuhelnik
{
    class Program
    {
        static void Main(string[] args)
        {
            string nacteno;

            Console.Write("Zadej stranu A: ");
            nacteno = Console.ReadLine();
            double stranaA = double.Parse(nacteno);

            Console.Write("Zadej stranu B: ");
            nacteno = Console.ReadLine();
            double stranaB = double.Parse(nacteno);

            Console.Write("Zadej stranu C: ");
            nacteno = Console.ReadLine();
            double stranaC = double.Parse(nacteno);

            // Sem přijde váš kód
            bool lzeSestavit = false;
            if (
                stranaA + stranaB > stranaC 
                && stranaB + stranaC > stranaA 
                && stranaC + stranaA > stranaB
                )
                lzeSestavit = true;

            if (lzeSestavit)
                Console.WriteLine("jde to");
            else
                Console.WriteLine("nejde to");
        }
    }
}
