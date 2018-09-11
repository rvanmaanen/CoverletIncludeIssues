using System;
using Demo;
using Xunit;

namespace Demo.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var demo = new Class1();
            var result = demo.DoStuff();
            Assert.Equal("Hello, World", result);
        }

        [Fact]
        public void Test2()
        {
            var demo = new Class1();
            var result = demo.DoStuff2();
            Assert.Equal("Hello, World", result);
        }

                [Fact]
        public void Test3()
        {
            var demo = new Class1();
            var result = demo.DoStuff3();
            Assert.Equal("Hello, World", result);
        }
    }
}
