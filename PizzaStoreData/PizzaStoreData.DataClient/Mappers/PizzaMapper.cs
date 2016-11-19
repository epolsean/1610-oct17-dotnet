using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PizzaStoreData.DataAccess;
using PizzaStoreData.DataClient.Models;

namespace PizzaStoreData.DataClient.Mappers
{
    public class PizzaMapper
    {
        public static PizzaDAO MapToPizzaDAO(Pizza pizza)
        {
            var p = new PizzaDAO();
            p.Id = pizza.PizzaID;
            p.Size = SizeMapper.MapToSizeDAO(pizza.Size);
            p.Crust = CrustMapper.MapToCrustDAO(pizza.Crust);
            p.Sauce = SauceMapper.MapToSauceDAO(pizza.Sauce);
            p.Cheese = CheeseMapper.MapToCheeseDAO(pizza.Cheese);
            p.Quantity = pizza.Quantity;
            p.Active = pizza.Active;

            return p;
        }

        public static Pizza MapToPizza(PizzaDAO pizza)
        {
            var p = new Pizza();
            p.PizzaID = pizza.Id;
            p.SizeID = SizeMapper.MapToSize(pizza.Size).SizeID;
            p.CrustID = CrustMapper.MapToCrust(pizza.Crust).CrustID;
            p.SauceID = SauceMapper.MapToSauce(pizza.Sauce).SauceID;
            p.CheeseID = CheeseMapper.MapToCheese(pizza.Cheese).CheeseID;
            p.Quantity = pizza.Quantity;
            p.Active = pizza.Active;

            return p;
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