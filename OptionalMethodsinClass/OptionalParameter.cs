using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace OptionalMethodsinClass
{
    class OptionalParameter
    {
        public void Additon(int num,int optionalint=10)
        {
            
            int result = num * 2;
            int result2 = result + optionalint;
             Console.WriteLine("First parameter after Multiplying by 2:  " + result+
                "\n Number with or without adding optional number into it : "+result2);
            
        }
    }
}
