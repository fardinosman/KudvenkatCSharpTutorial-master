using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56_Generics
{
    public class Customer1
    {
        public int Id { get; set; }
    }
   

    class Program
    {
        static void Main(string[] args)
        {
            Customer1 c1 = new Customer1();
            c1.Id = 1;
            Customer1 c2 = new Customer1();
            c2.Id = 1;

            bool lige = Calculator<int>.AreEqual(c1.Id, c2.Id);

            bool Equal = Calculator<string>.AreEqual("AAB", "AAB");
            bool reslult = Calculator<int>.AreEqual(5, 5);
            if (reslult)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("not Equal");
            }
            Console.WriteLine(Equal);
            Console.WriteLine(lige+ "customer id");
            

            
        }
    }
    public class Calculator<T>
    {
        public static bool AreEqual(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }
}

/*
 * Generics are introduced in c# 2.0 Generics allow us to design classes an d
 * methods decoupled from the data types
 * 
 * Generics classes are used extensivly by collection classes avialible in
 * System.Collection.Gererics namesapace.(Cover int the next session
 * 
 * One way of makeing AreEqual() Method reusable, is to use object type parameters
 * since every type in .NET directly or indirectly inherit from System.Object type
 * AreEqual() method works with any data type, but the problem is performance dgragation to to boxing and 
 * unboxing happning
 * 
 * Also AreEqual() method is no longer type safe. it is now possible to pass integer for
 * the first parameter, and a string for the second parameter. it dosent make sense to compare strings with 
 * integers..
 * so the problem with using system.object type is that
 * 1. AreEqual() method is not type safe
 * 2. Performance degragation due to boxing and unboxing happning
 * 
 * To make AreEqual() mehod generic, we specify a type parameter using angular brackets as shown below
 * 
 * public static bool AreEqual<T>(T value1, T value2)
 * 
 * at the point, when the client code wants
 We can make classes, and methods, interface, delegate gernica by using <T>*/
