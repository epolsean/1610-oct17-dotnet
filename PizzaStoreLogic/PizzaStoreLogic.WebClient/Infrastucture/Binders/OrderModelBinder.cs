using System;
using System.Web.Mvc;
using PizzaStoreLogic.Logic.Models;
using PizzaStoreLogic.Logic;
using System.Linq;

namespace PizzaStoreLogic.WebClient.Infrastucture.Binders
{
    public class OrderModelBinder : IModelBinder
    {
        private const string sessionKey = "Order";

        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            // get the Order from the session
            OrderDTO order = null;
            if (controllerContext.HttpContext.Session != null)
            {
                order = (OrderDTO)controllerContext.HttpContext.Session[sessionKey];
            }

            // create the Order if there wasn't one in the session data
            if(order == null)
            {
                order = new OrderDTO();
                if(controllerContext.HttpContext.Session != null)
                {
                    controllerContext.HttpContext.Session[sessionKey] = order;
                }
            }

            // return Order
            return order;
        }
    }
}