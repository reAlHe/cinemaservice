using System;
using System.Collections;
using System.Collections.Generic;
using app.Domain;
using FluentAssertions;
using Xunit;

namespace test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Customer c = new Customer {Name="Horst-Günther"};
            IEnumerable numbers = new[] { 1, 2, 3 };

            c.Name.Should().StartWith("Horst");
            numbers.Should().HaveCount(4, "because we thought we put four items in the collection");
        }
    }
}
