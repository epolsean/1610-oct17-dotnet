﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreLogic.Logic.Models
{
    public class EmailDTO
    {
        public int Id { get; set; }
        
        public string Address { get; set; }
        
        public bool Active { get; set; }
    }
}
