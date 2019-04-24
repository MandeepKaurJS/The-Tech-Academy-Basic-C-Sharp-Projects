using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class DailyReport
    {
        static public void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What course are you on?");
            String Course = Console.ReadLine();
           // int chnage = Convert.ToInt32(Course);
            Console.WriteLine("What Page Number?");
            String page = Console.ReadLine();
            Console.WriteLine("Do you need help with anything? Please answer “true” or “false”.");
            bool answer = true;
            Console.ReadLine();
            string ans = Convert.ToString(answer);
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            String Experience = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string Otherexperience = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            int hours=0; Console.ReadLine();
            String changeHours = Convert.ToString(hours);
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
        }
    }
}
