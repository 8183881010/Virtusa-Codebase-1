using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstWebAPP
{
    public partial class Demo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //Event Handler
        protected void Button1_Click(object sender, EventArgs e)
        {
            //get value from textbox
            string name = TextBox1.Text; //Text return text from the textbox
            Label1.Text = "Hello " + name;
        }
    }
}