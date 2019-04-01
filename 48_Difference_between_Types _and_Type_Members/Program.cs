using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48_Difference_between_Types__and_Type_Members
{
    class Customer
    {
        //these are called type members
        #region fields
        private int _id;
        private string _firstName;
        private string _lastNamme;
        #endregion

        #region Properties 
        public int Id {
            get { return this._id; }
            set { this._id = value; }
        }
       
        public string Name {
            get { return this._firstName; }
            set { this._firstName = value; }
        }
        public string LastName {
            get { return this._lastNamme; }
            set { this._lastNamme = value; }
        }
        #endregion
        #region Method
        public string GetFullName()
        {
            return this._firstName + " " + this._lastNamme;
        }
        #endregion

    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
/*
 Types vs type members
 
     int he exsample customer is a type and fieldsm properties and methods are type members
     
     so in general class, structs, enums, interfaces, delegates are called as types and fields, properties, constructores
     , methods etc, that normally reside in a type are called as type members..
     
     in c# there are 5 different access modifiers
     
     1. private
     2. protected
     3. internal
     4. protected internal
     5. public 
     
     Type members can have all the access modifiers, where  as types can have only 2 (internal public) of the 5 access modifiers
     
     Note Using regions you can expand and collaps sections of your code either manually 
     or using visual studio*/