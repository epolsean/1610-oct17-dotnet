using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaStoreLogic.Logic.Models;
using PizzaStoreLogic.Logic.PizzaStoreDataService;

namespace PizzaStoreLogic.Logic.Mappers
{
    public class SauceMapper
    {
        public static SauceDAO MapToDAO(SauceDTO sauce)
        {
            var s = new SauceDAO();
            s.Id = sauce.Id;
            s.Name = sauce.Name;
            s.Active = sauce.Active;

            return s;
        }

        public static SauceDTO MapToDTO(SauceDAO sauce)
        {
            var s = new SauceDTO();
            s.Id = sauce.Id;
            s.Name = sauce.Name;
            s.Active = sauce.Active;

            return s;
        }
    }
}
