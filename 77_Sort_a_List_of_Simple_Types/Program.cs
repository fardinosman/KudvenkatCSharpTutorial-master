using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _77_Sort_a_List_of_Simple_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number = new List<int> { 2, 5, 4, 556, 52, 44, 88 };
            foreach (var item in number)
            {
                Console.WriteLine(item);
            }

            number.Sort();


            //            List<int> number = new List<int> { 2, 5, 4, 556, 52, 44, 88 };
            foreach (var item in number)
            {
                Console.WriteLine(item);
            }
            number.Reverse();


            // List<int> number = new List<int> { 2, 5, 4, 556, 52, 44, 88 };
            foreach (var item in number)
            {
                Console.WriteLine(item);
            }

            number.Sort();

            List<string> alfabet = new List<string> { "A", "B", "D", "G" };

            foreach (var item in alfabet)
            {
                Console.WriteLine(item);
            }
            alfabet.Sort();
            foreach (var item in alfabet)
            {
                Console.WriteLine(item);
            }

            Customer customer1 = new Customer();
            customer1.ID = 45;
            customer1.Name = "Fardin";
            customer1.Salary = 10000;


            Customer customer2 = new Customer();
            customer2.ID = 2;
            customer2.Name = "fffFardin";
            customer2.Salary =5000;


            Customer customer3 = new Customer();
            customer3.ID = 3;
            customer3.Name = "ddFardin";
            customer3.Salary = 6000;

            List<Customer> customerslist = new List<Customer>();

            customerslist.Add(customer1);
            customerslist.Add(customer2);
            customerslist.Add(customer3);
            Console.WriteLine("befor sorting");
            foreach (var item in customerslist)
            {
                Console.WriteLine(item.Salary);
            }

            customerslist.Sort();
            Console.WriteLine("after sorting");
            foreach (var item in customerslist)
            {
                Console.WriteLine(item.Salary);
            }
         

            SortByName sortbyname = new SortByName();
            customerslist.Sort(sortbyname);
            Console.WriteLine("Sorting by name");
            foreach (var c in customerslist)
            {
                Console.WriteLine(c.Name);
            }
            Comparison<Customer> customComparison = new Comparison<Customer>(ComparisonCustomer);
            Console.WriteLine("Befor sorting");
            foreach (Customer cus in customerslist)
            {
                Console.WriteLine(cus.ID);
            }

            customerslist.Sort(customComparison);
            Console.WriteLine("After sorting");
            foreach (Customer cus in customerslist)
            {
                Console.WriteLine(cus.ID);
            }

            Console.WriteLine("After sorting");

        }

        private static int ComparisonCustomer(Customer x, Customer y) 
        {
            return x.ID.CompareTo(y.ID);
        }
    }
    public class SortByName : IComparer<Customer>
    {
       public int Compare(Customer x , Customer y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
    public class Customer :IComparable<Customer>//sorting complex time
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public int CompareTo(Customer other)
        {
            if (this.Salary > other.Salary)
            {
                return 1;
            }
            else if (this.Salary < other.Salary)
            {
                return -1;
            }
            else
            {
                return 0;
            }

            // because int implement Icomperable
            // so we can also do this
            //return this.Salary.CompareTo(other.Salary);
            //return this.Salary.CompareTo(other.Salary);

        }
    }
}
