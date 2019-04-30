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
          
            int answer;double ans;
            MethodCalls.getValue(out answer);
            Console.ReadLine();
            MethodCalls.getValue(out ans);
             Console.ReadLine();
        }
    }
}
