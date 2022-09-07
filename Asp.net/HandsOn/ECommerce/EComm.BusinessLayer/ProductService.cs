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
        public void DeleteProduct(int pid)
        {
            try
            {
                repository.DeleteProduct(pid);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void UpdateProduct(Product product)
        {
            try
            {
                repository.UpdateProduct(product);
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
