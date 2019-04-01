using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44_Exception_Handling_Abuse_Solved
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {


                Console.WriteLine("enter numerator");
                int Numerator;
                bool isnumeratorconverionSuccessful = Int32.TryParse(Console.ReadLine(), out Numerator);
                //= Convert.ToInt32(Console.ReadLine());
                if (isnumeratorconverionSuccessful)
                {


                    Console.WriteLine("enter Denomintor");
                    int Denominator;
                    bool isdenominatorconverionSuccessful = Int32.TryParse(Console.ReadLine(), out Denominator);
                    if (isdenominatorconverionSuccessful && Denominator != 0)
                    {
                        int result = Numerator / Denominator;

                        Console.WriteLine("Result = {0}", result);
                    }
                    else
                    {
                        if (Denominator ==0)
                        {
                            Console.WriteLine("Denominator can not be  zero");
                        }
                        else
                        {
                            Console.WriteLine("Denominator should be a valid number between {0} && {1}", Int32.MinValue, Int32.MaxValue);
                        }

                    }
                   
                  
                }
                else
                {
                    Console.WriteLine("Numeerator should be a valid number between {0} && {1}",Int32.MinValue, Int32.MaxValue);
                }
            }

            //catch (FormatException)
            //{

            //    Console.WriteLine("Please enter a number");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("Only numbers between  {0} && {1}", Int32.MinValue, Int32.MaxValue);
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Denominator can not be  zero");
            //}
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
