using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PATA = ProjectA.TeamA; // we use alias to avoid long typing namespace in main
using PATB = ProjectA.TeamB;

namespace nAmspacesinCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Projekt A
             Team A 
             Team B


             */
            // ClassA a = new ClassA();
            PATA.ClassA.Print();
            //ClassB b = new ClassB();
            PATB.ClassA.Print();

        }
    }
}
namespace ProjectA
{
    namespace TeamA
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team A Print Method");
            }
        }
    }
}
namespace ProjectA
{
    namespace TeamB
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team B Print Method");
            }
        }
    }
}