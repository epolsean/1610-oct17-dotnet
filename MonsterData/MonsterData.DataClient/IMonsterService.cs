using MonsterData.DataClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MonsterData.DataClient
{
    [ServiceContract]
    public interface IMonsterService
    {
        [OperationContract]
        List<GenderDAO> GetGenders();

        [OperationContract]
        List<MonsterTypeDAO> GetMonsterTypes();

        [OperationContract]
        List<TitleDAO> GetTitles();

        [OperationContract]
        bool InsertMonster(MonsterDAO monster);
    }
}
