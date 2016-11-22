using PizzaStoreLogic.Logic.Models;
using PizzaStoreLogic.Logic.PizzaStoreDataService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreLogic.Logic.Mappers
{
    public class OrderDetailMapper
    {
        public static PizzaOrderDetailDAO MapToDAO(OrderDetailsDTO orderDetail)
        {
            var pod = new PizzaOrderDetailDAO();
            pod.Id = orderDetail.Id;
            pod.Pizza = PizzaMapper.MapToDAO(orderDetail.Pizza);
            pod.Order = OrderMapper.MapToDAO(orderDetail.Order);
            pod.Active = orderDetail.Active;

            return pod;
        }

        public static OrderDetailsDTO MapToDTO(PizzaOrderDetailDAO orderDetail)
        {
            var od = new OrderDetailsDTO();
            od.Id = orderDetail.Id;
            od.Pizza = PizzaMapper.MapToDTO(orderDetail.Pizza);
            od.Order = OrderMapper.MapToDTO(orderDetail.Order);
            od.Active = orderDetail.Active;

            return od;
        }
    }
}
