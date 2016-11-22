using PizzaStoreData.DataAccess;
using PizzaStoreData.DataClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreData.DataClient.Mappers
{
    public class MeatMapper
    {
        public static MeatDAO MapToMeatDAO(Meat meat)
        {
            var m = new MeatDAO();
            m.Id = meat.MeatID;
            m.Name = meat.MeatType;
            m.Active = meat.Active;

            return m;
        }

        public static Meat MapToMeat(MeatDAO meat)
        {
            var m = new Meat();
            m.MeatID = meat.Id;
            m.MeatType = meat.Name;
            m.Active = meat.Active;

            return m;
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