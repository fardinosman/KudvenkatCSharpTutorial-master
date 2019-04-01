using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _67_Optional_Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            AddNumber(5, 5,new object[] { 34, 54, 34, 54, 23, 354, 234567, 8 });
            AddNumber(5, 5, 34, 54, 34, 54, 23, 354, 234567, 8 );
        }

        //by using params array we make it optional and it have to be th last paramter in a method
        public static void AddNumber(int FN, int SN, params object[] resofnumbers)
        {
            int result = FN + SN;
            if (resofnumbers !=null)
            {
                foreach (int item in resofnumbers)
                {
                    result += item;

                }
            }
            Console.WriteLine("Totlat numbers = {0}", result);
        }
    }
}
