using PizzaStoreLogic.Logic;
using PizzaStoreLogic.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreLogic.WebClient.Models
{
    public class CustomerModel
    {
        private DataService _Data = new DataService();
        private List<CustomerDTO> _Customers = new DataService().GetCustomers();

        public CustomerDTO Customer { get; set; }
        public string ReturnUrl { get; set; }
        public List<CustomerDTO> Customers { get { return _Customers; } set { _Customers = _Data.GetCustomers(); } }
    }
}