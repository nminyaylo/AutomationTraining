using System;

// Считав с консоли значение ширины, высоты и длины прямоугольного
// параллелепипеда, найти длину его диагонали, вывести на экран

namespace Exercise2
{
    class Program
    {

        static double InsertIntegerValue()
        {
            var result = false;
            double resultConverted = 0;
            while (!result)
            {
                var userInput = Console.ReadLine();
                result = double.TryParse(userInput, out resultConverted);
                if (!result)
                {
                    Console.WriteLine("You have entered not an integer! Please insert integer value:");
                }
            }
            return resultConverted;
        }

        static void Main()
        { 
            Console.WriteLine("Insert integer value of parallelepiped width:");
            double width = InsertIntegerValue();

            Console.WriteLine("Insert integer value of parallelepiped height:");
            double height = InsertIntegerValue();

            Console.WriteLine("Insert integer value of parallelepiped length:");
            double length = InsertIntegerValue();

            var parallelepipedDiagonal = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2) + Math.Pow(length, 2));

            Console.WriteLine("Parallelepiped diagonal length: " + parallelepipedDiagonal);

            Console.ReadKey();
        }
    }
}