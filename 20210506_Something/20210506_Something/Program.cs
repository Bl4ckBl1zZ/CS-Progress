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
                    operator1 = "*" ;
                    break;

                case "-":
                    operator1 = "-";
                    break;
                    Console.Clear();

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

            Console.WriteLine("Please type in your second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What operator do you want use?");
            string operator1 = Console.ReadLine();
            switch (operator1)
            {
                case "*":
                    operator1 = "*" ;
                    break;

                case "-":
                    operator1 = "-";
                    break;
                    Console.Clear();

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

            Console.Clear();



            Console.WriteLine("Please type in your third number:");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What operator do you want use?");
            string operator2 = Console.ReadLine();

            switch (operator2)
            {
                case "*":
                    operator2 = "*" ;
                    break;

                case "-":
                    operator2 = "-";
                    break;
                    Console.Clear();

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
                            Console.Clear();


            Console.WriteLine("Your calculation you wanted it is:");
            int result = num1 * num2 * num3;
            Console.WriteLine("{0} * {1} * {2} = {3}", num1, num2, num3, result);


            Console.ReadKey();
        }
    }
}