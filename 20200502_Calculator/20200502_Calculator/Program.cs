using System;
using System.Threading;

namespace _20200502_Calculator
{
    class Program
    {
        public static int number1;
        public static int number2;
        public static string operation;
        public static int answer;

        static void Main()
        {

            try
            {


                Console.Clear();
                Console.WriteLine("Welcome to my first Calculator!");
                Console.WriteLine("Please type in your first number!");

                number1 = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Please type in your second number!");
                number2 = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Please type in one of the following operations: +, -, :, *.");
                operation = Console.ReadLine();

                if (number1 > Int32.MaxValue || number2 > Int32.MaxValue) 
                {
                    Console.WriteLine("Numbers to high to calculate.");
                }

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
                        Console.WriteLine("Not a valid opertator");
                        Thread.Sleep(2500);
                        Main();
                        break;
                }

                Console.WriteLine(number1.ToString() + " " + operation.ToString() + " " + number2.ToString() + " = " + answer.ToString());

                Console.WriteLine("Do You have any more calculations to do?");
                Console.WriteLine("yes or no?");
                string repeat = Console.ReadLine();
                switch (repeat)
                {
                    case "yes":
                        Main();
                        break;
                    case "no":
                        Environment.Exit(-1);
                        break;
                    default:
                        Console.WriteLine("You can only use Yes or No");
                        break;
                }

                Console.ReadKey();
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number provided. ");
                Thread.Sleep(2500);
                Main();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"an unknown error orrcued: \n{ex.Message}");
                Thread.Sleep(2500);
                Main();
            }
        }
    }
}
