using PizzaStoreData.DataAccess;
using PizzaStoreData.DataClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreData.DataClient.Mappers
{
    public class VegetableToppingMapper
    {
        public static VegetableToppingDAO MapToVegetableToppingDAO(VegetableTopping vegetableTopping)
        {
            var vt = new VegetableToppingDAO();
            vt.Id = vegetableTopping.VegetableToppingID;
            vt.Pizza = PizzaMapper.MapToPizzaDAO(vegetableTopping.Pizza);
            vt.Vegetable = VegetableMapper.MapToVegetableDAO(vegetableTopping.Vegetable);
            vt.Active = vegetableTopping.Active;

            return vt;
        }

        public static VegetableTopping MapToVegetableTopping(VegetableToppingDAO vegetableTopping)
        {
            var vt = new VegetableTopping();
            vt.VegetableToppingID = vegetableTopping.Id;
            vt.PizzaID = PizzaMapper.MapToPizza(vegetableTopping.Pizza).PizzaID;
            vt.VegetableID = VegetableMapper.MapToVegetable(vegetableTopping.Vegetable).VegetableID;
            vt.Active = vegetableTopping.Active;

            return vt;
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