using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49_Access_Modifiers
{
   
    public class Customer
    {
        private int _id;

        public int ID 
        {
            get 
            { return this._id;
            }
            set 
            { this._id = value;
            }
        }
    }
    public class Car
    {
        protected int _id;

        protected int ID {
            get {
                return this._id;
            }
            set {
                this._id = value;
            }
        }
    }
    public class Toyota :Car
    {
        
        public void PrintId()
        {
            Toyota t1 = new Toyota();
            t1.ID = 1;

            base.ID = 1;

            this.ID = 23;
            // 3 ways
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.ID = 12;
            Console.WriteLine(c1.ID);
        }
    }
}
