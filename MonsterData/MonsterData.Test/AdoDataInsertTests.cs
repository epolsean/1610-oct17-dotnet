using MonsterData.DataAccess;
using Models = MonsterData.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MonsterData.Test
{
    public partial class AdoDataTests
    {
        private Models.Gender gender;
        private Models.MonsterType monsterType;
        private Models.Title title;
        private Models.Monster monster;

        public AdoDataTests()
        {
            gender = new Models.Gender() { Name = "TestGender" };
            monsterType = new Models.MonsterType() { Name = "TestType" };
            title = new Models.Title() { Name = "TestType" };
            monster = new Models.Monster() { GenderId = 1, TitleId = 1, TypeId = 1, Name = "TestMonster", PicturePath = "TestPath" };
        }

        [Fact]
        public void Test_InsertGender()
        {
            var data = new AdoData();
            var actual = data.InsertGender(gender);

            Assert.True(actual);
        }

        [Fact]
        public void Test_InsertMonsterType()
        {
            var data = new AdoData();
            var actual = data.InsertMonsterType(monsterType);

            Assert.True(actual);
        }

        [Fact]
        public void Test_InsertTitle()
        {
            var data = new AdoData();
            var actual = data.InsertTitle(title);

            Assert.True(actual);
        }

        [Fact]
        public void Test_InsertMonster()
        {
            var data = new AdoData();
            var actual = data.InsertMonster(monster);

            Assert.True(actual);
        }

        [Theory(gender = new Models.Gender() { Name = "blah", Active = true })]
        public void Theory_InsertGender(Models.Gender gender)
        {
            var data = new AdoData();
            var actual = data.InsertGender(gender);

            Assert.True(actual);
        }
    }
}
