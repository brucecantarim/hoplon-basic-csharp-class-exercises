using System;
namespace BasicCSharp.Exercises
{
    public class Five : Exercise
    {
        public static void Start()
        {
            int firstNum;
            int secondNum;
            int thirdNum;

            Console.WriteLine("What is the first number?");
            firstNum = int.Parse(Console.ReadLine());

            Console.WriteLine("And the second number?");
            secondNum = int.Parse(Console.ReadLine());

            Console.WriteLine(("Now, tell me the final number:"));
            thirdNum = int.Parse(Console.ReadLine());

            if (firstNum > secondNum && firstNum > secondNum)
            {

                Console.WriteLine(firstNum + " is the biggest number!");

            }
            else if (secondNum > thirdNum)
            {

                Console.WriteLine(secondNum + " is the biggest number!");

            }
            else
            {

                Console.WriteLine(thirdNum + " is the biggest number!");

            }

            if (firstNum < secondNum && firstNum < thirdNum)
            {

                Console.WriteLine(firstNum + " is the lowest number!");

            }
            else if (secondNum < thirdNum)
            {

                Console.WriteLine(secondNum + " is the lowest number!");

            }
            else
            {

                Console.WriteLine(thirdNum + " is the lowest number!");

            }

            Console.WriteLine();
        }
    }
}
