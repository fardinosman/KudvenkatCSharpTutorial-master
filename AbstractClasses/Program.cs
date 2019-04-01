using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    abstract class Customer
    {
        public abstract void Print(); //this is incomplete method becuase its marked abstract
    }
     class  Program : Customer // we mark this class with abstract to not implemt abstract class
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Print();
            //this the other wat parent point to child
            Customer customer = new Program();
            customer.Print();
        }
        public override void Print()
        {
            Console.WriteLine("Hello ");
        }


    }
}
/*
 to make a abstract class we just use abstract keywork

    abstract is incomplet

    since its abstract class we cant make instace of abstract class

    htey can only be used like base class

    those class that inherit abstract have to prived implemtion for all the abstrat mehodt

    we dont want to provide implemention we do this
    

       abstract class Customer
    {
        public abstract void Print(); //this is incomplete method becuase its marked abstract
    }
    abstract class  Program : Customer

    abstract can not be sealed
    an absrtact class may contain abstract members(mehods,properties, indexers and events but not mandatory




     */
