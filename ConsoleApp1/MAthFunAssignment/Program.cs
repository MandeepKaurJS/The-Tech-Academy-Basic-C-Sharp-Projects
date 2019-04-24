using System;

namespace MAthFunAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            /**First Question ***/
            Console.WriteLine("Enter an Integer to multiply it with 50");
            long Number = Convert.ToInt64(Console.ReadLine());
            long Multiply = Number * 50;
            Console.WriteLine("After Multiply with 50 number is: " + Multiply);

            /***Second Question ***/

            Console.WriteLine("Enter an Integer to add it into 25");
            int num = Convert.ToInt32(Console.ReadLine());
            int Add = num + 25;
            Console.WriteLine("Number after adding into 25: " + Add);

            /***Third Question ***/

            Console.WriteLine("Enter any number to divide it by 12.5 number ");
            double number = Convert.ToDouble(Console.ReadLine());
            double quotient = number / 12.5;
            Console.WriteLine(" We can Divide any number with 12.5: " + quotient);

            /***Forth Question ***/

            Console.WriteLine("Enter any number to check is number greater than or less than 50 :");
            int Num = Convert.ToInt32(Console.ReadLine());
            bool isnumGreater = Num > 50;
            Console.WriteLine(isnumGreater);

            /***Fifth Question ***/

            Console.WriteLine("Enter an Integer to divide it by 7");
            int Divide = Convert.ToInt32(Console.ReadLine());
            int divided = Divide % 7;
            Console.WriteLine("after divide by 7 remainder is: " + divided);
            Console.ReadLine();
        }
    }
}
