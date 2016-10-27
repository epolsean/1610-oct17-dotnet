using MonsterData.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MonsterData.Test
{
    public partial class AdoDataTests
    {
        [Fact]
        public void Test_GetGenders()
        {
            var data = new AdoData();
            var actual = data.GetGenders();
            
            Assert.NotNull(actual.Count);
        }

        [Fact]
        public void Test_GetMonsterTypes()
        {
            var data = new AdoData();
            var actual = data.GetMonsterTypes();

            Assert.NotNull(actual.Count);
        }

        [Fact]
        public void Test_GetTitles()
        {
            var data = new AdoData();
            var actual = data.GetTitles();
            
            Assert.NotNull(actual.Count);
        }
    }
}
