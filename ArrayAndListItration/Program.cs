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
            string[] value= new string[10];
            int i = 0;
            for(i = 0; i <10; i++)
            {
                Console.WriteLine("Enter some text");
                value[i] = Console.ReadLine();
                Console.WriteLine(value[i]);
                
            }

            Console.ReadLine();
        }
    }
}
