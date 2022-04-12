using System;
using Xunit;

namespace TheAreaOfAPolygonInsideACircle.Test
{
    public class CalculateTheAreaOfAPolygonInsideACircleTest
    {
        [Theory]
        [InlineData(3, 3, 11.69)]
        [InlineData(2, 4, 8)]
        [InlineData(2.5,5, 14.86)]

        public void CalculatorTest1_Successful(double circleRadius, int numberOfSides, double expected)
        {
            //Arrange
            ICalculateTheAreaOfAPolygonInsideACircle calculateArea = new CalculateTheAreaOfAPolygonInsideACircle();

            //Act
            var actual = calculateArea.Calculator(circleRadius, numberOfSides);

            //Assert
            Assert.Equal(expected, actual);

        }
    }
}