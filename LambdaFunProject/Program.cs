using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaFunProject
{
    class Program
    {
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public int idnum { get; set; }
        
        
    }
    class Employee
    {
        static void Main(string[] args)
        {
            Program prog = new Program();

            List<Program> emplist = new List<Program>() {
            new Program(){idnum=1,Firstname="mandeep",LastName="Kaur" },
            new Program(){ idnum=5,Firstname="joe",LastName="bob"},
            new Program(){ idnum=10,Firstname="joe",LastName="hena" },
            new Program(){ idnum=15,Firstname="joe",LastName="hena" },
            new Program(){ idnum=16,Firstname="heena",LastName="hena" },
            new Program(){ idnum=17,Firstname="Shruti",LastName="hena" },
            new Program(){ idnum=18,Firstname="Anubha",LastName="hena" },
            new Program(){ idnum=19,Firstname="Navi",LastName="hena" },
            new Program(){ idnum=20,Firstname="joe",LastName="hena" },
            new Program(){ idnum=21,Firstname="Varinder",LastName="singh" }
             };
            //List<string> newlist = new List<string>();
            foreach (Program list in emplist)
            {
                Console.WriteLine(list.Firstname+" " +" "+ list.LastName + " "+list.idnum);

                Console.ReadLine();

            }
            foreach (Program list in emplist)
            {
                if (list.Firstname == "joe")
                {
                    Console.WriteLine("Here is me whose First name is: " + list.Firstname);
                    // Console.ReadLine();
                }

                Console.ReadLine();

            }
            List<Program> resultName = emplist.Where(x => x.Firstname=="joe").ToList();

            foreach (Program firstname in resultName)
            {
                Console.WriteLine("All First Name With same name:  " + firstname.Firstname);
                Console.ReadLine();
            }
            List<Program> result = emplist.Where(x => x.idnum > 5).ToList();
            
            foreach(Program firstname in result)
            {
                Console.WriteLine("Id greater than 5:  " + firstname.idnum);
                Console.ReadLine();
            }

           


        }
    }
}
