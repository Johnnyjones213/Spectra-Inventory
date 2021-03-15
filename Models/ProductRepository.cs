using Dapper;
using System.Collections.Generic;
using System.Data;

namespace Spectra_inventory.Models
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDbConnection _conn;
        public ProductRepository(IDbConnection conn)
        {
            _conn = conn;
        }


        public IEnumerable<Product> AllProducts => _conn.Query<Product>("SELECT * FROM PRODUCTS;");

        public void UpdateProduct(Product products)
        {
            _conn.Execute("UPDATE products SET Name = @name, Price = @price WHERE ProductID = @id",
                new { name = products.Name, price = products.Price, id = products.ProductID });
        }

        public void InsertProduct(Product productToInsert)
        {
            _conn.Execute("INSERT INTO products (NAME, PRICE, CATEGORYID) VALUES (@name, @price, @categoryID);",
                new { name = productToInsert.Name, price = productToInsert.Price, categoryID = productToInsert.CategoryID });

        }

        public IEnumerable<Category> GetCategories()
        {
            return _conn.Query<Category>("SELECT * FROM Category;");
        }

        public Product AssignCategory()
        {
            var categoryList = GetCategories();
            var product = new Product();
            product.Category = categoryList;

            return product;
        }

        public void DeleteProduct(Product product)
        {
           
            _conn.Execute("DELETE FROM Sales WHERE ProductID = @id;",
                                       new { id = product.ProductID });
            _conn.Execute("DELETE FROM Products WHERE ProductID = @id;",
                                       new { id = product.ProductID });
        }





        public IEnumerable<Product> GetAllProducts()
        {
            throw new System.NotImplementedException();
        }

        public Product GetProduct(int Id)
        {
            return _conn.QuerySingle<Product>("SELECT * FROM PRODUCTS WHERE PRODUCTID = @id;",
                new { id = Id });
        }

        public IEnumerable<Category> GetCategory()
        {
            throw new System.NotImplementedException();
        }

    }
}   


