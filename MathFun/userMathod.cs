using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFun
{
     public class userMathod
    {
        public userMathod()
        {

        }
        Program prog = new Program();
       
       public  int AddFun(int add)
        {
            Console.WriteLine("Your Entered Number after Adding into 2: ");
             int result = add + 2;
           // Console.WriteLine(" here"+add.Number);
            return result;
            
        }
        public int MultiplyFun(int mul)
        {
            Console.WriteLine("Your Entered Number after multiply with itself: ");
           int Number= mul * mul;
           return Number;
        }

       

        public int DivideFun(int divide)
        {
            Console.WriteLine("Your Entered Number after dividing by 2: ");
            int divide1 = divide / 2;
            return divide1;

        }
        public int  MinusFun(int minus)
        {
            Console.WriteLine("Your Entered Number after Substracting 2 from it. ");
            int result = minus- 2;
            return result;
        }



    }
}
