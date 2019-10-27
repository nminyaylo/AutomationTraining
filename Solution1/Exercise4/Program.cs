using System;

// Считав с консоли 2 строки и символ, провести конкатенацию строк и вывести
// индекс последнего вхождения символа в конкатенированную строку,
// результат вывести на экран в формате
// “Index of XX in YY: ZZ”, где XX считанный символ, YY – результат
// конкатенации строк, ZZ – индекс посл. вхождения.

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert first string:");
            string firstLine = Console.ReadLine();

            Console.WriteLine("Insert second string:");
            string secondLine = Console.ReadLine();

            Console.WriteLine("Insert any symbol:");
            string symbol = Console.ReadLine();

            string concatStrings = (firstLine + secondLine);

            int lastIndexOfSymbol = concatStrings.LastIndexOf(symbol);

            string result = $"Index of {symbol} in {concatStrings}: {lastIndexOfSymbol}";
            Console.WriteLine(result);
        }
    }
}
