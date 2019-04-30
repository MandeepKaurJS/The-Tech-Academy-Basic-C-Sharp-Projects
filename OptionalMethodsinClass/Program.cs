using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalMethodsinClass
{
    class Program
    {
        static void Main(string[] args)
        {
            OptionalParameter number = new OptionalParameter();
            Console.WriteLine("Enter First number");
            int result = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n No need to enter second number: ");
            int result2 = 0;
            Console.ReadLine();
            number.Additon(result);
            
            number.Additon(result, result2);
            number.Additon(result, result2);
            number.Additon(result);
            Console.ReadLine();
        }
    }
}
