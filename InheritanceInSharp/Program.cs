using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInSharp
{

    //base class becuase firstname to avoid code 2 timees deplucate
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public void PrintFullName()
        {
            Console.WriteLine("info {0} {1} {2} ",FirstName, LastName, Email);
        }
    }
    public class FullTimeEmployee :Employee
    {
  
        public float YearSalary { get; set; }

    }
    public class PartTimeEmployee :Employee
    {
       
        public float hourlyTimeSalary { get; set; }

    }
    //we can also do this 
    // so we can have access to partimeemployee and employye
    class A :PartTimeEmployee
    {

    }

   

    class Program
    {
        static void Main(string[] args)
        {

            //Inheritance it allow code reuse and it can reduce time and error
            // Inheritance is 1 of 4 pillar of OOP object Oriented Programming
            // c# support only support single class inheritance

            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();

            fullTimeEmployee.LastName = "Osman";
            fullTimeEmployee.FirstName = "Fardin";
            fullTimeEmployee.Email = "Osmanfardin@hotmail.dk";
            fullTimeEmployee.YearSalary = 25000;
            fullTimeEmployee.PrintFullName();

            PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
            partTimeEmployee.FirstName = "part";
            partTimeEmployee.LastName = "time";
            partTimeEmployee.PrintFullName();

            A a1 = new A();
            a1.FirstName = "";
            //so multiple inheritance at the same time is not possible   
            //so multiple level inheritance is possible class A inheri from Partimeemployee and Employee
        }
    }
}
