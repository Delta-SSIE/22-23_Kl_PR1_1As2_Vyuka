namespace _03_While_13_NIm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sirky = 21;

            int cisloHrace = 2;

            while (sirky > 0) //dokud je něco na stole, hraje se
            {
                //hráči se střídají
                if (cisloHrace == 1)
                    cisloHrace = 2;
                else
                    cisloHrace = 1;

                //cisloHrace = (cisloHrace + 1) % 2; 

                //hráč zadá počet
                string nacteno;
                int pocet;
                do
                {
                    Console.WriteLine($"Hráč {cisloHrace}: Na stole leží {sirky} sirky. Zadej počet odebraných sirek:");
                    nacteno = Console.ReadLine();
                }//zkontrolujeme  
                while (!int.TryParse(nacteno, out pocet) || pocet < 1 || pocet > 3 || pocet > sirky);

                //odebereme
                sirky -= pocet;                               
            }

            Console.WriteLine($"Prohrál hráč {cisloHrace}");
        }
    }
}