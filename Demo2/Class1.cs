using System;
using Demo;

namespace Demo2
{
    public class Class1
    {
        public string DoStuff() {
            var result = "Hello, World";
            
            var demo1 = new Demo.Class1();
            result = $"{result} {demo1.DoStuff()}";

            return result;
        }
    }
}
