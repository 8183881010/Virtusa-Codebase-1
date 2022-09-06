using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace HandsOnAdoDisconnectedArchitecture
{
    class ProductCRUD
    {
        SqlConnection con = new SqlConnection(@"Data Source=SANTU\MSSQLSERVER2019;Initial Catalog=Training1DB;Integrated Security=True");
        SqlDataAdapter da = null;
        DataSet ds = null;
        SqlCommandBuilder cb = null;
        public ProductCRUD()
        {
            da = new SqlDataAdapter("Select * from Product", con);
            cb = new SqlCommandBuilder(da);
            ds = new DataSet("Product");
            da.Fill(ds);
            //set Primary key
            ds.Tables["Product"].PrimaryKey = new DataColumn[] { ds.Tables[0].Columns["Pid"] };
        }
        public void AddProduct(int Pid,string Pname,int Price,int Stock)
        {
            DataRow dr = ds.Tables[0].NewRow();
            dr["Pid"] = Pid;
            dr["Pname"] = Pname;
            dr["Price"] = Price;
            dr["Stock"] = Stock;
            ds.Tables["Product"].Rows.Add(dr); //adding new row to the DataTable.
            da.Update(ds);
        }
        public void DeleteProduct(int Pid)
        {
            ds.Tables["Product"].Rows.Find(Pid).Delete();
            da.Update(ds);
        }
        public void UpdateProduct(int Pid,int Price,int Stock)
        {
            ds.Tables[0].Rows.Find(Pid)["Price"] = Price;
            ds.Tables[0].Rows.Find(Pid)["Stock"] = Stock;
            da.Update(ds);
        }
        static void Main()
        {
            ProductCRUD obj = new ProductCRUD();
            //obj.AddProduct(6, "BBB", 10, 10);
            obj.DeleteProduct(6);
        }
    }
}
