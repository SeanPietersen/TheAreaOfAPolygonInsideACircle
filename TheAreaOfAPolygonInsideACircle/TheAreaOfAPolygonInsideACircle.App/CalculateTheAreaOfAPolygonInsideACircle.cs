using System;

namespace TheAreaOfAPolygonInsideACircle.App
{
    public class CalculateTheAreaOfAPolygonInsideACircle : ICalculateTheAreaOfAPolygonInsideACircle
    {
        public double AreaOfPolygonInsideCircle(double circleRadius, int numberOfSides)
        {
            /*1. get the number of sides and divide the polygon into equal triangles
             *2. Calculate the angle of each triangle by taking 360 divided by n
             *3. get divide the triangle into 2 to form a right angle triangle
             *4. The hypotenuse of the triangle is equal to the radius of the circle
             *5. determin the adjacent and the opposite of the triangle
             *6. calculate the area of the triangle multiply by 2.
             *6. multiply the area above by the number of sides.
             * 
             */

            double angle = 360d / numberOfSides;
            
            double angleOfRightAngleTriangle = angle / 2;

            double opposite = circleRadius * Math.Sin(angleOfRightAngleTriangle * 2.0 * Math.PI / 360.0);

            double adjacent = circleRadius * Math.Cos(angleOfRightAngleTriangle * 2.0 * Math.PI / 360.0);

            double area = 0.5 * (2 * opposite) * adjacent * numberOfSides;

            return Math.Round(area, 3);
        }
    }
}
