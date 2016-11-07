using RegistrationWeb.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RegistrationWeb.Tests
{
    public class ServiceTests
    {
        [Fact]
        public void Test_GetCourses()
        {
            var service = new DataService();
            var actual = service.GetCourses();
            Assert.NotNull(actual);
        }
    }
}
