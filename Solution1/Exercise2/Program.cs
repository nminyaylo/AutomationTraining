using System;

// Считав с консоли значение ширины, высоты и длины прямоугольного
// параллелепипеда, найти длину его диагонали, вывести на экран

namespace Exercise2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Insert integer value of parallelepiped width:");
            string insertedWidth = Console.ReadLine();
            int width;
            bool widthIsInteger = int.TryParse(insertedWidth, out width);

            while (widthIsInteger == false)
            {
                Console.WriteLine("You have entered not an integer! Please insert integer value of parallelepiped width:");
                insertedWidth = Console.ReadLine();
                widthIsInteger = int.TryParse(insertedWidth, out width);
            }

            Console.WriteLine("Insert integer value of parallelepiped height:");
            string insertedHeight = Console.ReadLine();
            int height;
            bool heightIsInteger = int.TryParse(insertedHeight, out height);

            while (heightIsInteger == false)
            {
                Console.WriteLine("You have entered not an integer! Please insert integer value of parallelepiped height:");
                insertedHeight = Console.ReadLine();
                heightIsInteger = int.TryParse(insertedHeight, out height);
            }

            Console.WriteLine("Insert integer value of parallelepiped length:");
            string insertedLength = Console.ReadLine();
            int length;
            bool lengthIsInteger = int.TryParse(insertedLength, out length);

            while (lengthIsInteger == false)
            {
                Console.WriteLine("You have entered not an integer! Please insert integer value of parallelepiped length:");
                insertedLength = Console.ReadLine();
                lengthIsInteger = int.TryParse(insertedLength, out length);
            }

            var rectangleDiagonal = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2));
            var parallelepipedDiagonal = Math.Sqrt(Math.Pow(rectangleDiagonal, 2) + Math.Pow(length, 2)); ;

            Console.WriteLine("Parallelepiped diagonal length: " + parallelepipedDiagonal);

            Console.ReadKey();
        }
    }
}