using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _76_Generic_List_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.ID = 1;
            c1.Name = "Fardin";
            c1.Salary = 2999;
            c1.Type = "Retail Customer";

            Customer c2 = new Customer();
            c2.ID = 2;
            c2.Name = "masi";
            c2.Salary = 4999;
            c2.Type = "Retail Customer";

            Customer c3 = new Customer();
            c3.ID = 3;
            c3.Name = "Carsten";
            c3.Salary = 5999;
            c3.Type = "Corporate Customer";

            Customer c4 = new Customer();
            c1.ID = 4;
            c1.Name = "Tod";
            c1.Salary = 1999;
            c1.Type = "Corporate Customer";

            Customer c5 = new Customer();
            c1.ID = 5;
            c1.Name = "Raoul";
            c1.Salary = 6999;
            c1.Type = "Corporate Customer";

            List<Customer> retailCustomerList = new List<Customer>();
            retailCustomerList.Add(c1);
            retailCustomerList.Add(c2);

            List<Customer> corporateCustomerList = new List<Customer>();

            corporateCustomerList.Add(c3);
            corporateCustomerList.Add(c4);
            corporateCustomerList.Add(c5); 

            retailCustomerList.AddRange(corporateCustomerList);
            retailCustomerList.RemoveAll(x => x.Type == "Corporate Customer");
            retailCustomerList.RemoveRange(3, 2);
            List<Customer> kunde = retailCustomerList.GetRange(3, 1);

            retailCustomerList.InsertRange(0, corporateCustomerList);

            foreach (Customer item in retailCustomerList)
            {
                Console.WriteLine(item.Name + " " +item.Type);
            }

        }
    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Type { get; set; }
    }

}
