namespace _05_Pole_08_Pole_a_retezce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] hoste = { "Hynek", "Vilém", "Jarmila" };
            Console.WriteLine( string.Join(", ", hoste ));

            string veta = "Pepa chodí do školy";
            string[] slova = veta.Split("-");
            for (int i = slova.Length - 1; i > -1; i--)
            {
                Console.WriteLine(slova[i]);
            }


        }
    }
}