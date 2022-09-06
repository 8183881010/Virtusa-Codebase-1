using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace HandsOnDataBindControlsDemo
{
    public partial class GridViewDemo1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=SANTU\MSSQLSERVER2019;Initial Catalog=VirtusaDB;Integrated Security=True");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from Employee", connection);
            connection.Open();
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet); //stores result set data into dataset object
            //show dataSet records into Gridview
            GridView1.DataSource=dataSet;
            GridView1.DataBind(); //DataBind() binds dataset data to the Gridview Control
           

        }
    }
}