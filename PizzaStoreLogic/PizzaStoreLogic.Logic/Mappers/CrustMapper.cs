using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaStoreLogic.Logic.Models;
using PizzaStoreLogic.Logic.PizzaStoreDataService;

namespace PizzaStoreLogic.Logic.Mappers
{
    public class CrustMapper
    {
        public static CrustDAO MapToDAO(CrustDTO crust)
        {
            var c = new CrustDAO();
            c.Id = crust.Id;
            c.Name = crust.Name;
            c.Active = crust.Active;

            return c;
        }

        public static CrustDTO MapToDTO(CrustDAO crust)
        {
            var c = new CrustDTO();
            c.Id = crust.Id;
            c.Name = crust.Name;
            c.Active = crust.Active;

            return c;
        }
    }
}
