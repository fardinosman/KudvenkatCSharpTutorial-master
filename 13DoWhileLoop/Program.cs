using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //do while loop
            string userdecion = string.Empty;
            do
            {
                int start = 0;
                Console.WriteLine("enter the target number");
                int userchoice = int.Parse(Console.ReadLine());

                while (start <= userchoice)
                {
                    Console.WriteLine(start + " ");
                    start = start + 2;
                }

                do
                {

                    Console.WriteLine("Do you want to continue yes or no?");
                    userdecion = Console.ReadLine().ToUpper();

                    if (userdecion != "YES" && userdecion != "NO")
                    {
                        Console.WriteLine("invalid choice, please enter yes or no");
                    }
                } while (userdecion != "YES" && userdecion != "NO");


            } while (userdecion =="YES");

            }

    }




}

