using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace TextIntoFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            /* ask for a number to user*/
            Console.WriteLine("Type a number : ");
            string number =(Console.ReadLine());
            /** pass user input to Datetime variable **/
            DateTime hours = DateTime.Now;
            hours.ToString(DateTime.Now.Hour.ToString(number));
            Console.WriteLine("Time After User input: "+hours);
            Console.ReadLine();
            /***With Another Way and used Tryparse to chechk for exception* ***/
            DateTime hour = DateTime.Now;
            //hours = DateTime.ParseExact(number, "h", null);
            DateTime.TryParse(number.ToString(), out hour);
            Console.WriteLine("" + "Time in hours:  " + hour.ToString());
            Console.ReadLine();
            Console.ReadLine();

            /*** we will pass entered number from user and put it into text file by using this statement***/
            File.WriteAllText(@"C:\Users\VrinMan Dulay\Documents\test.txt", number.ToString());
            /***by using this file stream writers i will write to file each time when we type***/
            using (StreamWriter file = new StreamWriter(@"C:\Users\VrinMan Dulay\Documents\test.txt", true))
            {
                file.WriteLine("\n"+DateTime.Now);
                file.WriteLine(number);
            }
            /***By using this statement we can read the text entered by user***/

            number = File.ReadAllText(@"C:\Users\VrinMan Dulay\Documents\test.txt");
        }
    }
}
