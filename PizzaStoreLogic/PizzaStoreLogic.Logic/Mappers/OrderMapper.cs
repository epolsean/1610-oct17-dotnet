using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaStoreLogic.Logic.Models;
using PizzaStoreLogic.Logic.PizzaStoreDataService;

namespace PizzaStoreLogic.Logic.Mappers
{
    public class OrderMapper
    {
        public static PizzaOrderDAO MapToDAO(OrderDTO order)
        {
            var po = new PizzaOrderDAO();
            po.Id = order.Id;
            po.Customer = CustomerMapper.MapToDAO(order.Customer);
            po.Store = StoreMapper.MapToDAO(order.Store);
            po.Payment = PaymentTypeMapper.MapToDAO(order.Payment);
            po.Active = order.Active;

            return po;
        }

        public static OrderDTO MapToDTO(PizzaOrderDAO order)
        {
            var o = new OrderDTO();
            o.Id = order.Id;
            o.Customer = CustomerMapper.MapToDTO(order.Customer);
            o.Store = StoreMapper.MapToDTO(order.Store);
            o.Payment = PaymentTypeMapper.MapToDTO(order.Payment);
            o.Active = order.Active;

            return o;
        }
    }
}
