using TheAreaOfAPolygonInsideACircle.App;
using Xunit;

namespace TheAreaOfAPolygonInsideACircle.Test
{
    public class CalculateTheAreaOfAPolygonInsideACircleTest
    {
        [Theory]
        [InlineData(3, 3, 11.691)]
        [InlineData(2, 4, 8)]
        [InlineData(2.5, 5, 14.86)]
        [InlineData(5.8, 7, 92.053)]
        [InlineData(4, 5, 38.042)]
        [InlineData(10.431180883865423, 19, 335.63900000000001d)]

        public void CalculatorTest1_Successful(double circleRadius, int numberOfSides, double expected)
        {
            //Arrange
            ICalculateTheAreaOfAPolygonInsideACircle calculateArea = new CalculateTheAreaOfAPolygonInsideACircle();

            //Act
            var actual = calculateArea.AreaOfPolygonInsideCircle(circleRadius, numberOfSides);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
