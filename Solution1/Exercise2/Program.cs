using System;

// Считав с консоли значение ширины, высоты и длины прямоугольного
// параллелепипеда, найти длину его диагонали, вывести на экран

namespace Exercise2
{
    class Program
    {
        static double? ConvertInsertedValueToInteger(string insertedValue)
        {
            return double.TryParse(insertedValue, out var temp) ? double.Parse(insertedValue) : (double?)null;
        }

        static void Main()
        {
            double? width;
            do
            {
                Console.WriteLine("Insert integer value of parallelepiped width:");
                string insertedWidth = Console.ReadLine();
                width = ConvertInsertedValueToInteger(insertedWidth);

                if (width == null)
                {
                    Console.WriteLine("You have entered not an integer! Please insert integer value of parallelepiped width:");
                }
            }
            while (width == null);

            double? height;
            do
            {
                Console.WriteLine("Insert integer value of parallelepiped height:");
                string insertedHeight = Console.ReadLine();
                height = ConvertInsertedValueToInteger(insertedHeight);

                if (height == null)
                {
                    Console.WriteLine("You have entered not an integer! Please insert integer value of parallelepiped height:");
                }
            }
            while (height == null);

            double? length;
            do
            {
                Console.WriteLine("Insert integer value of parallelepiped length:");
                string insertedLength = Console.ReadLine();
                length = ConvertInsertedValueToInteger(insertedLength);

                if (length == null)
                {
                    Console.WriteLine("You have entered not an integer! Please insert integer value of parallelepiped length:");
                }
            }
            while (length == null);

            var rectangleDiagonal = Math.Sqrt(Math.Pow((double)width, 2) + Math.Pow((double)height, 2));
            var parallelepipedDiagonal = Math.Sqrt(Math.Pow(rectangleDiagonal, 2) + Math.Pow((double)length, 2)); ;

            Console.WriteLine("Parallelepiped diagonal length: " + parallelepipedDiagonal);

            Console.ReadKey();
        }
    }
}