﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuranceProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? Give answer into true or false ");
            string Dui=Convert.ToString(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());
            bool qualified= (age <= 14 && Dui = false && tickets <= 3);
            Console.WriteLine("Qualified?"+qualified);
            
            

        }
    }
}
