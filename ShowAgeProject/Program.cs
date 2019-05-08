using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowAgeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Age: ");
            try
            {
                int age =Convert.ToInt32( Console.ReadLine());
                Console.ReadLine();
                int year = DateTime.Now.Year - age;
                if (age == 0)
                {
                    Console.WriteLine("Enter valid number");
                    Console.ReadLine();
                    return;
                }
                Console.WriteLine(year);
                Console.ReadLine();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Please Do not enter negative numbers, enter only digits.");
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Enter Age into numbers only.");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Enter age into digits only");
                Console.ReadLine();
            }
        }
    }
}
