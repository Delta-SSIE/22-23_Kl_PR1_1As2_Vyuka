namespace _02_Podm_05_Bool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 10;
            //int b = 15;

            //if (a == b)
            //{
            //    Console.WriteLine("Něco dělej");
            //}

            bool jeZima = true;
            if (jeZima)
            {
                Console.WriteLine("Vem si svetr!");
            }

            //if (!jeZima)
            //{
            //    Console.WriteLine("Vem si plavky");
            //}

            //int a = 10;
            //int b = 15;
            //bool aJeVetsiNezB = a > b;

            bool mamPenize = true;

            //když mám peníze nebo není zima, poradí mi jít ven,
            //jinak poradí zůstat doma
            if (!jeZima || mamPenize)
            {
                Console.WriteLine("Jdi ven");
            }
            else
            {
                Console.WriteLine("Zůstaň doma");
            }

        }
    }
}