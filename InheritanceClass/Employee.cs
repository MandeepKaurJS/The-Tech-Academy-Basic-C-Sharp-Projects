using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceClass
{
   public class Employee:Person
    {
        public int id;
        public void showid()
        {
            Console.WriteLine("Employee id: "+id);
        }
    }
    
}
