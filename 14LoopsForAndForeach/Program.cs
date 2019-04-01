using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14LoopsForAndForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            //for and foreach

            int[] number = new int[3];

            number[0] = 1;
            number[1] = 23;
            number[2] = 33;

            int i = 0; // doing initialization here

            while (i < number.Length) //checking condition here
            {
                Console.WriteLine(number[i]);
                i++; // incrementing here
            }

            for (int j = 0; j < number.Length; j++)
            {
                Console.WriteLine(number[j]);
            }

            foreach (var item in number)
            {
                Console.WriteLine(item);
            }


            //break statement
            for (int d = 0; d <= 20; d++)
            {
                Console.WriteLine(d);
                if (d == 10)
                {
                    break;
                }
            }
            Console.WriteLine("-----------------------");
            //continuo statement
            for (int e = 0; e <= 20; e++)
            {
              
                if (e % 2 == 1)
                
                    continue;
                    
                
                Console.WriteLine(e);

            }
        }
    }
}
