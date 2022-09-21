namespace _01_Uvod_05_Cisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int delenec = 20; //celočíselná proměnná
            int delitel = 3;
            int podil = delenec / delitel;
            int zbytek = delenec % delitel; //% je operátor modulo - znamená zbytek

            //Console.WriteLine(podil);
            Console.WriteLine("Podíl čísel " + delenec + " a " + delitel + " je " + podil + ", zbytek je " + zbytek + "."); //skládání řetězců
            
            Console.WriteLine("Podíl čísel {0} a {1} je {2}, zbytek je {3}.", delenec, delitel, podil, zbytek); //formátovácovací řetězec
            
            Console.WriteLine($"Podíl čísel {delenec} a {delitel} je {podil}, zbytek je {zbytek}."); //interpolace řetězců


            int cislo = 7;
            cislo = cislo + 7;
            Console.WriteLine(cislo);

            int velkeCislo = int.MaxValue; //největší hodnota
            Console.WriteLine(velkeCislo);
            velkeCislo = velkeCislo + 1; //přetečení
            Console.WriteLine(velkeCislo);

            //double desetinne = 1235,3; //nelze - carka ma v kodu jiny vyznam
            double desetinne = 1235.3; //pouzivame desetinnou tecku
            Console.WriteLine(desetinne / 2);

            double delenec2 = 20; //celočíselná 20 převede na desetinnou
            double delitel2 = 3;
            double podil2 = delenec2 / delitel2; //dělení v desetinných číslech
            Console.WriteLine($"Podíl čísel {delenec2} a {delitel2} je {podil2}.");

            double velkyDouble = 20_000_000_000_000_000_000d;
            Console.WriteLine(velkyDouble);
            double velkyDouble2 = velkyDouble + 1;
            Console.WriteLine(velkyDouble2 - velkyDouble); //pozor, jednička zmizela, double není dost přesný
        }
    }
}