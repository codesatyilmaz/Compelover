using System.Net;
using System.Net.Mail;

namespace Compelover.WEBUI.TagHelpers
{
    public static class PasswordResetTagHelper
    {
        public static void PasswordResetSendEmail(string link,string email)
        {
            var mailMessage = new MailMessage();
            SmtpClient smtpClient = new SmtpClient("esatyy@outlook.com",587);
            smtpClient.UseDefaultCredentials = false;
            smtpClient.EnableSsl = true;
            mailMessage.From = new MailAddress("esatcanyilmaz_@outlook.com"); //kimden gidecek bu mail adresi.
            mailMessage.To.Add(email); //kullanıcının email adresine gidecek.
            mailMessage.Subject = $"Open Test Şifre Yenileme";
            mailMessage.Body = "<h2>Şifre yenilemek için linke tıklayınız</h2><hr/>";
            mailMessage.Body += $"<a href='{link}'>Şifre yenilemek için tıkla</a>";
            mailMessage.IsBodyHtml = true;
            // smtpClient.Port = 587;
            smtpClient.Credentials=new NetworkCredential("esatcanyilmaz_@outlook.com","aaa");
            smtpClient.Send(mailMessage);

        }
    }
}