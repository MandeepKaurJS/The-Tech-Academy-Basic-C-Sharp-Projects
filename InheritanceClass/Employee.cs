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
        private T genericMemberVariable;

        public Employee(T value)
        {
            genericMemberVariable = value;
        }

        public void genericMethod<T>(this List<T> items,params T[] genericParameter)
        {
            items.AddRange(genericParameter);
            
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
