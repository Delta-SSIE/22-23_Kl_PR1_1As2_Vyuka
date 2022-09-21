namespace _01_Uvod_02_WriteLine_a_dalsi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // dvě lomítka znamenají řádkový komentář - ten se nevykonává
            // Console. WriteLine vypíše na nový řádek
            Console.WriteLine("Ahoj světe!");
            Console.WriteLine("Jsem tu");

            //celý označený blok zakomentuje CTRL-K-C, odkomentuje CTRL-K-U

            Console.Write("A chci něco dělat");
            Console.Write("Co mi nabídneš?");

            /* 
             Takhle uvedeme třeba větší kus kódu
             víceřádkovým komentářem             
             */
            Console.WriteLine("Je tu nepořádek.");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("A je tu uklizeno");
        }
    }
}