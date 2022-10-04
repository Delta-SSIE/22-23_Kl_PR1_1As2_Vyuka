namespace _02_Podm_01_Vyber_auta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolik auto stojí?");
            string nacteno = Console.ReadLine(); //načtu
            int cena = int.Parse(nacteno); //převedu na číslo

            int limit = 300_000;

            if (cena > limit) //kulaté závorky za if ohraničují podmínku
            {
                Console.WriteLine("Tu předraženou popelnici nekupuj!"); //tohle se vykoná jen při splnění podmínky
            }
            else //else se vykoná, když podmínka splněná není
            {
                Console.WriteLine("Ber to!");
            }

        }
    }
}