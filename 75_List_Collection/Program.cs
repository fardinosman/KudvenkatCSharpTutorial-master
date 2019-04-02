using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.ID = 1;
            c1.Name = "Name";
            c1.Salary = 3999;

            Customer c2 = new Customer();
            c2.ID = 2;
            c2.Name = "Ola";
            c2.Salary = 5099;

            Customer c3 = new Customer();
            c3.ID = 101;
            c3.Name = "Ola";
            c3.Salary = 5099;

            Customer[] cuArr = new Customer[2];
            cuArr[0] = c1;
            cuArr[1] = c2;
            // cuArr[2] = c2;

            List<Customer> cusList = new List<Customer>(2);
            cusList.Add(c1);
            cusList.Add(c2);
            cusList.Add(c2);

            Customer cr = cusList[0];
            Console.WriteLine(cr.Name);

            for (int i = 0; i < cusList.Count; i++)
            {
                Console.WriteLine(cusList[i].Name);
            }
            List<Customer> custom = cusList.FindAll(cus => cus.Salary > 5000);
            Console.WriteLine("------------");
            foreach (Customer item in custom)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("----------------");
            int index = cusList.FindIndex(cus => cus.Salary > 5000);
            Console.WriteLine("index {0} ", index);
            Console.WriteLine();
        }
    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
