using PizzaStoreLogic.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreLogic.WebClient.Models
{
    public class OrderIndexViewModel
    {
        public OrderDTO Order { get; set; }
        public string ReturnUrl { get; set; }
    }
}