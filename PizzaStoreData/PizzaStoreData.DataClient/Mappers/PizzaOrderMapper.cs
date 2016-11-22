using PizzaStoreData.DataAccess;
using PizzaStoreData.DataClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreData.DataClient.Mappers
{
    public class PizzaOrderMapper
    {
        public static PizzaOrderDAO MapToPizzaOrderDAO(PizzaOrder pizzaOrder)
        {
            var po = new PizzaOrderDAO();
            po.Id = pizzaOrder.OrderID;
            po.Customer = CustomerMapper.MapToCustomerDAO(pizzaOrder.Customer);
            po.Store = StoreMapper.MapToStoreDAO(pizzaOrder.Store);
            po.Payment = PaymentTypeMapper.MapToPaymentTypeDAO(pizzaOrder.PaymentType);
            po.Active = pizzaOrder.Active;

            return po;
        }

        public static PizzaOrder MapToPizzaOrder(PizzaOrderDAO pizzaOrder)
        {
            var po = new PizzaOrder();
            po.OrderID = pizzaOrder.Id;
            po.CustomerID = CustomerMapper.MapToCustomer(pizzaOrder.Customer).CustomerID;
            po.StoreID = StoreMapper.MapToStore(pizzaOrder.Store).StoreID;
            po.PaymentTypeID = PaymentTypeMapper.MapToPaymentType(pizzaOrder.Payment).PaymentTypeID;
            po.Active = pizzaOrder.Active;

            return po;
        }

        public static object MapTo(object o)
        {
            var properties = 0.GetType().GetProperties();
            var ob = new object();

            foreach (var item in properties.ToList())
            {
                ob.GetType().GetProperty(item.Name).SetValue(ob, item.GetValue(item));
            }

            return ob;
        }
    }
}