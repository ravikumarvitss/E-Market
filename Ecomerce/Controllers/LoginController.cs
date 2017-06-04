using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Ecomerce.Models;

namespace Ecomerce.Controllers
{
    public class LoginController : ApiController
    {
        Login[] login = new Login[]
        {
            new Login{UserName = "Ram123", password = "Ram123"},
            new Login{UserName = "Ravi123", password = "Ravi123"},
            new Login{UserName = "welcome", password = "welcome"}
        };

        public string GetAllUsers()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(login);
        }

        [HttpPost]
        public string GetLoggedinUserInformation(Login loginuser)
        {
            var userDetails = login.FirstOrDefault((p) => p.UserName == loginuser.UserName && p.password == loginuser.password);

            if (userDetails == null)
            {
                return "Fail";
            }
            return Newtonsoft.Json.JsonConvert.SerializeObject(userDetails);
        }

    }
}
