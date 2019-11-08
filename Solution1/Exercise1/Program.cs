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
        static double? ConvertInsertedValueToInteger(string insertedValue)
        {    
            return double.TryParse(insertedValue, out var temp) ? double.Parse(insertedValue) : (double?)null; 
        }

        static void Main()
        {
            double? x;
            do
            {
                Console.WriteLine("Insert integer value x:");
                string insertedX = Console.ReadLine();
                x = ConvertInsertedValueToInteger(insertedX);

                if (x == null)
                {
                    Console.WriteLine("You have entered not an integer! Please insert integer value x:");
                }
            }
            while (x == null);


            double? y;
            do
            {
                Console.WriteLine("Insert integer value y:");
                string insertedY = Console.ReadLine();
                y = ConvertInsertedValueToInteger(insertedY);

                if (y == null)
                {
                    Console.WriteLine("You have entered not an integer! Please insert integer value y:");
                }
            }
            while (y == null);

            double? z;
            do
            {
                Console.WriteLine("Insert integer value z:");
                string insertedZ = Console.ReadLine();
                z = ConvertInsertedValueToInteger(insertedZ);

                if (z == null)
                {
                    Console.WriteLine("You have entered not an integer! Please insert integer value z:");
                }
            }
            while (z == null);

            // 1. Сумма x и y, умноженная на увеличенный на единицу квадрат z
            var sqrtZ = Math.Sqrt((double)z);
            var result1 = (x + y) * sqrtZ++;

            Console.WriteLine("First expression result: " + result1);
        
        // 2. Уменьшенный на единицу остаток от деления x на z, умноженный на квадратный корень из y 
            try
                {
                    var result2 = (x % z) * Math.Sqrt((double)y);

                    Console.WriteLine("Second expression result: " + result2);
                }
            catch
                {
                    Console.WriteLine("Second expression result: I can’t divide by zero :(");
                }

        // 3. Сумма умножений пар чисел х и y & y и z, разделенная на куб числа z
             var result3 = ((x * y) + (y * z)) / Math.Pow((double)z, 3);

             Console.WriteLine("Third expression result: " + result3);

             Console.ReadKey();
        }
    }
}
