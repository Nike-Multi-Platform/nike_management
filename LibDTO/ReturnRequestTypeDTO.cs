using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibDTO
{
    public class ReturnRequestTypeDTO
    {
        private int request_type_id;
        private string request_type_name;

        public int Request_type_id { get => request_type_id; set => request_type_id = value; }
        public string Request_type_name { get => request_type_name; set => request_type_name = value; }
    }
}
