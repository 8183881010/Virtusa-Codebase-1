using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EComm.Entities;
using EComm.DataLayer;
namespace EComm.BusinessLayer
{
    public class ProductService
    {
        ProductRepository repository;
        public ProductService()
        {
            repository = new ProductRepository();
        }
        public void AddProduct(Product product)
        {
            try
            {
                repository.AddProduct(product);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void DeleteProduct(int Pid)
        {
            try
            {
                repository.DeleteProduct(Pid);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void UpdateProduct(int price, int stock, int pid,string pname)
        {
            try
            {
                repository.UpdateProduct(price,stock,pid,pname);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Product GetProductById(int productId)
        {
            try
            {
               return repository.GetProductById(productId);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Product> GetProducts()
        {
            try
            {
                return repository.GetAllProducts();
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
