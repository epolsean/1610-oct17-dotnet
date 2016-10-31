using Microsoft.VisualStudio.TestTools.UnitTesting;
using MonsterData.DataAccess;
using Models = MonsterData.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterData.Test
{
    [TestClass]
    public class AdoDataMSTests
    {
        private Models.Gender gender;

        [TestInitialize]
        public void Init()
        {
            gender = new Models.Gender() { Name = "TestGender" };
        }

        [TestCleanup]
        public void Cleanup()
        {
            GC.Collect();
        }

        [TestMethod]
        public void Test_InsertGender()
        {
            var data = new AdoData();
            var actual = data.InsertGender(gender);

            Assert.IsTrue(actual);
        }
    }
}
