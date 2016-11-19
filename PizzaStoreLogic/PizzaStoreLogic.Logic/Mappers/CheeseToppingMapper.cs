using PizzaStoreLogic.Logic.Models;
using PizzaStoreLogic.Logic.PizzaStoreDataService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreLogic.Logic.Mappers
{
    public class CheeseToppingMapper
    {
        public static CheeseToppingDAO MapToDAO(CheeseToppingDTO topping)
        {
            var ct = new CheeseToppingDAO();
            ct.Id = topping.Id;
            ct.Pizza = PizzaMapper.MapToDAO(topping.Pizza);
            ct.Cheese = CheeseMapper.MapToDAO(topping.Cheese);
            ct.Active = topping.Active;

            return ct;
        }

        public static CheeseToppingDTO MapToDTO(CheeseToppingDAO topping)
        {
            var ct = new CheeseToppingDTO();
            ct.Id = topping.Id;
            ct.Pizza = PizzaMapper.MapToDTO(topping.Pizza);
            ct.Cheese = CheeseMapper.MapToDTO(topping.Cheese);
            ct.Active = topping.Active;

            return ct;
        }
    }
}
