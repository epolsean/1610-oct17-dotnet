using PizzaStoreData.DataAccess;
using PizzaStoreData.DataClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreData.DataClient.Mappers
{
    public class PizzaOrderDetailMapper
    {
        public static PizzaOrderDetailDAO MapToPizzaOrderDetailDAO(PizzaOrderDetail pizzaOrderDetail)
        {
            var pod = new PizzaOrderDetailDAO();
            pod.Id = pizzaOrderDetail.PizzaOrderDetatilsID;
            pod.Pizza = PizzaMapper.MapToPizzaDAO(pizzaOrderDetail.Pizza);
            pod.Order = PizzaOrderMapper.MapToPizzaOrderDAO(pizzaOrderDetail.PizzaOrder);
            pod.Active = pizzaOrderDetail.Active;

            return pod;
        }

        public static PizzaOrderDetail MapToPizzaOrderDetail(PizzaOrderDetailDAO pizzaOrderDetail)
        {
            var pod = new PizzaOrderDetail();
            pod.PizzaOrderDetatilsID = pizzaOrderDetail.Id;
            pod.PizzaID = PizzaMapper.MapToPizza(pizzaOrderDetail.Pizza).PizzaID;
            pod.OrderID = PizzaOrderMapper.MapToPizzaOrder(pizzaOrderDetail.Order).OrderID;
            pod.Active = pizzaOrderDetail.Active;

            return pod;
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