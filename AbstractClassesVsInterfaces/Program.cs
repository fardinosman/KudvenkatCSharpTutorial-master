using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesVsInterfaces
{//abstract calss is private by default
  public   abstract class Customer
    {
        public void Print() // differnce we can have implemention and access modifier
        {

        }
    }
    public interface ICustomer // interface we can not have access modifier but its public by default also
        // intercases we have to provide for all interface members
    {
        void Print();
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
/*
 an abstract class can not inherit from abstract class or none abstract class
 but a interface can inherit from another interface 
     */
