using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreLogic.Logic.Models
{
    public class CheeseToppingDTO
    {
        public int Id { get; set; }
        
        public PizzaDTO Pizza { get; set; }
        
        public CheeseDTO Cheese { get; set; }
        
        public bool Active { get; set; }
    }
}
