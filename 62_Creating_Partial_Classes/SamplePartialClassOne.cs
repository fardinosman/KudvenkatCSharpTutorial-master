using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _62_Creating_Partial_Classes
{
    public partial class SamplePartialClass : ICustomer
    {
        public void CustomerMethod()
        {
            throw new NotImplementedException();
        }
    }
}
/*
 
     Creating Partial Classes
     1- All the parts spread across different files, must use the partial keyword.
     
     2- All the parts spread across different files, must have the same access modifiers.
     3- if any of the parts are declared abstract, then the entire type is considered abstract.
     4- if any of the parts are declared seal, the the etire type is considered sealed
     
     5- if any of the parts inherit a class, then the etire type inherit that class
     6 -  c# does not support multiple class inheritance . different parts of the partial class must
     not specify differnet base classes
     
     7- different parts of the partial class can specify different bas interface, and the final type implements all 
     of the the interfaces listed by
     all of the partial declations
     8- Any members that are declared in a partial defination are available to all of the other parts 
     ohter parts of the partial class*/