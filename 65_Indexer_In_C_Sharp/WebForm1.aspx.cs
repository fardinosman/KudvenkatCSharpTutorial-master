using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _65_Indexer_In_C_Sharp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Company company = new Company();

            Response.Write("Name of Empolyee with Id = 2 "+ company[2]);
            Response.Write("<br/>");
            Response.Write("Name of Empolyee with Id = 5 " + company[5]);
            Response.Write("<br/>");
            Response.Write("Name of Empolyee with Id = 3 " + company[3]);
            Response.Write("<br/>");
            Response.Write("<br/>");
            // changing employee name with use of indexer
            Response.Write("Changing names of employee with Id = 2 , 5 & 8");
            company[2] = "Thomas changed";
            company[5] = "Camila changed";
            company[3] = "Tod changed";
            Response.Write("<br/>");
            Response.Write("<br/>");

            Response.Write("Name of Empolyee with Id = 2 " + company[2]);
            Response.Write("<br/>");
            Response.Write("Name of Empolyee with Id = 5 " + company[5]);
            Response.Write("<br/>");
            Response.Write("Name of Empolyee with Id = 3 " + company[3]);
            Response.Write("<br/>");


        }
    }
}