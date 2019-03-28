using System;
namespace BasicCSharp.Exercises
{
    public class Eight : Exercise
    {
        public static void Start()
        {
            Console.WriteLine("What is the final number?");
            int end = int.Parse(Console.ReadLine());

            while (end < 0)
            {
                Console.WriteLine("No negative numbers, please. Try again:");
                end = int.Parse(Console.ReadLine());
            }

            Console.Clear();

            while (0 <= end)
            {
                Console.WriteLine(end);
                end--;
            }

            Console.WriteLine();
        }
    }
}
