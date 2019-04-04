using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _84_Real_Time_eks_Qeue_Colle
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["TokenQueue"] == null)
            {
                Queue<int> queueTokens = new Queue<int>();
                Session["TokenQueue"] = queueTokens;
            }

        }

        protected void btnPrintToken_Click(object sender, EventArgs e)
        {

            Queue<int> tokenQueue = (Queue<int>)Session["TokenQueue"];
            lblStatus.Text = "There are " + tokenQueue.Count.ToString() + " customer befor in the queue";
            if (Session["LastTokenNumberIssues"] == null)
            {
                Session["LastTokenNumberIssues"] = 0;
            }
            int nextTokenNumberToBeIssued = (int)Session["LastTokenNumberIssues"] + 1;
            Session["LastTokenNumberIssues"] = nextTokenNumberToBeIssued;
            tokenQueue.Enqueue(nextTokenNumberToBeIssued);

            AddTokenToListBox(tokenQueue);

        }

        private void AddTokenToListBox(Queue<int> tokenQueue)
        {
            listToken.Items.Clear();

            foreach (int token in tokenQueue)
            {
                listToken.Items.Add(token.ToString());
            }
        }

        protected void btncounter1_Click(object sender, EventArgs e)
        {
            servedcustomer(TxtCounter1,1);
        }

        protected void btncounter2_Click(object sender, EventArgs e)
        {
            servedcustomer(TxtCounter2,2);
        }

        protected void btncounter3_Click(object sender, EventArgs e)
        {
            servedcustomer(TxtCounter3,3);
        }
        private void servedcustomer(TextBox textBox, int counterNr)
        {
            Queue<int> tokenQueue = (Queue<int>)Session["TokenQueue"];
            if (tokenQueue.Count <= 0)
            {
                textBox.Text = "No customer in the queue";
            }
            else
            {
                int tokenNumberToBeServed = tokenQueue.Dequeue();
                textBox.Text = tokenNumberToBeServed.ToString();
                txtDisplay.Text = "Token Number: " + tokenNumberToBeServed.ToString() + "Please go to qoutner " + counterNr.ToString();
                AddTokenToListBox(tokenQueue);

            }
        }
    }
}