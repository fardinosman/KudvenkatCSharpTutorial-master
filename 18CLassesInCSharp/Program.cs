using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18CLassesInCSharp
{
    class Customer
    {
        string _firstName;
        string _lastName;

        //constructer is to initialize field or propertys
        public Customer() :this("No firtname", "no lastname provided")
        {

        }
        public Customer(string fname, string lastname)
        {
            this._firstName = fname;
            this._lastName = lastname;            
        }
        ~Customer() // basically usend to clean your object from memory
        {

        }
        public void PrintFullName()
        {
            Console.WriteLine("Fullname Name = {0}", this._firstName + " " + this._lastName);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Class
            // class constructer
            //complex custum type
            //this
            //overloading

            Customer c1 = new Customer("fardin","osman");
            Customer c2 = new Customer();
            c1.PrintFullName();
            c2.PrintFullName();


        }
    }
}
