using System;

// Приложение последовательно предлагает пользователю ввести первый и второй операнды,
// а также символ необходимой операции. Вычислить значение выражения согласно требуемой
// операции и вывести результат на экран. Поддерживаемые операции:
// + - / * ^ (возведение в степень) 

namespace CalculatorApp
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

        //static bool CheckIsOperationPossible(string insertedOperation)
        //{
        //    bool isOperationPossible;
        //    if (insertedOperation == "+" || insertedOperation == "-" || insertedOperation == "*" || insertedOperation == "/" || insertedOperation == "^")
        //    {
        //        isOperationPossible = true;
        //    }
        //    else
        //    {
        //        isOperationPossible = false;
        //    }
        //    return isOperationPossible;
        //}

        static void Main()
        {
            do
            {

                Console.WriteLine("Enter first integer operand");
                double firstOperand = InsertIntegerValue();


                Console.WriteLine("Enter second integer operand");
                double secondOperand = InsertIntegerValue();


                bool isOperationPossible;
                do
                {
                    Console.WriteLine("What operation is necessary to carry out?");
                    string operation = Console.ReadLine();
                    isOperationPossible = true;

                    switch (operation)
                    {
                        case "+":
                            double result = firstOperand + secondOperand;
                            Console.WriteLine("{0} + {1} = {2}", firstOperand, secondOperand, result);
                            break;
                        case "-":
                            result = firstOperand - secondOperand;
                            Console.WriteLine("{0} - {1} = {2}", firstOperand, secondOperand, result);
                            break;
                        case "/":
                            result = firstOperand / secondOperand;
                            Console.WriteLine("{0} / {1} = {2}", firstOperand, secondOperand, result);
                            break;
                        case "*":
                            result = firstOperand * secondOperand;
                            Console.WriteLine("{0} * {1} = {2}", firstOperand, secondOperand, result);
                            break;
                        case "^":
                            result = Math.Pow(firstOperand, secondOperand); ;
                            Console.WriteLine("{0} ^ {1} = {2}", firstOperand, secondOperand, result);
                            break;
                        default:
                            isOperationPossible = false;
                            Console.WriteLine("You have entered incorrect operation");
                            break;
                    }
                }
                while (!isOperationPossible);

                Console.WriteLine("\n");
            }
            while (true);
        }
    }
}