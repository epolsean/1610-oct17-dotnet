using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaStoreLogic.Logic.Models;
using PizzaStoreLogic.Logic.PizzaStoreDataService;

namespace PizzaStoreLogic.Logic.Mappers
{
    public class VegetableMapper
    {
        public static VegetableDAO MapToDAO(VegetableDTO vegetable)
        {
            var v = new VegetableDAO();
            v.Id = vegetable.Id;
            v.Name = vegetable.Name;
            v.Active = vegetable.Active;

            return v;
        }

        public static VegetableDTO MapToDTO(VegetableDAO vegetable)
        {
            var v = new VegetableDTO();
            v.Id = vegetable.Id;
            v.Name = vegetable.Name;
            v.Active = vegetable.Active;

            return v;
        }
    }
}
