namespace _01_Uvod_05_Cisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int delenec = 19; //celočíselná proměnná
            int delitel = 3;
            int podil = delenec / delitel;

            //Console.WriteLine(podil);
            //Console.WriteLine("Podíl čísel " + delenec + " a " + delitel + " je " + podil + "."); //skládání řetězců
            Console.WriteLine("Podíl čísel {0} a {1} je {2} ({0}/{1} = {2}).", delenec, delitel, podil);


        }
    }
}