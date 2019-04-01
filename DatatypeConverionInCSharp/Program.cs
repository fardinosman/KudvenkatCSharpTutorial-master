using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatatypeConverionInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            //implicit conversion is done by compiler 
            // explicit converion
            //parsing

            int i = 100;

            float f = i;

            Console.WriteLine(f); // conversion happen without do anything no loose of data

            // explicit converion
            float floa = 123.45F; // integra have no fractional part comma and ,12
            int integer = (int)floa; // we get error float is larger type

            Console.WriteLine(integer); // we can cast it or we can and this is explicit conversion

            int conversion =  Convert.ToInt32(floa);

            //difference between type cast and Convert.ToInt32(floa) is 
            // if type cast and the int int i = 23234355344343.34; get bigger we dont get exception
            // but when we use Convert.ToInt32(floa) it gives us exception stackoverflow
            //it can not hold it

            string strNumber = "100";
            int holder = int.Parse(strNumber); // in this case we use int.Parse() 3rd way conversion

            string sstrNumber = "10000";
            int hholder = int.Parse(strNumber); // in this case we use int.Parse() 3rd way conversion
            //we get exception
            // 
            int result = 0;
           bool IsconverionSuccessful =  int.TryParse(sstrNumber, out result); // it return boolan if convertion successfull


            if (IsconverionSuccessful)
            {
                Console.WriteLine(result + "fro");
            }
            else
            {
                Console.WriteLine("Please enter a valid number");
            }


        }
    }
}
