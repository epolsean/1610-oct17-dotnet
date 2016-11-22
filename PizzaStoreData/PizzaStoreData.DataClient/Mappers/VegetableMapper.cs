using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PizzaStoreData.DataAccess;
using PizzaStoreData.DataClient.Models;

namespace PizzaStoreData.DataClient.Mappers
{
    public class VegetableMapper
    {
        public static VegetableDAO MapToVegetableDAO(Vegetable vegetable)
        {
            var v = new VegetableDAO();
            v.Id = vegetable.VegetableID;
            v.Name = vegetable.VegetableType;
            v.Active = vegetable.Active;

            return v;
        }

        public static Vegetable MapToVegetable(VegetableDAO vegetable)
        {
            var v = new Vegetable();
            v.VegetableID = vegetable.Id;
            v.VegetableType = vegetable.Name;
            v.Active = vegetable.Active;

            return v;
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