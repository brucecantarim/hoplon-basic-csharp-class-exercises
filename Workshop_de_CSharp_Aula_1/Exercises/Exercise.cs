using System;
namespace BasicCSharp.Exercises
{
    public class Exercise
    {

        public static string ReadString(string message)
        {
            Console.WriteLine(message);
            string result = Console.ReadLine();
            return result; 
        }

        public static int ReadNumber(string message) 
        {
            Console.WriteLine(message);
            int result = int.Parse(Console.ReadLine());
            return result;
        }

        public static float ReadFloat(string message)
        {
            Console.WriteLine(message);
            float result = float.Parse(Console.ReadLine());
            return result;
        }

        public static int[] ReadIntArray(string quantity, string number) 
        {
            int totalNumbers = ReadNumber(quantity);

            int[] numbers = new int[totalNumbers];

            for (int i = 0; i < totalNumbers; i++)
            {

                numbers[i] = ReadNumber(number);

            }

            Console.Clear();

            return numbers;
        }

        public static string[] ReadStringArray(string quantity, string item)
        {
            int totalItems = ReadNumber(quantity);

            string[] items = new string[totalItems];

            for (int i = 0; i < totalItems; i++)
            {

                items[i] = ReadString(item);

            }

            Console.Clear();

            return items;
        }


        public static bool ContinueCheck(string message)
        {

            bool valid = false;
            bool result = false;

            while (!valid)
            {
                Console.WriteLine(message);
                string answer = Console.ReadLine();

                switch (answer)
                {
                    case "y":
                    case "Y":
                    case "Yes":
                    case "yes":
                        valid = true;
                        result = true;
                        break;

                    case "n":
                    case "N":
                    case "No":
                    case "no":
                        valid = true;
                        result = false;
                        break;

                    default:
                        valid = false;
                        break;
                }
            }

            return result;
        }
    }
}