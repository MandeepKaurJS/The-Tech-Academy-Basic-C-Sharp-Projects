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
            Methodsclass calling = new Methodsclass();
            Console.WriteLine("Enter any number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int result=0;
            calling.Addition(number,result);
            Console.WriteLine(result);
            Console.ReadLine();
            calling.Substraction(num: number, num3: result);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
