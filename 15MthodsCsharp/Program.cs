using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15MthodsCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Methods or function


            /* Program p = new Program();
                 p.PrintEvenNumbers();
            */
            Console.WriteLine("enter target");
            Program.PrintEvenNumbers(30);
            var result  = Program.Add(10, 20);
            Console.WriteLine(result);
        }
        public static void PrintEvenNumbers(int target)
        {
            int start = 0;
            while (start <= target)
            {
                Console.WriteLine(start);
                start = start + 2;
            }
        }

        public static int Add(int FN, int SN)
        {
            return FN + SN;
        }
    }
}
