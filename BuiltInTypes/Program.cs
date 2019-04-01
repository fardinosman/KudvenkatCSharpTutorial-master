using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiltInTypes
{
    class Program
    {
        static void Main(string[] args)
        {
         
            int i = 0;
            int minvalue = int.MinValue;

            Console.WriteLine(minvalue);

            int maxvalue = int.MaxValue;
            Console.WriteLine(maxvalue);

            double d = 12.2332323;
            Console.WriteLine(d);

            decimal dec = 244.434664534M;
            //escape sequence in c#
            string name = "\"Fardin \n osman \"";
            Console.WriteLine(name);
            string value = "one\ntwo\ntree";
            Console.WriteLine(value);

            //verbatim litral
            string path = @"C:\Users\Fard\Documents\FTP";
            Console.WriteLine(path);



        }
    }
}
