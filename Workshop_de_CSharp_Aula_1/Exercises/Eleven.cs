using System;
namespace BasicCSharp.Exercises
{
    public class Eleven : Exercise
    {
        public static void Start()
        {
            // Mostrar média no array
            // Mostrar o maior e o menor elemento, e calcular a mediana

            int[] numbers = ReadIntArray("How many numbers will you input?", "Type a number:");
            float sum = 0;
            int highest = int.MinValue;
            int lowest = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];

                if (numbers[i] > highest)
                {
                    highest = numbers[i];
                }

                if (numbers[i] < lowest)
                {
                    lowest = numbers[i];
                }
            }

            float average = sum / numbers.Length;

            Array.Sort(numbers);

            int median = numbers[(numbers.Length - 1) / 2];

            Console.WriteLine("The average is " + average);
            Console.WriteLine("The highest number is " + highest);
            Console.WriteLine("The lowest number is " + lowest);
            Console.WriteLine("The median is " + median);
        }
    }
}
