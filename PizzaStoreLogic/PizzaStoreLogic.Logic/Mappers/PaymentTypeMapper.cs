using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaStoreLogic.Logic.Models;
using PizzaStoreLogic.Logic.PizzaStoreDataService;

namespace PizzaStoreLogic.Logic.Mappers
{
    public class PaymentTypeMapper
    {
        public static PaymentTypeDAO MapToDAO(PaymentTypeDTO payment)
        {
            var p = new PaymentTypeDAO();
            p.Id = payment.Id;
            p.Type = payment.Type;
            p.Active = payment.Active;

            return p;
        }

        public static PaymentTypeDTO MapToDTO(PaymentTypeDAO payment)
        {
            var p = new PaymentTypeDTO();
            p.Id = payment.Id;
            p.Type = payment.Type;
            p.Active = payment.Active;

            return p;
        }
    }
}
