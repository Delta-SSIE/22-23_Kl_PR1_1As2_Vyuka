using System;

namespace _04_For_02_Retezce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string veta = "Včera bylo Pondělí, zítra se jde k Marii.";
            //Console.WriteLine(veta.Length);
            //Console.WriteLine(veta.Contains('b'));
            //Console.WriteLine(veta[0]); //první znak - index 0
            //Console.WriteLine(veta[1]); //druhý znak - index 1
            //Console.WriteLine(veta[veta.Length - 1]); //poslední znak

            //věta na řádek pod sebe
            for (int i = 0; i < veta.Length; i++)
            {
                Console.WriteLine(veta[i]);
            }
            Console.WriteLine();

            //odzadu
            //for (int i = 0; i < veta.Length; i++)
            //{
            //    Console.Write(veta[veta.Length - i - 1]);
            //}
            //Console.WriteLine();

            //odzadu jinak
            for (int i = veta.Length - 1; i > -1; i--)
            {
                Console.Write(veta[i]);
            }
            Console.WriteLine();

            //výpis bez mezer
            for (int i = 0; i < veta.Length; i++)
            {
                if (veta[i] != ' ')
                    Console.Write(veta[i]);
            }
            Console.WriteLine();

            //výpis místo mezer podtržítka
            for (int i = 0; i < veta.Length; i++)
            {
                if (veta[i] != ' ')
                    Console.Write(veta[i]);
                else
                    Console.Write('_');
            }
            Console.WriteLine();

            //vypsat jen malá písmena
            //for (int i = 0; i < veta.Length; i++)
            //{
            //    string znak = veta[i].ToString();
            //    if (znak.ToUpper() != znak) //jak poznám ze znak je velký?
            //        Console.Write(veta[i]);
            //}
            //Console.WriteLine();

            ////vypsat kódy znaků
            //for (int i = 0; i < veta.Length; i++)
            //{
            //    char znak = veta[i];
            //    Console.WriteLine(znak + ": " + (int)znak);
            //}
            //Console.WriteLine();


            //vypsat bez velkých
            for (int i = 0; i < veta.Length; i++)
            {
                char znak = veta[i];
                if (znak < 65 || znak > 90)
                    Console.Write(znak);
            }
        }
    }
}