using Classes;
using System;

namespace geometric_tasks_app
{
    class Program
    {
        static int InsertIntegerValue()
        {
            var result = false;
            int resultConverted = 0;
            while (!result)
            {
                var userInput = Console.ReadLine();
                result = int.TryParse(userInput, out resultConverted);
                if (!result)
                {
                    Console.WriteLine("You have entered not an integer! Please insert integer value:");
                }
            }
            return resultConverted;
        }

        static void Main()
        {
            Console.WriteLine("Write the length of the first side of the rectangle:");
            int side1 = InsertIntegerValue();

            Console.WriteLine("Write the length of the second side of the rectangle:");
            int side2 = InsertIntegerValue();

            Rectangle userRectangle = new Rectangle(side1, side2);

            int rectanglePerimeter = userRectangle.PerimeterCalculator();
            int rectangleArea = userRectangle.AreaCalculator();

            Console.WriteLine($"The area of the rectangle is {rectangleArea}, the perimeter of the rectangle is {rectanglePerimeter}");

            Console.ReadKey();
        }
    }
}
