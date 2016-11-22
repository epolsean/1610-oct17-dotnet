using PizzaStoreLogic.Logic.Models;
using PizzaStoreLogic.WebClient.Infrastucture.Binders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PizzaStoreLogic.WebClient
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            ModelBinders.Binders.Add(typeof(OrderDTO), new OrderModelBinder());
            ModelBinders.Binders.Add(typeof(CustomerDTO), new CustomerModelBinder());
        }
    }
}
