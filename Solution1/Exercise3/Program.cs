using System;

// Считав с консоли 3 строки, преобразовав их к ПРОПИСНОМУ ФОРМАТУ,
// вывести на экран следующее булево значение:
// 1. Начинается ли 1ая строка со 2ой
// 2. Кончается ли 1ая строка 3ьей
// В формате: “String XX starts from YY: ZZ:”, где XX первая строка (после
// преобразования), YY вторая строка (после преобразования), ZZ результат
// выражения.

namespace Exercise3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Insert first string:");
            string firstLine = Console.ReadLine().ToUpper();

            Console.WriteLine("Insert second string:");
            string secondLine = Console.ReadLine().ToUpper();

            Console.WriteLine("Insert third string:");
            string thirdLine = Console.ReadLine().ToUpper();

            var result1 = firstLine.StartsWith(secondLine);
            var result2 = firstLine.EndsWith(thirdLine);

            Console.WriteLine("String {0} starts from {1}: {2}", firstLine, secondLine, result1);
            Console.WriteLine("String {0} ends with {1}: {2}", firstLine, thirdLine, result2);

            Console.ReadKey();
        }
    }
}
