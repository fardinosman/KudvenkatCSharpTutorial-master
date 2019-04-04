using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _82_Generic_Queue_collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.ID = 1;
            c1.Name = "Faridn";
            c1.Gender = "Male";

            Customer c2 = new Customer();
            c1.ID = 2;
            c1.Name = "masn";
            c1.Gender = "Male";

            Customer c3 = new Customer();
            c1.ID = 3;
            c1.Name = "Yoyo";
            c1.Gender = "Male";

            Customer c4 = new Customer();
            c1.ID = 4;
            c1.Name = "West";
            c1.Gender = "female";

            Customer c5 = new Customer();
            c1.ID = 5;
            c1.Name = "lolo";
            c1.Gender = "female";

            Queue<Customer> queueCustomer = new Queue<Customer>();
            queueCustomer.Enqueue(c1);
            queueCustomer.Enqueue(c2);
            queueCustomer.Enqueue(c3);
            queueCustomer.Enqueue(c4);
            queueCustomer.Enqueue(c5);
            foreach (Customer customer in queueCustomer)
            {
              
                Console.WriteLine(customer.ID + " "+customer.Name + " "+  queueCustomer.Count);
              
            }
             Customer  c = queueCustomer.Peek();
            Console.WriteLine(" Peek " + c.Name);

            Customer c22 = queueCustomer.Peek();
            Console.WriteLine(" Peek " + c22.Name);

            bool d = queueCustomer.Contains(c1);
            Console.WriteLine(d);
            Customer cone = queueCustomer.Dequeue();
            Console.WriteLine(cone.ID+ " " + cone.Name+ " " + cone.Gender);
            Console.WriteLine("Total item in the queue = "+ queueCustomer.Count);
            Customer con2 = queueCustomer.Dequeue();
            Console.WriteLine(cone.ID + " " + cone.Name + " " + cone.Gender);
            Console.WriteLine("Total item in the queue = " + queueCustomer.Count);
            Customer con3 = queueCustomer.Dequeue();
            Console.WriteLine(cone.ID + " " + cone.Name + " " + cone.Gender);
            Console.WriteLine("Total item in the queue = " + queueCustomer.Count);
            Customer con4 = queueCustomer.Dequeue();
            Console.WriteLine(cone.ID + " " + cone.Name + " " + cone.Gender);
            Console.WriteLine("Total item in the queue = " + queueCustomer.Count);
            Customer con5 = queueCustomer.Dequeue();
            Console.WriteLine(cone.ID + " " + cone.Name + " " + cone.Gender);
            Console.WriteLine("Total item in the queue = " + queueCustomer.Count);

        }
    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
}
