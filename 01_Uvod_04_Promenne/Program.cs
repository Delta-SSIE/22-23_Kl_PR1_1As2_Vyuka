namespace _01_Uvod_04_Promenne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jmeno = "Karel"; //deklaruju proměnnou, alokuje se paměť, ukládám do ní hodnotu
            Console.WriteLine(jmeno);

            jmeno = "Františka";//měním hodnotu
            Console.WriteLine(jmeno);

            //string jmeno = "Alois";//nelze - klíčové slovo string znamená "udělej novou" ale už existuje

            string mesto; //deklaruju proměnnou ale neukládám
            //Console.WriteLine(mesto); //nelze - nepřiřazená proměnná

        }
    }
}