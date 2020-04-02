using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace BlueSkyTravel
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            Execute().Wait();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        static async Task Execute()
        {
            var apiKey = Environment.GetEnvironmentVariable("BlueSky");
            var client = new SendGridClient("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");
            var from = new EmailAddress("TShaw516@gmail.com", "WCCI Team");
            var subject = "Email Confirmation";
            var to = new EmailAddress("TShaw516@gmail.com", "Tom Shaw");
            var plainTextContent = "and easy to do anywhere, even with C#";
            var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
        }
    }
}
