using BLL;
using System;
using Xunit;

namespace DemoTests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_SimpleValuesShouldCalculate()
        {
            //Arrange
            var firstNumber = 2;
            var secondNumber = 3;
            var expected = 5;

            // Act 
            var actual = Calculator.Add(firstNumber, secondNumber);
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
