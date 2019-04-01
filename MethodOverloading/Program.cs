using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Add(5, 5, ref sum);
            Console.WriteLine(sum);
        }

        public static void Add(int fn, int sn)
        {
            Console.WriteLine("Sum = {0}", fn+sn);
        }
        public static void Add(int fn, int sn, int Tn)
        {
            Console.WriteLine("Sum = {0}", fn + sn);
        }
        public static void Add(int fn, int sn, int Tn, int fnn)
        {
            Console.WriteLine("Sum = {0}", fn + sn);
        }
        public static void Add(float fn, float sn)
        {
            Console.WriteLine("Sum = {0}", fn + sn);
        }
        public static void Add(int fn,  int sn, ref int sum)
        {
            Console.WriteLine("Sum = {0}", fn + sn);
            sum = fn + sn;
        }
        public static int Add(int fn, int sn, int ff) // its not possble overload function 
            // with int modifier or params
        {
            Console.WriteLine("Sum = {0}", fn + sn);
            return 4;
        }
        public static int Add(int[] fn, int sn, int ff) // its not possble overload function 
                                                      // with int modifier or params
        {
            Console.WriteLine("Sum = {0}");
            return 4;
        }
    }
   
}
