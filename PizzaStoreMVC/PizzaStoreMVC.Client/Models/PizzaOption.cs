using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzaStoreMVC.Client.Models
{
    public class PizzaOption
    {
        public List<SelectListItem> Sauces { get; set; }
    }
}