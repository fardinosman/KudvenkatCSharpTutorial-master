using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _85_Realtim_Stack_Exsample
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Session["BackButtonClicked"] = "YES";
            if (Session["URLStack"] != null)
            {
                Stack<string> stackUrl = (Stack<string>)Session["URLStack"];
                string url = stackUrl.Pop();
                Response.Redirect(url);
            }
            else
            {
                lblMessage.Text = "There are no pages in the history";
            }
        }
    }
}