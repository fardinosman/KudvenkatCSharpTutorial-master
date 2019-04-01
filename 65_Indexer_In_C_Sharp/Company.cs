﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _65_Indexer_In_C_Sharp
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
    public class Company
    {
        private List<Employee> employeeslist; // no 

        public Company()
        {
            //in realty we may load the employees from database
            employeeslist = new List<Employee>();
            employeeslist.Add(new Employee { EmployeeId = 1, Name = "Fardin", Gender = "Male" });
            employeeslist.Add(new Employee { EmployeeId = 2, Name = "Masi", Gender = "Male" });
            employeeslist.Add(new Employee { EmployeeId = 3, Name = "Denina", Gender = "Femal" });
            employeeslist.Add(new Employee { EmployeeId = 4, Name = "mursal", Gender = "Femal" });
            employeeslist.Add(new Employee { EmployeeId = 5, Name = "Ibrahim", Gender = "Male" });
            employeeslist.Add(new Employee { EmployeeId = 6, Name = "Yusuf", Gender = "Male" });
            employeeslist.Add(new Employee { EmployeeId = 7, Name = "Yunus", Gender = "Male" });
            employeeslist.Add(new Employee { EmployeeId = 8, Name = "Nargis", Gender = "Female" });
        }

        // we create indexer 
        // to create indexer we use this key word 
        //indexers have parameter
        // otherwise its like auto generated properties get and set
        public string this[int employeeId] 
            {
            get 
                {
                return employeeslist.FirstOrDefault(emp => emp.EmployeeId == employeeId).Name;
                    }
            set 
                {
                employeeslist.FirstOrDefault(emp => emp.EmployeeId == employeeId).Name = value;
            }
        }
    }
}