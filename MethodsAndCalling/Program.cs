using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndCalling
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodsCall callfun = new MethodsCall();
            callfun.Addition(2);
            callfun.Addition(2.3);
            callfun.Addition("2");
            Console.ReadLine();
        }
    }
}
