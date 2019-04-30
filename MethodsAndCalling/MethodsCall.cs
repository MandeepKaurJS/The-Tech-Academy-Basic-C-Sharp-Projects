using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndCalling
{
    class MethodsCall
    {
        public void Addition(int add)
        {
            try
            {
                int result = add / 2;
                Console.WriteLine("Divide number by 2: " + result);

            }catch(DivideByZeroException e)
            {
                Console.WriteLine("we cannot divide any number with 0");
            }
            
            
        }
        public void Addition(double mul)
        {
            double result = mul * mul;
            Console.WriteLine("Multiplication of decimal Number is : " + result);
        }
        public void Addition(string show)
        {
            try
            {
                int showresult = Int32.Parse(show+show);
                Console.WriteLine("Add string by itself:" +showresult);
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{show}'");
            }

        }
    }
}
