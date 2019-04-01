using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToInterface
{
    interface ICustomer
    {
        void Print();// we can not have implemention //method // properties //but cant have field
    }
    interface I2
    {
        void Method2();
    }
    public class Customer : ICustomer2 ,I2 //  we have to provide implemention for the interface
    {//class can inherit multiple interface
        public void Method2()
        {
            Console.WriteLine("I2 Method");
        }

        public void Print()
        {
            Console.WriteLine("Print1");
        }

        public void Print2()
        {
            Console.WriteLine("print2");
        }
    }
    interface ICustomer2 :ICustomer
    {
        void Print2();
    }
    class Sample
    {

    }

    public class Program 
    {
        static void Main(string[] args)
        {

            Customer c1 = new Customer();
            c1.Print();
            c1.Print2();

            ICustomer cust = new Customer();
            cust.Print(); // we can only see the Print() method 
            //because ICustomer cust is type of ICustomer 
        
        }
    }
}

/*
 * interfaces are reference type
 * interfaces can only contain declartion and not implemention
 * 
 * interfaces can inherit from other intefaces chain of interface like the exsample abov
 * 
 * we can not create an  instance of a interface, but
 * an interface reference variable can point to a derived class object
 * 
 *     ICustomer customer = new ICustomer();
    customer.Print(); we can do this because the print method not implements


*/
