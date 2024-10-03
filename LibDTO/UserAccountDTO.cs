namespace LibDTO
{
    public class UserAccountDTO
    {

        private int id;
        private string username;
        private string password;
        private string gender;
        private string email;
        private string phone_number, address, first_name, last_name, url;
        private int? point;
        private int? member_tier;

        public int user_id { get => id; set => id = value; }
        public string user_username { get => username; set => username = value; }
        public string user_password { get => password; set => password = value; }
        public string user_gender { get => gender; set => gender = value; }
        public string user_email { get => email; set => email = value; }
        public string user_phone_number { get => phone_number; set => phone_number = value; }
        public string user_address { get => address; set => address = value; }
        public string user_first_name { get => first_name; set => first_name = value; }
        public string user_last_name { get => last_name; set => last_name = value; }
        public int? user_member_tier { get => member_tier; set => member_tier = value; }
        public int? user_point { get => point; set => point = value; }
        public string user_url { get => url; set => url = value; }


    }
}
