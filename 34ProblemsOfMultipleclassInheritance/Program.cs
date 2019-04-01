using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34ProblemsOfMultipleclassInheritance
{ 
    class A
    {
        public virtual void Print()
        {
            Console.WriteLine("A Implemention");
        }
    }
    class B :A
    {
        public override void Print()
        {
            Console.WriteLine("B Implemention");
        }
    }
    class C : A
    {
        public override void Print()
        {
            Console.WriteLine("C Implemention");
        }
        
    }
    class D : B ,C // c# dosent support multiple class inhertance we get diamond problem
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            D d = new D();
            d.Print();
        }
    }
}
