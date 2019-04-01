using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismInCSharp
{
    public class  Employee
    {
        public string FirstName = "FN";
        public string LastName = "LN";

        public virtual void PrintFullName()
        {
            Console.WriteLine(FirstName + "  " + LastName);
        }
    }
    public class PartTimeEmployee :Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + "  " + LastName + " - PartTime");
        }
    }
    public class FullTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + "  " + LastName + " - FullTime");
        }
    }
    public class TemporaryEmployee :Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + "  " + LastName+" - TempTime");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Overriding virtual methods
            //Polymorphism

            Employee[] employees = new Employee[4];
            employees[0] = new Employee();
            employees[1] = new PartTimeEmployee();
            employees[2] = new FullTimeEmployee();
            employees[3] = new TemporaryEmployee();

            foreach (var item in employees)
            {
                item.PrintFullName();
            }
            //Employee employee = new Employee();
            //employee.PrintFullName();

             

        }
    }
}
