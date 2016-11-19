using PizzaStoreLogic.Logic.Models;
using PizzaStoreLogic.Logic.PizzaStoreDataService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreLogic.Logic.Mappers
{
    public class MeatToppingMapper
    {
        public static MeatToppingDAO MapToDAO(MeatToppingDTO topping)
        {
            var mt = new MeatToppingDAO();
            mt.Id = topping.Id;
            mt.Pizza = PizzaMapper.MapToDAO(topping.Pizza);
            mt.Meat = MeatMapper.MapToDAO(topping.Meat);
            mt.Active = topping.Active;

            return mt;
        }

        public static MeatToppingDTO MapToDTO(MeatToppingDAO topping)
        {
            var mt = new MeatToppingDTO();
            mt.Id = topping.Id;
            mt.Pizza = PizzaMapper.MapToDTO(topping.Pizza);
            mt.Meat = MeatMapper.MapToDTO(topping.Meat);
            mt.Active = topping.Active;

            return mt;
        }
    }
}
