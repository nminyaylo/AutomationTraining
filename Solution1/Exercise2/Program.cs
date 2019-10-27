using System;

// Считав с консоли значение ширины, высоты и длины прямоугольного
// параллелепипеда, найти длину его диагонали, вывести на экран

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
        Label1:    
            Console.WriteLine("Insert integer value of parallelepiped width:");
            string insertedWidth = Console.ReadLine();
            int width;
            bool widthIsInteger = int.TryParse(insertedWidth, out width);

            if (widthIsInteger == false)
            {
                Console.WriteLine("You have entered not an integer!");
                goto Label1;           
            }
        
        Label2:
            Console.WriteLine("Insert integer value of parallelepiped height:");
            string insertedHeight = Console.ReadLine();
            int height;
            bool heightIsInteger = int.TryParse(insertedHeight, out height);

            if (heightIsInteger == false)
            {
                Console.WriteLine("You have entered not an integer!");
                goto Label2;                   
            }
        
        Label3:
            Console.WriteLine("Insert integer value of parallelepiped length:");
            string insertedLength = Console.ReadLine();
            int length;
            bool lengthIsInteger = int.TryParse(insertedLength, out length);

            if (lengthIsInteger == false)
            {
                Console.WriteLine("You have entered not an integer!");
                goto Label3;                   
            }

            var rectangleDiagonal = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2));
            var parallelepipedDiagonal = Math.Sqrt(Math.Pow(rectangleDiagonal, 2) + Math.Pow(length, 2));;

            Console.WriteLine("Parallelepiped diagonal length: " + parallelepipedDiagonal);
        
        }
    }
}
