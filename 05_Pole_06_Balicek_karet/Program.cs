namespace _05_Pole_06_Balicek_karet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] barvy = { "Zelená", "Srdce", "Žaludy", "Kule" };
            string[] hodnoty = { "Sedma", "Osma", "Devítka", "Desítka", "Spodek", "Vršek", "Král", "Eso" };
            string[] karty = new string[barvy.Length * hodnoty.Length];

            int pocitadlo = 0;
            for (int i = 0; i < barvy.Length; i++)
            {
                for (int j = 0; j < hodnoty.Length; j++)
                {
                    karty[pocitadlo] = $"{barvy[i]} - {hodnoty[j]}";
                    pocitadlo++;
                }
            }

            Console.WriteLine("Výpis balíčku:");
            for (int i = 0; i < karty.Length; i++)
            {
                Console.WriteLine(karty[i]);
            }

            Console.WriteLine();
            Console.WriteLine("5 náhodných karet:");
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                int nahodnyIndex = rnd.Next(karty.Length);
                Console.WriteLine(karty[nahodnyIndex]);
            }

            //zamícháme balíček
            int ukazatel = karty.Length - 1; //na začátku dám náhodnou kartu na konec
            while (ukazatel > 0) //dokud se ukazatel "příští karta k znáhodnění" neposune na první pozici
            {
                int nahodnyIndex = rnd.Next(ukazatel + 1); //náhodná pozice od startu až do ukazatele
                
                //vyměním karty na náhodné pozici a na ukazateli
                string temp = karty[nahodnyIndex];
                karty[nahodnyIndex] = karty[ukazatel];
                karty[ukazatel] = temp;

                ukazatel--;
            }

            //karty.OrderBy(x => rnd.NextDouble());

            Console.WriteLine();
            Console.WriteLine("Výpis zamíchaného balíčku:");
            for (int i = 0; i < karty.Length; i++)
            {
                Console.WriteLine(karty[i]);
            }
        }
    }
}