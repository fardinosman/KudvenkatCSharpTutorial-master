using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridingVsMethodHiding
{
    public class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("I am a Base Class Print Method");
        }
    }
    public class DerivedClass :BaseClass
    {
        public new void Print() // method hiding
        {
            Console.WriteLine("I am a Derived Class Print Method");
        }
        public new void Print2() // method overriding
        {
            Console.WriteLine("I am a Derived Class Print Method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            //Method overriding and hiding
            BaseClass baseClass = new DerivedClass();

            baseClass.Print();
        }
    }
}
