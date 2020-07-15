using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAthFunctions2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Methodsclass calling = new Methodsclass();
            //Console.WriteLine("Enter any number : ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int result = 0;
            //calling.Addition(number, result);
            //Console.WriteLine(result);
            //Console.ReadLine();
            //calling.Substraction(num: number, num3: result);
            //Console.WriteLine(result);
            //Console.ReadLine();
            Program ob = new Program();
            double acre = Convert.ToDouble(Console.ReadLine());
            ob.SquareFeet(acre);
            Console.ReadLine();

        }
        public void SquareFeet(double acre)
        {
            Console.WriteLine("in acres");
            int feet = 43560;

            if (acre < feet)
            {
                Console.WriteLine("135");
            }
            else if (acre > feet) { 
                Console.WriteLine("$204");
            }else if (acre <= feet * 2)
            {
                Console.WriteLine("$204");
            }
            else if (acre > feet * 2)
            {
                Console.WriteLine("$270");
            }else if(acre <= feet * 5)
            {
                Console.WriteLine("$270");
            }
            else if (acre > feet * 5 || acre <= feet * 9)
            {
                if (acre < 5)
                {
                    Console.WriteLine("$270");
                }
                Console.WriteLine("$" + 270 + 34);
            }else if (acre >= feet * 10)
            {
                Console.WriteLine("$" + 439 + 27);
            }
            else
            {
                Console.WriteLine("nothing");
            }
        }
    }
}
