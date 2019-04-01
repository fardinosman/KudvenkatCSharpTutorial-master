using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47_Enums
{
    class Program
    {
        static void Main(string[] args)
        {

            Gender gend = (Gender)3;
            int f = (int)Gender.Female;

            Console.WriteLine(  );
            short[] values= (short[])Enum.GetValues(typeof(Gender));

            foreach (var value in values)
            {
                Console.WriteLine(value);
            }
            string[] values1 = (string[])Enum.GetNames(typeof(Gender));

            foreach (var value in values1)
            {
                Console.WriteLine(value);
            }

            Gender g = (Gender)Season.Sommer;// enums are strongly type
         
        }
    }
    public enum Gender :short
    {
        Unknown,
        male = 5,
        Female = 23 
    }
    public enum Season
    {
        Winer =1,
        Spring =2,
        Sommer =3
    }
}
/*
 Enums
 
     if a program uses a set og integral numbers,  consider replacing it with enums
     which make the program more 
     
     - readable a
     - and maintainable
     
     1. Enums are enumerations
     2. Enums are strongly typed constants, Hence a explicit cast is needed to convert
     from enum tyoe to integral type and vice versa. also an enum of one time type can not be imlicitly assigned to an enum of another
     type even do thier underlying value of thier members are the same.
     3. the default underlying og an enum is int
     4. the default value for the first element is zero, and gets incremented by 1
     5. it is possible to customize the underlying type and values
     6. enums are value types
     7. Enum keyword( all small letters) is used to create enumerations, where as Enum class
     contains staticGetValues and GetName/( methid which can be used to list Enum underlyingtype values and Name*/