using System;

namespace LibDTO
{
    public class FlashSaleDTO
    {
        private DateTime createdAt = DateTime.UtcNow;
        private DateTime updatedAt = DateTime.UtcNow;
        private DateTime start_at = DateTime.UtcNow;
        private DateTime end_at = DateTime.UtcNow.AddHours(1);

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
