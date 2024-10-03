namespace LibDTO
{
    public class ProductColorsDTO
    {
        public int product_id { get; set; }
        public int product_parent_id { get; set; }
        public string product_more_info { get; set; }
        public string product_img { get; set; }
        public string product_size_and_fit { get; set; }
        public string product_style_code { get; set; }
        public string product_color_shown { get; set; }
        public string product_description { get; set; }
        public string product_description2 { get; set; }
        public int supplier_id { get; set; }
        public string sale_prices { get; set; }
        public string sold { get; set; }
        public string total_stock { get; set; }
        //    public ProductImgDTO product_imgs { get; set; }
        //   public ProductSizeDTO product_sizes { get; set; }

    }
}
