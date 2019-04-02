using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _72_Dictionar
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
            c3.ID = 3;
            c3.Name = "Ola";
            c3.Salary = 5099;

            Dictionary<int, Customer> dictionarCustomer = new Dictionary<int, Customer>();

            dictionarCustomer.Add(c1.ID, c1);
            dictionarCustomer.Add(c2.ID, c2);
            if (!dictionarCustomer.ContainsKey(c1.ID))
            {
                dictionarCustomer.Add(c1.ID, c1);
            }
            dictionarCustomer.Add(c3.ID, c3);// if we add the same key we get runtime exception

            Customer customer1 = dictionarCustomer[1];

            Console.WriteLine("ID = {0}, Name = {1}, Salary = {1}",customer1.ID,customer1.Name,customer1.Salary );

            foreach (KeyValuePair<int,Customer> keyValuePair in dictionarCustomer)
            {
                Console.WriteLine( "ID = {0} ", keyValuePair.Key);
                Customer cust = keyValuePair.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}",cust.ID,cust.Name,cust.Salary);
                Console.WriteLine("---------------------------------------------------------");


            }
            //foreach (KeyValuePair<int, Customer> keyValuePair in dictionarCustomer.Keys)
            //{


            //    int s = keyValuePair.Key;
            //}
            foreach (Customer keyValuePair in dictionarCustomer.Values)
            {


                Console.WriteLine("ID = {0}, Name {1} , Salary {2}", keyValuePair.ID,keyValuePair.Name,keyValuePair.Salary);
            }


        }
    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}/*

 */