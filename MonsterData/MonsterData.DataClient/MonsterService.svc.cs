using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MonsterData.DataClient
{
    public class MonsterService : IMonsterService
    {
        public string DoWork()
        {
            return "So clean!";
        }
    }
}
