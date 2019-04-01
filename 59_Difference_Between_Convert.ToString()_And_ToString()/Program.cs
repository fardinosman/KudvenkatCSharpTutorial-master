using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _59_Difference_Between_Convert.ToString___And_ToString__
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.Name = "Far";
            string str = c1.ToString();
            Console.WriteLine(str);
        }
    }
    public class Customer
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
