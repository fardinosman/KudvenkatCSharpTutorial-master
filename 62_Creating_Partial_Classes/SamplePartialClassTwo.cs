using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _62_Creating_Partial_Classes
{
    public partial class SamplePartialClass : IEmployee
    {
        public void EmployeeMethod()
        {
            throw new NotImplementedException();
        }
       
    }




    public interface IEmployee
    {
        void EmployeeMethod();
    }
    public interface ICustomer
    {
        void CustomerMethod();
    }
}