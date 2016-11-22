using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using PizzaStoreApi.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Web;
using System.Web.Http;

namespace PizzaStoreApi.Client.Controllers
{
    public class AccountController : ApiController
    {
        private static  UserStore<IdentityUser> credentials = new UserStore<IdentityUser>();

        public HttpResponseMessage Post([FromBody] UserAccount account)
        {
            var user = new IdentityUser() { UserName = account.username};
            var manager = new UserManager<IdentityUser>(credentials);
            var result = manager.Create(user, account.password);

            if(result.Succeeded)
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }

            return Request.CreateResponse(HttpStatusCode.BadRequest);
        }

        public HttpResponseMessage Delete(string user)
        {
            var manager = new UserManager<IdentityUser>(credentials);
            var u = manager.FindByName(user);
            var result = manager.Delete(u);

            if (result.Succeeded)
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }

            return Request.CreateResponse(HttpStatusCode.BadRequest);
        }

        [HttpGet]
        public HttpResponseMessage Login([FromBody] UserAccount account)
        {
            var manager = new UserManager<IdentityUser>(credentials);
            var u = manager.FindByName(account.username);

            if(u == null)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            var auth = HttpContext.Current.GetOwinContext().Authentication;
            var id = manager.CreateIdentity(u, DefaultAuthenticationTypes.ApplicationCookie);

            auth.SignIn(id);

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpGet]
        [Agent007]
        public HttpResponseMessage Logout([FromBody] UserAccount account)
        {
            var auth = HttpContext.Current.GetOwinContext().Authentication;

            auth.SignOut();
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
