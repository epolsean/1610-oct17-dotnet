using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PizzaStoreData.DataAccess;
using PizzaStoreData.DataClient.Models;

namespace PizzaStoreData.DataClient.Mappers
{
    public class CheeseMapper
    {
        public static CheeseDAO MapToCheeseDAO(Cheese cheese)
        {
            var c = new CheeseDAO();
            c.Id = cheese.CheeseID;
            c.Name = cheese.CheeseType;
            c.Active = cheese.Active;

            return c;
        }

        public static Cheese MapToCheese(CheeseDAO cheese)
        {
            var c = new Cheese();
            c.CheeseID = cheese.Id;
            c.CheeseType = cheese.Name;
            c.Active = cheese.Active;

            return c;
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