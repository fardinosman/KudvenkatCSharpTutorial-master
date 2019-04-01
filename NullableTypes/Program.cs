using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = null;

            //int i = null;

            int? i = null; // we can make value types nullable by addint question mark
            //

            bool? AreyouMajor = true;
            // if user dosent select answer
            bool? d = null;
            //when we work with database and c# we use null ? 
            if (AreyouMajor == true)
            {
                Console.WriteLine("User is Major");

            }
            else if(!AreyouMajor.Value)// or you can say AreuserMajor == false it also works
            {
                Console.WriteLine("User is Major");
            }
            else
            {
                Console.WriteLine("User does no answer question");
            }

            //null coalicing operator
            //exsample with  null coalescing operator
            int? TicketsOnSale = null;
            int avalialbleTickets = TicketsOnSale ?? 0; // it means if the ticketonsal is null then
            //use the default 0 otherwise use the value that is present inside the variable





        }
    }
}

//exsample with none null coalescing operator
//int? TicketsOnSale = null;
//int avalialbleTickets;

//if (TicketsOnSale == null)
//{
//    avalialbleTickets = 0;
//}
//else
//{
//    avalialbleTickets = (int)TicketsOnSale; // TicketsOnSale.value to make nullable to non nullable
//}
//Console.WriteLine("AvaliableTickets = {0 }", avalialbleTickets);