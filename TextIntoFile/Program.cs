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
            /* ask for a number to user*/
            Console.WriteLine("Type a number : ");
            string number =(Console.ReadLine());
            /*** we will pass entered number from user and put it into text file by using this statement***/
            File.WriteAllText(@"C:\Users\VrinMan Dulay\Documents\test.txt", number.ToString());
            /***By using this statement we can read the text entered by user***/
            
            number= File.ReadAllText(@"C:\Users\VrinMan Dulay\Documents\test.txt");
        }
    }
}
