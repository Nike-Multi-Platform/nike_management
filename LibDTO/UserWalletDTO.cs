using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibDTO
{
    public class UserWalletDTO
    {
        private int user_wallet_id;
        private string user_id;
        private decimal balance;
        private System.DateTime createdAt;
        private System.DateTime updatedAt;
        public int User_wallet_id { get => user_wallet_id; set => user_wallet_id = value; }
        public string User_id { get => user_id; set => user_id = value; }
        public decimal Balance { get => balance; set => balance = value; }
        public DateTime CreatedAt { get => createdAt; set => createdAt = value; }
        public DateTime UpdatedAt { get => updatedAt; set => updatedAt = value; }
    }
}
