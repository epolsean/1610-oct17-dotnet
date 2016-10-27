using MonsterData.DataAccess;
using MonsterData.DataAccess.Models;
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
        private Gender gender;
        private string query;


        public AdoDataTests()
        {
            gender = new Gender() { Name = "TestGender"};
            query = "insert into Monster.Gender(GenderName, Active) values (@name, 1)";
        }

        [Fact]
        public void Test_InsertGender()
        {
            var data = new AdoData();
            var actual = data.InsertGender(gender);

            Assert.True(actual);
        }
    }
}
