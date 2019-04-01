using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _40_Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = null;
            try
            {


                 streamReader = new StreamReader(@"C:\Sample Files\Data1.txt");
                Console.WriteLine(streamReader.ReadToEnd());

           
            }

            catch (FileNotFoundException e)
            {
                Console.WriteLine("please check if the file exist {0} ", e.FileName);
                //Log the details to the DB
                Console.WriteLine();
                Console.WriteLine(e.Message);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(e.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Close();
                  
                }
              
                Console.WriteLine("Finally Block");
            }
        }
    }
}
/*
 Exception is base class for all other exception

    other classes inherit from Exception class which is base class

    we use try catch and finally blocks for exception handling

    try - the code that c an possibly cause an exception will be in the try block

    catch handles the exception

    finally clean and free resources that the class was holding onto during the program execution
     finally block is optional

    but its good practice to to always release resources in tthe finally block
    becuase it garated to exicute  iirespective og whether there is an exception or not

     */
