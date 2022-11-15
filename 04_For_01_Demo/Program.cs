using System;

namespace _04_For_01_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i = 1;
            //while (i < 11)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //Console.WriteLine(i);

            //int i = 1;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //while (i < 11);
            //Console.WriteLine(i);


            //for (int i = 1; i < 11; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 0; i < 101; i += 10)
            //{
            //    Console.WriteLine(i);
            //}

            for (int i = 100; i > -1; i -= 10)
            {
                Console.WriteLine(i);
            }
        }
    }
}