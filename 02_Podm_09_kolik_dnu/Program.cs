using System;

namespace _02_Podm_09_kolik_dnu
{
    class Program
    {
        static void Main(string[] args)
        {
            int cisloMesice = 10;

            int pocetDnu;
            switch (cisloMesice)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    pocetDnu = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    pocetDnu = 30;
                    break;
                case 2:
                    pocetDnu = 28;
                    break;
                default:
                    pocetDnu = 0;
                    break;
            }
        }
    }
}
