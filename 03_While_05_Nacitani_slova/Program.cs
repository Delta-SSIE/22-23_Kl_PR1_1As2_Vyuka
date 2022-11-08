namespace _03_While_05_Nacitani_slova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Zadej slovo, ukonči mezerníkem.");
            //string slovo = "";
            //int delka = 0;
            //char znak = 'a'; //vraz tam cokoliv

            //while (znak != ' ')
            //{
            //    znak = Console.ReadKey().KeyChar;
            //    if (znak != ' ')
            //    { 
            //        slovo += znak;
            //        delka++;
            //    }
            //}

            //Console.WriteLine($"Zadané slovo bylo \"{slovo}\", jeho délka je {delka}.");

            Console.WriteLine("Zadej slovo, ukonči mezerníkem.");
            string slovo = "";
            int delka = 0;
            
            char znak = Console.ReadKey().KeyChar;

            while (char.IsLetter(znak))
            {
                slovo += znak;
                delka++;
                znak = Console.ReadKey().KeyChar;
            }

            Console.WriteLine($"Zadané slovo bylo \"{slovo}\", jeho délka je {delka}.");
        }
    }
}