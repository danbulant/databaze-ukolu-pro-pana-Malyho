using System;

namespace PVAukol
{
    class Program
    {
        static void Main(string[] args)
        {

            int cas = DateTime.Now.Hour;

            Console.Write("Vaše jméno: ");
            string jmeno = Console.ReadLine();
            string doba;
            
            if (cas < 12)
            {
                doba = "rána";
            }

            else if(cas >= 12 && cas < 18)
            {
                doba = "odpoledne";
            }


            else
            {
                doba = "večera";
            }

            Console.WriteLine($"Dobrého {doba}, ti přeji {jmeno}.");



        }
    }
}
