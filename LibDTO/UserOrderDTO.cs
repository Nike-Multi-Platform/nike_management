using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibDTO
{
    public class UserOrderDTO
    {
        private int user_order_id, user_order_status_id, total_quantity;

        private string user_id, first_name, last_name, address, email, phone_number, payment_method, order_code, order_code_return;

        private System.DateTime createdAt, updatedAt;

        private System.Nullable<System.DateTime> _return_expiration_date;

        private System.Nullable<byte> is_canceled_by;

        private decimal shipping_fee, total_price, discount_price, final_price;
        public UserOrderStatusDTO UserOrderStatusDTO { get; set; }
        public string UserOrderStatusName => UserOrderStatusDTO?.user_order_status_name ?? "N/A";
        public int UserOrderStatusId => UserOrderStatusDTO?.user_order_status_id ?? 1;

        public int User_order_id { get => user_order_id; set => user_order_id = value; }
        public int User_order_status_id { get => user_order_status_id; set => user_order_status_id = value; }
        public int Total_quantity { get => total_quantity; set => total_quantity = value; }
        public string User_id { get => user_id; set => user_id = value; }
        public string First_name { get => first_name; set => first_name = value; }
        public string Last_name { get => last_name; set => last_name = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }
        public string Phone_number { get => phone_number; set => phone_number = value; }
        public string Payment_method { get => payment_method; set => payment_method = value; }
        public string Order_code { get => order_code; set => order_code = value; }
        public string Order_code_return { get => order_code_return; set => order_code_return = value; }
        public DateTime CreatedAt { get => createdAt; set => createdAt = value; }
        public DateTime UpdatedAt { get => updatedAt; set => updatedAt = value; }
        public DateTime? Return_expiration_date { get => _return_expiration_date; set => _return_expiration_date = value; }
        public byte? Is_canceled_by { get => is_canceled_by; set => is_canceled_by = value; }
        public decimal Shipping_fee { get => shipping_fee; set => shipping_fee = value; }
        public decimal Total_price { get => total_price; set => total_price = value; }
        public decimal Discount_price { get => discount_price; set => discount_price = value; }
        public decimal Final_price { get => final_price; set => final_price = value; }
    }
}
