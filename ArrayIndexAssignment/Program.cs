using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayIndexAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = {"Mandeep","Kaur","Tech","Acedemy","C#",
            ".NET","Done"};
            int[] num = { 11, 12, 13, 14, 22,26 };
            List<String> inList = new List<string>()
            {"Varinder","Singh","Northwest","university" };
            Console.WriteLine("select an index :");
            try
            {
                int user = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(array[user]);
                Console.ReadLine();
            }
            catch (IndexOutOfRangeException e)
            {
                System.Console.Write(e.Message);
                Console.WriteLine("Index not exist");
                Console.ReadLine();
                
            }
            try
            {
                Console.WriteLine("Select an index for number");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num[number]);
            }
            catch(IndexOutOfRangeException e)
            {
                System.Console.Write(e.Message);
                Console.WriteLine("index not exist");
            }
            try
            {
                Console.WriteLine("Select an index for list");
                int list =Int32.Parse(Console.ReadLine().ToString());
                Console.WriteLine(inList[list]);
            }
            catch (System.IndexOutOfRangeException ex) 
            {
                System.Console.Write(ex.Message);
                Console.WriteLine("index not exist");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
            

        }

    }
}
