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
           
            /* ask for a number to user*/
           // 1.Ask a user for a number. So it might look like this:
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Please give me a number:");
           // 2.Log that number to a text file.
            int input = Convert.ToInt32(Console.ReadLine());
            //adds the integer input in hours to the current dateTime and writes to console
            Console.WriteLine("In {0} hours it will be " + DateTime.Now.AddHours(input), input);
           // 3.Print the text file back to the user.
           Console.Read();
            /***With Another Way and used Tryparse to chechk for exception* ***/
            DateTime hour = DateTime.Now;
            //hour = DateTime.ParseExact(number, "hh:mm", null);
            //DateTime.TryParse(inumber.ToString(), out hour);
            Console.WriteLine("" + "Time in hours:  " + hour.ToString());
            Console.ReadLine();
            Console.ReadLine();

            /*** we will pass entered number from user and put it into text file by using this statement***/
            //File.WriteAllText(@"C:\Users\VrinMan Dulay\Documents\test.txt", number.ToString());
            /***by using this file stream writers i will write to file each time when we type***/
            using (StreamWriter file = new StreamWriter(@"C:\Users\VrinMan Dulay\Documents\test.txt", true))
            {
                file.WriteLine("\n"+DateTime.Now);
                //file.WriteLine(number);
            }
            /***By using this statement we can read the text entered by user***/

           // number = File.ReadAllText(@"C:\Users\VrinMan Dulay\Documents\test.txt");
        }
    }
}
