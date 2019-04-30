using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodForOutput
{
    static class MethodCalls
    {
       public static void getValue(out int x)
        {


            int answer;
            Console.WriteLine("Enter any number: ");
            answer = Convert.ToInt32(Console.ReadLine());

            x = answer / 2;
                Console.WriteLine("Number after dividing by two : " + x);
            
        }
        public static void getValue(out double y)
        {
            double ans;
            Console.WriteLine("Enter another number");
            ans = Convert.ToDouble(Console.ReadLine());
            y = ans* 2;
            Console.WriteLine("number after diving deci mal number: "+y);
        }
    }
}
