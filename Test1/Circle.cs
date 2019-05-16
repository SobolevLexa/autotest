using System;

namespace Test1
{
    public class Circle : Figure
    {
        private double _radius;
        
        public Circle(double radius)
        {
            _radius = radius;
            Area = Math.PI * _radius * _radius;
        }

        public bool Contains(Square figure)
        {
            return Math.Sqrt(Area / Math.PI) >= 0.5 * Math.Sqrt(2 * figure.Area);
        }
    }
}