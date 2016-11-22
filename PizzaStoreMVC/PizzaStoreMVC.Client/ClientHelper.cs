using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzaStoreMVC.Client
{
    public class ClientHelper
    {
        public static List<SelectListItem> GetSauces()
        {
            var sauces = new List<SelectListItem>()
            {
                new SelectListItem() { Text = "Alfredo", Value = "0" },
                new SelectListItem() { Text = "Tomato", Value = "1", Selected = true },
                new SelectListItem() { Text = "Marinara", Value = "2" }
            };

            return sauces;
        }
    }
}