using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreMVC.Client.Models
{
    public class Customer
    {
        public Address Address { get; set; }
        public Email Email { get; set; }
        public Name Name { get; set; }
        public Phone Phone { get; set; }
    }
}