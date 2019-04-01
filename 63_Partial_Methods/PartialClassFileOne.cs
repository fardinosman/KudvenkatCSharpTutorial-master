using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _63_Partial_Methods
{
    public partial class PartialClassFile
    {
        partial void SamplePartialMethod(int i );

        public void PublicMethod()
        {
            Console.WriteLine("Public Mehtod Invoked");
            SamplePartialMethod(02);
        }
        partial void SamplePartialMethod(int i)
        {
            Console.WriteLine(i);
            Console.WriteLine("Sample partial method invoked");
        }
    }
}
/*
 
     Partial Methods
     
     1- A partial class or struct can obtain partial methods.
     2- a partial method is created using partial method
     3- a partial method declaration cosist of two parts
     i) the defination only the method signature)
     ii) the implemention .
     these may be in seprate parts of partial class, or in the same part.
     4- the implementation for apartial mehod is optional. 
     if we dont provide the implemention, the compileer removes the signature and all calls
     to the method..
     
     5- partial methods are private by defaultand its a compile time error to include any acces modifieres, in
     including private
     
     6- its compile time error to include delartion and implemention at the same time for a partial
     mehod
     
     7. a partial method return type must be void , including any other type is a compile
     time error.*
     8_ signature of the partial method declartion must match twith the signature of the implemention
     9- a partial mehod must be declared within a partial class or partial struct.
     a non partial class or struct cannot include partial methods
     10- a partial method can be implemented only once. trying to implement a partial
     method more that once, raises a compile time error