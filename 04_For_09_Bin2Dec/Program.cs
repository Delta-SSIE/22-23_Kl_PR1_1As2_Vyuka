namespace _04_For_09_Bin2Dec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bin = "10011101";
            Console.WriteLine(Convert.ToInt32(bin, 2));

            int dec = 0;
            int zaklad = 1;

            for (int i = bin.Length - 1; i >= 0 ; i--)
            {
                char bit = bin[i];
                if (bit == '1')
                    dec += zaklad;

                zaklad *= 2;
            }

            Console.WriteLine(dec);



        }
    }
}