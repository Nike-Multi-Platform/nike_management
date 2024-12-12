using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using System;
using System.IO;

namespace Nike_Shop_Management.Firebase
{
    public static class FirebaseConfig
    {
        public static void InitializeFirebase()
        {
            if (FirebaseApp.DefaultInstance == null)
            {
                string fullPath = Path.Combine(Directory.GetCurrentDirectory(), "Configs", "nike-d3392-firebase-adminsdk-t6ndk-9ec16d6644.json");

                if (!File.Exists(fullPath))
                {
                    throw new FileNotFoundException($"Không tìm thấy tệp cấu hình Firebase tại: {fullPath}");
                }

                FirebaseApp.Create(new AppOptions
                {
                    Credential = GoogleCredential.FromFile(fullPath)
                });
            }
        }
    }
}
