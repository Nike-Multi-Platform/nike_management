using System;

namespace LibDTO
{
    public class FlashSaleTimeFrameDTO
    {

        public System.DateTime createAt, updateAt;
        public System.Nullable<System.DateTime> start_at, end_at;
        public int flash_sale_time_frame_id { get; set; }
        public int flash_sale_id { get; set; }
        public string status { get; set; }
        public DateTime? Start_at { get => start_at; set => start_at = value; }
        public DateTime? End_at { get => end_at; set => end_at = value; }
        public DateTime CreateAt { get => createAt; set => createAt = value; }
        public DateTime UpdateAt { get => updateAt; set => updateAt = value; }
    }
}
