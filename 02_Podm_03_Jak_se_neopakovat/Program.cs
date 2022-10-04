namespace _02_Podm_03_Jak_se_neopakovat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jaké je číslo");

            string nacteno = Console.ReadLine();
            int cislo = int.Parse(nacteno);


            //string odpoved = $"Číslo {cislo} je ";
            //if (cislo < 7)
            //{
            //    odpoved += "malé";
            //}
            //else if (cislo < 14)
            //{
            //    odpoved += "tak akorát";
            //}
            //else
            //{
            //    odpoved += "velké";
            //}
            //odpoved += ".";
            //Console.WriteLine(odpoved);

            string rozhodnuti; //pripravim promennou, ale nic do ni nedam
            if (cislo < 7)
            {
                rozhodnuti = "malé";
            }
            else if (cislo < 14)
            {
                rozhodnuti = "tak akorát";
            }
            else
            {
                rozhodnuti = "velké";
            }
            Console.WriteLine($"Cislo {cislo} je {rozhodnuti}.");
        }
    }
}