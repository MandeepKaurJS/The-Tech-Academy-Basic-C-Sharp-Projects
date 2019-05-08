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
            /*** if I pass Const Name value to Constructor it will remain the same not changable any more ****/
            var PassCons = new Program(24);
            Console.WriteLine("Employee Age: "+PassCons.Age);
            /**** This is Constructor with two parameter***/
            var cons = new Program(24,"Mandeep");
            Console.WriteLine("Employee Age and Name: "+"Age: "+ cons.Age+"\nName: "+cons.TheName);
            Console.ReadLine();
            /*** Consrutor with one parameter***/
            var consone = new Program(24,"Mandeep","Black");
            Console.WriteLine("Eployee full info: "+"Age: "+consone.Age+"\nName: "+consone.TheName+"\nHaircolor: "+consone.HairColour);
            Console.ReadLine();
            
            
           


        }
    }
}
