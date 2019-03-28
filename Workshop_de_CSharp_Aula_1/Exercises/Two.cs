using System;
namespace BasicCSharp.Exercises
{
    public class Two : Exercise
    {
        public static void Start()
        {
            int a, b;

            Console.WriteLine("Please enter the first number:");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second number:");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("The sum result is: " + (a + b));
            Console.WriteLine("The multiplication result is: " + (a * b));

            Console.WriteLine();
        }
    }
}
