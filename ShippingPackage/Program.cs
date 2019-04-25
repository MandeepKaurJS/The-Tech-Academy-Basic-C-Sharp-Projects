using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingPackage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. " +
                "Please follow the instructions below.");
            Console.ReadLine();
            Console.WriteLine("Please enter the package weight:");
            int weight = Convert.ToInt32(Console.ReadLine());

            /***Comparison ***/
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. " +
                    "Have a good day.");
            }
            else if (weight < 50)
            {
                
                Console.WriteLine("Please enter the package width:");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package height:");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package length:");
                int length = Convert.ToInt32(Console.ReadLine());
                int sum = height + length;
                if(sum > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
            }
            Console.ReadLine();
        }
    }
}
