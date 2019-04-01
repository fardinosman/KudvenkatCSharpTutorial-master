using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_Delegates
{
    public delegate void HelloFunctionDelegate(string Message); // it have to match mehod signature
    class Program
    {
        static void Main(string[] args)
        {
            // int the constructer of a delegate we pass the  name of method to which delegate to point to 
            HelloFunctionDelegate helloFunctionDelegate = new HelloFunctionDelegate(Hello);
            // we call the delegate and pass parameter
            helloFunctionDelegate("Hello from Youtube");

        }



        public static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
        }
    }

    
}
/*
 we learn the basic of delegates

    what is a delegate
    // defination
    delegate is a function pointer 
    delegate is a type safe function pointer


    to create a delegate we use delegate keyword

    and we make instance of delegate
    it holds a refereence pointer to a function

     */