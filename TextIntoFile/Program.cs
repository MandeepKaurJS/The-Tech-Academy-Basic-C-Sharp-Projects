using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
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
            /** pass user input to Datetime variable and used Tryparse to chechk for exception***/
            DateTime hours;
            DateTime.TryParse(number.ToString(),out hours);
            Console.WriteLine(""+ "Time in hours:  " + hours.ToString());
            Console.ReadLine();
            DateTime show=new DateTime();
            Console.WriteLine(show.Hour);
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
