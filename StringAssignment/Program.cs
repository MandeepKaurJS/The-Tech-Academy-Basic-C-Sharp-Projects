using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Mandeep Kaur.";
            Console.WriteLine("Hi this is " + name);
            string work = " taking classes from Tech Academy.";
            Console.WriteLine("I Am " + work);
            string hours = "spend 8 hours per day in weekdays.";
            Console.WriteLine("I " + hours);
            Console.WriteLine("To see everything into one line press enter");
            Console.ReadLine();
            String join = "I'm "+name + "I am "+ work +"I "+ hours;
            Console.WriteLine("MY Current Status is \n" + join);
            Console.ReadLine();
            join=join.ToUpper();
            Console.WriteLine("Now I'm in Upper Case \n"+join);
            Console.Read();
            StringBuilder sb = new StringBuilder();
            sb.Append("Taking ");
            sb.Append("classes ");
            sb.Append("from ");
            sb.Append("Tech ");
            sb.Append("Acedemy ");
            sb.Append("make ");
            sb.Append("be ");
            sb.Append("able ");
            sb.Append("to ");
            sb.Append("take ");
            sb.Append("a ");
            sb.Append("step ");
            sb.Append("into ");
            sb.Append("IT ");
            sb.Append("world.");
            Console.WriteLine(sb);
            Console.ReadLine();
            Console.Read();
        }

    }
}
