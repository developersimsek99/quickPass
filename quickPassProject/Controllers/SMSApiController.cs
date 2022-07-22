using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vonage.Request;
using Vonage;

namespace quickPassProject.Controllers
{
    public class SMSApiController : Controller
    {
        // GET: SMSApi
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Send()
        {
            var credentials = Credentials.FromApiKeyAndSecret(
    "1effce5f",
    "JfbCEk87q7qjcq3D"
    );

            var VonageClient = new VonageClient(credentials);

            var response = VonageClient.SmsClient.SendAnSms(new Vonage.Messaging.SendSmsRequest()
            {
                To = "905537741245",
                From = "Vonage APIs",
                Text = "Sayin Murat SIMSEK, "+Session["name"]+" "+Session["surname"]+" tarafindan gönderilmis yeni bir oneri/sikayet kaydiniz bulunmaktadir."
            });
            return RedirectToAction("Index","Home");
        }
    }
}