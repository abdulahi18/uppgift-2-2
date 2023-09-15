using System;

namespace Abdullahi
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur högt hoppade Elin i meter");
            string LångText = Console.ReadLine();
            Console.WriteLine("Hur högt hoppade Alma i meter?");
            string HoppadeText = Console.ReadLine();
            double långt = double.Parse(LångText);
            double hoppade = double.Parse(HoppadeText);
            double skillnad = långt - hoppade; 
                
            Console.WriteLine("Elin hoppade " + skillnad + " meter mer än Alma");
        }
    }
}