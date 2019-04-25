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
            int i = 0;
            do
            {
                Console.WriteLine("Value of i: {0}", i);

                i++;
                if(i>10)
                break;
            }
            while (true);
            Console.Read();
            /***While loop ****/
           int j= 0;

            while (true)
            {
                Console.WriteLine("Value of i: {0}", j);

                j++;
                if (j > 10) 
                break;
                
            }
            Console.Read(); 

        }

    }
}
