using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaStoreLogic.Logic.Models;
using PizzaStoreLogic.Logic.PizzaStoreDataService;

namespace PizzaStoreLogic.Logic.Mappers
{
    public class HoursMapper
    {
        public static StoreHourDAO MapToDAO(HoursDTO hours)
        {
            var sh = new StoreHourDAO();
            sh.Id = hours.Id;
            sh.OpeningTime = hours.OpeningTime;
            sh.ClosingTime = hours.ClosingTime;
            sh.Active = hours.Active;

            return sh;
        }

        public static HoursDTO MapToDTO(StoreHourDAO hours)
        {
            var h = new HoursDTO();
            h.Id = hours.Id;
            h.OpeningTime = hours.OpeningTime;
            h.ClosingTime = hours.ClosingTime;
            h.Active = hours.Active;

            return h;
        }
    }
}
