using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _53_Reflections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Type T = Type.GetType("_53_Reflections.Customer"); //this Gettype() static method 
            Type T = typeof(Customer);
            Console.WriteLine("FullName =  {0}",T.FullName);
            Console.WriteLine("Just the Name =  {0}", T.Name);
            Console.WriteLine("Just the NameSpace =  {0}", T.Namespace);

            Console.WriteLine();
            Console.WriteLine("Properties in Customer class");
            PropertyInfo[] properties = T.GetProperties();
            foreach (var item in properties)
            {
                Console.WriteLine(item.PropertyType.Name+ " " +item.Name);
            }

            Console.WriteLine(
                );
            Console.WriteLine("Methods in Customers class");
            MethodInfo[] methodInfo = T.GetMethods();
            foreach (var method in methodInfo)
            {
                Console.WriteLine(method.ReturnType + " " + method.Name);
            }
            Console.WriteLine(
                );
            Console.WriteLine("Methods in Customers class");
            ConstructorInfo[] constructorInfo = T.GetConstructors();
            foreach (var constructor in constructorInfo)
            {
                Console.WriteLine(constructor + " " + constructor.ToString());
            }

        }
    }
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Customer(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public Customer()
        {
            this.Id = 1;
            this.Name = string.Empty;
        }

        public void PrintName()
        {
            Console.WriteLine("Name = {0}", this.Name);
        }
        public void PrintID()
        {
            Console.WriteLine("Name = {0}", this.Name);
        }
    }
}
/*
 Reflection
 
     Reflection is the ability of inspecting an assemblies¨ metadata at runtime.
     itis used to find all types in an assembly and/or dynamically invoke methods in an assembly.
     
     uses of reflection:
     1. when you drag and drop a button on a win forms or an asp.net application. the properties window uses reflection to 
     show all the properties of the button class
     so reflection is extensivelt used by IDE or a UI designers.
     
     2. Late binding can be achived by using reflectiion. you can use reflection to
     dynamically create an instance of a type, about which we dont have any information
     at compile time, reflection enables you to use code that is not avialable at compile time.
     
     3. Consider an exsample where we have two alternate implementation of an
     interface. you want to allow the user to oick one or ther other using config file.
     with reflection, you can simply read the name of the class whose implemention you want to use from the config file
     and instantiate an instance of that class. this is another
     exsample for late binding using reflection*/
