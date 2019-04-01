using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52_Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator.Add(50, 50);
            Calculator.Add(2, 3, 4);
            Calculator.Add(new List<int>() { 10,20,30,40});
        }
    }
    public class Calculator
    {
        [Obsolete("Use Add og Add(List<int> Numbers) method ",true)] // for backword compilibilty an we can customize it
        public static int Add(int FN, int  SN)
        {
            return FN +SN;
        }
        public static int Add(int FN, int SN, int TD)
        {
            return FN + SN +TD;
        }
        public static int Add(List<int> Numbers)
        {
            int sum = 0;
             foreach (var item in Numbers)
            {
                sum = sum + item;
                Console.WriteLine(sum);
            }
            return sum;
        }
    }
}
/*
 Attributes
 
     Atrributes allow ypu to add declaritive information to your program.
     this information can then be queried at runtime using reflection.
     
     there are several pre-definded attributes provided by .net it is also possible to create your own custom attribute
     
     a few pre-defined attribute using parameters
     
     an attribute is class that inherits from System.Atrribute base class*/