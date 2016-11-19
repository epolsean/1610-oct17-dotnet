using PizzaStoreData.DataAccess;
using PizzaStoreData.DataClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreData.DataClient.Mappers
{
    public class CheeseToppingMapper
    {
        public static CheeseToppingDAO MapToCheeseToppingDAO(CheeseTopping cheeseTopping)
        {
            var ct = new CheeseToppingDAO();
            ct.Id = cheeseTopping.CheeseToppingID;
            ct.Pizza = PizzaMapper.MapToPizzaDAO(cheeseTopping.Pizza);
            ct.Cheese = CheeseMapper.MapToCheeseDAO(cheeseTopping.Cheese);
            ct.Active = cheeseTopping.Active;

            return ct;
        }

        public static CheeseTopping MapToCheeseTopping(CheeseToppingDAO cheeseTopping)
        {
            var ct = new CheeseTopping();
            ct.CheeseToppingID = cheeseTopping.Id;
            ct.PizzaID = PizzaMapper.MapToPizza(cheeseTopping.Pizza).PizzaID;
            ct.CheeseID = CheeseMapper.MapToCheese(cheeseTopping.Cheese).CheeseID;
            ct.Active = cheeseTopping.Active;

            return ct;
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