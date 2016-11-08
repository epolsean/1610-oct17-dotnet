using MonsterWeb.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterWeb.Logic.Models
{
    public partial class MonsterDTO : MonsterThing
    {
        partial void IsNull(ref string data, string value);

        private string _Name = default(string);

        /// <summary>
        /// 
        /// </summary>
        public override string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                IsNull(ref _Name, value);
            }
        }

        public GenderDTO Gender { get; set; }
        public TypeDTO Type { get; set; }
        public TitleDTO Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        public MonsterDTO(string name) : base()
        {
            Name = name;
        }

        /// <summary>
        /// 
        /// </summary>
        ~MonsterDTO()
        {
            GC.Collect();
        }
    }
}
