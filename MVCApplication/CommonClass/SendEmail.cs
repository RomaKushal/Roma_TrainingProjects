using System;
using System.Configuration;
using System.IO;
using System.Net.Mail;

namespace MVCApplication.CommonClass
{
    public class SendEmail
    {
        #region Variable Declarations
        private static string smtpClientUrl = ConfigurationManager.AppSettings["smtpclient"];
        private static string smtpUser = ConfigurationManager.AppSettings["smtpUser"];
        private static string smtpPassword = ConfigurationManager.AppSettings["smtpuserpassword"];
        private static string smtpPort = ConfigurationManager.AppSettings["smtpPort"];
        private static string emailFrom = ConfigurationManager.AppSettings["email_ToUser_from"];
        private static string DefaultCredentials = ConfigurationManager.AppSettings["default_credentials"];
        private static string EnableSSL = ConfigurationManager.AppSettings["enable_ssl"];

        #endregion

        #region Public Methods
        public static string ReadTemplateFile(string templateFilePath)
        {
            return File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + templateFilePath);
        }

        public static bool SendEmailMessage(string emailTo, string body)
        {
            MailMessage mailMessage = new MailMessage();
            mailMessage.IsBodyHtml = true;
            mailMessage.From = new MailAddress(emailFrom);
            mailMessage.To.Add(new MailAddress(emailTo));

            mailMessage.Subject = "sad";
            mailMessage.Body = body;
            mailMessage.Priority = MailPriority.High;

            SmtpClient smtpClientDetails = new SmtpClient(smtpClientUrl);
            System.Net.NetworkCredential SMTPUserInfo = new System.Net.NetworkCredential(smtpUser, smtpPassword);
            smtpClientDetails.Port = Convert.ToInt16(smtpPort);
            smtpClientDetails.UseDefaultCredentials = Convert.ToBoolean(DefaultCredentials);
            smtpClientDetails.EnableSsl = Convert.ToBoolean(EnableSSL);
            smtpClientDetails.Credentials = SMTPUserInfo;
            smtpClientDetails.Send(mailMessage);
            return true;
        }

        #endregion

    }
}