using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WxplicitInterfaceImplemention
{
    interface I1
    {
        void interfaceMethod();
    }
    interface I2
    {
        void interfaceMethod();
    }
    class Program : I1,I2
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            ((I1)p).interfaceMethod();//type casting
            ((I2)p).interfaceMethod();


            //this another way
            I1 i1 = new Program();
            i1.interfaceMethod();

            I1 i2 = new Program();
            i2.interfaceMethod();



        }

        //public void interfaceMethod()
        //{
        //    Console.WriteLine("interfaceMethod");
        //}
        // we can also this 
         void I1.interfaceMethod()
        {
            Console.WriteLine("I1 interfaceMethod");
        }
        void I2.interfaceMethod()
        {
            Console.WriteLine("I2 interfaceMethod");
        }
    }
}
/*
 if 2 interfaces have the same method , then we use explixit we type cast

     */
