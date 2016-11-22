using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaStoreLogic.Logic.Models;
using PizzaStoreLogic.Logic.PizzaStoreDataService;

namespace PizzaStoreLogic.Logic.Mappers
{
    public class PhoneMapper
    {
        public static PhoneDAO MapToDAO(PhoneDTO phone)
        {
            var p = new PhoneDAO();
            p.Id = phone.Id;
            p.Number = phone.Number;
            p.Active = phone.Active;

            return p;
        }

        public static PhoneDTO MapToDTO(PhoneDAO phone)
        {
            var p = new PhoneDTO();
            p.Id = phone.Id;
            p.Number = phone.Number;
            p.Active = phone.Active;

            return p;
        }
    }
}
