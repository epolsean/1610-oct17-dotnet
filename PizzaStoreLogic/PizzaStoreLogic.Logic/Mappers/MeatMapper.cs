using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaStoreLogic.Logic.Models;
using PizzaStoreLogic.Logic.PizzaStoreDataService;

namespace PizzaStoreLogic.Logic.Mappers
{
    public class MeatMapper
    {
        public static MeatDAO MapToDAO(MeatDTO meat)
        {
            var m = new MeatDAO();
            m.Id = meat.Id;
            m.Name = meat.Name;
            m.Active = meat.Active;

            return m;
        }

        public static MeatDTO MapToDTO(MeatDAO meat)
        {
            var m = new MeatDTO();
            m.Id = meat.Id;
            m.Name = meat.Name;
            m.Active = meat.Active;

            return m;
        }
    }
}
