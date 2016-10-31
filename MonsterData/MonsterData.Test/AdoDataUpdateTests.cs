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
        public void Test_UpdateGender()
        {
            var data = new AdoData();
            var actual = data.UpdateGender(gender);

            Assert.True(actual);
        }

        [Fact]
        public void Test_UpdateMonsterType()
        {
            var data = new AdoData();
            var actual = data.UpdateMonsterType(monsterType);

            Assert.True(actual);
        }

        [Fact]
        public void Test_UpdateTitle()
        {
            var data = new AdoData();
            var actual = data.UpdateTitle(title);

            Assert.True(actual);
        }

        [Fact]
        public void Test_UpdateMonster()
        {
            var data = new AdoData();
            var actual = data.UpdateMonster(monster);

            Assert.True(actual);
        }
    }
}
