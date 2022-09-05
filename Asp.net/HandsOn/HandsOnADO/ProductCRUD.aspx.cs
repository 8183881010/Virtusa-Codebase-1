using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
namespace HandsOnADO
{
    public partial class ProductCRUD : System.Web.UI.Page
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["VirtusaDBConnection"].ConnectionString);
        SqlCommand command = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Add_Product(object sender, EventArgs e)
        {
            string qry = $"Insert into product values({txtId.Text},'{txtName.Text}',{txtPrice.Text},{txtStock.Text})";
            try
            {
                command = new SqlCommand(qry, connection);
                connection.Open();
                command.ExecuteNonQuery();
                lblMsg.Text = "Record Added";
                //reset form
                txtId.Text = String.Empty;
                txtPrice.Text = String.Empty;
                txtStock.Text = String.Empty;
                txtName.Text = String.Empty;
                txtId.Focus(); //set cursor focus
            }
            catch (Exception ex)
            {
                lblMsg.Text = "Error: " + ex.Message;
                
            }
            finally
            {
                connection.Close();
            }
        }

        protected void Search_Product(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            string qry = $"select * from product where pid={id}";
            try
            {
                command = new SqlCommand(qry, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.HasRows)
                {
                    reader.Read();
                    txtName.Text = reader["pname"].ToString();
                    txtPrice.Text = reader["price"].ToString();
                    txtStock.Text = reader["stock"].ToString();
                }
                else
                {
                    lblMsg.Text = "Invalid Id";
                    txtPrice.Text = String.Empty;
                    txtStock.Text = String.Empty;
                    txtName.Text = String.Empty;
                }
                
            }
            catch (Exception ex)
            {
                lblMsg.Text = "Error: " + ex.Message;

            }
            finally
            {
                connection.Close();
            }
        }

        protected void Delete_Product(object sender, EventArgs e)
        {
            string qry = $"delete from product where pid={txtId.Text}";
            try
            {
                command = new SqlCommand(qry, connection);
                connection.Open();
                command.ExecuteNonQuery();
                lblMsg.Text = "Record Deleted";
              
            }
            catch (Exception ex)
            {
                lblMsg.Text = "Error: " + ex.Message;

            }
            finally
            {
                connection.Close();
            }
        }

        protected void Update_Product(object sender, EventArgs e)
        {
            string qry = $"update product set price={txtPrice.Text},stock={txtStock.Text} where pid={txtId.Text}";
            try
            {
                command = new SqlCommand(qry, connection);
                connection.Open();
                command.ExecuteNonQuery();
                lblMsg.Text = "Record Updated";

            }
            catch (Exception ex)
            {
                lblMsg.Text = "Error: " + ex.Message;

            }
            finally
            {
                connection.Close();
            }
        }
    }
}