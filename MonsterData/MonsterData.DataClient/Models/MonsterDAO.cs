using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonsterData.DataClient.Models
{
    public class MonsterDAO
    {
        public int Id { get; set; }
        public string Name { get; set;  }
        public GenderDAO Gender { get; set; }
    }
}