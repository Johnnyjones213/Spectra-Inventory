using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
us
namespace Spectra_inventory.Models
{
    public class ProductRepository: IProductRepository
    {
        private readonly IDbConnection _conn;
        public ProductRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<product> GetAllProducts()
        {
            return _conn.Query<product>("Select * FROM PRODUCTS;");
        }

       



    }
}
