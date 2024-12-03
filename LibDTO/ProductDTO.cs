using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibDTO
{
    public class ProductDTO
    {
        private int product_id;
        private int product_parent_id;

        public int Product_id { get => product_id; set => product_id = value; }
        public int Product_parent_id { get => product_parent_id; set => product_parent_id = value; }
        public ProductParentDTO ProductParent { get; set; }
    }
}
