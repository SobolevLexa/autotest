using System;

namespace Test1
{
    public class Square : Figure
    {
        private double _side;
        
        public Square(double side)
        {
            _side = side;
            Area = _side * _side;
        }

        public bool Contains(Circle figure)
        {
            return Math.Sqrt(figure.Area / Math.PI) <= 0.5 * Math.Sqrt(Area);
        }
    }
}