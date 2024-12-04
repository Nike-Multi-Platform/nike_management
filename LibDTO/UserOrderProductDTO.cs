using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibDTO
{
    public class UserOrderProductDTO
    {
        public int user_order_id { get; set; }
        public int product_size_id { get; set; }
        public int amount { get; set; }
        public decimal price { get; set; }
        public string thumbnail { get; set; }
        public string product_name { get; set; }
        public string size_name { get; set; }
        public int on_register_flash_sales_id { get; set; }
    }

}
