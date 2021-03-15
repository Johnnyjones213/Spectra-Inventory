using System.Collections.Generic;
using System;
using Spectra_inventory.Models;


namespace Spectra_inventory.Models
{
    public interface IProductRepository
    {
        public IEnumerable<Product> AllProducts { get; }

        public Product GetProduct(int id);
        public void UpdateProduct(Product product);
        public void InsertProduct(Product productToInsert);

        public IEnumerable<Category> GetCategory();

        public Product AssignCategory();
        public void DeleteProduct(Product product);
       
     
    }

}
