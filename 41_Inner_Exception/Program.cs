using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_Inner_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {


                try
                {



                    Console.WriteLine("Enter First Number");
                    int FN = Convert.ToInt32(Console.ReadLine());


                    Console.WriteLine("Enter Second Number");
                    int SN = Convert.ToInt32(Console.ReadLine());


                    int result = FN / SN;

                    Console.WriteLine("Result = {0}", result);
                }
                catch (Exception e)
                {
                    string path = @"C:\Sample Files\Log12.txt";
                    StreamWriter sw = new StreamWriter(path);
                    if (File.Exists(path))
                    {


                        sw.Write(e.GetType().Name);
                        sw.WriteLine();
                        sw.Write(e.Message);
                        sw.WriteLine();
                        sw.WriteLine();
                        sw.WriteLine();
                        sw.Write(DateTime.Now);
                        sw.Write(e.StackTrace);
                        sw.WriteLine();
                        sw.Close();
                        Console.WriteLine("There is a problem, please try again");
                    }
                    else
                    {
                        throw new FileNotFoundException(path + " is not present", e);
                    }
                }

            }
            catch (Exception exception)
            {

                Console.WriteLine("Current Exception = {0}", exception.GetType().Name);
                Console.WriteLine("Inner Exception = {0}", exception.InnerException.GetType().Name);
            }

        }
    }
}

/*
 
     the basics of the inner exception
     
     
     */
