using System;

namespace geometry_app
{
    class Rectangle : Figure
    {
        private float rectangeSideOne;
        private float rectangeSideTwo;

        public Rectangle(float rectangeSideOne, float rectangeSideTwo)
        {
            this.rectangeSideOne = rectangeSideOne;
            this.rectangeSideTwo = rectangeSideTwo;
        }

        public override float Area()
        {
            return rectangeSideOne * rectangeSideTwo;
        }

        public override float Perimeter()
        {
            return (rectangeSideOne + rectangeSideTwo) * 2;
        }

        public override float Radius()
        {
            return (float)Math.Sqrt(Math.Pow (rectangeSideOne, 2) + Math.Pow(rectangeSideTwo, 2)) / 2;
        }
    }
}
