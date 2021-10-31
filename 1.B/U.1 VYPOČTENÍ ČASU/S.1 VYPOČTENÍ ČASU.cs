//by TeolorD
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej minuty: ");
            
            int time = Int32.Parse(Console.ReadLine());

            int leftminutes = time % 60;

            int hours = (time - leftminutes) / 60;
           
            Console.WriteLine($"Počet hodin: {hours}");
            Console.WriteLine($"Počet minut: {leftminutes}");
        }
    }
}
