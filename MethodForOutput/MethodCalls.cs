using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodForOutput
{
    class MethodCalls
    {
        public void getValue(out int x)
        {


            int answer;
            Console.WriteLine("Enter any number: ");
            answer = Convert.ToInt32(Console.ReadLine());

            x = answer / 2;
                Console.WriteLine("Number after dividing by two : " + x);
            
        }
    }
}
