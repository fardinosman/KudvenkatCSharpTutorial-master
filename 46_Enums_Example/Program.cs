using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46_Enums_Example
{
    public class Customer
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer[] customers = new Customer[3];

            customers[0] = new Customer { Name = "Fardin", Gender = Gender.Male };
            customers[1] = new Customer { Name = "mAsi", Gender = Gender.Male };
            customers[2] = new Customer { Name = "Denia", Gender = Gender.Unknown };

            foreach (var customer in customers)
            {
                Console.WriteLine("Name = {0} && Gender = {1}", customer.Name, GetGender(customer.Gender));
            }
        }
        public static string GetGender(Gender gender)
        {
            switch (gender)
            {
                case Gender.Unknown:
                    return "Unknown";
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "Female";
                default:
                    return "Invalid data detected";


            }
        }
    }
   public enum Gender
    {
        Unknown,
        Male,
        Female
    }

}
