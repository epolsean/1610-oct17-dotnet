using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Test2Data.DataAccess;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Test2Data.Test
{
    public class EFDataTests
    {
        [Fact]
        public void Test_GetCostumes()
        {
            var data = new EFData();
            var actual = data.GetCostumes();

            Assert.NotNull(actual);
        }

        public void Test_GetCostumeTypes()
        {
            var data = new EFData();
            var actual = data.GetCostumeTypes();

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_InsertCostume()
        {
            var data = new EFData();
            Costume costume = new Costume() { Name = "Skelleton", TypeId = 1, Complete = 0, Active = 1};
            var actual = data.InsertCostume(costume);

            Assert.True(actual);
        }

        [Fact]
        public void Test_InsertCostumeType()
        {
            var data = new EFData();
            CostumeType costumeType = new CostumeType() { Name = "Prop" };
            var actual = data.InsertCostumeType(costumeType);

            Assert.True(actual);
        }

        [Fact]
        public void Test_UpdateCostume()
        {
            var data = new EFData();
            Costume costume = new Costume() { CostumeId = 3, Name = "Reaper", TypeId = 2, Complete = 1, Active = 1 };
            var actual = data.ChangeCostume(costume, EntityState.Modified);

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_DeleteCostume()
        {
            var data = new EFData();
            Costume costume = new Costume() { CostumeId = 4 };
            var actual = data.ChangeCostume(costume, EntityState.Deleted);

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_CompleteCostume()
        {
            var data = new EFData();
            Costume costume = new Costume() { CostumeId = 2 };
            var actual = data.ChangeCostume(costume, true);

            Assert.NotNull(actual);
        }

        [Fact]
        public void Test_IncompleteCostume()
        {
            var data = new EFData();
            Costume costume = new Costume() { CostumeId = 2 };
            var actual = data.ChangeCostume(costume, false);

            Assert.NotNull(actual);
        }
    }
}
