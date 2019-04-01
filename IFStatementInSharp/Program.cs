using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFStatementInSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // if statement
            // if else 
            // differnece between && and  &
            //difference betwwen ||  and |

            Console.WriteLine("please enter a number");

            int usernumber = int.Parse(Console.ReadLine());

            if (usernumber ==1) // boolean expression
            {
                Console.WriteLine("your number one is 1");
            } else if (usernumber == 2) // boolean expression
            {
                Console.WriteLine("your number one is 2");
            }else if (usernumber == 3) // boolean expression
            {
                Console.WriteLine("your number one is 3");
            }
            else
            {
                Console.WriteLine("your number is not between 1 and 3");
            }

            //if (usernumber != 1 && usernumber != 2 & usernumber != 3)
            //{
            //    Console.WriteLine("your number is not between 1 and 3");
            //}

            if (usernumber ==10 || usernumber ==20)
            {
                Console.WriteLine("your number is  {0}: ", usernumber);
            }

            // the difference between double pipe and singel pipe is
            // that if we use singel pipe it checks bother expression usernumber == 10 | usernumber == 20
            // where as double piple only checkt the first expression dont and if its true it dosent check
            //the other expression
            //double pipe is faster

            if (usernumber == 10 | usernumber == 20)
            {
                Console.WriteLine("your number is  {0}: ", usernumber);
            }
            //single amparsen checks both expression
            //double expression check only the first expression
            //double ampersen is faster
            if (usernumber == 10 & usernumber == 20)
            {
                Console.WriteLine("your number is  {0}: ", usernumber);
            }


        }

    }
}
