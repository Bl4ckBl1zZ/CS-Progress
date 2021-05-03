using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printing_Variables_to_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whats your Name?");
            string name = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("How tall are you");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Clear();




            Console.WriteLine("Here are you're results! :");

            //Print our name age height to console as separate WriteLines
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Height: " + height);

            Console.WriteLine();
            Console.WriteLine();

            //Print Name Age Height to console as one single WriteLine
            Console.WriteLine("Name: " + name + "\n" + "Age: " + age + "\n" + "Height: " + height);

            Console.WriteLine();
            Console.WriteLine();

            //Use arguments to print Name Age Height
            Console.WriteLine("Name: {0}\nAge: {1}\nHeight: {2}", name, age, height);   //Composite Formatting

            Console.WriteLine();
            Console.WriteLine();

            //Print our name age and heigfht to Console
            Console.WriteLine($"Name: {name}\nAge: {age}\nHeight: {height}");   //String interpolation


            Console.ReadKey();

        }
    }
}
