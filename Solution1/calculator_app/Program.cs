using System;

// Приложение последовательно предлагает пользователю ввести первый и второй операнды,
// а также символ необходимой операции. Вычислить значение выражения согласно требуемой
// операции и вывести результат на экран. Поддерживаемые операции:
// + - / * ^ (возведение в степень) 

namespace CalculatorApp
{
    class Program
    {
        static bool TryToConvertInsertedOperandToInteger(string insertedOperand)
        {
            double integerOperand;
            bool operandIsInteger = double.TryParse(insertedOperand, out integerOperand);
            return operandIsInteger;
        }

        static double ConvertInsertedOperandToInteger(string insertedOperand)
        {
            double integerOperand;
            bool operandIsInteger = double.TryParse(insertedOperand, out integerOperand);
            return integerOperand;
        }

        static bool CheckIsOperationPossible(string insertedOperation)
        {
            bool isOperationPossible;
            if (insertedOperation == "+" | insertedOperation == "-" | insertedOperation == "*" | insertedOperation == "/" | insertedOperation == "^")
            {
                isOperationPossible = true;
            }
            else
            {
                isOperationPossible = false;
            }
            return isOperationPossible;
        }

        static void Main()
        {
            bool isOperandInteger;
            double firstOperand;
            do
            {
                Console.WriteLine("Enter first integer operand");
                string insertedFirstOperand = Console.ReadLine();

                isOperandInteger = TryToConvertInsertedOperandToInteger(insertedFirstOperand);
                firstOperand = ConvertInsertedOperandToInteger(insertedFirstOperand);

                if (isOperandInteger == false)
                {
                    Console.WriteLine("You have entered not an integer!");
                }
            }
            while (isOperandInteger == false);

            double secondOperand;
            do
            {
                Console.WriteLine("Enter second integer operand");
                string insertedSecondOperand = Console.ReadLine();

                isOperandInteger = TryToConvertInsertedOperandToInteger(insertedSecondOperand);
                secondOperand = ConvertInsertedOperandToInteger(insertedSecondOperand);

                if (isOperandInteger == false)
                {
                    Console.WriteLine("You have entered not an integer!");
                }
            }
            while (isOperandInteger == false);

            bool isOperationPossible;
            do
            {
                Console.WriteLine("What operation is necessary to carry out?");
                string operation = Console.ReadLine();

                isOperationPossible = CheckIsOperationPossible(operation);

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
                        Console.WriteLine("You have entered incorrect operation");
                        break;
                }
            }
            while (isOperationPossible == false);

            Console.ReadKey();
        }
    }
}