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
    }

}
