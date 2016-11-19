using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaStoreLogic.Logic.Models;
using PizzaStoreLogic.Logic.PizzaStoreDataService;

namespace PizzaStoreLogic.Logic.Mappers
{
    class SizeMapper
    {
        public static SizeDAO MapToDAO(SizeDTO size)
        {
            var s = new SizeDAO();
            s.Id = size.Id;
            s.Name = size.Name;
            s.Active = size.Active;

            return s;
        }

        public static SizeDTO MapToDTO(SizeDAO size)
        {
            var s = new SizeDTO();
            s.Id = size.Id;
            s.Name = size.Name;
            s.Active = size.Active;

            return s;
        }
    }
}
