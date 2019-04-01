using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _68_MethoParam_optional_Using_MdOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            AddNumber(5, 5, new object[] { 34, 54, 34, 54, 23, 354, 234567, 8 });
            AddNumber(5, 5, 34, 54, 34, 54, 23, 354, 234567, 8);
            AddNumber(3, 43, 56, 789, 44, 22, 55, 7);
            AddNumber(2, 4);
        }

        //by using params array we make it optional and it have to be th last paramter in a method
        public static void AddNumber(int FN, int SN, params object[] resofnumbers)
        {
            int result = FN + SN;
            if (resofnumbers != null)
            {
                foreach (int item in resofnumbers)
                {
                    result += item;

                }
            }
            Console.WriteLine("Totlat numbers = {0}", result);
        }
  
        public static void AddNumber(int FN, int SN)
        {

            AddNumber(FN, SN, null);
            
        }
    }
    
}
