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
        public void Test_DeleteGender()
        {
            var data = new AdoData();
            var actual = data.DeleteGender(gender);

            Assert.True(actual);
        }

        [Fact]
        public void Test_DeleteMonsterType()
        {
            var data = new AdoData();
            var actual = data.DeleteMonsterType(monsterType);

            Assert.True(actual);
        }

        [Fact]
        public void Test_DeleteTitle()
        {
            var data = new AdoData();
            var actual = data.DeleteTitle(title);

            Assert.True(actual);
        }

        [Fact]
        public void Test_DeleteMonster()
        {
            var data = new AdoData();
            var actual = data.DeleteMonster(monster);

            Assert.True(actual);
        }
    }
}
