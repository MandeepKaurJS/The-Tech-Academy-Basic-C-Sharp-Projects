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
            Employee emp2 = new Employee();
            Person name = new Person();
            emp.id = 1;
            emp2.id = 2;
            if (emp.id == emp2.id)
            {
                Console.WriteLine("Equal"+emp.id);
            }
            else
            {
                Console.WriteLine(emp.id + " Not Equal " + emp2.id);
            }
            //emp.FirstName = "Sample";
            //emp.LastName = "Student";
            //emp.showid();
            //name.FirstName = "Mandeep";
            //name.LastName = "Kaur";
            //name.SayName();
            //emp.showid();
            //emp.SayName();
           Console.ReadLine();
        }
    }
}
