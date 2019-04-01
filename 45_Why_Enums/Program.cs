using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45_Why_Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer[] customers = new Customer[3];

            customers[0] = new Customer { Name = "Fardin", Gender = 1 };
            customers[1] = new Customer { Name = "mAsi", Gender = 1 };
            customers[2] = new Customer { Name = "Denia", Gender = 0 };

            foreach (var customer in customers)
            {
                Console.WriteLine("Name = {0} && Gender = {1}",customer.Name , GetGender(customer.Gender));
            }
        }
        public static string GetGender(int gender)
        {
            switch (gender)
            {
                case 0:
                    return "Unknown";
                case 1:
                    return "Male";
                case 2:
                    return "Female";
                default:
                    return "Invalid data detected";

                    
            }
        }
    }

    // 0 -Unknown
    // 1- male
    // 2. female
    public class Customer
    {
        public string Name { get; set; }
        public int Gender { get; set; }
    }
}
/*
 why Enums

    Enums are strongly typed constants

    if a program  uses set of integra numbers, consider replacing them with enums
       
    otherwise the program becomes less
    readable
    maintainable

    
 */
