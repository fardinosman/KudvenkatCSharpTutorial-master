using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructsInCSharp
{
    public struct Customer
    {
        int _id;
        string _name;
        int _passMark;

        public int ID { get { return this._id; } set { this._id = value; } }

        public string Name { get => _name; set => _name = value; }
        public int PassMark { get => _passMark; set => _passMark = value; }

        public Customer(int id, string name, int passmark)
        {
            this._id = id;
            this._name = name;
            this._passMark = passmark;
        }

        public void PrintDetails()
        {
            Console.WriteLine("Id = {0} && Name = {1} PassMark = {2}", this._id, this._name, this._passMark);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //we learn about structs

            //we follow the exsact 

            Customer c1 = new Customer(101,"name",-123456  );
            
            c1.PrintDetails();
            Customer c2 = new Customer();
            c2.ID = 12;
            c2.Name = "Name";
            c2.PrintDetails();
           
            
            
            //instead all the above 
            // we can use object initialization intrud in c# 3.0

            Customer c3 = new Customer
            {
                ID = 123,
                Name = "Fardin"
            };
        }
    }
}
