using APIMetaDoc.Auth;
using APIMetaDoc.Models;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Services.Description;
using System.Net;
using System.Net.Mail;

namespace APIMetaDoc.Controllers
{
    [EnableCors("*", "*", "*")]
    public class AuthController : ApiController
    {
        //[HttpPost]
        //[Route("api/login")]
        //public HttpResponseMessage Login (LoginModel login)
        //{
        //    try
        //    {
        //        var res = AuthService.Authenticate(login.Username, login.Password);
        //        if (res != null)
        //        {
        //            return Request.CreateResponse(HttpStatusCode.OK, res);
        //        }
        //        else return Request.CreateResponse(HttpStatusCode.NotFound, new { Message = "User not found" });
        //    }
        //    catch (Exception ex)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
        //    }
        //}

        //[Logged]
        //[HttpGet]
        //[Route("api/logout")]
        //public HttpResponseMessage Logout()
        //{
        //    var token = Request.Headers.Authorization.ToString();
        //    try
        //    {
        //        var res = AuthService.Logout(token);
        //        return Request.CreateResponse(HttpStatusCode.OK, res);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message });
        //    }
        //}

        [HttpPost]
        [Route("api/login")]
        public HttpResponseMessage Login(LoginModel login)
        {
            try
            {
                var res = AuthService.Authenticate(login.Username, login.Password);
                if (res != null)
                {
                    // Successful authentication
                    SendEmail(login.Username, "Login Notification", "You have successfully logged in.");

                    return Request.CreateResponse(HttpStatusCode.OK, res);
                }
                else
                {
                    // User not found
                    return Request.CreateResponse(HttpStatusCode.NotFound, new { Message = "User Not Found!" });
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        private void SendEmail(string toEmail, string subject, string body)
        {
            string fromEmail = "metadocofficials@gmail.com"; // Replace with your email address

            MailMessage mail = new MailMessage();
            SmtpClient smtpClient = new SmtpClient();

            mail.From = new MailAddress(fromEmail);
            mail.To.Add(toEmail);
            mail.Subject = subject;
            mail.Body = body;

            smtpClient.Send(mail);
        }

        [Logged]
        [HttpGet]
        [Route("api/logout")]
        public HttpResponseMessage Logout()
        {
            var token = Request.Headers.Authorization.ToString();
            try
            {
                var res = AuthService.Logout(token);
                return Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message });
            }
        }
    }
}
