using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EComm.Entities;
using EComm.BusinessLayer;
namespace EComm.UI
{
    public partial class AddProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Add_Product(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product();
                product.Pid = int.Parse(txtId.Text);
                product.Pname = txtName.Text;
                product.Stock = int.Parse(txtStock.Text);
                product.Price = int.Parse(txtPrice.Text);
                ProductService productService = new ProductService();
                productService.AddProduct(product);
                lblMsg.Text = "Record Added";
            }
            catch (Exception ex)
            {

                lblMsg.Text = ex.Message;
            }
            
        }
    }
}