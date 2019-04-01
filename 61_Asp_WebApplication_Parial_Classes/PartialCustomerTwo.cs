using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _61_Asp_WebApplication_Parial_Classes
{
    public partial class PartialCustomer
    {
        public string GETfULLnAME()
        {
            return _firstName + ", " + _lastName;
        }
    }
}