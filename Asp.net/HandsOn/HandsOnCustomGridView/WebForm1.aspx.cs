using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace HandsOnCustomGridView
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[3] { new DataColumn("Id"), new DataColumn("Name"), new DataColumn("Country") });
                dt.Rows.Add(1, "John Hammond", "United States");
                dt.Rows.Add(2, "Mudassar Khan", "India");
                dt.Rows.Add(3, "Suzanne Mathews", "France");
                dt.Rows.Add(4, "Robert Schidner", "Russia");
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
{
    if (e.CommandName == "Select")
    {
        //Determine the RowIndex of the Row whose Button was clicked.
        int rowIndex = Convert.ToInt32(e.CommandArgument);
 
        //Reference the GridView Row.
        GridViewRow row = GridView1.Rows[rowIndex];
 
        //Fetch value of Name.
        string name = (row.FindControl("txtName") as TextBox).Text;
                //Fetch value of Price.
                string Price = (row.FindControl("ddlPrice") as DropDownList).Text;
                //Fetch value of Country
                string country = row.Cells[1].Text;
 
        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Name: " + name + "\\nCountry: " + country + "Price: "+Price+"');", true);
    }
}
    }
}