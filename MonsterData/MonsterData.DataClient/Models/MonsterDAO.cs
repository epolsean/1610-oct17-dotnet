using System;
using System.Collections.Generic;
using System.Linq;
<<<<<<< HEAD
=======
using System.Runtime.Serialization;
>>>>>>> refs/remotes/origin/master
using System.Web;

namespace MonsterData.DataClient.Models
{
<<<<<<< HEAD
    public class MonsterDAO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public GenderDAO Gender { get; set; }
        public MonsterTypeDAO MonsterType { get; set; }
        public TitleDAO Title { get; set; }
=======
    [DataContract]
    public class MonsterDAO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public GenderDAO Gender { get; set; }
>>>>>>> refs/remotes/origin/master
    }
}