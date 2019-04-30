using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Person name = new Employee();
            name.FirstName = "Sample";
            name.LastName = "Student";
            name.SayName();
            Console.ReadLine();

        }
    }
}
