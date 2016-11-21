using PizzaStoreLogic.WebClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzaStoreLogic.WebClient.Controllers
{
    public class PizzaController : Controller
    {
        public ViewResult Home()
        {
            return View();
        }

        public PartialViewResult Pizza()
        {
            return PartialView(new NewPizzaModel());
        }
    }
}