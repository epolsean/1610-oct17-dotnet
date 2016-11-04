using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterWeb.Logic.Models
{
    public partial class MonsterDTO
    {
        internal override MonsterDTO Create<MonsterDTO>()
        {
            return new MonsterDTO();
        }

        partial void IsNull(ref string data, string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return;
            }

            data = value;
        }
    }
}
