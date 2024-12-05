using System;

namespace LibDTO
{
    public class FlashSaleDTO
    {
        private System.DateTime start_at, end_at, updatedAt, createdAt;

        public int flash_sale_id { get; set; }
        public string flash_sale_name { get; set; }
        public string thumbnail { get; set; }
        public string status { get; set; }
        public DateTime Start_at { get => start_at; set => start_at = value; }
        public DateTime End_at { get => end_at; set => end_at = value; }
        public DateTime CreatedAt { get => createdAt; set => createdAt = value; }
        public DateTime UpdatedAt { get => updatedAt; set => updatedAt = value; }
    }

}
