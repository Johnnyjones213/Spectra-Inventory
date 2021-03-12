using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spectra_inventory.Models
{
     public interface IProductRepository
     {
        public IEnumerable<product> GetAllProducts();
     }

}
