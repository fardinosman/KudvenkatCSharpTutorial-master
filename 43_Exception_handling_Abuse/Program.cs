using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_Exception_handling_Abuse
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

         
            Console.WriteLine("enter numerator");
            int Numerator = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter Denomintor");
            int Denomintor = Convert.ToInt32(Console.ReadLine());

            int result = Numerator / Denomintor;

            Console.WriteLine("Result = {0}", result);
            }
            catch (FormatException )
            {

                Console.WriteLine("Please enter a number");
            }
            catch(OverflowException)
            {
                Console.WriteLine("Only numbers between  {0} && {1}",Int32.MinValue, Int32.MaxValue);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Denominator can not be  zero");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
/*
 * 
 * */