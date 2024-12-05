using System;

namespace LibDTO
{
    public class DiscountVoucherDTO
    {
        public System.DateTime start_at, end_at;
        public int discount_voucher_id { get; set; }
        public string voucer_name { get; set; }
        public string voucher_code { get; set; }
        public string discount_type { get; set; }
        public int usage { get; set; }
        public int quantity { get; set; }
        public int min_order_value { get; set; }
        public long discount_value { get; set; }
        public long discount_max_value { get; set; }
        public string discription { get; set; }
        public DateTime Start_at { get => start_at; set => start_at = value; }
        public DateTime End_at { get => end_at; set => end_at = value; }

    }
}
