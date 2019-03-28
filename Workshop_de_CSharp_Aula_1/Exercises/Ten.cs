using System;
namespace BasicCSharp.Exercises
{
    public class Ten : Exercise
    {
        public static void Start()
        {
            // Ler array e mostrar ordem decrescente
            // * Fiz com a Ester, está na máquina dela

            int totalNumbers = ReadNumber("How many numbers will you input?");

            int[] numbers = new int[totalNumbers];

            for (int i = 0; i < totalNumbers; i++)
            {

                numbers[i] = ReadNumber("Type a number:");

            }

            Console.Clear();
            Console.WriteLine("Here's your numbers in a decrescent fashion:");

            for (int i = totalNumbers - 1; 0 <= i; i--)
            {

                Console.Write(numbers[i] + " ");

            }

            Console.WriteLine();
        }
    }
}
