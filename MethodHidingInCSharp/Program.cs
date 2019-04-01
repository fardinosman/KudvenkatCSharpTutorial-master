using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHidingInCSharp
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }

    public class PartimeEmployee : Employee
    {
        public new void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName  + " - Contractor");
        }
    }
    public class FullTimeEmployee :Employee
    {
        public  new void PrintFullName() //this method hides the Employee base class method
        {
            base.PrintFullName();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //method hiding
            //invoke hidden base class members

            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "FullTime";
            FTE.LastName = "Employee";

            FTE.PrintFullName();

            PartimeEmployee PTE = new PartimeEmployee();
            FTE.FirstName = "PartTime";
            FTE.LastName = "Employee";

          ((Employee)PTE).PrintFullName();

            // a child class reference variable can not point to parent class object
            // but a parent class reference variable can point to child class object 

            //Polymorphism







        }
    }
}
