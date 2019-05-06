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

            
           Employee<string> UserName = new  Employee<string>();
            UserName.AddItems("Mandeep");
            UserName.AddItems("Mandeep");
            UserName.AddItems("Mandeep");
            UserName.AddItems("Mandeep");
           Employee<int> number = new Employee<int>();
            number.AddItems(1);
            number.AddItems(2);
            number.AddItems(3);
            number.AddItems(4);
            number.showResult();
            UserName.showResult();
            Console.ReadLine();


            

            //for (int i = 0; i < 10; i++)
            //{
            //    intvar.things.Add(1);
            //    intvar.things.Add(2);
            //    name.things.Add("Mandeep");
            //    name.things.Add("kaur");
            //    Console.WriteLine(intvar);
            //    Console.WriteLine(name);
            //    Console.ReadLine();
            //}
            
            //Employee emp = new Employee();
            //Employee emp2 = new Employee();
            //Person name = new Person();
            //emp.id = 1;
            //emp2.id = 2;
            //if (emp.id == emp2.id)
            //{
            //    Console.WriteLine("Equal"+emp.id);
            //}
            //else
            //{
            //    Console.WriteLine(emp.id + " Not Equal " + emp2.id);
            //}
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
