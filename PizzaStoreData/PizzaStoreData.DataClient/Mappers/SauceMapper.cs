using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PizzaStoreData.DataAccess;
using PizzaStoreData.DataClient.Models;

namespace PizzaStoreData.DataClient.Mappers
{
    public class SauceMapper
    {
        public static SauceDAO MapToSauceDAO(Sauce sauce)
        {
            var s = new SauceDAO();
            s.Id = sauce.SauceID;
            s.Name = sauce.SauceType;
            s.Active = sauce.Active;

            return s;
        }

        public static Sauce MapToSauce(SauceDAO sauce)
        {
            var s = new Sauce();
            s.SauceID = sauce.Id;
            s.SauceType = sauce.Name;
            s.Active = sauce.Active;

            return s;
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