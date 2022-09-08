using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HandsonStateManagementDemo
{
    public partial class Page1 : System.Web.UI.Page
    {
        int x = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            x = 10;

            //set value in hidden filed
            h1.Value = x.ToString();
            Response.Write("x= " + x);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //read hiddenfield value
            x = int.Parse(h1.Value);
            Response.Write("x= " + x);
        }
    }
}