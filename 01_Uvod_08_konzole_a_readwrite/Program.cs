namespace _01_Uvod_08_konzole_a_readwrite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kolik je ti let: ");
            string nacteno = Console.ReadLine();
            Console.WriteLine($"Odpověděl jsi {nacteno}.");
            Console.WriteLine("pro ukončení stiskni libovolnou klávesu");
            Console.ReadKey(); //výsledek zahodím, ale znamená to, že čeká na stisk libovolné klávesy
            //Console.WriteLine("pro ukončení stiskni enter");
            //Console.ReadLine(); //výsledek zahodím, ale znamená to, že čeká na stisk enteru
        }
    }
}