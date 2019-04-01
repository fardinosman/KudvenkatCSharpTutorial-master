using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _64_Asp_How_where_indexers_used
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Session["Session1"] = "Session 1 Data";
            //Session["Session2"] = "Session 2 Data";


            ////retirve data out of the indexses
            //Response.Write("Session data is equal = " + Session[0].ToString());
            //Response.Write("<br/>");
            //Response.Write("Session data is equal = " + Session["Session2"].ToString());

            string CS = "Data Source=ibrahim;Initial Catalog=Sample;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("Select * from tblEmployee", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read()) // we read each row the DB table
                {
                    //Response.Write(rdr[0].ToString());
                   
                        Response.Write("Id = " +rdr[0].ToString() + " ");
                    Response.Write("Name = " + rdr[1].ToString() + " ");
                    Response.Write("Gender = " + rdr[2].ToString() + " ");
                    Response.Write("City = " + rdr[3].ToString() + " ");

                    Response.Write("<br/>");

                }
            }
        }
    }
}