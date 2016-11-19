using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaStoreLogic.Logic.Models;
using PizzaStoreLogic.Logic.PizzaStoreDataService;

namespace PizzaStoreLogic.Logic.Mappers
{
    public class CheeseMapper
    {
        public static CheeseDAO MapToDAO(CheeseDTO cheese)
        {
            var c = new CheeseDAO();
            c.Id = cheese.Id;
            c.Name = cheese.Name;
            c.Active = cheese.Active;

            return c;
        }

        public static CheeseDTO MapToDTO(CheeseDAO cheese)
        {
            var c = new CheeseDTO();
            c.Id = cheese.Id;
            c.Name = cheese.Name;
            c.Active = cheese.Active;

            return c;
        }
    }
}
