using System;
namespace BasicCSharp.Exercises
{
    public class Seven : Exercise
    {
        public static void Start()
        {
            /*int sum = 0;

            for (int i = 0; i <= 100; i++) {
                sum += i;
            }

            Console.WriteLine("The sum of the numbers from 1 to 100 is " + sum);*/

            int sum = 0;
            int counter = 0;

            Console.WriteLine("What is the final number of the sum?");
            int end = int.Parse(Console.ReadLine());

            while (counter <= end)
            {
                sum += counter;
                counter++;
            }

            Console.WriteLine("The sum of the numbers from 1 to " + end + " is " + sum);
        }
    }
}
