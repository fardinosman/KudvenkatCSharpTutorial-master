using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _80_some_meth_usefull_of_list_colltion_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             True for all  
             TrueForAll()

             */
            Customer c1 = new Customer();
            c1.ID = 1;
            c1.Name = "fardin";
            c1.Salary = 5000;
            Customer c2 = new Customer();
            c2.ID = 1;
            c2.Name = "masi";
            c2.Salary = 55000;
            Customer c3 = new Customer();
            c3.ID = 3;
            c3.Name = "jhon";
            c3.Salary = 8000;

            List<Customer> cList = new List<Customer>();
            cList.Add(c1);
            cList.Add(c2);
            cList.Add(c3);

            Console.WriteLine("Are all salaries greater that 3000 = " + cList.TrueForAll(x => x.Salary >3000));

            ReadOnlyCollection<Customer> readonlyco = cList.AsReadOnly();
            foreach (var item in readonlyco)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("Item  = " + readonlyco.Count); 
        }
    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
