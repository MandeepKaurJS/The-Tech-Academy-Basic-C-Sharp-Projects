using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalMethodsinClass
{
    class OptionalParameter
    {
        public void Additon(int num, int optionalint=10)
        {
            int result = num * 2;
            Console.WriteLine("First parameter after Multiplying by 2: \n " + result);
            if (optionalint == optionalint)
            {
                result = num * 2 + optionalint;
                Console.WriteLine("Number after Adding optional parameter into " +
                    "first parameter " + result);
            }
            else
            {
                Console.Write("No need to type another varible");
            }
        }
    }
}
