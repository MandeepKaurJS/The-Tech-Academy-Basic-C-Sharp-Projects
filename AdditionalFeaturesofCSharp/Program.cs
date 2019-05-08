using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalFeaturesofCSharp
{
    class Program
    {
        private int Age;
        private string TheName;
        private string HairColour;


        public Program(int theAge) : this(theAge, "", "")
        {
            //One parameter
        }

        public Program(int theAge, string theName) : this(theAge, theName, "")
        {
            //Two Parameters
        }

        public Program(int theAge, string theName, string theHairColour)
        {
            //Three parameters
            Age = theAge;
            TheName = theName;
            HairColour = theHairColour;
        }


        static void Main(string[] args)
        {
            const string Name = "Mandeep Kaur";
            var age = 25;
            Console.WriteLine("Constant string and var Age: " + Name + "\n " + age);
            Console.ReadLine();
            /***Consrutor with one parameter  ****/
            var PassCons = new Program(age);
            Console.WriteLine("Employee Age: "+PassCons.Age);
            /**** This is Constructor with two parameter***/
            /***if I pass Const  value to Constructor it will remain the same not changable any more****/
            var cons = new Program(24,Name);
            Console.WriteLine("Employee Age and Name: "+"Age: "+ cons.Age+"\nName: "+cons.TheName);
            Console.ReadLine();
            /***Consructor with three parameters ***/
            var consone = new Program(24,"Mandeep","Black");
            Console.WriteLine("Eployee full info: "+"Age: "+consone.Age+"\nName: "+consone.TheName+"\nHaircolor: "+consone.HairColour);
            Console.ReadLine();
            
            
           


        }
    }
}
