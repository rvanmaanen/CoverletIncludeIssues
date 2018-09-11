using System;
using Xunit;
using Demo2;

namespace Demo2.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var demo = new Class1();
            var result = demo.DoStuff();
            Assert.Equal("Hello, World Hello, World", result);
        }
    }
}
