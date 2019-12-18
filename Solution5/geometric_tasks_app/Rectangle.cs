using System;

namespace Classes
{
    class Rectangle
    {
        private int side1;
        private int side2;

        public Rectangle(int a, int b) { side1 = a; side2 = b; }

        public int AreaCalculator()
        {
            int rectangleArea = side1 * side2;
            return rectangleArea;
        }

        public int PerimeterCalculator()
        {
            int rectanglePerimeter = 2 * (side1 + side2);
            return rectanglePerimeter;
        }
    }
}
