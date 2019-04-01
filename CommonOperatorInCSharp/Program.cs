using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonOperatorInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            int anothernumber = 20;
            if (number == 10 && anothernumber ==20) // AND operator
            {
                Console.WriteLine("ok");
            }

            if (number == 10 || anothernumber == 20) // OR operator
            {
                Console.WriteLine("ok");
            }

            bool IsNumber10;

            if (number == 10)
            {
                IsNumber10 = true;
            }
            else
            {
                IsNumber10 = false;
            }
            Console.WriteLine("Number is equal to 10 {0}", IsNumber10);

            //ternary operator

            bool IsNumber = number == 10 ? true : false;
            Console.WriteLine("TernaryOperator {0} ",IsNumber);

            Console.ReadKey();
        }
    }
}
