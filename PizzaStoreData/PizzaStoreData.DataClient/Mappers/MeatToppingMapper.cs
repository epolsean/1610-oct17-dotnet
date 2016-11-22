using PizzaStoreData.DataAccess;
using PizzaStoreData.DataClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreData.DataClient.Mappers
{
    public class MeatToppingMapper
    {
        public static MeatToppingDAO MapToMeatToppingDAO(MeatTopping meatTopping)
        {
            var mt = new MeatToppingDAO();
            mt.Id = meatTopping.MeatToppingID;
            mt.Pizza = PizzaMapper.MapToPizzaDAO(meatTopping.Pizza);
            mt.Meat = MeatMapper.MapToMeatDAO(meatTopping.Meat);
            mt.Active = meatTopping.Active;

            return mt;
        }

        public static MeatTopping MapToMeatTopping(MeatToppingDAO meatTopping)
        {
            var mt = new MeatTopping();
            mt.MeatToppingID = meatTopping.Id;
            mt.PizzaID = PizzaMapper.MapToPizza(meatTopping.Pizza).PizzaID;
            mt.MeatID = MeatMapper.MapToMeat(meatTopping.Meat).MeatID;
            mt.Active = meatTopping.Active;

            return mt;
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