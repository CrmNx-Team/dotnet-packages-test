using Xunit;
using Demo.NetLibrary;
using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;

namespace Demo.NetLibrary.Tests
{
    public class DemoClassTests
    {
        [Fact()]
        public void DemoClassTest()
        {
            var instance = new DemoClass("ttkoma");

            instance.Should().NotBeNull();
            instance.UserName.Should().Be("ttkoma");
        }
    }
}