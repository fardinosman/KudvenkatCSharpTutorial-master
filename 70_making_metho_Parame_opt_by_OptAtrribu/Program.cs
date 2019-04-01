using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace _70_making_metho_Parame_opt_by_OptAtrribu
{
    class Program
    {
        static void Main(string[] args)
        {
            AddNumbers(554, 34);
        }

        public static void AddNumbers(int FN,int SN,  [Optional] int[] restOfNum)
        {
            int result = FN + SN;
            if (restOfNum != null)
            {
                foreach (int item in restOfNum)
                {
                    result += item;
                }
               
            }
            Console.WriteLine("Total = " + result.ToString());
        }
    }

}
