using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibDTO
{
    public class ProductImportDTO
    {
        public int product_id { get; set; }
        public string product_name { get; set; }
        public string product_color { get; set; }
        public int product_size_id { get; set; }
        public string product_size { get; set; }
        public int quantity { get; set; }
        public int price { get; set; }
        public int total_price { get; set; }
    }
}
