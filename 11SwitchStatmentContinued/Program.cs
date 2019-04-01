using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11SwitchStatmentContinued
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalCoffeCost = 0;
            Start: // lable mark control jump here 
            bool stop = true;
            Console.WriteLine("1 . small, 2 -meduim, 3 _ Large");

            int userchoice = int.Parse(Console.ReadLine());
            switch (userchoice)
            {
                case 1:
                    totalCoffeCost += 1;
                    break;
                case 2:
                    totalCoffeCost += 2;

                    // we can also use goto to jump to a case statement case 1;
                    break;
                case 3:
                    totalCoffeCost += 3;
                    break;
                default:
                    Console.WriteLine("your choice is invalid {0}");
                    goto Start;
            }
            Decide:
            Console.WriteLine("do you want a another coffee");
      
            string userdecision = Console.ReadLine();
            
            switch (userdecision.ToUpper())
            {
                case "YES":
                    goto Start;
                case "NO":
                    break;
                default:
                    Console.WriteLine("your choice { 0} is invalid. please try again",userdecision);
                    goto Decide;
                  
            }

            Console.WriteLine("that for shopping with us");
            Console.WriteLine("total coffe cost = {0}",totalCoffeCost);

        }
    }
}
