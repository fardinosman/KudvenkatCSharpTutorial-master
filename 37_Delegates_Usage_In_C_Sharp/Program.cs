﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_Delegates_Usage_In_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee() { ID = 101, Name = "Fardin", Salary = 5000, Experience = 5 });
            empList.Add(new Employee() { ID = 102, Name = "Jhon", Salary = 4000, Experience = 4 });
            empList.Add(new Employee() { ID = 103, Name = "Dennis", Salary = 6000, Experience = 6 });
            empList.Add(new Employee() { ID = 104, Name = "karina", Salary = 3000, Experience = 3 });

            Employee E1 = new Employee();
            E1.PromoteEmployee(empList);
        }
    }

    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public void PromoteEmployee(List<Employee> employeesList)
        {
            foreach (var employee in employeesList)
            {
                if (employee.Experience >= 5)
                {
                    Console.WriteLine(employee.Name + " Promoted");
                }
            }
        }
    }
}
