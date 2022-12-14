namespace _04_For_10_Dec2Bin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dec = 157;

            Console.WriteLine(Convert.ToString(dec, 2));

            string bin = "";

            while (dec > 0)
            {
                int zbytek = dec % 2;

                bin = zbytek + bin;
                dec /= 2;
            }

            Console.WriteLine(bin);
        }
    }
}