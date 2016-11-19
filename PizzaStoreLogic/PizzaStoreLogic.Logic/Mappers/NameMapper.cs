using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaStoreLogic.Logic.Models;
using PizzaStoreLogic.Logic.PizzaStoreDataService;

namespace PizzaStoreLogic.Logic.Mappers
{
    public class NameMapper
    {
        public static NameDAO MapToDAO(NameDTO name)
        {
            var n = new NameDAO();
            n.Id = name.Id;
            n.FirstName = name.FirstName;
            n.LastName = name.LastName;
            n.Active = name.Active;

            return n;
        }

        public static NameDTO MapToDTO(NameDAO name)
        {
            var n = new NameDTO();
            n.Id = name.Id;
            n.FirstName = name.FirstName;
            n.LastName = name.LastName;
            n.Active = name.Active;

            return n;
        }
    }
}
