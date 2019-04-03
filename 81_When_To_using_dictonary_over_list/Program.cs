using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _81_When_To_using_dictonary_over_list
{
    class Program
    {
        static void Main(string[] args)
        {
            string userChoice;
            Country c1 = new Country() { Code = "AUS", Name = "Australia", Capital = "Canberra" };
            Country c2 = new Country() { Code = "IND", Name = "India", Capital = "New Dehli" };
            Country c3 = new Country() { Code = "USA", Name = "United States", Capital = "Washinton D.C." };
            Country c4 = new Country() { Code = "GBR", Name = "United KIngdom", Capital = "London" };
            Country c5 = new Country() { Code = "CAN", Name = "Canada", Capital = "Ottawa" };


            //List<Country> listCon = new List<Country>();
            Dictionary<string, Country> dictionaryCountris = new Dictionary<string, Country>();
            dictionaryCountris.Add(c1.Code, c1);
            dictionaryCountris.Add(c2.Code, c2);
            dictionaryCountris.Add(c3.Code, c3);
            dictionaryCountris.Add(c4.Code, c4);
            dictionaryCountris.Add(c5.Code, c5);

            do
            {


                Console.WriteLine("Please Enter Country code");
                string strcontryCode = Console.ReadLine().ToUpper();
                Country resultContry = dictionaryCountris.ContainsKey(strcontryCode) ? dictionaryCountris[strcontryCode] : null;
                if (resultContry == null)
                {
                    Console.WriteLine("country code not valid");
                }
                else
                {
                    Console.WriteLine("Name = {0}, Capital = {1}", resultContry.Name, resultContry.Capital);
                }
                Console.WriteLine("Do you want continue?");
                userChoice = Console.ReadLine().ToUpper();
                do
                {
                    Console.WriteLine("Do you want continue?");
                    userChoice = Console.ReadLine().ToUpper();
                } while (userChoice != "YES" && userChoice != "NO");
            } while (userChoice == "YES");
        }
    }
    public class Country
    {
        public string  Name { get; set; }
        public string Code { get; set; }
        public string Capital { get; set; }
    }
}
