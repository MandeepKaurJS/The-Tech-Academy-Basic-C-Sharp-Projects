using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your required number to see some" +
         "math operations on it");
            int Number = Convert.ToInt32(Console.ReadLine());
            userMathod user = new userMathod();
            // user.AddFun(g.Number);
            //Console.WriteLine(g.Number);

            Console.WriteLine(user.AddFun(Number));
            Console.ReadLine();
            Console.WriteLine(user.MultiplyFun(Number));
            Console.ReadLine();
            Console.WriteLine(user.DivideFun(Number));
            Console.ReadLine();
            Console.WriteLine(user.MinusFun(Number));
            Console.ReadLine();
            string textFile = @"C:\Users\VrinMan Dulay\Documents\GitHub\The-Tech-Academy-Basic-C-Sharp-Projects\MathFun\docs\TextFile.docx";
            if (File.Exists(textFile))
            {
                // Read entire text file content in one string  
                string text = File.ReadAllText(textFile);
                Console.WriteLine(text);
            }

            if (File.Exists(textFile))
            {
                // Read a text file line by line.
                string[] lines = File.ReadAllLines(textFile);
                foreach (string line in lines)
                    Console.WriteLine(line);
                Console.ReadLine();

            }
        }
    }
}
