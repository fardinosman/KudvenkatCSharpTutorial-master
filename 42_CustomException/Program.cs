using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;

namespace _42_CustomException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

          
            throw new UserAlreadyLoggedInException("User already loggedind no duplicate session allowed");
            //throw new FileNotFoundException("File xyz is not found");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
    }
}
[Serializable]
public class UserAlreadyLoggedInException : Exception
{
    public UserAlreadyLoggedInException() :base()
    {

    }
    public UserAlreadyLoggedInException(string message):base(message)// communicates with base class constructer
    {

    }
    public UserAlreadyLoggedInException(string message, Exception innerException) 
        : base(message, innerException)
    {

    }
    public UserAlreadyLoggedInException(SerializationInfo info , StreamingContext context):base(info,context)
    {

    }
}

/*
 Custum Exception

    1. Create a class taht derives from System.Exception class. As a convention, end
    the class name with Exception suffix. All .Net exception end with , exception suffix.

    2. provide a public constructor, you can also track back the original exception. if you want to provide this
    capability for your  custom exception class, then overload the constructor
    accordingly

    4.

    if you want you exception class object to work across apllication domain,
    then the object must be serializable. To make your exception class serializable
    matk with serializble attribute an d provide a constructor that invokes the base exception class
    constructor that takes in serializationinfo and streamcontext object as parameters

    note it is also possible to provide your own custom serialzation, which will discuss in later session kudvenkat

     */
