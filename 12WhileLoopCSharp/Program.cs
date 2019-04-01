using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12WhileLoopCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            //while

            Console.WriteLine("enter number");

            int value = int.Parse(Console.ReadLine());

            int start = 0;

            while (start <= value)
            {
                Console.WriteLine(start);
                start = start + 2;

            }
        }
    }
}
