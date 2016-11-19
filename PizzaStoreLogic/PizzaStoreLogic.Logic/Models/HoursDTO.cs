using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreLogic.Logic.Models
{
    public class HoursDTO
    {
        public int Id { get; set; }
        
        public int OpeningTime { get; set; }
        
        public int ClosingTime { get; set; }
        
        public bool Active { get; set; }
    }
}
