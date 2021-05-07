using System;
using System.Threading;

namespace _20210506_Something
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("calculator but with 3 numbers");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Please type in your first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What operator do you want use?");
            string operator1 = Console.ReadLine();

            switch (operator1)
            {
                case "*":
                    operator1 = "*";
                    break;

                case "-":
                    operator1 = "-";
                    break;

                case "+":
                    operator1 = "+";
                    break;

                case ":":
                    operator1 = "/";
                    break;

                default:
                    Console.WriteLine("Not a valid opertator");
                    Thread.Sleep(2500);
                    Main();
                    break;

            }

            Console.Clear();

            Console.WriteLine("Please type in your second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What operator do you want use?");
            string operator2 = Console.ReadLine();
            switch (operator2)
            {
                case "*":
                    operator2 = "*";
                    break;

                case "-":
                    operator2 = "-";
                    break;

                case "+":
                    operator2 = "+";
                    break;

                case ":":
                    operator2 = "/";
                    break;

                default:
                    Console.WriteLine("Not a valid opertator");
                    Thread.Sleep(2500);
                    Main();
                    break;

            }

            Console.Clear();


            Console.WriteLine("Please type in your third number:");
            int num3 = Convert.ToInt32(Console.ReadLine());

            Console.Clear();



            Console.WriteLine("Your calculation you wanted is:");
            int result = num1 * num2 * num3;

            if (result > Int32.MaxValue)
            {
                Console.WriteLine("Numbers to high to calculate.");
            }

            Console.WriteLine("{0} {1} {2} {3} {4} = {5}", num1, operator1, num2, operator2, num3, result);

            Thread.Sleep(2500);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Do you have any more calculations to do?");
            Console.WriteLine("Yes or no?");

            string repeat = Console.ReadLine();

            switch (repeat)
            {
                case "yes":
                    Main();
                    break;
                case "no":
                    Console.WriteLine("thanks");
                    Thread.Sleep(2500);
                    Environment.Exit(-1);
                    break;
                default:
                    Console.WriteLine("You can only use Yes or No");
                    break;
            }




            Console.ReadKey();
        } 
    }
}