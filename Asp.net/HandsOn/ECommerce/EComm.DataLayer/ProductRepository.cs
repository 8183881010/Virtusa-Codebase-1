using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using EComm.Entities;
namespace EComm.DataLayer
{
    public class ProductRepository
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["VirtusaDBConn"].ConnectionString);
        SqlCommand command = null;
      
        public void AddProduct(Product product)
        {
            try
            {
                command = new SqlCommand($"insert into product values({product.Pid},'{product.Pname}',{product.Price},{product.Stock})", connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }
        public void DeleteProduct(int pid)
        {
            try
            {
                command = new SqlCommand($"Delete from Product where Pid={pid}", connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }
        public void UpdateProduct(Product product)
        {
            try
            {
                command = new SqlCommand($"Update Product set Price={product.Price},Stock={product.Stock} where Pid={product.Pid}", connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }
        public Product GetProductById(int productId)
        {
            try
            {
                Product product = null;
                command = new SqlCommand($"Select * from Product where Pid={productId}", connection);
                connection.Open();
                SqlDataReader dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    product = new Product();
                    product.Pid = (int)dr["pid"];
                    product.Pname = dr["pname"].ToString();
                    product.Price = (int)dr["price"];
                    product.Stock = (int)dr["stock"];
                }
                return product;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Product> GetAllProducts()
        {
            try
            {
                List<Product> products = new List<Product>();
                command = new SqlCommand($"Select * from Product", connection);
                connection.Open();
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    Product product = new Product();
                    product.Pid = (int)dr["pid"];
                    product.Pname = dr["pname"].ToString();
                    product.Price = (int)dr["price"];
                    product.Stock = (int)dr["stock"];
                    products.Add(product); //add product details to list
                }
                return products;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
