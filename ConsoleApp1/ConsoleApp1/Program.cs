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
            Console.Read();
           
        }
    }
}
