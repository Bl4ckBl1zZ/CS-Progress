using System;

namespace _20210506_Something
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("calculator but with 3 numbers");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Please type in your first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Please type in your second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Please type in your third number:");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Your calculation you wanted it is:");
            int result = num1 * num2 * num3;
            Console.WriteLine("{0} * {1} * {2} = {3}", num1, num2, num3, result);


            Console.ReadKey();
        }
    }
}
