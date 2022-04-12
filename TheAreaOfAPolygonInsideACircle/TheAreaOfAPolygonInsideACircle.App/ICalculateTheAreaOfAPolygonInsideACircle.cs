using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAreaOfAPolygonInsideACircle.App
{
    public interface ICalculateTheAreaOfAPolygonInsideACircle
    {
        double AreaOfPolygonInsideCircle(double circleRadius, int numberOfSides);
    }
}
