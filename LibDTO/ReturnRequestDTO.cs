using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibDTO
{
    public class ReturnRequestDTO
    {
        private int return_request_id;
        private int request_type_id;
        private string resolver_id;
        private int user_order_id;
        private string return_request_reason;
        private int status_id;
        private DateTime created_at;
        private DateTime updated_at;

        public int Return_request_id { get => return_request_id; set => return_request_id = value; }
        public int Request_type_id { get => request_type_id; set => request_type_id = value; }
        public string Resolver_id { get => resolver_id; set => resolver_id = value; }
        public int User_order_id { get => user_order_id; set => user_order_id = value; }
        public string Return_request_reason { get => return_request_reason; set => return_request_reason = value; }
        public int Status_id { get => status_id; set => status_id = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
        public DateTime Updated_at { get => updated_at; set => updated_at = value; }
    }
}
