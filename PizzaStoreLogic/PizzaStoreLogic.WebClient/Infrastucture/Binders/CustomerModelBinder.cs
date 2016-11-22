using System;
using System.Web.Mvc;
using PizzaStoreLogic.Logic.Models;

namespace PizzaStoreLogic.WebClient.Infrastucture.Binders
{
    public class CustomerModelBinder : IModelBinder
    {
        private const string sessionKey = "Customer";

        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            // get the Customer from the session
            CustomerDTO customer = null;
            if (controllerContext.HttpContext.Session != null)
            {
                customer = (CustomerDTO)controllerContext.HttpContext.Session[sessionKey];
            }

            // create the Customer if there wasn't one in the session data
            if (customer == null)
            {
                customer = new CustomerDTO();
                customer.Id = 0;
                if (controllerContext.HttpContext.Session != null)
                {
                    controllerContext.HttpContext.Session[sessionKey] = customer;
                }
            }

            // return Customer
            return customer;
        }
    }
}