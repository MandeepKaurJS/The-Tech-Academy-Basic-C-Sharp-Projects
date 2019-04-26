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
            int[] num = { 1, 2, 3, 4, 2,6 };
            List<String> inList = new List<string>()
            {"Varinder","Singh","Northwest","university" };
            Console.WriteLine("select an index :");
            int user = Convert.ToInt32(Console.ReadLine());
            if (user == 1)
            {
                Console.WriteLine(array[0]);
                Console.ReadLine();
            }
            else if (user == 2)
            {
                Console.WriteLine(array[1]);
                Console.ReadLine();
            }
            else if (user == 3)
            {
                Console.WriteLine(array[2]);
                Console.ReadLine();
            }
            else if (user == 4)
            {
                Console.WriteLine(array[3]);
                Console.ReadLine();
            }
            else if (user == 5)
            {
                Console.WriteLine(array[4]);
                Console.ReadLine();
            }
            else if (user == 6)
            {
                Console.WriteLine(array[5]);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Index doesn't exist");
                Console.ReadLine();
            }
            Console.WriteLine("select an index for number :");
            int number = Convert.ToInt32(Console.ReadLine());
            
            if (number == 1)
            {
                Console.WriteLine(num[0]);
                Console.ReadLine();
            }
            else if (number == 2)
            {
                Console.WriteLine(num[1]);
                Console.ReadLine();
            }
            else if (number == 3)
            {
                Console.WriteLine(num[2]);
                Console.ReadLine();
            }
            else if (number == 4)
            {
                Console.WriteLine(num[3]);
                Console.ReadLine();
            }
            else if (number == 5)
            {
                Console.WriteLine(num[4]);
                Console.ReadLine();
            }
            else if (number == 6)
            {
                Console.WriteLine(num[5]);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Index doesn't exist");
                Console.ReadLine();
            }
            Console.WriteLine("select an index for List element :");
            int list = Convert.ToInt32(Console.ReadLine());

            if (list == 1)
            {
                Console.WriteLine(inList[0]);
                Console.ReadLine();
            }
            else if (list == 2)
            {
                Console.WriteLine(inList[1]);
                Console.ReadLine();
            }
            else if (list == 3)
            {
                Console.WriteLine(inList[2]);
                Console.ReadLine();
            }
            else if (list == 4)
            {
                Console.WriteLine(inList[3]);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("index doesn't Exist");
                Console.ReadLine();
            }

        }

    }
}
