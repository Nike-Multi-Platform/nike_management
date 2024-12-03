using System;

namespace LibDTO
{
    public class FlashSaleDTO
    {
        private System.DateTime createdAt, updatedAt;
        public int flash_sale_id { get; set; }
        public string flash_sale_name { get; set; }
        public string thumbnail { get; set; }
        public string status { get; set; }
        public DateTime start_at { get; set; }
        public DateTime end_at { get; set; }
        public DateTime CreatedAt { get => createdAt; set => createdAt = value; }
        public DateTime UpdatedAt { get => updatedAt; set => updatedAt = value; }
    }
}
