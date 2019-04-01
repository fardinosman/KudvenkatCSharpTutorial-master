using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferenceBetweenClassesAndStructs
{
    class Program
    {
        public class Customer
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }
        static void Main(string[] args)
        {

            int i = 10; // int is a struct mean its value type and operate on stack 
            // int is a alias or System.Int32 Name, we can also say instead int32
            if (i==10)
            {
                int j =20;
                Customer c3 = new Customer();//reference type  c1 is created on stack actual object is created
                // on heap
                c3.ID = 12;
                c3.Name = "Fardin";
            }

            int integer = 10;
            int jint = integer;
            jint = jint + 1;

            Console.WriteLine($"{integer},{jint}");

            Customer c1 = new Customer();

            c1.ID = 101;
            c1.Name = "far";
            Customer c2 = c1;
            c2.Name = "Mary";
            Customer c4 = new Customer();
            c4 = c1;

            Console.WriteLine(c4.Name + c1.Name);

            Console.WriteLine(c1.Name + c2.Name);
        }
    }
}
            /*
            a structure is a value type where as a class is a refrerence type
            structs are stored on stack, where as classes are stored on the heap

            value types are destroyed immdiatly after scope is lost, where as for reference types only
            the reference variable is destroyed  after the scope is lost. the object is later destroyed
            by garbage collector. 

            when you copy a struct into another struct, a new copy of taht struct gets created and modification
            one one struct will not affect the values containd by other struct.

            when you copy a class into another class, we only get a copy of the reference variable. both the reference variables point to the same object
            on the heap.
            so operations on one variable will effect the values contained by other reference variable.

            classes have distructor ~Customer(){}
            struct have no distructor because they are value times 
            struct can not have parameterless constructor but clas kan have 
            struct dosent support inheritance from other class where as 
            class can both structs and classes can inherit from an interface

            prevent class from being inheritet we use sealed keyword on class
            */
