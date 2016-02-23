using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Helpers;

namespace copadomundoAUX.Controllers
{
    public class EmailController : Controller
    {

        public EmailController()
        {
            WebMail.SmtpServer = "smtp.gmail.com";
            WebMail.EnableSsl = true;
            WebMail.SmtpPort = 587;
            WebMail.From = "Email";
            WebMail.UserName = "username";
            WebMail.Password = "senha";
        }

        // POST: /Email/Envia 
        public ActionResult Envia(String mensagem)
        {
            WebMail.Send("Email", "Copa do Mundo - Erro", mensagem);
            return View();
        }
    }
}