using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HandsonStateManagementDemo
{
    public partial class Page2 : System.Web.UI.Page
    {
        int x = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            x = 10;
            //set value in ViewState
            ViewState["k"] = x;
            Response.Write("x= "+x);
            Label1.Text = "Hello " + TextBox1.Text;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Read value from Viewstate
            x = (int)ViewState["k"];
            Response.Write("x= " + x);
        }
    }
}