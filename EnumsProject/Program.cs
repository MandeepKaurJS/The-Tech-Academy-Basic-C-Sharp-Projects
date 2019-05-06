using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (days planet in Enum.GetValues(typeof(days)))
            {
                Console.WriteLine( planet.ToString());

            }
            Console.ReadLine();
            Console.WriteLine("Enter current day of week");
            
                days value = 0;
                if (days.TryParse(Console.ReadLine(), out value))
                {
                try
                {
                    if (Enum.IsDefined(typeof(days), value))
                    {
                        days selectday = (days)value;
                        Console.WriteLine("Here is my selected day: " + selectday);
                        Console.ReadLine();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter an actual day of the week.");
                    Console.ReadLine();

                }
            }
            
            Console.ReadLine();
                //Console.WriteLine(day.ToString());

            
           

        }
        public enum days
        {
            Monday,
            Tuseday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }


    }

}
