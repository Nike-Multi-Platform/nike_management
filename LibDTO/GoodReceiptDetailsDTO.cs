namespace LibDTO
{
    public class GoodReceiptDetailsDTO
    {
        public int goods_receipt_details_id { get; set; }
        public int good_receipt_id { get; set; }
        public int product_id { get; set; }
        public int product_size_id { get; set; }
        public int quantity { get; set; }
        public int import_price { get; set; }
        public int total_price { get; set; }
    }
}
