using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaStoreLogic.Logic.Models;
using PizzaStoreLogic.Logic.PizzaStoreDataService;

namespace PizzaStoreLogic.Logic.Mappers
{
    public class PizzaMapper
    {
        public static PizzaDAO MapToDAO(PizzaDTO pizza)
        {
            var p = new PizzaDAO();
            p.Id = pizza.Id;
            p.Size = SizeMapper.MapToDAO(pizza.Size);
            p.Crust = CrustMapper.MapToDAO(pizza.Crust);
            p.Sauce = SauceMapper.MapToDAO(pizza.Sauce);
            p.Cheese = CheeseMapper.MapToDAO(pizza.Cheese);
            p.Quantity = pizza.Quantity;
            p.Active = pizza.Active;

            return p;
        }

        public static PizzaDTO MapToDTO(PizzaDAO pizza)
        {
            var p = new PizzaDTO();
            p.Id = pizza.Id;
            p.Size = SizeMapper.MapToDTO(pizza.Size);
            p.Crust = CrustMapper.MapToDTO(pizza.Crust);
            p.Sauce = SauceMapper.MapToDTO(pizza.Sauce);
            p.Cheese = CheeseMapper.MapToDTO(pizza.Cheese);
            p.Quantity = pizza.Quantity;
            p.Active = pizza.Active;

            return p;
        }
    }
}
