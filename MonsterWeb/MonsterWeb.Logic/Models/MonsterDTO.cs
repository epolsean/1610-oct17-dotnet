using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterWeb.Logic.Models
{
    class MonsterDTO
    {
        public string Name { get; set; }
        public int GenderId { get; set; }
        public int TypeId { get; set; }

        public MonsterDTO(string name, string genderId, string typeId)
        {
            int tempGender;
            int tempType;
            int.TryParse(genderId, out tempGender);
            int.TryParse(typeId, out tempType);

            Name = name;
            GenderId = tempGender;
            TypeId = tempType;
        }


    }
}
