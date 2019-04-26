using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndListItration

{
    class Program
    {
        static void Main(string[] args)
        {
            string[] value = new string[10];
            int i = 0;
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter some text");
                value[i] = Console.ReadLine();
            }
            Console.WriteLine("The values you've entered are :");
            Console.WriteLine(String.Join(",", value));
            Console.ReadLine();
            while (true)
            {
                Console.WriteLine("looping...");

                if (Console.KeyAvailable)
                {
                    break;
                }
            }
            Console.ReadLine();
            Console.Write(" iterating the loop is a “<=” operator.");
            int count = 4;
            for (int j = 1; j <= count; j++)
            {
                Console.WriteLine("Current value of i is - " + j);
            }
            Console.WriteLine(" iterating the loop is a “<” operator.");
            int count1 = 4;
            for (int k = 1; k < count1; k++)
            {
                Console.WriteLine("Current value of i is - " + k);
            }
            Console.ReadLine();
            List<string> list = new List<string>()
            { "Mandeep","kaur","Sidhu","Dulay","Done"};
            for (int str = 0; str < list.Count; str++)
            {
                Console.WriteLine("Search any string");
                string search = Convert.ToString(Console.ReadLine());

                if (search==list[str])
                {
                    Console.WriteLine("Search Result is at index ");
                    int index = str;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("String is not in list");
                    Console.ReadLine();
                    break;
                }
            }


        }
    }
}
