using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _83_Generic_Stack_Collection_class
{
    class Program // last in first out
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.ID = 1;
            c1.Name = "f";
            c1.Salary = 2000;


            Customer c2 = new Customer();
            c2.ID = 2;
            c2.Name = "m";
            c2.Salary = 3000;


            Customer c3 = new Customer();
            c3.ID = 3;
            c3.Name = "c";
            c3.Salary = 4000;


            Customer c4 = new Customer();
            c4.ID = 4;
            c4.Name = "d";
            c4.Salary = 5000;


            Customer c5 = new Customer();
            c5.ID = 5;
            c5.Name = "h";
            c5.Salary = 7000;

            Stack<Customer> StackCustomers = new Stack<Customer>();
            StackCustomers.Push(c1);
            StackCustomers.Push(c2);
            StackCustomers.Push(c3);
            StackCustomers.Push(c4);
            StackCustomers.Push(c5);
            Customer k11 = StackCustomers.Peek();
           bool dd=  StackCustomers.Contains(c1);
            Console.WriteLine(dd);


            Console.WriteLine(k11.Name + "  peek");
            foreach (var item in StackCustomers)
            {
                Console.WriteLine(item.ID + " " +item.Name);
            }

           Customer k1 = StackCustomers.Pop();
            Console.WriteLine(k1.ID +" " +k1.Name);
            Console.WriteLine("Items left in stack " + StackCustomers.Count);

            Customer k2 = StackCustomers.Pop();
            Console.WriteLine(k2.ID + " " + k2.Name);
            Console.WriteLine("Items left in stack " + StackCustomers.Count);
            Customer k3 = StackCustomers.Pop();
            Console.WriteLine(k3.ID + " " + k3.Name);
            Console.WriteLine("Items left in stack " + StackCustomers.Count);
            Customer k4 = StackCustomers.Pop();
            Console.WriteLine(k4.ID + " " + k4.Name);
            Console.WriteLine("Items left in stack " + StackCustomers.Count);
            Customer k5 = StackCustomers.Pop();
            Console.WriteLine(k4.ID + " " + k4.Name);
            Console.WriteLine("Items left in stack " + StackCustomers.Count);
        }
    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
