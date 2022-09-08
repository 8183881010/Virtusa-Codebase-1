using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HandsonStateManagementDemo
{
    public partial class Welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Read Session values
            if (Session["un"] != null)
            {
                Label1.Text = Session["un"].ToString();
            }
            else
                Response.Redirect("Login.aspx");
        }
    }
}