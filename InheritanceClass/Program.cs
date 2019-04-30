using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Person name = new Person();
            emp.id = 1;
            emp.FirstName = "Sample";
            emp.LastName = "Student";
            emp.showid();
            name.FirstName = "Mandeep";
            name.LastName = "Kaur";
            name.SayName();
            emp.SayName();
           Console.ReadLine();
        }
    }
}
