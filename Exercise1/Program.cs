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
            Console.WriteLine("Insert value x:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insert value y:");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insert value z:");
            int z = Convert.ToInt32(Console.ReadLine());

        // 1. Сумма x и y, умноженная на увеличенный на единицу квадрат z
            var sqrtZ = Math.Sqrt(z);
            var result1 = (x + y) * sqrtZ++;

            Console.WriteLine("First expression result: " + result1);
            
        // 2. Уменьшенный на единицу остаток от деления x на z, умноженный на
        // квадратный корень из y 
            var result2 = (x % z) * Math.Sqrt(y);

            Console.WriteLine("Result2 " + result2);
            
        // 3. Сумма умножений пар чисел х и y & y и z, разделенная на куб числа z
            var result3 = ((x * y) + (y * z)) / Math.Pow(z, 3);

            Console.WriteLine("Result3 " + result3);
        
        }
    }
}
