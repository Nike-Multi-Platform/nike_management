using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nike_Shop_Management.GHNService
{
    public class GHNOrderResponse
    {
        public string Code { get; set; }
        public string Message { get; set; }
        public GHNOrderData Data { get; set; }
    }
    public class GHNOrderData
    {
        public string order_code { get; set; }
        public string status { get; set; }
    }
}
