using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreLogic.Logic.Models
{
    public class PizzaDTO
    {
        public int Id { get; set; }
        
        public SizeDTO Size { get; set; }
        
        public CrustDTO Crust { get; set; }
        
        public SauceDTO Sauce { get; set; }
        
        public CheeseDTO Cheese { get; set; }
        
        public int Quantity { get; set; }
        
        public bool Active { get; set; }
    }
}
