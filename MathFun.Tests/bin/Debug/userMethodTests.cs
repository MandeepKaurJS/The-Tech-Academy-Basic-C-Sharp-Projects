using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathFun;
using Xunit;
namespace MathFun.Tests
{
    class userMethodTests
    {
        public void add_simpleCodeWillworks()
        {
            //arrange
            double expected =5;
            //Act
            double actual = userMethodTests.add(3,2);
            //assert
            Assert.Equal(expected, actual);
        }
        public static double add(double x, double y)
        {
            return x + y;
        }
    }
}
