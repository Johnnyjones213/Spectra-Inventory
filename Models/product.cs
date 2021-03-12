using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spectra_inventory.Models
{
    public class product
    {
        public int Product_id { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public int parlevel { get; set; }

        public int category_id { get; set; }

    }
}
