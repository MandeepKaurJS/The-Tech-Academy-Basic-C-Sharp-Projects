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
    class DailyReport
    {
        static public void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What course are you on?");
            String Course = Console.ReadLine();
            int chnage = Convert.ToInt32(Course);
            Console.WriteLine("Do you need help with anything? Please answer “true” or “false”.");
            bool answer = true;
            string ans = Convert.ToString(answer);
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            String Experience = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string Otherexperience = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            // int hours = Console.ReadLine();
            //String changeHours = Convert.ToString(hours);
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
        }
    }
    class Class1
    {
        static public void Main()
        {
            Console.WriteLine("Write Your favorite number?");
            string favnumber = Console.ReadLine();
            int favnum = Convert.ToInt32(favnumber);
            int total = favnum + 5;
            Console.WriteLine("Your favorite number plus 5 is :" + total);
            Console.ReadLine();
        }
    }
}
