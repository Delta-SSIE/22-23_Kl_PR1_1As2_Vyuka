namespace _05_Pole_11_Kostky_a_pst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10000; //pocet hodu (opakovani)
            int steny = 4;

            Random rnd = new Random();
            int[] pocty = new int[steny + 1];

            for (int i = 0; i < n; i++)
            {
                int hod = rnd.Next(1, steny + 1);
                pocty[hod]++;
            }

            for (int i = 1; i < pocty.Length; i++)
            {
                double pst = ((double)pocty[i]) / n;
                Console.WriteLine($"{i}: {pocty[i]} - {pst}");
            }
        }
    }
}