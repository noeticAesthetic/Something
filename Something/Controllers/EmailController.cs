using RestSharp;
using Something.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace Something.Controllers
{
    public class EmailController : Controller
    {
        public ActionResult ContactForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult ContactForm(EmailModel _emailModel)
        {
            if (ModelState.IsValid)
            {
                //SendSimpleMessage();
                RestClient client = new RestClient();
                client.BaseUrl = "https://api.mailgun.net/v2";
                client.Authenticator =
                       new HttpBasicAuthenticator("api",
                                                  "key-578a749965e5c77f55426bcfed902999");
                RestRequest request = new RestRequest();
                request.AddParameter("domain",
                                    "sandbox2b8c71a3563645e6a05ab4db474beb59.mailgun.org", ParameterType.UrlSegment);
                request.Resource = "{domain}/messages";
                request.AddParameter("from", "Mailgun Sandbox <postmaster@sandbox2b8c71a3563645e6a05ab4db474beb59.mailgun.org>");
                request.AddParameter("to", "Clint <clintecurtis@gmail.com>");
                request.AddParameter("subject", "Contact Form Test");
                string body = string.Format("Name: {0}{1}Email: {2}{1}Website: {3}{1}Phone: {4}{1}{1}{5}", _emailModel.FromName, Environment.NewLine, _emailModel.From, _emailModel.FromUrl, _emailModel.FromPhone, _emailModel.Body);
                request.AddParameter("text", body);
                request.Method = Method.POST;
                client.Execute(request);

                //MailMessage mail = new MailMessage();
                //mail.To.Add("clintecurtis@gmail.com");
                //mail.From = new MailAddress(_emailModel.From);
                //mail.Subject = "Contact Test Form";
                //string Body = string.Format("Name: {0}{1}Email: {2}{1}Website: {3}{1}Phone: {4}{1}{5}", _emailModel.FromName, Environment.NewLine, _emailModel.From, _emailModel.FromUrl, _emailModel.FromPhone, _emailModel.Body);
                //mail.Body = Body;
                //mail.IsBodyHtml = true;
                //SmtpClient smtp = new SmtpClient();
                //smtp.Host = "smtp.gmail.com";
                //smtp.Port = 587;
                //smtp.Credentials = new System.Net.NetworkCredential("clintecurtis@gmail.com", "PASSWORD");
                //smtp.EnableSsl = true;
                //smtp.Send(mail);

                return View("Error"); // TODO: Return different view eventually
            }
            else
            {
                return View();
            }
        }

        public static IRestResponse SendSimpleMessage(EmailModel _emailModel)
        {
            RestClient client = new RestClient();
            client.BaseUrl = "https://api.mailgun.net/v2";
            client.Authenticator =
                   new HttpBasicAuthenticator("api",
                                              "key-578a749965e5c77f55426bcfed902999");
            RestRequest request = new RestRequest();
            request.AddParameter("domain",
                                "sandbox2b8c71a3563645e6a05ab4db474beb59.mailgun.org", ParameterType.UrlSegment);
            request.Resource = "{domain}/messages";
            request.AddParameter("from", "Mailgun Sandbox <postmaster@sandbox2b8c71a3563645e6a05ab4db474beb59.mailgun.org>");
            request.AddParameter("to", "Clint <clintecurtis@gmail.com>");
            request.AddParameter("subject", "Contact Form Test");
            string body = string.Format("Name: {0}{1}Email: {2}{1}Website: {3}{1}Phone: {4}{1}{5}", _emailModel.FromName, Environment.NewLine, _emailModel.From, _emailModel.FromUrl, _emailModel.FromPhone, _emailModel.Body);
            request.AddParameter("text", body);
            request.Method = Method.POST;
            return client.Execute(request);
        }
    }
}
