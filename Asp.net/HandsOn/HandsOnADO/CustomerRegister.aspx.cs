using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HandsOnADO
{
    public partial class CustomerRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Register(object sender, EventArgs e)
        {
            //wriet code here to add customer details to db
            lblMsg.Text = "Customer Registered";
            //Add customer details to table
        }
    }
}