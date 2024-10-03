using System;

namespace LibDTO
{
    public class ProductParentDTO
    {
        public int product_parent_id { get; set; }
        public string product_parent_name { get; set; }
        public string thumbnail { get; set; }
        public string product_price { get; set; }
        public Boolean is_new_release { get; set; }
        public int product_icons_id { get; set; }
        public int sub_categories_id { get; set; }
        //public ProductIconsDTO productIcons { get; set; }
        //public ProductDTO product { get; set; }
        //public ProductObjectDTO productObject { get; set; }
        //public ProductCategoryDTO productCategory { get; set; }


    }
}
