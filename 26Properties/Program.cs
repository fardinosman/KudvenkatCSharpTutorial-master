using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26Properties
{
    public class Student
    {
        private int _id;
        private string _Name;
        private int _passMark = 35;

        public int GetPassMark()
        {
            return this._passMark;
        }

        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("name can not be null or empty");
            }
            else
            {
                this._Name = name;
            }
        }
        public string GetName()
        {
            return string.IsNullOrEmpty(this._Name) ? "no name" : this._Name; 
        }

        public void SetId(int Id)
        {
            if (Id <=0)
            {
                throw new Exception("student id can not be negativ");
            }
            else
            {
                this._id = Id;
            }
        }

        public int GetId()
        {
            return this._id;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student();
            student.SetId(52);
            Console.WriteLine("studen id is {0} ",   student.GetId());

            student.SetName("Mark");
            Console.WriteLine(  "student name {0} ", student.GetName());

            Console.WriteLine(student.GetPassMark());

        }
    }
}
