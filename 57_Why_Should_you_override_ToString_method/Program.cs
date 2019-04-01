using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57_Why_Should_you_override_ToString_method
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number = 10;
            Console.WriteLine(Number.ToString());
            Customer c1 = new Customer();
            c1.FirstName = "Faridn";
            c1.LastName = "Osman";
            Console.WriteLine(  c1.ToString());
            Console.WriteLine(Convert.ToString(c1));
        }
    }
    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return FirstName + " , " + LastName;
        }
    }
}
