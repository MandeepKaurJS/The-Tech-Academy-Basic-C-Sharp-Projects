using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodForOutput
{
    class Program
    {
        static void Main(string[] args)
        {
          MethodCalls getcall = new MethodCalls();
            int answer;
            getcall.getValue(out answer);
            
            Console.ReadLine();
        }
    }
}
