using System;

namespace MAthFunAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            /**First Question ***/
            Console.WriteLine("Enter an Integer");
            long Number = Convert.ToInt64(Console.ReadLine());
            long Multiply = Number * 50;
            Console.WriteLine("Multiply with 50: " + Multiply);

            /***Second Question ***/

            Console.WriteLine("Enter an Integer");
            int num = Convert.ToInt32(Console.ReadLine());
            int Add = num + 25;
            Console.WriteLine("Number after adding into 25: " + Add);

            /***Third Question ***/

            Console.WriteLine("Enter any number ");
            double number = Convert.ToDouble(Console.ReadLine());
            double quotient = number / 12.5;
            Console.WriteLine(" We can Divide any number with 12.5: " + quotient);

            /***Forth Question ***/

            Console.WriteLine("Enter any number :");
            int Num = Convert.ToInt32(Console.ReadLine());
            bool isnumGreater = Num > 50;
            Console.WriteLine(isnumGreater);
            Console.ReadLine();
        }
    }
}
