using System;

namespace _20200502_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            string operation;
            float answer;

            Console.WriteLine("Welcome to my first Calculator!");
            Console.WriteLine("Please type in your first number!");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please type in your second number!");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please type in one of the following operations: +, -, :, *.");
            operation = Convert.ToString(Console.ReadLine());

            switch (operation)
            {
                case "+":
                    answer = number1 + number2;
                    break;

                case "-":
                    answer = number1 - number2;
                    break;

                case "*":
                    answer = number1 * number2;
                    break;

                case ":":
                    answer = number1 / number2;
                    break;

                default:
                    answer = 0;
                    break;
            }

            Console.WriteLine(number1.ToString() + " " + operation.ToString() + " " + number2.ToString() + " = " + answer.ToString());

            Console.ReadKey();

        }
    }
}
