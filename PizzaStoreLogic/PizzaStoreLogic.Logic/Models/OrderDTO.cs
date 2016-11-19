using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreLogic.Logic.Models
{
    public class OrderDTO
    {
        public int Id { get; set; }
        
        public CustomerDTO Customer { get; set; }
        
        public StoreDTO Store { get; set; }
        
        public PaymentTypeDTO Payment { get; set; }
        
        public bool Active { get; set; }
    }
}
