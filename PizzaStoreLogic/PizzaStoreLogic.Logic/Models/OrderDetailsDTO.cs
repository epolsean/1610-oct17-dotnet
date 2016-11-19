using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreLogic.Logic.Models
{
    public class OrderDetailsDTO
    {
        public int Id { get; set; }
        
        public PizzaDTO Pizza { get; set; }
        
        public OrderDTO Order { get; set; }
        
        public bool Active { get; set; }
    }
}
