using PizzaStoreLogic.Logic.Models;
using PizzaStoreLogic.Logic.PizzaStoreDataService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreLogic.Logic.Mappers
{
    public class VegetableToppingMapper
    {
        public static VegetableToppingDAO MapToDAO(VegetableToppingDTO topping)
        {
            var vt = new VegetableToppingDAO();
            vt.Id = topping.Id;
            vt.Pizza = PizzaMapper.MapToDAO(topping.Pizza);
            vt.Vegetable = VegetableMapper.MapToDAO(topping.Vegetable);
            vt.Active = topping.Active;

            return vt;
        }

        public static VegetableToppingDTO MapToDTO(VegetableToppingDAO topping)
        {
            var vt = new VegetableToppingDTO();
            vt.Id = topping.Id;
            vt.Pizza = PizzaMapper.MapToDTO(topping.Pizza);
            vt.Vegetable = VegetableMapper.MapToDTO(topping.Vegetable);
            vt.Active = topping.Active;

            return vt;
        }
    }
}
