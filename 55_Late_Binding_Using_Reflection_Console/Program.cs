using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _55_Late_Binding_Using_Reflection_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //we do late binding only if dont know about the type example Customer

            Assembly executingAssembly = Assembly.GetExecutingAssembly(); //latebinding


            Type customerType = executingAssembly.GetType(
                "_55_Late_Binding_Using_Reflection_Console.Customer");

           object customerInstance = Activator.CreateInstance(customerType);

            MethodInfo GetFullNameMethod =  customerType.GetMethod("GetFullName");

            string[] parameters = new string[2];
            parameters[0] = "Fardin";
            parameters[1] = "Osman";


           string FullName = (string)GetFullNameMethod.Invoke(customerInstance, parameters);
       Console.WriteLine(FullName);

            //  Customer c1 = new Customer(); // here this is exsample of early binding
            //string fullname =  c1.GetFullName("Fardin", "Osman");
            //  Console.WriteLine(fullname);
        }
    }
    public class Customer
    {
        public string GetFullName(string FirstName, string LastName)
        {
            return FirstName + " " + LastName;
        }
    }
}
/*
 Late binding
 early binding
     */
