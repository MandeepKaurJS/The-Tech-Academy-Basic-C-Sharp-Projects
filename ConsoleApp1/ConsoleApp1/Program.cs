using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Welcome to Acme Accounting Systems");
            Console.WriteLine("Remember, we’re “accounting” on you!");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome to Acme Accounting System " + name + "");
            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();

            //float yearsInCentury = 100f;
            //float ageInCenturies = (float)age / yearsInCentury;
           // Console.WriteLine("You are " + ageInCenturies + " centuries old.");

            //Prints "You are .31 centuries old"


        }
    }
}
