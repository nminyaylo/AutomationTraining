using System;

namespace geometry_app
{
    class Program
    {
        static string InsertedFigure()
        {
            var figureType = "";
            var match = false;
            while (!match)
            {
                var userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "R":
                        Console.WriteLine("You have chosen a rectangle");
                        figureType = "R";
                        match = true;
                        break;
                    case "S":
                        Console.WriteLine("You have chosen a square");
                        figureType = "S";
                        match = true;
                        break;
                    case "T":
                        Console.WriteLine("You have chosen a triangle");
                        figureType = "T";
                        match = true;
                        break;
                    default:
                        Console.WriteLine("You have entered not an appropriate value! Please enter one of the letters: R (for rectangle), S (for square), T (for triangle)");
                        break;
                }
            }
            return figureType;
        }

        static float InsertIntegerValue()
        {
            var result = false;
            float resultConverted = 0;
            while (!result)
            {
                var userInput = Console.ReadLine();
                result = float.TryParse(userInput, out resultConverted);
                if (!result)
                {
                    Console.WriteLine("You have entered not an numerical value! Please insert numerical value:");
                }
            }
            return resultConverted;
        }

        static void Main()
        {
            Console.WriteLine("Enter type of figure using following letters: R (for rectangle), S (for square), T (for triangle)");
            var insertedFigure = InsertedFigure();
            Figure figure = null;

            switch (insertedFigure)
            {
                case "R":
                    Console.WriteLine("Enter the length of the first side of the rectangle");
                    float rectangeSideOne = InsertIntegerValue();

                    Console.WriteLine("Enter the length of the second side of the rectangle");
                    float rectangeSideTwo = InsertIntegerValue();

                    figure = new Rectangle(rectangeSideOne, rectangeSideTwo);

                    break;

                case "S":
                    Console.WriteLine("Enter the length of the sides of the square");
                    float sideSquare = InsertIntegerValue();

                    figure = new Square(sideSquare);

                    break;

                case "T":
                    Console.WriteLine("Enter the length of the first side of the triangle");
                    float triangleSideOne = InsertIntegerValue();

                    Console.WriteLine("Enter the length of the second side of the triangle");
                    float triangleSideTwo = InsertIntegerValue();

                    Console.WriteLine("Enter the length of the third side of the triangle");
                    float triangleSideThree = InsertIntegerValue();

                    figure = new Triangle(triangleSideOne, triangleSideTwo, triangleSideThree);

                    break;
            }

            float area = figure.Area();
            Console.WriteLine($"Area: {area}");

            float perimeter = figure.Perimeter();
            Console.WriteLine($"Perimeter: {perimeter}");

            float radius = figure.Radius();
            Console.WriteLine($"Circle radius: {radius}");

            Console.ReadKey();

        }
    }
}
