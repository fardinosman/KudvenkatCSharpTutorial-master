using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays

            int i = 10;
            int[] values = { 5,3,9,8,7,6,9,8};
            int[] hold = new int[5];
            hold[0] = 1;
            hold[1] = 2;
            hold[2] = 3;
            hold[3] = 4;
            hold[4] = 5;
            hold[5] = 5; // we get error indexoutofrange exception, it can only hold 5 items
            // we get exception at runtime

            //array can not grow once its initialiazed

            Console.WriteLine(hold[4]);



        }
    }
}
