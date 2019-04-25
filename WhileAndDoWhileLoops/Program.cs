using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileAndDoWhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num between 0 to 10");
            int number=Convert.ToInt32(Console.ReadLine());
            int num = number;
            
            bool IsShow = false;
            while ((IsShow = true) && (num < 10))
            {
                ++num;
                Console.WriteLine("Number is incremented by 1: " + num.ToString());
                Console.WriteLine();
            }
            Console.WriteLine(IsShow);
            Console.ReadLine();

            /****Do While ****/
            Console.WriteLine("Enter num between 0 to 20");
            number = Convert.ToInt32(Console.ReadLine());
            num = number;

            IsShow = false;
            do
            {
                
                ++num;
                Console.WriteLine("Number is incremented by 1: " + num.ToString());
                Console.WriteLine();

            } while ((IsShow = true) && (num < 20));
            Console.WriteLine(IsShow);
            Console.ReadLine();
            /* int i = 0;
             do
             {
                 Console.WriteLine("Value of i: {0}", i);

                 i++;
                 if(i>10)
                 break;
             }
             while (true);
             Console.Read();
             /***While loop ****
            int j= 0;

             while (true)
             {
                 Console.WriteLine("Value of i: {0}", j);

                 j++;
                 if (j > 10) 
                 break;

             }
             Console.Read(); */

        }

    }
}
