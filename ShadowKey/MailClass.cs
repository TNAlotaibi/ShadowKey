using System;
using System.Net.Mail;
using System.Net;
using System.Net.Mime;

namespace ShadowKey
{
    internal class MailClass
    {

        public static void SendMailTo(string toMail, string toName, string Hash, string decryptionKey,string fromName)
        {

            var fromAddress = new MailAddress("YourEmail", "ShadowKey App");
            var toAddress = new MailAddress(toMail, toName);
            const string fromPassword = "YourPasswordHere";
            const string subject = "🔐 You've Received a Secure Message via ShadowKey";
            string body = $@"
<html>
  <head>
    <style>
      body {{
        font-family: Arial, sans-serif;
        background-color: #f4f4f4;
        padding: 20px;
        color: #333;
      }}
      .container {{
        background-color: #fff;
        border-radius: 10px;
        padding: 30px;
        max-width: 600px;
        margin: auto;
        box-shadow: 0 0 10px rgba(0,0,0,0.1);
      }}
      .title {{
        color: #4A148C;
        text-align: center;
        font-size: 22px;
        font-weight: bold;
      }}
      .details {{
        margin-top: 20px;
        line-height: 1.6;
        font-size: 16px;
      }}
      .code-block {{
        background-color: #f1f1f1;
        border: 1px solid #ccc;
        padding: 10px;
        border-radius: 5px;
        font-family: 'Courier New', monospace;
        font-size: 15px;
        word-break: break-all;
        margin: 10px 0;
        color: #222;
      }}
      .footer {{
        margin-top: 30px;
        font-size: 13px;
        color: #999;
        text-align: center;
      }}
    </style>
  </head>
  <body>
    <div class='container'>
      <div class='title'>You've Got a Secret Message!</div>
      <div class='details'>
        Hello <strong>{toName}</strong>,<br><br>
        You've received a new <strong>encrypted message</strong> from <strong>{fromName}</strong>, via <em>ShadowKey</em>.<br><br>
        <strong>Hash:</strong>
        <div class='code-block'><strong>{Hash}</strong></div>
        <strong>Decryption Key:</strong>
        <div class='code-block'><strong>{decryptionKey}</strong></div>
        Use the ShadowKey app to decrypt and view your hidden message.
      </div>
      <div class='footer'>
        &copy; 2025 ShadowKey App | Secure Steganography Messaging
      </div>
    </div>
  </body>
</html>";



            try
            {
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };

                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    
                    IsBodyHtml = true
                })
                {
                    AlternateView htmlView = AlternateView.CreateAlternateViewFromString(body, null, MediaTypeNames.Text.Html);
                    message.AlternateViews.Add(htmlView);
                    smtp.Send(message);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error sending email:\n" + ex.Message);
            }
        }
      

    }
}
