using MonsterWeb.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterWeb.Logic.Models
{
    public class TitleDTO : MonsterThing
    {
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

        public TitleDTO() : base()
        {

        }

        internal override TitleDTO Create<TitleDTO>()
        {
            return new TitleDTO();
        }

        private void IsNull(ref string data, string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return;
            }

            data = value;
        }
    }
}
