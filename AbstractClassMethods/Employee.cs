using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassMethods
{
    public class Employee:Person,IQuittable
    {
        public override  void SayName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
        public void Quit()
        {
            Console.WriteLine("Hi! I am An Interface");
        }
    }
}
