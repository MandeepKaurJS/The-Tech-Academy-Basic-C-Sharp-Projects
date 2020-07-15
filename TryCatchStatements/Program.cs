using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                int[] number = { 2, 3, 4, 5, 6, 7, 8 };
                Console.WriteLine("Pick any number.");
                int num = Convert.ToInt32(Console.ReadLine());
                for (var i = 0; i < number.Length; i++)
                {
                    int Divide = number[i] / num;
                    Console.WriteLine("After Dividing number is : "+Divide);
                    Console.ReadLine();
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Choose Another num, We Can't divide any number by Zero" );
            }
            catch (System.FormatException e)
            {
                Console.WriteLine("Integer is not Divide by string or chararcter" );
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
