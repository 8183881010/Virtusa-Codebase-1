using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HandOnListControls
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //add items to dropdown
            if (IsPostBack == false)
            {
                DropDownList1.Items.Add("Rohan");
                DropDownList1.Items.Add("Suren");
                DropDownList1.Items.Add("Jeson");
                DropDownList1.Items.Add("Joy");
                DropDownList1.Items.Add("Uday");
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label1.Text = "Hello " + DropDownList1.Text;
        }
    }
}