using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Xoponky.Core
{
    public class DummyTests
    {
        [Fact]
        public void Sum_Pass()
        {
            //Arrange
            int v1 = 1, v2 = 2, v3 = 3;
            var sut = new Dummy();

            //Act
            var result = sut.Sum(v1, v2, v3);

            //Assert
            Assert.Equal(6, result);
        }
    }
}
