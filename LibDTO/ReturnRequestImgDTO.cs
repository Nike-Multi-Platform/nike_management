using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LibDTO
{
    public class ReturnRequestImgDTO
    {
        private int return_request_imgs_id;
        private int return_request_id;
        private string img_url;

        public int Return_request_imgs_id { get => return_request_imgs_id; set => return_request_imgs_id = value; }
        public int Return_request_id { get => return_request_id; set => return_request_id = value; }
        public string Img_url { get => img_url; set => img_url = value; }
    }
}
