using System;
using System.Net;
using System.Net.Mail;

namespace Nike_Shop_Management.Utils
{
    public class EmailHelper
    {
        public static void SendResetPasswordEmail(string toEmail, string resetLink)
        {
            try
            {
                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("boquangdieu2003@gmail.com", "bcrozehsoamutvkm"), 
                    EnableSsl = true,
                };

                var mailMessage = new MailMessage
                {
                    From = new MailAddress("boquangdieu2003@gmail.com"),
                    Subject = "Đặt lại mật khẩu",
                    Body = $"Chào bạn,<br><br>Bạn có thể đặt lại mật khẩu bằng cách nhấp vào liên kết sau:<br><a href='{resetLink}'>{resetLink}</a><br><br>Trân trọng,<br>Đội ngũ hỗ trợ.",
                    IsBodyHtml = true,
                };

                mailMessage.To.Add(toEmail);
                smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Loi gui mail: {ex.Message}");
                throw;
            }
        }
    }
}
