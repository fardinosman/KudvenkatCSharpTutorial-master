using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16DifferentTypesOfMethodParamters
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0; // have its own memory location
            Program.SimpleMethod( ref  i); // when we use ref key word we now make reference type
            // so now they both point to same memory location i  =  0 and j = 0 both point to 0 
            //in same memory location
            Console.WriteLine(i );


            int total = 0;
            int product = 0;
            Program.calculate(30, 30, out total, out  product);

            Console.WriteLine(total + " " + product);
            // parameter arrays

            int[] numbers = new int[3];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;

            Program.ParamsMethod(1,2,3,4,5,8);// we can make optional by using params

        }
        public static void SimpleMethod(ref int j) // j has also own memory location both are 0 
        {
            j = 101;
        }

        public static void calculate(int f, int s, out int sum, out int product)// since we are using 
            //out parameter we dont need int return type
        {
            sum =  f + s;
            product = f * s;
        }

        // parameter arrays
        public static void ParamsMethod(params int[] numbers) // params has to be last one (int x, params int[] numers)
        {
            Console.WriteLine("there are  {0 } ", numbers.Length);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
