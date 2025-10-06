using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using ShoppingMongo.Models;

namespace ShoppingMongo.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult DetailComponent(string id)
        {
            return ViewComponent("_UIProductDetailComponent", new { id = id });
        }

        [HttpGet]
        public PartialViewResult _FooterPartial()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult _FooterPartial(UINewsletterViewModel model)
        {
            MimeMessage mimeMessage = new MimeMessage();
            MailboxAddress mailboxAddressFrom = new MailboxAddress("Coza Store Admin", "projectsdotnet1@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom);

            MailboxAddress mailboxAddressTo = new MailboxAddress("User", model.ReceiverMail);
            mimeMessage.To.Add(mailboxAddressTo);

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = "Hello," +
                "\\n\\nYou have successfully subscribed to our newsletter to stay informed about Coza Store’s special campaigns and the latest products." +
                "\\n\\n🎁 We have a special discount coupon just for you!" +
                "\\n\\Coupon Code: COZA20" +
                "\\nDiscount: %20" +
                "\\nValidity: On all products" +
                "\\n\\nUse your coupon now and enjoy your shopping! " +
                "👉 https://www.cozastore.com" +
                "\\n\\nIf you have any questions, don’t hesitate to contact us." +
                "\\n\\nWe wish you a pleasant shopping experience.!" +
                "\\n\\nWith love," +
                "\\nCoza Store Team\";";
            mimeMessage.Body = bodyBuilder.ToMessageBody();
            mimeMessage.Subject = "Coza Store | Your Newsletter Subscription Has Been Confirmed";

            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
            client.Authenticate("projectsdotnet1@gmail.com", "scmo rnov rnbj ighn");
            client.Send(mimeMessage);
            client.Disconnect(true);

            return RedirectToAction("Index");            
        }
    }
}
