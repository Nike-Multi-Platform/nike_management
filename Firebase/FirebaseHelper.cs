using FirebaseAdmin.Auth;
using System;
using System.Threading.Tasks;

namespace Nike_Shop_Management.Firebase
{
    public class FirebaseHelper
    {
        public static async Task<string> GeneratePasswordResetLink(string email)
        {
            try
            {
                FirebaseConfig.InitializeFirebase();
                var link = await FirebaseAuth.DefaultInstance.GeneratePasswordResetLinkAsync(email);

                return link;
            }
            catch (Exception ex)
            {
                throw new Exception($"Loi tao lien ket: {ex.Message}");
            }
        }
    }
}
