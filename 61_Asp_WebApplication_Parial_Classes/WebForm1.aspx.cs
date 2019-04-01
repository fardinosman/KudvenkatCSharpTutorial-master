using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _61_Asp_WebApplication_Parial_Classes
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
             
            Customer c1 = new Customer();
            c1._firstName = "Fardin";
            c1._lastName = "Osman";

            string Fullname = c1.GETfULLnAME();

            Response.Write("Full Name = " + Fullname + "<br/>");

            PartialCustomer C2 = new PartialCustomer();
            C2._firstName = "Dod";
            C2._lastName = "loot";

            Response.Write( C2.GETfULLnAME() +"<br/>");
        }
    }
}
/*
 
     Patial Classes
     Partial classes aloow us to split a class into 2 more files.
     All These parts are then combined into single class, when the application is compiled. the partial keyword can 
     aslo be used to split a struct or an interface over two more files
     
     Advangtages of partial classes
     
     1. the main advantage is that, visual studio uses partial classses to seprate automatically generated
     system code from the developers code.
     for eksampl, when 
     you add a webform, two.CS files are generated
     
     a) webfor1.aspx.cs Contais the system generated code. For example,
     declartion for the controlsthat you drag and drop on the webform
     
     2. when working on large projects, spreading a class over separate files allows multiple
     programmers to worl on it simultaneouslt. though Microsofft claims 
     this as an advantage, i havent really seen anywhere, people using partial classes, just to work on them
     simultaneously*/