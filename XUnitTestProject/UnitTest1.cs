using HelloWorld;
using System;
using Xunit;

namespace XUnitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var service = new HelloService();
            Assert.True(!string.IsNullOrEmpty(service.GetWorldName()));
        }

        [Fact]
        public void Test2()
        {
            var service = new HelloService();
            Assert.True(service.GetWorldName().Length > 0);
        }
    }
}
