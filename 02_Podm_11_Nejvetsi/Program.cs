using System;

namespace _02_Podm_11_Nejvetsi
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 20;
            int y = -30;
            int z = 70;
            int a = 100;

            /* dobře, ale nerozšířím na víc vstupů*/
            //int max;
            //if (x > y && x > z)
            //    max = x;
            //else if (y > z)
            //    max = y;
            //else
            //    max = z;

            int max = x;

            if (y > max)
                max = y;

            if (z > max)
                max = z;

            if (a > max)
                max = a;



        }
    }
}
