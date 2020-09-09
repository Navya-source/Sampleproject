using System;
using System.Linq;
using Samplewebapi.Controllers;
using Xunit;

namespace XUnitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var controller = new ValuesController();
            var result = controller.Get();
            Assert.Equal(3, result.Count());
        }
    }
}
