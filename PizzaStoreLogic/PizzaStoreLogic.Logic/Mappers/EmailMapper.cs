using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaStoreLogic.Logic.Models;
using PizzaStoreLogic.Logic.PizzaStoreDataService;

namespace PizzaStoreLogic.Logic.Mappers
{
    public class EmailMapper
    {
        public static EmailDAO MapToDAO(EmailDTO email)
        {
            var e = new EmailDAO();
            e.Id = email.Id;
            e.Address = email.Address;
            e.Active = email.Active;

            return e;
        }

        public static EmailDTO MapToDTO(EmailDAO email)
        {
            var e = new EmailDTO();
            e.Id = email.Id;
            e.Address = email.Address;
            e.Active = email.Active;

            return e;
        }
    }
}
