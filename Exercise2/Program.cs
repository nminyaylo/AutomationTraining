using System;

// Считав с консоли, значение ширины, высоты и длины прямоугольного
// параллелепипеда найти длину его диагонали, вывести на экран

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Parallelepiped width:");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Parallelepiped height:");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Parallelepiped length:");
            int length = Convert.ToInt32(Console.ReadLine());

            var rectangleDiagonal = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2));
            var parallelepipedDiagonal = Math.Sqrt(Math.Pow(rectangleDiagonal, 2) + Math.Pow(length, 2));;

            Console.WriteLine("Length of the parallelepiped's diagonal is " + parallelepipedDiagonal);
        
        }
    }
}
