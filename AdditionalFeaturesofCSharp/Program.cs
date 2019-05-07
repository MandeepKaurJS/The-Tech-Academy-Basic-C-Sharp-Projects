using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalFeaturesofCSharp
{
    class Program
    {
        public Program(string name,int age)
        {
            
        }
        public Program() : this("Mandeep",26)
        {

        }
        static void Main(string[] args)
        {
            const string Name = "Mandeep Kaur";
            var age = 25;
            Console.WriteLine("Constant string and var Age" + Name + " " + age);
            Console.ReadLine();
            /**** This is Constructor with two parameter***/
            Program cons = new Program("Varinder", 26);
            Console.WriteLine("Constructors with 2 parameters"+cons);
            Console.ReadLine();
            /****Constructor with no parameters ***/
            Program cons2 = new Program();
            Console.WriteLine("Constructors with no parameters"+cons2);
            Console.ReadLine();


        }
    }
}
