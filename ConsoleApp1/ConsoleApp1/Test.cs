using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
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
