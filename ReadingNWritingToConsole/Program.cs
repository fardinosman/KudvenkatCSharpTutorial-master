using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingNWritingToConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter your first name");

            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name");
            string lastName = Console.ReadLine();

            Console.WriteLine("Hello {0} {1}",firstName,lastName);

            Console.ReadLine();
        }
    }
}
