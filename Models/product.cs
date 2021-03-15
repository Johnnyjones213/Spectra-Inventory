using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spectra_inventory.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Par { get; set; }

        public int CategoryID { get; set; }

        
        public IEnumerable<Category> Category { get; internal set; }
    }
}
