using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _61_Asp_WebApplication_Parial_Classes
{
    public partial class Customer
    {
        public string _firstName { get; set; }
        public string _lastName { get; set; }

        public string GETfULLnAME()
        {
            return  _firstName + ", " +_lastName;
        }
    }
}