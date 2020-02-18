using System;

namespace geometry_app
{
    class Triangle : Figure
    {
        private readonly float triangleSideOne;
        private readonly float triangleSideTwo;
        private readonly float triangleSideThree;

        public Triangle(float triangleSideOne, float triangleSideTwo, float triangleSideThree)
        {
            this.triangleSideOne = triangleSideOne;
            this.triangleSideTwo = triangleSideTwo;
            this.triangleSideThree = triangleSideThree;
        }

        public override float Area()
        {
            float radius = Radius();
            return (triangleSideOne * triangleSideTwo * triangleSideThree) / 4 * radius;
        }

        public override float Perimeter()
        {
            return triangleSideOne + triangleSideTwo + triangleSideThree;
        }

        public override float Radius()
        {
            float halfPerimetr = (triangleSideOne + triangleSideTwo + triangleSideThree) / 2;
            return (triangleSideOne * triangleSideTwo * triangleSideThree) / (4 * (float)Math.Sqrt(halfPerimetr * (halfPerimetr - triangleSideOne) * (halfPerimetr - triangleSideTwo) * (halfPerimetr - triangleSideThree)));
        }
    }
}
