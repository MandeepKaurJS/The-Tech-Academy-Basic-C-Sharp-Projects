using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceClass
{
    public class Employee : Person
    {
        public int id;
        public void showid()
        {
            Console.WriteLine("Employee id: " + id);
        }
        
        public static bool operator ==(Employee employee, Employee otherEmployee)
        {
            if (employee.id == otherEmployee.id)
            {
                return true;
            }else
            {
                return false;
            }
        }
        public static bool operator !=(Employee employee, Employee otherEmployee)
        {
            if (employee.id != otherEmployee.id)
            {
                return true;
            }
            else
            {
                return false;
            }
            //return employee;
        }
        
    }

}
