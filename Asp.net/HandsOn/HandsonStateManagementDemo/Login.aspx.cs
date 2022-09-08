using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HandsonStateManagementDemo
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Validate(object sender, EventArgs e)
        {
            if (txtUname.Text == "Hemanth" && txtPwd.Text == "12345")
            {
                //set value in session
                Session["un"] = txtUname.Text;
                Response.Redirect("Welcome.aspx");
            }
            else
                Label1.Text = "Invalid Credentials";
        }
    }
}