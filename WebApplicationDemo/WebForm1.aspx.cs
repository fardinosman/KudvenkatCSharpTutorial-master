using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["CountryData"] == null)
            {
                Country c1 = new Country() { Code = "AUS", Name = "Australia", Capital = "Canberra" };
                Country c2 = new Country() { Code = "IND", Name = "India", Capital = "New Dehli" };
                Country c3 = new Country() { Code = "USA", Name = "United States", Capital = "Washinton D.C." };
                Country c4 = new Country() { Code = "GBR", Name = "United KIngdom", Capital = "London" };
                Country c5 = new Country() { Code = "CAN", Name = "Canada", Capital = "Ottawa" };


                //List<Country> listCon = new List<Country>();
                Dictionary<string, Country> dictionaryCountris = new Dictionary<string, Country>();
                dictionaryCountris.Add(c1.Code, c1);
                dictionaryCountris.Add(c2.Code, c2);
                dictionaryCountris.Add(c3.Code, c3);
                dictionaryCountris.Add(c4.Code, c4);
                dictionaryCountris.Add(c5.Code, c5);

                Session["CountryData"] = dictionaryCountris;
            }
        
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Dictionary<string, Country> dictionartContries = (Dictionary<string, Country>)Session["CountryData"];
            Country resultContry = dictionartContries.ContainsKey(TxtCode.Text.ToUpper()) ? dictionartContries[TxtCode.Text.ToUpper()] : null;
            if (resultContry == null)
            {
                LabelMessage.Text = "Country not Found";
            }
            else
            {
                TxtName.Text = resultContry.Name;
                TxtCapital.Text = resultContry.Capital;
                LabelMessage.Text = "";

            }
        }
    }
}