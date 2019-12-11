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
            Console.WriteLine("Please input numerical value for X:");
            double x = InsertIntegerValue();

            Console.WriteLine("Please input numerical value for Y:");
            double y = InsertIntegerValue();

            Console.WriteLine("Please input numerical value for Z:");
            double z = InsertIntegerValue();

            // 1. Сумма x и y, умноженная на увеличенный на единицу квадрат z
            var sqrtZ = Math.Sqrt(z);
            var result1 = (x + y) * sqrtZ++;
            Console.WriteLine("First expression result: " + result1);

            // 2. Уменьшенный на единицу остаток от деления x на z, умноженный на квадратный корень из y 
            var result2 = (x % z) * Math.Sqrt(y);
            Console.WriteLine("Second expression result: " + result2);

            // 3. Сумма умножений пар чисел х и y & y и z, разделенная на куб числа z
            var result3 = ((x * y) + (y * z)) / Math.Pow(z, 3);
            Console.WriteLine("Third expression result: " + result3);

            Console.ReadKey();
        }
    }
}
