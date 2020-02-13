using System;

namespace geometry_app
{
    class Square : Figure
    {
        private float squareSide;

        public Square(float squareSide)
        {
            this.squareSide = squareSide;
        }

        public override float Area()
        {
            return squareSide * squareSide;
        }

        public override float Perimeter()
        {
            return squareSide * 4;
        }

        public override float Radius()
        {
            return squareSide / (float)Math.Sqrt(2);
        }
    }
}
