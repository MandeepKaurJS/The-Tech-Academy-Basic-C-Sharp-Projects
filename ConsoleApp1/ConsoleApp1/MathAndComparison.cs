using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class MathAndComparison
    {
        static void Main(string[] args)
        {
            Console.Write("Add two variables");
            int total = 5 + 10;
            int othertotal = 12 + 22;
            int combined = total + othertotal;
            Console.WriteLine(combined);
            // Console.WriteLine("Five Plus Ten" + total);
            Console.ReadLine();

            Console.Write("Substract two variables");
            int difference = 10 - 5;
            Console.WriteLine("\n Ten Minus five"+difference);
            Console.ReadLine();

            Console.Write("Multiply two variables");
            int product = 10 * 5;
            Console.WriteLine("\n" + product);
            Console.ReadLine();

            Console.Write("Divide two variables");
            int quotient = 100 / 5;
            Console.WriteLine("\n Divide by 5" + quotient);
            Console.ReadLine();

            Console.Write("Divide decimal two variables");
            double quotient1 = 100.0 / 17.5;
            Console.WriteLine("\n Divide by 17.5" + quotient1);
            Console.ReadLine();

            Console.Write("Divide  two variables which gives remainder");
            int remainder = 10 % 2;
            Console.WriteLine("\n Divide by 2" + remainder);
            Console.ReadLine();

            Console.Write("Comparison operetors");
            bool trueorFalse = 12 > 5;
            Console.Write(trueorFalse.ToString());
            Console.ReadLine();

            int  roomtemp = 70;
            int currunttemp = 70;

            //bool isWarm = currunttemp > roomtemp;
            bool isWarm = currunttemp != roomtemp;
            Console.WriteLine(isWarm);
            Console.ReadLine();






        }
    }
}
