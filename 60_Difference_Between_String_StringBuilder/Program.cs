using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _60_Difference_Between_String_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            string userString = "C#"; //5 objects on heap this is a exsample of immutable
            // means it can not be changed once its created
            // System.String is immutable 
            userString += "Video";
            userString += "Tutorial";
            userString += "for";
            userString += "begginers";

            Console.WriteLine(userString);

            //StringBuilder is Mutable 
            //means not matter how many time we change it we still have the same object we refer to
            //String.Builder they are better performance than string

            StringBuilder stringBuilder = new StringBuilder("C#");
            //we use the append method spo me can concatent the sstring togther

            stringBuilder.Append("Video");
            stringBuilder.Append(" Tutorial");
            stringBuilder.Append(" For beginners");

            Console.WriteLine(stringBuilder);

            string user = string.Empty; // this is bad because we have alot of objects 10000 it give bas 
            //performance and bad for heap
            for (int i = 1; i <=10000; i++)
            {
                user += i + "  ";
             }
            Console.WriteLine(user);
           


        }
    }
}
