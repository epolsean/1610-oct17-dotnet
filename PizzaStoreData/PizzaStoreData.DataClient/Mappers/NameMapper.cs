using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PizzaStoreData.DataAccess;
using PizzaStoreData.DataClient.Models;

namespace PizzaStoreData.DataClient.Mappers
{
    public class NameMapper
    {
        public static NameDAO MapToNameDAO(Name name)
        {
            var n = new NameDAO();
            n.Id = name.NameID;
            n.FirstName = name.FirstName;
            n.LastName = name.LastName;
            n.Active = name.Active;

            return n;
        }

        public static Name MapToName(NameDAO name)
        {
            var n = new Name();
            n.NameID = name.Id;
            n.FirstName = name.FirstName;
            n.LastName = name.LastName;
            n.Active = name.Active;

            return n;
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