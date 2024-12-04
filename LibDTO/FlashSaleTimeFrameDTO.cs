using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibDTO
{
    public class FlashSaleTimeFrameDTO
    {
        public DateTime start_time, end_time, createAt, updateAt;
        public int flash_sale_time_frame_id { get; set; }
        public int flash_sale_id { get; set; }
        public string status { get; set; }
        public DateTime Start_time { get => start_time; set => start_time = value; }
        public DateTime End_time { get => end_time; set => end_time = value; }
        public DateTime CreateAt { get => createAt; set => createAt = value; }
        public DateTime UpdateAt { get => updateAt; set => updateAt = value; }
    }
}
