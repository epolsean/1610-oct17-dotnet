using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzaStoreMVC.Client.Models
{
    public class PizzaModel
    {
        public List<SelectListItem> Option { get; set; }
        public string Sauce { get; set; }

        public PizzaModel()
        {
            Option = ClientHelper.GetSauces();
        }
    }
}