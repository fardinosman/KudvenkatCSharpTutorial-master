using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_MultiCast_Delegate

    
{
    public delegate void SampleDelegate(out int Intefer);
    class Program
    {
        static void Main(string[] args)
        {
            //SampleDelegate sampleDelegate = new SampleDelegate(SampleMethod1);
            //sampleDelegate();

            SampleDelegate del1, del2, del4;
            del1 = new SampleDelegate(SampleMethod1);
            del2 = new SampleDelegate(SampleMethod2);
          //  del3 = new SampleDelegate(SampleMethod3);4

            del4 = del1 + del2  -del2; //delegate del4 point all of the method and its called multicast delegat
            // we can remove by using -del2
            // we use + to add 
            //del4();
            //other way of using or making multicast delegatep
            SampleDelegate del = new SampleDelegate(SampleMethod1);
            del += SampleMethod2;
          //  del += SampleMethod3;
            //del -= SampleMethod2;
            //int delegatereturnValue =  del();// this to invoke delegate
            int delegateOutPutParameterValue = 5;
            del(out delegateOutPutParameterValue);
            Console.WriteLine(delegateOutPutParameterValue);
        }

        //public static void SampleMethod3()
        //{
        //    Console.WriteLine("SampleMethod3 Invoked");
        //}

        public static void SampleMethod2(out int number)
        {
            Console.WriteLine("SampleMethod2 Invoked");
            number = 2;
        }

        public static void SampleMethod1(out int number)
        {
            Console.WriteLine("SampleMethod1 Invoked");
            number = 1;
        }
       
    }
}
/*
 multicast delgegate is a delegate that has references to more that one function.

    when you invoke a multicast delegate, all the functions tge delegate is pointing to, are invoked.

    there are 2 approaches to create a multicast delegate. depending on the approach you use

    + or += to register a method with the delegate
    -or-= to un-register a method with the delegate

    Note: a multicast delegate, invokes the methods in the invocation list, in the same order in which
    thaty are addred

    if the delegate has a return type other than void and if the the delegate is a multicast delegate, only
    the value of the last invoked method will be returned. Along the same lines, if delegate has an out parameter
    the value og the output parameter, will be the value assigned by the last method

    commen interview question where do you use multicast delegate?
    multicast dlegate makes implementation of observer design pattern very simple.
    observer pattern is also called as publish / subscribe pattern
     */
