using BLL;
using System;
using System.Transactions;
using Xunit;

namespace DemoTests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(4, 3, 7)]
        [InlineData(21, 5.25, 26.25)]
        [InlineData(double.MaxValue, 5, double.MaxValue)]
        public void Add_SimpleValuesShouldCalculate(double x, double y, double expected)
        {
            //Arrange

            // Act 
            var actual = Calculator.Add(x, y);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8, 4, 2)]
        public void Divide_SimpleValuesShouldWork(double x, double y, double expected)
        {
            var actual = Calculator.Divide(x, y);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Divide_ByZero()
        {
            double expected = 0;
            var actual = Calculator.Divide(15, 0);
            Assert.Equal(expected, actual);
        }
    }
}
