using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58_Why_Should_Override_Equals
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            int j = 10;

            Console.WriteLine(i.Equals(j));
            Console.WriteLine(i==j);

            Direction direction1 = Direction.East;
            Direction direction2 = Direction.West;

            Console.WriteLine(direction1 == direction2);
            Console.WriteLine(direction1.Equals(direction2));

            Customer c1 = new Customer();
            c1.FirstName = "fard";
            c1.LastName = "Tan";
            Customer c2 = c1;
            Customer c3 = new Customer();
            c3.FirstName = "fard";
            c3.LastName = "Tan";

            Console.WriteLine(c1==c2 );
            Console.WriteLine("override Equals");// (== value equality) -- Equal() = reference equality
            Console.WriteLine(c1.Equals(c2));//pointing same object on heap

            Console.WriteLine(c1.Equals(c3));// false 



            
        }
    }
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override bool Equals(object obj)
        {
            if (obj ==null)
            {
                return false;
            }
            if (!(obj is Customer))
            {
                return false; 
            }
            return this.FirstName == ((Customer)obj).FirstName && 
                this.LastName == ((Customer)obj).LastName;

        }
        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
        }


    }
    public enum Direction
    {
        East = 1,
        West = 2,
        North =3,
        South= 4

    }
}
