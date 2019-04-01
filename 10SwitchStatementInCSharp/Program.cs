using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10SwitchStatementInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //switch statement in c#

            // switch // break // escap

            Console.WriteLine("Please enter a number");

            int usernumber = int.Parse(Console.ReadLine());

            if (usernumber == 10)
            {
                Console.WriteLine("you number is 10");
            }
            else
            if (usernumber == 20)
            {
                Console.WriteLine("you number is 20");
            }
            else
            if (usernumber == 30)
            {
                Console.WriteLine("you number is 30");
            }
            else
            {
                Console.WriteLine("you number is not 10 , 20 or 30");
            }

            switch (usernumber)
            {
                //joinin multiple case statement
                case 10:
                    //Console.WriteLine("10");
                    //break;
                case 20:
                    //Console.WriteLine("20");
                    //break;
                case 30:
                    Console.WriteLine("your number is {0}", usernumber);
                    break;
                default:
                    Console.WriteLine(" not between 10 , 20 , 30");
                    break;
            }

        }
    }
}
