using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceClass
{
    public class Employee<T>
    {
        public int id;
        private List<T> things;

        public Employee()
        {
            this.things = new List<T>();
        }
        public void AddItems(T newItem)
        {
            
                things.Add(newItem);
                //Console.WriteLine(newItem);
        }
        public void showResult()
        {
            foreach (var items in things)
            {
                Console.WriteLine(items.ToString());
            }
        }

       

        public T genericProperty { get; set; }
    


    //return things;


    //public static bool operator ==(Employee employee, Employee otherEmployee)
    //{
    //    if (employee.id == otherEmployee.id)
    //    {
    //        return true;
    //    }else
    //    {
    //        return false;
    //    }
    //}
    //public static bool operator !=(Employee employee, Employee otherEmployee)
    //{
    //    if (employee.id != otherEmployee.id)
    //    {
    //        return true;
    //    }
    //    else
    //    {
    //        return false;
    //    }
    //    //return employee;
    //}

}

}
