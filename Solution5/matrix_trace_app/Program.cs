using System;

namespace matrix_trace_app
{
    class Program
    {
        static int InsertIntegerValue()
        {
            var result = false;
            int resultConverted = 0;
            while (!result)
            {
                var userInput = Console.ReadLine();
                result = int.TryParse(userInput, out resultConverted);
                if (!result)
                {
                    Console.WriteLine("You have entered not an integer! Please insert integer value:");
                }
            }
            return resultConverted;
        }

        static void Main()
        {
            Console.WriteLine("Insert matrix size:");
            int matrixSize = InsertIntegerValue();

            Console.WriteLine("\n");

            var random = new Random();

            int[,] matrix = new int[matrixSize, matrixSize];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(0, 10);
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n");

            int[] diagonal = new int[matrixSize];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        diagonal[i] = matrix[i, j];
                    }
                }
            }

            int matrixTrace = 0;

            foreach (int i in diagonal)
            {
                matrixTrace += i;
            }

            Console.WriteLine($"Matrix trace is {matrixTrace}");

            Console.ReadKey();
        }
    }
}
