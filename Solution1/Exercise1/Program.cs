using System;

// Последовательно считать с консоли 3 числа (x y z)
// Вычислить и вывести на экран результаты следующих выражений:
// 1. Сумма x и y, умноженная на увеличенный на единицу квадрат z
// 2. Уменьшенный на единицу остаток от деления x на z, умноженный на
// квадратный корень из y
// 3. Сумма умножений пар чисел х и y & y и z, разделенная на куб числа z

namespace Exercise1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Insert integer value x:");
            string insertedX = Console.ReadLine();
            int x; 
            bool xIsInteger = int.TryParse(insertedX, out x);

            while (xIsInteger == false)
            {
                Console.WriteLine("You have entered not an integer! Please insert integer value x:");
                insertedX = Console.ReadLine();
                xIsInteger = int.TryParse(insertedX, out x);
            }
  
            Console.WriteLine("Insert integer value y:");
            string insertedY = Console.ReadLine();
            int y;
            bool yIsInteger = int.TryParse(insertedY, out y);

            while (yIsInteger == false)
            {
                Console.WriteLine("You have entered not an integer! Please insert integer value y:");
                insertedY = Console.ReadLine();
                yIsInteger = int.TryParse(insertedY, out y);
            }
         
            Console.WriteLine("Insert integer value z:");
            string insertedZ = Console.ReadLine();
            int z;
            bool zIsInteger = int.TryParse(insertedZ, out z);

            while (zIsInteger == false)
            {
                Console.WriteLine("You have entered not an integer! Please insert integer value z:");
                insertedZ = Console.ReadLine();
                zIsInteger = int.TryParse(insertedZ, out z);
            }

        // 1. Сумма x и y, умноженная на увеличенный на единицу квадрат z
            var sqrtZ = Math.Sqrt(z);
            var result1 = (x + y) * sqrtZ++;

            Console.WriteLine("First expression result: " + result1);
        
        // 2. Уменьшенный на единицу остаток от деления x на z, умноженный на квадратный корень из y 
            try
                {
                    var result2 = (x % z) * Math.Sqrt(y);

                    Console.WriteLine("Second expression result: " + result2);
                }
            catch
                {
                    Console.WriteLine("Second expression result: I can’t divide by zero :(");
                }

        // 3. Сумма умножений пар чисел х и y & y и z, разделенная на куб числа z
             var result3 = ((x * y) + (y * z)) / Math.Pow(z, 3);

             Console.WriteLine("Third expression result: " + result3);

             Console.ReadKey();
        }
    }
}
