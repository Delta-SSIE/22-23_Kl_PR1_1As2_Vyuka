using System;
using System.Runtime.InteropServices;

namespace _04_For_05_Caesar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string otevrenyText = "UTOK ZACNE VE TRI RANO U SEVERNI BRANY";
            int klic = 3;

            string sifrovyText = "";

            //pro kazdy znak
            for (int i = 0; i < otevrenyText.Length; i++)
            {
                char znak = otevrenyText[i];

                if (znak >= 'A' && znak <= 'Z')
                {
                    //znak na cislo
                    int cisloZnaku = znak;

                    //prictu klic
                    cisloZnaku += klic;

                    if (cisloZnaku > 'Z')
                        cisloZnaku -= 26;

                    //prevod zpět na znak
                    char sifrovyZnak = (char)cisloZnaku;

                    //pridat k sifrovemu textu
                    sifrovyText += sifrovyZnak;
                }
                else
                {
                    sifrovyText += znak;
                }
            }

            // vypsat sifrovy text
            Console.WriteLine(sifrovyText);
        }
    }
}