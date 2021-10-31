using System;

namespace welcome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vaše jméno: ");
            var name = Console.ReadLine();
            var hour = DateTime.Now.Hour;
            string time;
            if(hour < 12) time = "Dobré ráno";
            else if(hour > 12 && hour < 18) time = "Dobré odpoledne";
            else time = "Dobrý večer";
            Console.WriteLine($"{time}, {name}");
        }
    }
}
