using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesInCSharp
{

    public class Student
    {
        string name;
        int Id;
        int passMark;

        public int PassMark {
            get {
                return this.passMark;
            }
        }
        public int ID {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("student id should be ");
                }
                else
                {
                    this.Id = value;
                }
                
            }
            get 
            {
                return this.Id;
            }


        }
        public string Name 
        {
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("name can not be null or empty");
                }
                else
                {
                    this.name = value;
                }
            }
            get 
                {
                return string.IsNullOrEmpty(name) ? "no name" : this.name;
            }
           
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.ID = 101;
            s1.Name = "fardin";
            Console.WriteLine(s1.Name);
            Console.WriteLine( s1.ID);
        }
    }
}
