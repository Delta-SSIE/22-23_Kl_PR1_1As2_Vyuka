namespace _05_Pole_07_Je_setrizeno
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //double[] cisla = { -5, 4.3, 2.7, 6.41, 12 }; //není
            //double[] cisla = { -5, 2.7, 4.3, 6.41, 12 }; //je
            double[] cisla = { -5, 2.7, 2.7, 4.3, 6.41, 12 }; //je

            //projdu celé pole a porovnám každý prvek s následovníkem, jestli je předchůzdce menší
            bool jeSetrizeno = true;
            for (int i = 0; i < cisla.Length - 1; i++)
            {
                if (cisla[i] > cisla[i+1]) //pokud ano, neni setrizeno
                {
                    jeSetrizeno = false;
                    break;
                }
            }

            if (jeSetrizeno)
                Console.WriteLine("Pole je setřízené");
            else
                Console.WriteLine("Pole není setřízené");

        }
    }
}