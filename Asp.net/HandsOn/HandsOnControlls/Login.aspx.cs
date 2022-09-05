using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HandsOnControlls
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Validate(object sender, EventArgs e)
        {
            string uname = txtUname.Text;
            string pwd = txtPwd.Text;
            if(uname=="Rohan" && pwd=="12345")
            {
                //Redirect to welcome page
               // Response.Redirect("Welcome.aspx);
                Response.Redirect("Welcome.aspx?un="+uname);
                //Response.Redirect("http://google.co.in");
            }
            else
            {
                lblMsg.Text = "Invalid Userdetails";
            }
        }

        protected void Reset(object sender, EventArgs e)
        {
            txtUname.Text = "";
            txtPwd.Text = "";
        }
    }
}