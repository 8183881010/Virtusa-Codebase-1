using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstWebAPP
{
    public partial class MathForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
           
            int no1 = int.Parse(txtNo1.Text);
            int no2 = int.Parse(txtNo2.Text);
            int result = no1 + no2;
            //display result value on label
            lblResult.Text = "Addition: " + result;
        }

        protected void btnSub_Click(object sender, EventArgs e)
        {
            int no1 = int.Parse(txtNo1.Text);
            int no2 = int.Parse(txtNo2.Text);
            int result = no1 - no2;
            //display result value on label
            lblResult.Text = "Subtraction: " + result;
        }
    }
}