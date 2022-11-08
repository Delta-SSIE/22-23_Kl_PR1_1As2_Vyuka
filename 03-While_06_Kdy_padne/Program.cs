namespace _03_While_06_Kdy_padne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            //int hod = 0;
            //int pocet = 0;

            //while (hod != 6) { 
            ////házej kostkou, dokud nepadne šestka,
            //    hod = rnd.Next(1, 7);
            //    Console.WriteLine(hod);
            //    pocet++;
            //}



            do
            {
                Console.Clear();

                int pocet = 0;
                int hod;

                do
                {
                    hod = rnd.Next(1, 7);
                    Console.WriteLine(hod);
                    pocet++;
                }
                while (hod != 6); //do - while patří tam, kde chci, aby se to aspoň jednou stalo

                //pak řekni, kolikrát jsi musel hodit
                Console.WriteLine("Hodil jsem {0} krát.", pocet);

                Console.WriteLine("Chceš hrát znovu? A/N");
            }
            while (Console.ReadLine().ToUpper() == "A");
        }
    }
}