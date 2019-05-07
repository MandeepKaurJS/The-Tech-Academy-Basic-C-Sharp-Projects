using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalFeaturesofCSharp
{
    class Program
    {
        string name;
        int Age;
        int Wage;
        public Program(string Name,int age)
        {
            name = Name;
            Age = age;
            
        }
        public Program(int wage) 
        {
            Wage = wage;

        }
        public void showResults()
        {
            Console.WriteLine("Constructors with 2 parameters: "+name+"\n"+Age);
            Console.ReadLine();
           
        }
        public void showOneParameter()
        {
            Console.WriteLine("Constructors with 1 parameter: " + Wage);
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            const string Name = "Mandeep Kaur";
            var age = 25;
            Console.WriteLine("Constant string and var Age: " + Name + "\n " + age);
            Console.ReadLine();
            /*** if I pass Const Name value to Constructor it will remain the same not changable any more ****/
            var PassCons = new Program(Name, age);
            PassCons.showResults();
            /**** This is Constructor with two parameter***/
            var cons = new Program("Mandeep",26);
            cons.showResults();
            /****Constructor with no parameters ***/
            var cons2 = new Program(wage:2000);
            cons2.showOneParameter();
           


        }
    }
}
