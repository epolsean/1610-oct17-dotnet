using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterWeb.Logic.Interfaces
{
    public interface IThing
    {
        Guid Id { get; }
        string Name { get; }
        DateTime Creation { get; }
    }
}
