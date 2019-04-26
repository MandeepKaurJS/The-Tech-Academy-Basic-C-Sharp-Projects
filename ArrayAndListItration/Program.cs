using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndListItration

{
    class Program
    {
        static void Main(string[] args)
        {
            string[] value = new string[10];
            int i = 0;
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter some text");
                value[i] = Console.ReadLine();
            }
            Console.WriteLine("The values you've entered are :");
            Console.WriteLine(String.Join(",", value));
            Console.ReadLine();
            
            /***Infinite loop ***/

            while (true)
            {
                Console.WriteLine("looping...");

                if (Console.KeyAvailable)
                {
                    break;
                }
            }
            Console.ReadLine();
            /****Loop for < opreator ********/

            Console.Write(" iterating the loop is a “<=” operator.");
            int count = 4;
            for (int j = 1; j <= count; j++)
            {
                Console.WriteLine("Current value of i is - " + j);
            }
            Console.ReadLine();

            /****loop For <= operator****/

            Console.WriteLine(" iterating the loop is a “<” operator.");
            int count1 = 4;
            for (int k = 1; k < count1; k++)
            {
                Console.WriteLine("Current value of i is - " + k);
            }
            Console.ReadLine();
            /*******Question 6 to 8 List with string ****/

            List<string> list = new List<string>()
            { "Mandeep","kaur","Sidhu","Dulay","Done","Tech","Academy"};
            
                Console.WriteLine(String.Join(",",list));
                Console.ReadLine();
            
            
            for (int str = 0; str < list.Count; str++)
            {
                 Console.WriteLine("Select any string and get his index in list");
                string search = Convert.ToString(Console.ReadLine());
                //Console.WriteLine("Search Result is at index ");
                int result = list.IndexOf(search);


                if (result >= 0)
                {
                    Console.WriteLine("Search Result is at index ");
                    Console.WriteLine(result);
                    Console.ReadLine();
                    if (result==str)
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("String is not in list");
                    Console.ReadLine();
                    break;
                }
                Console.ReadLine();
            }
            /*******question 9 to 10*********/
            
            List<string> mylist = new List<string>()
            { "Mandeep","kaur","Sidhu","Dulay","Done","Tech",
                "Academy" ,"Acedemy","Sidhu"};

            Console.WriteLine("Another List of string \n"+String.Join(",", mylist));
            Console.ReadLine();
            for(var k = 0; k < mylist.Count; k++)
            {
                Console.WriteLine("Select any string and get his index in list");
                string search = Convert.ToString(Console.ReadLine());
                //Console.WriteLine("Search Result is at index ");
                int result = list.IndexOf(search);
                
                if (result >= 0)
                {
                    Console.WriteLine("Search Result is at index ");
                    
                    Console.WriteLine(result);
                    Console.ReadLine();
                    if (search == "Sidhu")
                    {
                        var duplicates = mylist
                                .Select((x, index) => new { search = x, index })
                                .Where(x => (mylist
                                                .GroupBy(data => data)
                                                .Where(g => g.Count() > 1)
                                                .Select(g => g.Key).ToList()
                                              ).Contains(x.search));
                        foreach(var group in duplicates)
                        {
                            Console.WriteLine("Duplicate values into list index {0}:" + group.index);
                        }
                    }
                    else if (search == k.ToString())
                    {
                        break;
                    }
                }
                
                else
                {
                    Console.WriteLine("String is not in list");
                    Console.ReadLine();
                    break;
                }

            }
            /****11 Question ***/
            List<string> strList = new List<string>()
            { "abc","cdc","abc","edf","Def"};
            foreach(string check in strList)
            {
                if (strList.Contains("abc")){
                    Console.WriteLine("This is Already In the List :"+strList.IndexOf(check));
                        }
                else
                {
                    Console.WriteLine("Doesn't Exist");
                }
                Console.WriteLine(String.Join(",",check));
                Console.ReadLine();

                
            }
            Console.ReadLine();
            

        }
    }
}
