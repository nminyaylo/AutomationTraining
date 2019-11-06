using System;

// Приложение последовательно предлагает пользователю ввести первый и второй операнды,
// а также символ необходимой операции. Вычислить значение выражения согласно требуемой
// операции и вывести результат на экран. Поддерживаемые операции:
// + - / * ^ (возведение в степень) 

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
        Label1:
            Console.WriteLine("Enter first integer operand");
            string insertedFirstOperand = Console.ReadLine();
            double firstOperand;
            bool firstOperandIsInteger = double.TryParse(insertedFirstOperand, out firstOperand);

            if (firstOperandIsInteger == false)
            {
                Console.WriteLine("You have entered not an integer!");
                goto Label1;
            }

        Label2:
            Console.WriteLine("Enter second integer operand");
            string insertedSecondOperand = Console.ReadLine();
            double secondOperand;
            bool secondOperandIsInteger = double.TryParse(insertedSecondOperand, out secondOperand);

            if (secondOperandIsInteger == false)
            {
                Console.WriteLine("You have entered not an integer!");
                goto Label2;
            }

        Label3:
            Console.WriteLine("What operation is necessary to carry out?");
            string operation = Console.ReadLine();

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
                    goto Label3;
            }
        }
    }
}