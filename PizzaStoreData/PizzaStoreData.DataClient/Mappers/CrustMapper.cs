using PizzaStoreData.DataAccess;
using PizzaStoreData.DataClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreData.DataClient.Mappers
{
    public class CrustMapper
    {
        public static CrustDAO MapToCrustDAO(Crust crust)
        {
            var c = new CrustDAO();
            c.Id = crust.CrustID;
            c.Name = crust.CrustType;
            c.Active = crust.Active;

            return c;
        }

        public static Crust MapToCrust(CrustDAO crust)
        {
            var c = new Crust();
            c.CrustID = crust.Id;
            c.CrustType = crust.Name;
            c.Active = crust.Active;

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