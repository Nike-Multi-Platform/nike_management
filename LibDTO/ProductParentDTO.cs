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
        private int weight;
        private int height;
        private int width;
        private int length;
        private DateTime createdAt;
        private DateTime updatedAt;
        public DateTime CreatedAt { get => createdAt; set => createdAt = value; }
        public DateTime UpdatedAt { get => updatedAt; set => updatedAt = value; }
        public int Weight { get => weight; set => weight = value; }
        public int Height { get => height; set => height = value; }
        public int Width { get => width; set => width = value; }
        public int Length { get => length; set => length = value; }
        public ProductDTO product { get; set; }

        //public ProductIconsDTO productIcons { get; set; }
        //public ProductObjectDTO productObject { get; set; }
        //public ProductCategoryDTO productCategory { get; set; }


    }
}
