using MonsterData.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MonsterData.Test
{
    public class EFDataTests
    {
        #region Gender
        [Fact]
        public void Test_GetGenders()
        {
            var data = new EFData();
            var actual = data.GetGenders();

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_InsertGender()
        {
            var data = new EFData();
            var expected = new Gender() { GenderName = "Martian", Active = true };

            var actual = data.ChangeGender(expected, System.Data.Entity.EntityState.Added);

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_UpdateGender()
        {
            var data = new EFData();
            var expected = new Gender() { GenderId = 1, GenderName = "ET", Active = true };

            var actual = data.ChangeGender(expected, System.Data.Entity.EntityState.Modified);

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_DeleteGender()
        {
            var data = new EFData();
            var expected = new Gender() { GenderId = 6, GenderName = "Martian", Active = true};

            var actual = data.ChangeGender(expected, System.Data.Entity.EntityState.Deleted);

            Assert.NotNull(actual);
        }
        #endregion

        #region MonsterType
        [Fact]
        public void Test_GetMonsterTypes()
        {
            var data = new EFData();
            var actual = data.GetMonsterTypes();

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_InsertMonsterType()
        {
            var data = new EFData();
            var expected = new MonsterType() { TypeName = "Martian", Active = true };

            var actual = data.ChangeMonsterType(expected, System.Data.Entity.EntityState.Added);

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_UpdateMonsterType()
        {
            var data = new EFData();
            var expected = new MonsterType() { MonsterTypeId = 5, TypeName = "ET", Active = true };

            var actual = data.ChangeMonsterType(expected, System.Data.Entity.EntityState.Modified);

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_DeleteMonsterType()
        {
            var data = new EFData();
            var expected = new MonsterType() { MonsterTypeId = 6, TypeName = "ET", Active = true };

            var actual = data.ChangeMonsterType(expected, System.Data.Entity.EntityState.Deleted);

            Assert.NotNull(actual);
        }
        #endregion

        #region Title
        [Fact]
        public void Test_GetTitles()
        {
            var data = new EFData();
            var actual = data.GetTitles();

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_InsertTitle()
        {
            var data = new EFData();
            var expected = new Title() { TitleName = "King", Active = true };

            var actual = data.ChangeTitle(expected, System.Data.Entity.EntityState.Added);

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_UpdateTitle()
        {
            var data = new EFData();
            var expected = new Title() { TitleId = 1, TitleName = "Sire", Active = true };

            var actual = data.ChangeTitle(expected, System.Data.Entity.EntityState.Modified);

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_DeleteTitle()
        {
            var data = new EFData();
            var expected = new Title() { TitleId = 6, TitleName = "Sire", Active = true };

            var actual = data.ChangeTitle(expected, System.Data.Entity.EntityState.Deleted);

            Assert.NotNull(actual);
        }
        #endregion

        #region Monster
        [Fact]
        public void Test_GetMonsters()
        {
            var data = new EFData();
            var actual = data.GetMonsters();

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_InsertMonster()
        {
            var data = new EFData();
            var expected = new Monster() { GenderId = 3, TitleId = 3, TypeId = 2, Name = "Luther", PicturePath = "", Active = true };

            var actual = data.ChangeMonster(expected, System.Data.Entity.EntityState.Added);

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_UpdateMonster()
        {
            var data = new EFData();
            var expected = new Monster() { MonsterId = 4, GenderId = 3, TitleId = 2, TypeId = 3, Name = "Martin", PicturePath = "", Active = true };

            var actual = data.ChangeMonster(expected, System.Data.Entity.EntityState.Modified);

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_DeleteMonster()
        {
            var data = new EFData();
            var expected = new Monster() { MonsterId = data.GetSearchMonster().MonsterId };

            var actual = data.ChangeMonster(expected, System.Data.Entity.EntityState.Deleted);

            Assert.NotNull(actual);
        }
        #endregion
    }
}
